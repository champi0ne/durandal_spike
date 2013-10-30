using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace durandal_web
{
    public class PeopleModule : NancyModule
    {
        
        List<dynamic> people = new List<dynamic>(){new { firstName="Mick", lastName="Jagger", description="Lead singer for the Rolling Stones"}, new {firstName="Jimmy", lastName="Hendrix", description="Best guitarist evar"}};
 
        public PeopleModule() :  base("/people")
        {
            
            Get[@"/all"] = _ =>
            {
                return Response.AsJson(people);
            };
        }
    }
}