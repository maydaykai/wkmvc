﻿using System.Web.Mvc;

namespace WebPage.Areas.SysManage
{
    public class SysManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SysManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SysManage_default",
                "Sys/{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "WebPage.Areas.SysManage.Controllers" }
            );
        }
    }
}