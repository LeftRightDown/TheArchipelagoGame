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
        public string Narration;
        public List<Item> Item = new List<Item>();
        public List<Rooms> Rooms = new List<Rooms>();
        public NPC GameNPC {get; set;}
        public string ImagePath { get; set; }
      

    }
}
