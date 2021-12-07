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
        //public List<Item>Allitems = new List<Item>();
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
            
            //Pirate
            Item Flintlock = new Item("Flintlock", "A Vintage Weapon from the Golden Years.");
            Item EyePatch = new Item("EyePatch", "Stops things from entering the gaping whole in your eye.");
            Item GoldCoin = new Item("Gold Coin", "Ancient Piece of Currency.");
            //Sheriff
            Item HorseShoe = new Item("Horse Shoe", "Not Stolen off a horse.");
            Item CakeCoupon = new Item("Cake Coupon", "Enables Trade for Cake.");
            Item CowboyHat = new Item("Cowbow Hat", "Fashionable Acessory.");

            //Guild Master
            Item WizardStaff = new Item("Wizard Staff", "Thick old tree branch that shoots lightning.");
            Item BirthdayCake = new Item("Birthday Cake", "Most Delicious Cake EVER! REQUIRED FOR PARTY!");
            Item HealthPotion = new Item("Health Potion", "EMERGENCY USE ONLY! REQUIRED FOR PARTY!");
            Item.Add(BirthdayCake);
            Item.Add(HealthPotion);
            //BirthdayPerson
            Item SliceofCake = new Item("Slice of Cake", "Lemon Flavored Cake.");
            Item Plate = new Item("Plate", "Biodegradable Paper Plate.");
            Item Fork = new Item("Fork", "Biodegradable Fork.");

            //Creating NPCS
            NPC PirateNPC = new NPC("Captian Bon", "Honors Pirate Code", Flintlock, CowboyHat,GoldCoin );
            NPC SheriffNPC = new NPC("Sheriff Marcus", "Man of Few Words", CowboyHat, WizardStaff, EyePatch);
            NPC GuildMasterNPC = new NPC("Guild Master Egor", "Retired Cake Maker", BirthdayCake, Flintlock, CakeCoupon);
            NPC BirthdayPersonNPC = new NPC("Sir Jordy", "Today is their birthday", SliceofCake, Plate, Fork);
            

            //Creatng Rooms
            Rooms PirateShip = new Rooms("Pirate Ship", $"A Shady yet wholesome home. Here you can find Flintlock.", "Media/PirateShip.jpg");
            Rooms Dungeon = new Rooms("Dungeon", $"A Mysterious cave with nice furniture. Here you can find Birthday Cake.", "Media/Dungeon.jpg");
            Rooms Saloon = new Rooms("Saloon", $"A Happy and joyous place to forget. Here you can find Cake Coupon.", "Media/Saloon.jpg");
            Rooms PartyRoom = new Rooms("Receptional Hall", $"Where the fun begins! Here you can find Slice of Cake.", "Media/Cake.png");


            //Creating Islands
            
            //0
            Islands PirateIsland = new Islands()
            {
                Name = "Pirate Island",
                Description = $"Island Filled with the meanest and badest Pirates that can't last a day without a mutiny amoungst themsleves. Here you will find {PirateNPC.Name}.",
                Narration = $"You dock your ship and walk off the port when you see {PirateNPC.Name} roll along the port floor stopping right in front of you." +
                $"Before he can give you Flintlock he requires {PirateNPC.RequiredItem.Name} from Frontier Island & {PirateNPC.RequiredItemTwo.Name} from Pirate Island. " +
                $"Once you take gather the required items meet him in {PirateShip.Name}.",
                Item = { EyePatch, GoldCoin, Flintlock},
                ImagePath = "Media/PirateIsland.png",
                Rooms = { PirateShip },
                GameNPC = PirateNPC
            };
            Islands.Add(PirateIsland);

            //1
            Islands FrontierIsland = new Islands()
            {
                Name = "Frontier Island",
                Description = $"A western oasis for all kinds of people. A new frontier for American expansion westward! Here you will find {SheriffNPC.Name}.",
                Narration = $"Yout meet {SheriffNPC.Name} in the middle of town. " +
                $"Before {SheriffNPC.Name} can give you Cake Coupon he wants to trade it for a {SheriffNPC.RequiredItem.Name} from Middle-Earth Island & {SheriffNPC.RequiredItemTwo.Name} from Pirate Island." +
                $" Once you take gather the required items meet him in {Saloon.Name}.",
                Item = {HorseShoe, CowboyHat, CakeCoupon},
                ImagePath = "Media/WildWest Island.png",
                Rooms = {Saloon},
                GameNPC = SheriffNPC
            };
            Islands.Add(FrontierIsland);
            //2
            Islands FantasyIsland = new Islands()
            {
                Name = "Fantasy Island",
                Description = $"A Magical and Mystic Island full of things straight out of a fantasy book. Here you will find {GuildMasterNPC.Name}",
                Narration = $"{GuildMasterNPC.Name} greets you with open arms. " +
                $"Before he can give you Birthday Cake he requires {GuildMasterNPC.RequiredItem.Name} from Pirate Island & {GuildMasterNPC.RequiredItemTwo.Name} for {GuildMasterNPC.NPCItem.Name[2]} from Frontier Island. " +
                $"Once you take gather the required items meet him in {Dungeon.Name}.",
                Item = {WizardStaff, HealthPotion, BirthdayCake },
                ImagePath = "Media/FantasyIsland.png",
                Rooms = {Dungeon},
                GameNPC = GuildMasterNPC
            };
            Islands.Add(FantasyIsland);
            //3
            Islands PartyIsland = new Islands()
            {
                Name = "Party Island",
                Narration = $"WELCOME TO PARTY ISLAND! An Island that never wants to sleep! Today We're celebrating {BirthdayPersonNPC.Name}!" +
                $" Here, grab {BirthdayPersonNPC.RequiredItem.Name} & {BirthdayPersonNPC.RequiredItemTwo.Name} for A Slice of Cake in the {PartyRoom.Name}!",
                Description = "CONGRATULATIONS YOU'VE SUCCESSFULLY DELIVERED THE CAKE AND HEALTH POTIONS!",
                Item = {Plate, Fork, SliceofCake},
                ImagePath = "Media/PartyIsland.png",
                Rooms = {PartyRoom},
                GameNPC = BirthdayPersonNPC

            };
            Islands.Add(PartyIsland);


        }
    }
}
