﻿using System.Web.Http;
using System.Web.Routing;

namespace pewpewService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register();
        }
    }
}