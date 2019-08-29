using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;

namespace StudentEF.Controllers
{
    [FlushLog]
    public class ValuesController : ApiController
    {
        StudentContext context;
        static StreamWriter writer;
        public ValuesController()
        {
            context = new StudentContext();
            if (writer == null)
            {
                writer = new StreamWriter("../log.txt");
            }
            context.Database.Log = writer.WriteLine;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            var firstStu = context.People.FirstOrDefault();
            //writer.Flush();
            //writer.Close();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
