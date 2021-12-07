using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArchipelagoGame
{
    public class NPC: Player
    {
        
        public Item NPCItem { get; set; }
        public Item RequiredItem { get; set; }
        public Item RequiredItemTwo { get; set; }
        public NPC(string name, string description, Item item, Item requiredItem, Item requiredItemTwo)
        {
            Name = name;
            Description = description;
            RequiredItem = requiredItem;
            NPCItem = item;
            RequiredItemTwo = requiredItemTwo;

        }
       

    }
    
}
