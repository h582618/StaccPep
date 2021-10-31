using System;
using System.Collections.Generic;

namespace StaccKodeOppgave.Models
{
    public class Pep
    {
        public int numberOfHits { get; set; }
        public List<Person> hits { get; set; }

        public Pep()
        {
        }
    }
}
