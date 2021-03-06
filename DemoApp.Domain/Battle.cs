using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Domain
{
    public class Battle
    {
        public Battle()
        {
            SamuraiBattles = new List<SamuraiBattle>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EdnDate { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
