using Marknad_V2.Persons_Structure;
using Marknad_V2.Products_Structure;
using Marknad_V2.Products_Structure.Furniture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marknad_V2
{
    public class Market_Place
    {
        private double hour = DateTime.Now.Hour;
        private double minute = DateTime.Now.Minute;
        private Chair chair;
        private Table table;
        private Seller seller;

        public Customer customer { get; set; }
        public List<Product> Cart { get; set; }
        public List<Seller> sellers { get; set; }
        public List<Product> ChairList { get; set; }
        public List<Product> TableList { get; set; }

        public void Load()
        {
            seller.LoadSeller(sellers);
            chair.LoadChairs(ChairList);
            table.LoadTables(TableList);
        }

        // Checks if the time hours on your computer is between 8 - 18. If it is it return "true" otherwise it returns "false".
        public bool OpenHour()
        {
            if (hour < 8 || hour <= 18)
            {
                return true;
            }
            return false;
        }

        // Controlls if OpenHour is true or not. If it is you get a message that market is open and return "true".
        public bool MarketOpenOrClosed()
        {
            if (OpenHour() == true)
            {
                Console.WriteLine("Marknaden har nu öppnat!");
                return true;
            }
            else
            {
                Console.WriteLine("Marknaden är nu stängd!\nKom åter igen klockan 8 på morgonen.");
                return false;
            }
        }

        public void EnterMarket()
        {
            Load();
            bool sant = OpenHour();
            Console.WriteLine(sant);
            bool MarketOpen = MarketOpenOrClosed();

            if (MarketOpen == true)
            {
                do
                {
                    if (customer == null)
                    {
                        Console.WriteLine("Hej!\nJag är vakten här på marknaden. Jag kan endast släppa in er om ni visar legitimation först.\nVad menar du att du inte har ett... \"Suck\" \nOkej gå till polis stationen innan och fixa ett kom tillbaka sen.");
                        Console.WriteLine("1. Gå till polisstationen\n2. Gå hem.");
                        string userInput = Console.ReadLine();
                        switch (userInput)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Hej!\nVälkommen till polisstationen, jag heter Berit och vad söker du?");
                                PoliceStation();
                                EnterMarket();
                                break;
                            case "2":
                                Console.Clear();
                                Console.WriteLine("Du gick hem.");
                                Environment.Exit(3);
                                break;
                            default:
                                Console.WriteLine("Gör något annat");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Så jag ser att du fixat ditt legitimation. Perfekt!\nVälkommen in.");
                        MeetYourFriend();
                    }

                } while (true);
            }
        }

        // Here we go to the police station to recieve a ID card.
        public void PoliceStation()
        {
            bool sant = true;
            do
            {
                Console.WriteLine("1. Legitimation\n2. Pass\n3. Kriminalregister\n4. Lämna");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Fyll i formuläret här tack!");
                        Console.Clear();
                        Form();
                        break;
                    case "2":
                        Console.WriteLine("Tyvärr, våra pass är tyvärr slut.");
                        break;
                    case "3":
                        Console.WriteLine("Just nu funkar inte det då vårat dator system inte funkar.");
                        break;
                    case "4":
                        sant = false;
                        break;
                    default:
                        Console.WriteLine("Vad försökte du göra nu?!");
                        break;
                }
            } while (sant);
        }

        // This is just the form to make the ID card.
        public void Form()
        {
            Console.WriteLine("Skriv ditt namn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Skriv din address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Skriv ditt telefonnummer: ");
            int phoneNumber = int.Parse(Console.ReadLine());
            this.customer = new Customer(name, address, phoneNumber, 0);
        }

        public void MeetYourFriend()
        {
            Console.WriteLine($"Hejsan {this.customer.Name}!\nHur är det? Det var länge sen vi sågs.\nDu vill inte haka på och kolla runt marknaden ihop?");
            Console.WriteLine("Svar: Ja/Nej");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "ja")
            {
                GoWithFriend();
                TravelThroughMarket("ja");
            }
            else if (userInput == "nej")
            {
                GoWithoutFriend();
                TravelThroughMarket("nej");
            }
        }

        public void GoWithFriend()
        {
            Console.WriteLine("Du: Jo men det kan vi göra.");
            Console.WriteLine("Din vän: Behöver du pengar du kan få låna av mig.");
            this.customer.Cash = 2000;
            Console.WriteLine($"Du fick {this.customer.Cash}");
        }

        public void GoWithoutFriend()
        {
            Console.WriteLine("Du: Nähe... jag tror jag ska kolla runt lite själv.");
            Console.WriteLine("Din vän: Jaha...? Trodde vi var kompisar men ja jag kanske trodde fel.");
            Console.WriteLine("\"Din vän Gick iväg arg\"");
            Console.WriteLine("Åh kolla du vän tappade 2000kr. Ta dem!");
            this.customer.Cash = 2000;
        }

        // Go shoping/use restroom or exit.
        public void TravelThroughMarket(string choice)
        {
            if (choice == "ja")
            {
                Console.WriteLine("Din vän: Så vad vill du hitta på nu?");
            }
            else if (choice == "nej")
            {
                Console.WriteLine("*Undrar vad jag vill göra nu?*");
            }
            do
            {
                Console.WriteLine("Välj:\n1. Shoppen\n2. Toaletten");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShopKeeper();
                        break;
                    case "2":
                        UseRestroom();
                        break;
                    default:
                        Console.WriteLine("Kom tillbaka! Var ska du?!");
                        break;
                }

            } while (true);

        }

        public void ShopKeeper()
        {
            Console.WriteLine("Vilken shop vill du gå till?");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    LoadShop("table");
                    break;
                case "2":
                    LoadShop("chair");
                    break;
                default:
                    break;
            }
        }

        public void UseRestroom()
        {

        }

        public void LoadShop(string shop)
        {
            switch (shop)
            {
                case "table":
                    PrintList(TableList);
                    break;
                case "chair":
                    PrintList(ChairList);
                    break;
                default:
                    break;
            }
        }

        private void PrintList(List<Product> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
