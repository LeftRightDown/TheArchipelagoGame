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
        public List<Items> Items = new List<Items>();
        public List<string> NPCInventory = new List<string>();
        public List<Rooms> Rooms = new List<Rooms>();
        public NPC CurrentNPC { get; set; }
        public Islands CurrentIsland { get; set; }
        public Items CurrentItem { get; set; }
        public string QuestDescription;

      public Game()
        {
            QuestDescription = " You ";
            
            //Creating Items
            Items Flintlock = new Items("Flintlock", "");
            Items EyePatch = new Items("EyePatch", "");

            Items HorseShoe= new Items("Horse Shoe", "");
            Items CowboyHat = new Items("Cowboy Hat", "");

            Items WizardStaff = new Items("Wizard Staff", "");
            Items HealthPotion = new Items("Health Potion", "");
          
            //Creatng Rooms
            Rooms PirateShip = new Rooms("Pirate Ship", "");
            Rooms Dungeons = new Rooms("Dungeon", "");

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
                Items = { Flintlock, EyePatch },
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
                Items = {HorseShoe, CowboyHat},
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
                Items = {WizardStaff,HealthPotion},
                ImagePath = "",
                GameNPC =  GuildMasterNPC
            };
            Islands.Add(FantasyIsland);




        }
    }
}
