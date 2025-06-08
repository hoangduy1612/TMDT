using TMDT_BanHang.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;
using TMDT_BanHang; 

[assembly: OwinStartup(typeof(TMDT_BanHang.App_Start.Startup))]
namespace TMDT_BanHang.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
