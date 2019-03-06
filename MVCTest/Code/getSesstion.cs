using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVCTest.Code
{
    public class getSesstion
    {
        public static void SetSesstion(UserSesstion s)
        {
            HttpContext.Current.Session["login"] = s;
        }
        public static UserSesstion getLoginSesstion()
        {
            var session = HttpContext.Current.Session["login"];
            if (session == null) return null;
            else return session as UserSesstion;
            
        }
    }
}