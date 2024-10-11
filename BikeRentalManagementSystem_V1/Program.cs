using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeManager manager = new BikeManager();
            int respones = 0;
            do
            {
                Console.WriteLine("\n Bike Rental Management System" +
                    "\n 1. Add Bike" +
                    "\n 2. View All Bikes" +
                    "\n 3. Update a bike" +
                    "\n 4. Delete a bike " +
                    "\n 5. exit ");

                Console.Write("Choose an option");

                switch (respones)
                {
                    case 1:
                        manager.CreateBike();
                        break;
                    case 2:
                        manager.ReadBikes();
                        break;
                    case 3:
                        manager.UpdateBike();
                        break;
                    case 4:
                        manager.DeleteBike();
                        break;


                }
            } while (respones != 5);
        }
    }
}
