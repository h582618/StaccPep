using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.FileIO;
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
            string azure = "/home/site/wwwroot/pep.csv";
            string lokalt = "data/pep.csv";
            return File.ReadAllLines(lokalt)
                    .Skip(1)
                    .Select(v => Person.FromCsv(v))
                    .ToList();

        }
    }
}
