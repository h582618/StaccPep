using System;

namespace PepApi.Models
{
    public class Person
    {
        public string id { get; set; } //= "evpo-ff10bc5a-4aad-4895-b886-fb88e598ed57";
        public string schema { get; set; } //    "schema": "Person",
        public string addresses { get; set; } //= 0.0003451437393358565;
        public string name { get; set; } //   "name": "Knut Arild Hareide",
        public string aliases { get; set; } //   "aliases": "Hareide, Knut Arild",
        public string birth_date { get; set; } //    "birth_date": "1972-11-23",
        public string countries { get; set; } //  "countries": "no",
        public string identifiers { get; set; } //     "identifiers": "Q1350399",
        public string sanctions { get; set; } //  "sanctions": "",
        public string phones { get; set; }    //"phones": "",
        public string emails { get; set; } //    "emails": "",
        public string dataset { get; set; } //  "Every Politician",
        public string last_seen { get; set; } //"2021-07-26 11:55:45",
        public string first_seen { get; set; } //  "2021-10-07 03:02:59"

        public Person()
        {

        }

        public Person(string id, string schema, double score, string name, string aliases, string birth_date, string countries, string identifiers, string sanctions, string phones, string emails, string dataset, string last_seen, string first_seen)
        {
            this.id = id;
            this.schema = schema;
           
            this.name = name;
            this.aliases = aliases;
            this.birth_date = birth_date;
            this.countries = countries;
            this.identifiers = identifiers;
            this.sanctions = sanctions;
            this.phones = phones;
            this.emails = emails;
            this.dataset = dataset;
            this.last_seen = last_seen;
            this.first_seen = first_seen;
        }

        public static Person FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Person person = new Person();
            person.id = values[0].TrimStart('"').TrimEnd('"');
            person.schema = values[1].TrimStart('"').TrimEnd('"');
            person.name = values[2].TrimStart('"').TrimEnd('"');
            person.aliases = values[3].TrimStart('"').TrimEnd('"');
            person.birth_date = values[4].TrimStart('"').TrimEnd('"');
            person.countries = values[5].TrimStart('"').TrimEnd('"');
            person.addresses = values[6].TrimStart('"').TrimEnd('"');
            person.identifiers = values[7].TrimStart('"').TrimEnd('"'); ; 
            person.sanctions = values[8].TrimStart('"').TrimEnd('"');
            person.phones = values[9].TrimStart('"').TrimEnd('"');
            person.emails = values[10].TrimStart('"').TrimEnd('"');
            person.dataset = values[11].TrimStart('"').TrimEnd('"');
            person.last_seen = values[12].TrimStart('"').TrimEnd('"');
            person.first_seen = values[13].TrimStart('"').TrimEnd('"');

            return person;
        }

    }
}