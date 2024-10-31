﻿using Microsoft.AspNetCore.Mvc;
using zoo.Entities;
using zoo.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorsController : ControllerBase
    {
        VisitorsServicies visitorsServicies = new VisitorsServicies();
        // GET: api/<VisitorsController>
        [HttpGet]
        public List<Visitor> Get()
        {
            return visitorsServicies.Get();
        }

        // GET api/<VisitorsController>/5
        [HttpGet("{id}")]
        public Visitor Get(int id)
        {
            return visitorsServicies.GetById(id);
        }

        // POST api/<VisitorsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Visitor visitor)
        {
            return visitorsServicies.Post(visitor);
        }

        // PUT api/<VisitorsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Visitor visitor)
        {
            return visitorsServicies.Put(id, visitor);
        }

        // DELETE api/<VisitorsController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return visitorsServicies.Delete(id);
        }
    }
}