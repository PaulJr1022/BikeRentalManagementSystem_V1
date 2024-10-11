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
            int count = 0;

            if (count > 0)
            {
                foreach (Bike bike in BikeList)
                {
                    count++;
                }
            }

            if (count == 0 )
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

                var BikeDtails = BikeList.Single(Bike p => p.)

                var bikeDetails = BikeList.(Id, brand, model, price);
                BikeList.Remove(bikeDetails);
                var bikeInfo = BikeList.(Id, brand, model, price);
                BikeList.Add(bikeInfo);

                foreach (Bike bike in BikeList)
                {
                    Console.WriteLine(bike);
                }
            }

        }

        public void DeleteBike()
        {
            Console.Write("Enter Bike Id for delete bike : ");
            string id = Console.ReadLine ();

            if (id != null)
            {
                var deleteBike = BikeList.Single(Bike(p=>p.));
                BikeList.Remove (deleteBike);

            }
            else
            {
                Console.Write("Invalid Id ");
            }
        }
    }
}
