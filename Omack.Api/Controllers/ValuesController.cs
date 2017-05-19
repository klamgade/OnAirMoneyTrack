using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Omack.Data;

namespace Omack.Api.Controllers
{
    [Route("api/values")]   //routing are of two type: 1. Conventional MVC Routing & Attribute Routing. This is attribute routing.
    public class ValuesController : Controller
    {
        [HttpGet()]
        public JsonResult GetItems()
        {
            return new JsonResult(SampleData.Current.Items);
        }

        //api/values/int
        [HttpGet("{id}")]  //to work with parameters in routing, curley braces are used. //
        public JsonResult GetItem(int Id)
        {
            return new JsonResult(SampleData.Current.Items.FirstOrDefault(i => i.Id == Id));
        }
    }
}
