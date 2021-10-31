using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PepApi.Models;
using PepApi.Data;

namespace PepApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PepController : ControllerBase
    {


        private List<Person> people { get; set; } = Persons.getData();

        public PepController()
        {

        }

        [HttpGet]
        public Pep Get(string name)
        {
            
           if(name != "") { 
            List<Person> persons = people.FindAll(x => x.name.ToLower().Contains(name.ToLower()));
            if(persons.Count > 0) { 
                Pep pep = new Pep();
                pep.hits = persons;
                pep.numberOfHits = persons.Count();
                return pep;
                }
            }
            return null;
            
        }
    }
}