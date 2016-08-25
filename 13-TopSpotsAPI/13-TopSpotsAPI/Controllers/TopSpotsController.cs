using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13_TopSpotsAPI.Controllers
{
    public class TopSpotsController : Controller
    {
        // GET: TopSpots
        public IEnumerable</*Define NameSpace To Call*/> Get()
        {
            return new topspots.name[]
                {
                String JSONstring = File.ReadAllText("http://goo.gl/EdKdpn")
                    {
                    JsonConvert.DeserializeObject<topspots>();
                    //JavaScriptSerializer Ser = new JavaScriptSerializer();
                    //User JSON Convert 
                    }

                }
        }
        // POST /api/vehicles
        public topspots.name Post(topspots.name name)
        {
            return name;
        }
}

