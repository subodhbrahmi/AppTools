using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoWebapi.Models;

namespace DemoWebapi.Controllers
{
    public class ValuesController : ApiController
    {
        PersonEntities db = new PersonEntities();
        // GET api/values
        public IEnumerable<Person> Get()
        {
            return db.Persons.ToList();
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public Person Get(int id)
        {
            return db.Persons.Find(id);
            //return "value";
        }

        // POST api/values
        public void Post(List<string> value) //Person obj
        {
            try
            {
                Person obj = new Person();
                obj.Name = value[0];
                obj.Address = value[1];
                obj.DOB = Convert.ToDateTime(value[2]);
                db.Persons.Add(obj);
                db.SaveChanges();

            }
            catch (Exception) { }
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