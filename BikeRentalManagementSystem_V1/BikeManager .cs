using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BikeRentalManagementSystem_V1
{
    internal class BikeManager
    {
        public List<Bike> BikeList = new List<Bike>();

        public void CreateBike()
        {
            Console.Write("Enter Bike ID : ");
            string Id = Console.ReadLine();

            Console.Write("Enter Bike Brand : ");
            string brand = Console.ReadLine();

            Console.Write("Enter Bike Model : ");
            string model = Console.ReadLine();

            Console.Write("Enter Rental_Price : ");
            decimal price = decimal.Parse(Console.ReadLine());

            if (price < 0)
            {
                Console.Write("Price should be in positive");
            }
            else
            {
                //var bikeInfo = BikeList.(Id, brand, model, price);
                //BikeList.Add(bikeInfo);
            }



        }
        //public void ValidateBikeRentalPrice()
        //{
        //    if (price < 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        public void ReadBikes()
        {
            Console.Write("List All Bikes : ");
            foreach (Bike bike in BikeList)
            {
                Console.WriteLine(bike);
            }
        }

        public void UpdateBike()
        {
            Console.Write("Enter Bike Id for update Bike : ");
            string id = Console.ReadLine();
            int count = 0;

            if (count > 0)
            {
                foreach (Bike bike in BikeList)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.Write("Invalid Id...");

            }
            else
            {
                Console.Write("Enter new Bike Id :");
                string Id = Console.ReadLine();

                Console.Write("Enter Bike Brand : ");
                string brand = Console.ReadLine();

                Console.Write("Enter Bike Model : ");
                string model = Console.ReadLine();

                Console.Write("Enter Rental_Price : ");
                decimal price = decimal.Parse(Console.ReadLine());

                //var BikeDtails = BikeList.Single(Bike p => p.id)

                //var bikeDetails = BikeList.(Id, brand, model, price);
                //BikeList.Remove(bikeDetails);
                //var bikeInfo = BikeList.(Id, brand, model, price);
                //BikeList.Add(bikeInfo);

                foreach (Bike bike in BikeList)
                {
                    Console.WriteLine(bike);
                }
            }

        }

        public void DeleteBike()
        {
            Console.Write("Enter Bike Id for delete bike : ");
            string id = Console.ReadLine();
            int count = 0;

            // if (Bike p => p.Id == id)
            {
                foreach (Bike bike in BikeList)
                {
                    count++;
                }

            }

            if (count == 0)
            {
                Console.WriteLine("Invalid Id");
            }
            else
            {
                //var bikes = BikeList.Single(Bike d => d.id);
                //BikeList.Remove(bikes);
            }

        }


    }
}
