using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TwoFactorAuthApp.Services
{
    public class SmsSender : ISmsSender
    {
  
            private readonly string _accountSid;
            private readonly string _authToken;
            private readonly string _fromNumber;

            public SmsSender(IConfiguration configuration)
            {
                _accountSid = configuration["Twilio:AccountSID"];
                _authToken = configuration["Twilio:AuthToken"];
                _fromNumber = configuration["Twilio:FromNumber"];
                TwilioClient.Init(_accountSid, _authToken);
            }

            public async Task SendSmsAsync(string number, string message)
            {
                var messageResult = await MessageResource.CreateAsync(
                    body: message,
                    from: new Twilio.Types.PhoneNumber(_fromNumber),
                    to: new Twilio.Types.PhoneNumber(number)
                );
            }
        }
    }
    
