using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArchipelagoGame
{
    public class NPC
    {
        public string Name;
        public string Description;
        public Item NPCItem { get; set; }
        public Item RequiredItem { get; set; }
        public NPC(string name, string description, Item item, Item requiredItem)
        {
            Name = name;
            Description = description;
            RequiredItem = requiredItem;
            NPCItem = item;

        }
       

    }
    
}
