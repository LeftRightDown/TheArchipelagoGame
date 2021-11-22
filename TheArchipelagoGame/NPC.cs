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
        public Items NPCItem { get; set; }
        public Items RequiredItem { get; set; }
        public NPC(string name, string description, Items item, Items requiredItem)
        {
            Name = name;
            Description = description;
            RequiredItem = requiredItem;
            NPCItem = item;

        }
       

    }
    
}
