using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArchipelagoGame
{
    public class Islands
    {
        public string Name;
        public string Description;
        public List<Items> Items = new List<Items>();
        public string ImagePath { get; set; }
      

    }
}
