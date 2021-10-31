using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PepApi.Models;

namespace PepApi.Data
{
    public class Persons
    {
        public Persons()
        {
        }

        public static List<Person> getData()
        {
            return File.ReadAllLines("data/pep.csv")
                                           .Skip(1)
                                           .Select(v => Person.FromCsv(v))
                                           .ToList();

        }
    }
}
