using System;
using System.Collections.Generic;

namespace DemoApp.Domain
{
    public class Samurai
    {
        public Samurai()
        {
            Quotes = new List<Quote>();
            SamuraiBattles = new List<SamuraiBattle>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } = new List<Quote>();
        public Clan Clan { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
        public Horse Horse { get; set; }
    }
}
