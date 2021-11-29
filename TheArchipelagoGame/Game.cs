using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheArchipelagoGame
{
    public class Game
    {
        //Creating Properties
        public Player player = new Player();
        public List<Islands> Islands = new List<Islands>();
        public List<Item> Item = new List<Item>();
        public List<string> NPCInventory = new List<string>();
        public List<Rooms> Rooms = new List<Rooms>();
        public NPC CurrentNPC { get; set; }
        public Islands CurrentIsland { get; set; }
        public Item CurrentItem { get; set; }
        public string QuestDescription;

      public Game()
        {
            QuestDescription = " Make it to your friend's birthday party on Party Island.";
            
            //Creating Items
            Item Flintlock = new Item("Flintlock", "A Vintage Weapon from the Golden Years.");
            Item EyePatch = new Item("EyePatch", "Stops things from entering the gaping whole in your eye.");

            Item HorseShoe= new Item("Horse Shoe", "Not Stolen off a horse.");
            Item CowboyHat = new Item("Cowboy Hat", "Want to look fashionable? Here's your chance.");

            Item WizardStaff = new Item("Wizard Staff", "Thick old tree branch that shoots lightning");
            Item HealthPotion = new Item("Health Potion", "Drink it and find out!");
          
            //Creatng Rooms
            Rooms PirateShip = new Rooms("Pirate Ship", "A Shady yet wholesome home.");
            Rooms Dungeons = new Rooms("Dungeon", "A Mysterious cave with nice furniature.");

            //Creating NPCS
            NPC PirateNPC = new NPC("", "", Flintlock, HorseShoe);
            NPC SheriffeNPC = new NPC("", "",CowboyHat, WizardStaff);
            NPC GuildMasterNPC = new NPC("", "", WizardStaff, Flintlock);
            //Creating Islands
            Islands PirateIsland = new Islands()
            {
                Name = @"Pirate Island
                    ",
                Description = "Island Filled with the meanest and badest Pirates",
                Narration = "You head towards the island of Pirates docking your ship on the only port.",
                Item = { Flintlock, EyePatch },
                ImagePath = "",
                Rooms = { },
                GameNPC = PirateNPC
            };
            Islands.Add(PirateIsland);


            Islands FrontierIsland = new Islands()
            {
                Name = @"Frontier Island
                        ",
                Description = "A western oasis for Cowboys, Cowgirls, and Outlaws ",
                Item = {HorseShoe, CowboyHat},
                ImagePath = "",
                Rooms = {},
                GameNPC = SheriffeNPC
            };
            Islands.Add(FrontierIsland);

            Islands FantasyIsland = new Islands()
            {
                Name = @"Middle-Earth 
     Island
                         ",
                Description = "A Magical and Mystic Island full of things straigh out of a fantasy book.",
                Item = {WizardStaff,HealthPotion},
                ImagePath = "",
                GameNPC =  GuildMasterNPC
            };
            Islands.Add(FantasyIsland);




        }
    }
}
