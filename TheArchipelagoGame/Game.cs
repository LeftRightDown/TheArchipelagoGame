using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArchipelagoGame
{
    public class Game
    {
        public Player player = new Player();
        public List<Islands> Islands = new List<Islands>();
        public Islands CurrentIsland { get; set; }

      public Game()
        {
            Items Flintlock = new Items("", "");

            Islands PirateIsland = new Islands()
            {
                Name = "Pirate Island",
                Description = "Island Filled with the meanest and badest Pirates",
                Items = {},
                ImagePath = "",
            };
            Islands.Add(PirateIsland);

            Islands FrontierIsland = new Islands()
            {
                Name = "Frontier Island",
                Description = "A western oasis for Cowboys, Cowgirls, and Outlaws ",
                Items = { },
                ImagePath = "",
            };
            Islands.Add(FrontierIsland);

            Islands FantasyIsland = new Islands()
            {
                Name = "Middle-Earth Island",
                Description = "A Magical and Mystic Island full of things straigh out of a fantasy book.",
                Items = { },
                ImagePath = "",
            };
            Islands.Add(FantasyIsland);

        }
    }
}
