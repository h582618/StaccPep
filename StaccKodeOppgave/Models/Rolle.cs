namespace StaccKodeOppgave.Models
{
    [ToString]
    public class Rolle
    {
        public Type1 type { get; set; }
        public Person1 person { get; set; }
        public bool fratraadt { get; set; }
        public int rekkefolge {get; set;}

    }
    [ToString]
    public class Person1
    {
        public string fodselsdato { get; set; }
        public Navn navn { get; set; }
        public bool erDoed { get; set; }
    }
    [ToString]
    public class Navn
    {
        public string fornavn {get; set;}
        public string etternavn { get; set; }
    }
}