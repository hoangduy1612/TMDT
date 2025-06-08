using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using TMDT_BanHang.Model;

namespace TMDT_BanHang.Models
{
    public static class StringExtensions
    {
        public static async Task<bool> ValidateAsRecapchaToken(this string token)
        {
            using (var client = new HttpClient())
            {
                var secret = Config.RecaptchaSecretKey;
                var url = $"https://www.google.com/recaptcha/api/siteverify?secret={secret}&response={token}";
                var response = await client.PostAsync(url, new StringContent(""));

                var responseContent = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<RecaptchaResponseModel>(responseContent);

                return responseModel != null && responseModel.Success;
            }
        }
    }
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }
    public class Sigin
    {
        public int account_id { get; set; }
        //Email
        [Required(ErrorMessage = "Nhập email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //Password
        [Required(ErrorMessage = "Nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        //Roles
        [StringLength(1)] public string Role { get; set; }
        //Name
        public string Name { get; set; }
        //Avatar
        public string Avatar { get; set; }
        public string RecaptchaToken { get; set; }
    }
}   