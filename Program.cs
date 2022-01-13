using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_MP1_Level1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Asset> assets = new List<Asset>();

            Console.WriteLine("Enter User Assets: ");

            while (true)
            {

                Console.WriteLine("UsearName: ");
                string userName = Console.ReadLine();

                if (userName == "q")
                {
                    Console.WriteLine("Username".PadRight(15) + "Modelname".PadRight(15) + "Purchasedate".PadRight(30) + "Price");
                    foreach (Asset data in assets)
                    {
                        Console.WriteLine(data.UserName.PadRight(15) + data.ModelName.PadRight(15) + data.PurchaseDate.ToString().PadRight(30) + data.Price);

                    }
                    break;

                }
                else
                {

                    Console.WriteLine("Computer Name: ");

                    string computername = Console.ReadLine();
                    Console.WriteLine("Phone Name: ");
                    string phonename = Console.ReadLine();

                    DateTime dt1 = new DateTime(2019, 12, 25);
                    DateTime dt2 = new DateTime(2020, 04, 08);
                    DateTime dt3 = new DateTime(2018, 07, 11);

                    Computers asus = new Computers($"{userName}", "Asus", dt1, 1500);
                    Computers macbook = new Computers($"{userName}", "Macbook", dt3, 2000);
                    Computers lenovo = new Computers($"{userName}", "Lenovo", dt2, 2500);
                    //Computers otherC = new Computers($"{userName}", "Dell", dt2, 1000);

                    Mobile iphone = new Mobile($"{userName}", "Iphone", dt1, 3000);
                    Mobile samsung = new Mobile($"{userName}", "Samsung", dt1, 4000);
                    Mobile nokia = new Mobile($"{userName}", "Nokia", dt3, 5000);
                    //Mobile otherM = new Mobile($"{userName}", "Moto", dt3, 5000);

                    if (computername == "Asus")
                    {
                        assets.Add(asus);
                    }
                    if (computername == "Macbook")
                    {
                        assets.Add(macbook);
                    }
                    if (computername == "Lenovo")
                    {
                        assets.Add(lenovo);
                    }

                    

                    if (phonename == "Iphone")
                    {

                        assets.Add(iphone);
                    }

                    if (phonename == "Samsung")
                    {

                        assets.Add(samsung);
                    }


                    if (phonename == "Nokia")
                    {

                        assets.Add(nokia);
                    }

                    

                }

            }
        }

    }


    class Computers : Asset
    {

        public Computers(string userName, string modelName, DateTime purchaseDate, int price) : base(userName, modelName, purchaseDate, price)
        {

        }
    }

    class Mobile : Asset
    {

        public Mobile(string userName, string modelName, DateTime purchaseDate, int price) : base(userName, modelName, purchaseDate, price)
        {
        }
    }
    class Asset
    {
        public Asset(string userName, string modelName, DateTime purchaseDate, int price)
        {
            UserName = userName;
            ModelName = modelName;
            PurchaseDate = purchaseDate;
            Price = price;
        }

        public string UserName { get; set; }
        public string ModelName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }


    }

}
