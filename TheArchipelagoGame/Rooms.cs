using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArchipelagoGame
{
    public class Rooms
    {
        public string Name;
        public string Description;
        public string ImagePath { get; set; }
        

        public Rooms(string name, string description, string image)
        {
            Name = name;    
            Description = description;
            ImagePath = image;
        } 
    }
}
