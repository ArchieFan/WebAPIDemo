﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static System.Console;

namespace WebAPIDemo.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        static List<string> str = new List<string>()
        {
            "value0","value1", "value2"
        };

        // GET api/values
        public IEnumerable<string> Get()
        {
            return str;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return str[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            str.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            str[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            str.RemoveAt(id);
        }
    }
}
