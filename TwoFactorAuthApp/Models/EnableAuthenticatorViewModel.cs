using System.ComponentModel.DataAnnotations;

namespace TwoFactorAuthApp.Models
{
    public class EnableAuthenticatorViewModel
    {
        public string SharedKey { get; set; }

        public string AuthenticatorUri { get; set; }

        [Required]
        [StringLength(7, MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Doğrulama Kodu")]
        public string Code { get; set; }
    }
}
