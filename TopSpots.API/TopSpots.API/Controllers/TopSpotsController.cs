using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Http;
using TopSpots.API.Models;

namespace TopSpots.API.Controllers
{
    public class TopSpotsController : ApiController
    {
        private string filePath;

        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {
            string fileName = HttpContext.Current.Server.MapPath("../App_Data/topspots.json");

            string json = File.ReadAllText(fileName);

            IEnumerable<TopSpot> topSpots = JsonConvert.DeserializeObject<IEnumerable<TopSpot>>(json);

            return topSpots;
        }

        // POST: api/TopSpots
        public void Post([FromBody]TopSpot value)
        {
            // 1. Get the filename
            string fileName = HttpContext.Current.Server.MapPath("../App_Data/topspots.json");

            // 2. Read the JSON from the file system
            string json = File.ReadAllText(fileName);

            // 3. Deserialize
            List<TopSpot> topSpots = JsonConvert.DeserializeObject<List<TopSpot>>(json);

            // 4. Add the top spot to the list
            topSpots.Add(value);

            // 5. Turn the list back into JSON
            json = JsonConvert.SerializeObject(topSpots);

            // 6. Write the JSON back to the file system.
            File.WriteAllText(fileName, json);
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]TopSpot updatedTopSpot)
        {
            // 1. Get the filename
            string fileName = HttpContext.Current.Server.MapPath("../App_Data/topspots.json");

            // 2. Read the JSON from the file system
            string json = File.ReadAllText(fileName);

            // 3. Deserialize
            List<TopSpot> topSpots = JsonConvert.DeserializeObject<List<TopSpot>>(json);

            // 4. Find the top spot to be updated
            foreach (var topSpot in topSpots)
            {
                if(topSpot.Id == updatedTopSpot.Id)
                {
                    // 5. Modify the properties
                    topSpot.Name = updatedTopSpot.Name;
                    topSpot.Description = updatedTopSpot.Description;
                    topSpot.Location = updatedTopSpot.Location;
                }
            }

            // 6. Turn the list back into JSON
            json = JsonConvert.SerializeObject(topSpots);

            // 7. Write the JSON back to the file system.
            File.WriteAllText(fileName, json);
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {// 1. Get the filename
            string fileName = HttpContext.Current.Server.MapPath("../App_Data/topspots.json");

            // 2. Read the JSON from the file system
            string json = File.ReadAllText(fileName);

            // 3. Deserialize
            List<TopSpot> topSpots = JsonConvert.DeserializeObject<List<TopSpot>>(json);

            // 4. Find the top spot to remove
            foreach (var topSpot in topSpots)
            {
                if(topSpot.Id == id)
                {
                    // 5. Remove it from the list
                    topSpots.Remove(topSpot);
                    break;
                }
            }

            // 6. Convert the list back to JSON
            json = JsonConvert.SerializeObject(topSpots);

            // 7. Save to the file system
            File.WriteAllText(filePath, json);
        }
    }
}
