﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APICheck.Controllers
{
    public class HouseController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] {"Shubhang","Avinash","Siva" };
        }
    }
}
