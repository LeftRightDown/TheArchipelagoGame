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
            QuestDescription = @"Deliver the birthday cake and health potion to your friends party on Party Island! 
            
             1. Visit Sheriff Marcus to obtain Cake Coupon.
                                
             2.Trade a Flintlock with Guild Master Egor for Cake.

             3. Bring Cake and Health Potion to PARTY ISLAND!

                ";

            //Creating Items
            Item Flintlock = new Item("Flintlock", "A Vintage Weapon from the Golden Years.");
            Item EyePatch = new Item("EyePatch", "Stops things from entering the gaping whole in your eye.");

            Item HorseShoe = new Item("Horse Shoe", "Not Stolen off a horse.");
            Item CakeCoupon = new Item("Cake Coupon", "Enables Trade for Cake");
            Item CowboyHat = new Item("Cowbow Hat", "Fashionable Acessory");


            Item WizardStaff = new Item("Wizard Staff", "Thick old tree branch that shoots lightning");
            Item BirthdayCake = new Item("Birthday Cake", "Most Delicious Cake EVER");
            Item HealthPotion = new Item("Health Potion", "EMERGENCY USE ONLY");

            Item SliceofCake = new Item("Slice of Cake", "Lemon Flavored Cake");
            Item Plate = new Item("Plate", "Biodegradable Paper Plate");
            Item Fork = new Item("Fork", "Biodegradable Fork");

            //Creatng Rooms
            Rooms PirateShip = new Rooms("Pirate Ship", "A Shady yet wholesome home.");
            Rooms Dungeons = new Rooms("Dungeon", "A Mysterious cave with nice furniture.");
            Rooms Saloon = new Rooms("Saloon", "A Happy and joyous place to forget.");

            //Creating NPCS
            NPC PirateNPC = new NPC("Captian Bon", "Honors Pirate Code", Flintlock, CowboyHat, BirthdayCake);
            NPC SheriffNPC = new NPC("Sheriff Marcus", "Man of Few Words", CowboyHat, WizardStaff, EyePatch);
            NPC GuildMasterNPC = new NPC("Guild Master Egor", "Retired Cake Maker", BirthdayCake, Flintlock, CakeCoupon);
            NPC BirthdayPersonNPC = new NPC("Birthday Child", "Today is their birthday", SliceofCake, Plate, Fork);
            
            //Creating Islands
            
            //0
            Islands PirateIsland = new Islands()
            {
                Name = @"Pirate Island
                    ",
                Description = $"Island Filled with the meanest and badest Pirates",
                Narration = $"You dock your ship and walk off the port when you see {PirateNPC.Name}",
                Item = { EyePatch, Flintlock },
                ImagePath = "",
                Rooms = { PirateShip },
                GameNPC = PirateNPC
            };
            Islands.Add(PirateIsland);

            //1
            Islands FrontierIsland = new Islands()
            {
                Name = @"Frontier Island
                        ",
                Description = $"A western oasis for Cowboys, Cowgirls, and Outlaws",
                Narration = $"Before {SheriffNPC.Name} can give you the coupon he wants to trade it for a Wizard Staff and Eye.",
                Item = { HorseShoe, CowboyHat, CakeCoupon },
                ImagePath = "",
                Rooms = { Saloon },
                GameNPC = SheriffNPC
            };
            Islands.Add(FrontierIsland);
            //2
            Islands FantasyIsland = new Islands()
            {
                Name = @"Middle-Earth 
                Island
                         ",
                Narration = $"{GuildMasterNPC.Name} greets you with open arms. Before he can give you the cake he requires {GuildMasterNPC.RequiredItem.Name} & {GuildMasterNPC.RequiredItemTwo.Name}",
                Description = @"A Magical and Mystic Island full of things straigh out of a fantasy book.",
                Item = { WizardStaff, BirthdayCake, HealthPotion },
                ImagePath = "",
                Rooms = { Dungeons },
                GameNPC = GuildMasterNPC
            };
            Islands.Add(FantasyIsland);
            //3
            Islands PartyIsland = new Islands()
            {
                Name = "Party Island",
                Narration = $"CONGRAGULATIONS YOU'VE DELIVERED THE CAKE AND HEALTH POTIONS!",
                Description = "A never ending Event!",
                Item = {SliceofCake, Plate, Fork},
                ImagePath = "",
                Rooms = { },
                GameNPC = BirthdayPersonNPC

            };
            Islands.Add(PartyIsland);


        }
    }
}
