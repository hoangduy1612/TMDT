using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMDT_BanHang.Common
{
    public class AccountEmail
    {
        //vui lòng không đổi mật khẩu mail, néu mật khảu bị thay đổi vui lòng nhắn tin qua zalo:0948521622
        //để dùng google email gửi email reset cho người khác bạn cần phải vô đây "https://www.google.com/settings/security/lesssecureapps" Cho phép ứng dụng kém an toàn: Bật
        public const string Host = "smtp.gmail.com"; //tên mấy chủ nếu bạn dùng gmail thì đổi  "Host = "smtp.gmail.com"
        //tài khoản email của bạn
        public const string UserEmail = "nguyenngocminhb2804@gmail.com";
            //"suabottothandh@gmail.com";
        public const string UserEmailSupport = "nguyenngocminhb2804@gmail.com";
        //Mật khẩu Email của bạn
        public const string Password = "nwsu ijjw swdo hdhw"; //nwsu ijjw swdo hdhw
            //"hoan265104";
        //Tên Email bạn muốn hiển thị khi gửi
        public const string Name = "SuabottotH&H";
    }
}