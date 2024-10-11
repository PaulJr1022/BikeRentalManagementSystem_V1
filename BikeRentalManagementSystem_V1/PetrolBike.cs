using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class PetrolBike : Bike
    {
        public string FuelTankCapacity { get; set; }
        public string EngineCapacity { get; set; }

        public PetrolBike(string bikeId, string brand, string model, decimal rentalPrice, string fuelTankCapacity, string engineCapacity) : base(bikeId, brand, model, rentalPrice)
        {
            EngineCapacity = engineCapacity;
            FuelTankCapacity = fuelTankCapacity;
        }

        //public string DisplayPetrolBikeInfo()
        //{
        //    var Info = new DisplayBikeInfo();
        //    return($"{Info}, fuelTankCapacity : {FuelTankCapacity}, EngineCapacity : {EngineCapacity} ");
        //}

        //public void DisplayBikeInfo()
        //{
        //    var bikeInfo = base.DisplayBikeInfo();
        //    Console.WriteLine($"{bikeInfo}, fuelTankCapacity : {FuelTankCapacity}, EngineCapacity : {EngineCapacity} ");
        //}

        public string DisplayBikeInfo()
        {
            var bikeInfo = base.DisplayBikeInfo();
            return($"{bikeInfo}, fuelTankCapacity : {FuelTankCapacity}, EngineCapacity : {EngineCapacity} ");
        }
    }
}

