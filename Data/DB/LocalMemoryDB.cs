using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DB
{    
    public static class LocalMemoryDB
    {
        public static List<Consumption> ConsumptionsContext = new List<Consumption>();
        public static List<Member> MembersContext = new List<Member>();
    }
}
