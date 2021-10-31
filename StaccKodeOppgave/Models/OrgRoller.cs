using System;
using System.Collections.Generic;

namespace StaccKodeOppgave.Models
{
    [ToString]
    public class OrgRoller
    {
        
        public Type1 type { get; set; }
        public string sistEndret { get; set; }
        public List<Rolle> roller { get; set; }
        public OrgRoller()
        {
        }
    }
}
