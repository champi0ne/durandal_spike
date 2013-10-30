using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace durandal_web
{
    public class DefaultModule : NancyModule
    {
        public DefaultModule()
        {
            Get[@"/"] = _ =>
            {
                return View["Durandal/Index"];
            };
        }
    }
}