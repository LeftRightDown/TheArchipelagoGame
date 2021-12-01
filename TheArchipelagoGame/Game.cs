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
            QuestDescription = @"Deliver the birthday cake to your friends party on Pirate Island! 
            
             1. Visit Sheriff Marcus to obtain Cake Coupon.
                                
             2.Trade a Flintlock with Guild Master Egor for Cake.

             3. Make it to the Party!

                ";
           
            //Creating Items
            Item Flintlock = new Item("Flintlock", "A Vintage Weapon from the Golden Years.");
            Item EyePatch = new Item("EyePatch", "Stops things from entering the gaping whole in your eye.");

            Item HorseShoe= new Item("Horse Shoe", "Not Stolen off a horse.");
            Item CakeCoupon = new Item("Cake Coupon", "Enables Trade for Cake");
            Item CowboyHat = new Item("Cowbow Hat", "Fashionable Acessory");
            

            Item WizardStaff = new Item("Wizard Staff", "Thick old tree branch that shoots lightning");
            Item BirthdayCake = new Item("Birthday Cake", "Most Delicious Cake EVER");
            Item HealthPotion = new Item("Health Potion", "EMERGENCY USE ONLY");
            
          
            //Creatng Rooms
            Rooms PirateShip = new Rooms("Pirate Ship", "A Shady yet wholesome home.");
            Rooms Dungeons = new Rooms("Dungeon", "A Mysterious cave with nice furniture.");

            //Creating NPCS
            NPC PirateNPC = new NPC("Captian Bon", "Today is their birthday!", Flintlock, CowboyHat, BirthdayCake);
            NPC SheriffNPC = new NPC("Sheriff Marcus", "Man of Few Words",CowboyHat, WizardStaff, EyePatch);
            NPC GuildMasterNPC = new NPC("Guild Master Egor", "Retired Cake Maker", BirthdayCake, Flintlock, CakeCoupon);
            
            //Creating Islands
            Islands PirateIsland = new Islands()
            {
                Name = @"Pirate Island
                    ",
                Description = "Island Filled with the meanest and badest Pirates",
                Narration = @"You head towards the island of Pirates docking your ship on the only port.",
                Item = { EyePatch, Flintlock },
                ImagePath = "",
                Rooms = {PirateShip},
                GameNPC = PirateNPC
            };
            Islands.Add(PirateIsland);


            Islands FrontierIsland = new Islands()
            {
                Name = @"Frontier Island
                        ",
                Description = @"A western oasis for Cowboys, Cowgirls, and Outlaws",
                Narration = "Before Sheriff Marcus can give you the coupon he wants to trade it for a Wizard Staff and Eye.",
                Item = {HorseShoe, CakeCoupon},
                ImagePath = "",
                Rooms = {Dungeons},
                GameNPC = SheriffNPC
            };
            Islands.Add(FrontierIsland);

            Islands FantasyIsland = new Islands()
            {
                Name = @"Middle-Earth 
                Island
                         ",
                Narration = "",
                Description = @"A Magical and Mystic Island full of things straigh out of a fantasy book.",
                Item = {WizardStaff, BirthdayCake},
                ImagePath = "",
                GameNPC =  GuildMasterNPC
            };
            Islands.Add(FantasyIsland);

            Islands PartyIsland = new Islands()
            {
                Name = "Party Island",
                Narration= "" ,
                Description = "A never ending Event!",
                Item = { },
                ImagePath = "",
                
            };
            Islands.Add(PartyIsland);


        }
    }
}
