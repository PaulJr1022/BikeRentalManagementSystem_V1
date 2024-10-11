using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class ElectricBike : Bike
    {
        public string BatteryCapacity {  get; set; }
        public string MotorPower { get; set; }

        public ElectricBike(string bikeId, string brand, string model, decimal rentalPrice, string batteryCapacity, string motorPower) : base(bikeId, brand, model, rentalPrice)
        {
            BatteryCapacity = batteryCapacity;
            MotorPower = motorPower;
        }

        //public void DisplayElectricBikeInfo()
        //{
        //    var Info = new DisplayBikeInfo();
        //    Console.WriteLine($"{Info}, batteryCapacity : {BatteryCapacity}, motorPower : {MotorPower} ");
        //}

        //public void DisplayBikeInfo()
        //{
        //    var bikeInfo = base.DisplayBikeInfo();
        //    Console.WriteLine($"{bikeInfo}, batteryCapacity : {BatteryCapacity}, motorPower : {MotorPower} ");
        //} 
        
        public string DisplayBikeInfo()
        {
            var bikeInfo = base.DisplayBikeInfo();
            return($"{bikeInfo}, batteryCapacity : {BatteryCapacity}, motorPower : {MotorPower} ");
        }
    }
}
