using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TMDT_BanHang
{
    public static class Config
    {
        private static NameValueCollection _appSettings;

        private static NameValueCollection AppSettings => _appSettings ?? (_appSettings = ConfigurationManager.AppSettings);

        public static string RecaptchaSiteKey => GetStringValueOrDefault("RECAPTCHA:SITE_KEY", "6LeciTcrAAAAAOpLv4XDYd3u-_Oh91t_XKbYxzxG");

        public static string RecaptchaSecretKey => GetStringValueOrDefault("RECAPTCHA:SECRET_KEY", "6LeciTcrAAAAAKcEKXh9nyyt5RHevcieFMGlcHXW");

        private static string GetStringValueOrDefault(string key, string defaultValue)
        {
            return string.IsNullOrWhiteSpace(GetStringValueFromAppSettings(key))
                    ? defaultValue
                    : GetStringValueFromAppSettings(key);
        }

        private static string GetStringValueFromAppSettings(string key)
        {
            return string.IsNullOrEmpty(AppSettings[key]) ? string.Empty : AppSettings[key];
        }
    }
}