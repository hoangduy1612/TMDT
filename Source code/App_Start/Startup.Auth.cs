﻿
using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;
using TMDT_BanHang.Model;

[assembly: OwinStartup(typeof(TMDT_BanHang.App_Start.Startup))]
namespace TMDT_BanHang.App_Start
{
    public partial class Startup
    {
        //public void ConfigureAuth(IAppBuilder app)
        //{
        //    app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
        //    {
        //        ClientId = "1050040891368-gtc3c1gn5ogdi56afktlv9e694l7n5u3.apps.googleusercontent.com",
        //        ClientSecret = "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"
        //    });
        //}
    }
}
