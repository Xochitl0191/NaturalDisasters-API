using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;


namespace NaturalDisasters_API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        string path = @"C:\Users\XochLove\source\repos\NaturalDisasters-API\NaturalDisasters-API\Data\DisasterDeclarationsSummaries.csv";
        public ValuesController()
        {


            //using (StreamReader reader = new StreamReader(path))
            //{
            //  myData = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
            //}
        }

        // GET api/values
        // http://localhost:63220/api/values?type=Flood
        [HttpGet]
        public JsonResult Get(string type)
        {
            List<DataRecord> pp = new List<DataRecord>();

            using (var sr = new StreamReader(path))
            {
                var reader = new CsvReader(sr);
                //CSVReader will now read the whole file into an enumerable
                var records = reader.GetRecords<DataRecord>().ToList();
                // find by incedent type
                var oc = records.Where(s => s.incidentType == type);
                pp = oc.ToList();

            }

            return Json(pp);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
