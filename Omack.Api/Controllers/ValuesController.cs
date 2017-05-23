using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Omack.Data;
using Microsoft.AspNetCore.JsonPatch;

namespace Omack.Api.Controllers
{
    [Route("api/values")]   //routing are of two types: 1. Conventional MVC Routing & 2. Attribute Routing. This is attribute routing.
    public class ValuesController : Controller
    {
        //[HttpGet()]
        public JsonResult GetItemsTest()
        //returning JsonResult is not a good practice for api. Instead we can use IActionResult that has helper methods to send status code as well. 
        {
            return new JsonResult(SampleData.Current.Items);
            //Here it will return 200 if its null. But should be 404. That's why we use IActionResult instead of just Json Result
            //Note: it will never return not found, though list doesn't have any items in its list. It will return emply string with 200 status code. 
        }

        [HttpGet()]
        public IActionResult GetItems()
        {
            var items = SampleData.Current.Items;   //later we will implement interface for this.
            //var items = new SampleData(); if we initialize here, we dont need  "current" static method in the SampleData class.
            if (items == null)
            {
                return NotFound("Sorry. There are no items.");
                //remember: when you open from browser, it just returns blank page. However, we can see the status from console. But if we want to show in brower windows
                //          we can add statuspage middleware in startup.cs class.
            }
            else
            {
                return Ok(items);   //return status code with some data. This is the best practice.
            }
        }

        // api/values/int
        [HttpGet("{id}", Name = "GetItem")]  //to work with parameters in routing, curley braces are used. for mulitple parameter: [HttpGet("Group/{userId}/createItem/{Id}")]
        public IActionResult GetItem(int Id)
        {
            var item = SampleData.Current.Items.SingleOrDefault(i => i.Id == Id);
            if (item == null) { return NotFound("Sorry. This item does not exists."); } //will return 404 status code with error.
            return Ok(item);   //this is new syntax but still same like if else. And it return item with correct status code. 404 if null, otherwise 200
        }

        //api/values
        [HttpPost]
        public IActionResult CreateItem([FromBody]Items item)  //[FromBody] makes sure that it is deserialzed into Item DTO, if unsuccesfull parameter will be null
        {
            if (item.Id < 0)
            {
                ModelState.AddModelError("Id", "Id cannot be zero or negative");   //First Param: Key, Second: Value
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                SampleData.Current.Items.Add(item);

                //it will return 201 success code since it is post. And also it will return given URL as the header Location. 
                return CreatedAtRoute("GetItem", new { id = item.Id }, item);
                //normally for post new data, we return data as well as it's new location in header
                //here fist param: routename of post data location, second param: route parameters, third param: posted data
            }
        }
        //api/values
        [HttpPatch("{id}")]
        public IActionResult PartiallyUpdateItem(int id, [FromBody] JsonPatchDocument<Items> itemPatch)
        {
            if(itemPatch == null)
            {
                return BadRequest();
            }
            var itemFromStore = SampleData.Current.Items.SingleOrDefault(i=>i.Id == id); //Get data from SampleData.cs
            if(itemFromStore == null)
            {
                return NotFound();
            }
            itemPatch.ApplyTo(itemFromStore, ModelState);   //this will do the partial update. Based on patchdocument from body, itemPatch will contain about the information about which field or column to update
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //return model error if the given new value is not valid 
            }
            return NoContent();  //normally for update and partial update we dont return content, because they already know the information.

        }

    }
}
