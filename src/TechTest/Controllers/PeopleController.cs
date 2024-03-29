﻿using System;
using Microsoft.AspNetCore.Mvc;
using TechTest.Repositories;
using TechTest.Repositories.Models;

namespace TechTest.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public PeopleController(IUnitofWork unitofWork)
        {
             _UnitofWork= unitofWork;
        }

        private IUnitofWork _UnitofWork { get; }

        [HttpGet]
        [Produces("application/json")]
        public IActionResult GetAll()
        {
            // TODO: Step 1
            //
            // Implement a JSON endpoint that returns the full list
            // of people from the PeopleRepository. If there are zero
            // people returned from PeopleRepository then an empty
            // JSON array should be returned.

            var results = _UnitofWork.Persons.GetAll();
            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // TODO: Step 2
            //
            // Implement a JSON endpoint that returns a single person
            // from the PeopleRepository based on the id parameter.
            // If null is returned from the PeopleRepository with
            // the supplied id then a NotFound should be returned.
            var person = _UnitofWork.Persons.Get(id);

            return (person != null) ? Ok(person) : Ok(NotFound());
        }

       
        [HttpPut]
        public IActionResult Update(int id,[FromBody] PersonUpdate personUpdate)
        {

            // TODO: Step 3
            //
            // Implement an endpoint that receives a JSON object to
            // update a person using the PeopleRepository based on
            // the id parameter. Once the person has been successfully
            // updated, the person should be returned from the endpoint.
            // If null is returned from the PeopleRepository then a
            // NotFound should be returned.

            var person = _UnitofWork.Persons.Get(id);
            if (person != null)
            {
                person.Authorised = personUpdate.Authorised;
                person.Enabled = personUpdate.Enabled;
                person.Colours = personUpdate.Colours;
                var result =_UnitofWork.Persons.Update(person);
                _UnitofWork.Complete();
                return Ok(result);

            }

            return Ok(NotFound());
           
        }
    }
}