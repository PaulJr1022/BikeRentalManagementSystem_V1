using System;
using System.Collections.Generic;
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

            var bikeInfo = BikeList.(Id, brand, model, price);
            BikeList.Add(bikeInfo);
        }

        public void ReadBikes ()
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
            string id = Console.ReadLine ();

            if (id != null)
            {
                Console.Write("Enter new Bike Id :");
                string Id = Console.ReadLine();

                Console.Write("Enter Bike Brand : ");
                string brand = Console.ReadLine();

                Console.Write("Enter Bike Model : ");
                string model = Console.ReadLine();

                Console.Write("Enter Rental_Price : ");
                decimal price = decimal.Parse(Console.ReadLine());

                var bikeDetails = BikeList.(Id, brand, model, price);
                BikeList.Remove(bikeDetails);
                var bikeInfo = BikeList.(Id, brand, model, price);
                BikeList.Add(bikeInfo);

                foreach (Bike bike in BikeList)
                {
                    Console.WriteLine(bike);
                }

            }
            else
            {
                Console.Write("Invalid Id...");
            }

        }

        public void DeleteBike()
        {
            Console.Write("Enter Bike Id for delete bike : ");
            string id = Console.ReadLine ();

            if (id != null)
            {
                var deleteBike = BikeList.Single(p=>p.Equals(id));
                BikeList.Remove (deleteBike);

            }
            else
            {
                Console.Write("Invalid Id ");
            }
        }
    }
}
