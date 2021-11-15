using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArchipelagoGame
{
    public class Player
    {
        public List<string> Inventory;
        public string Name;
        public string Description;

        public Player()
        {
            Inventory = new List<string>();
        }
    }
}
