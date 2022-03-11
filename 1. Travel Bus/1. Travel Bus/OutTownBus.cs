using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Travel_Bus
{
    class OutTownBus
    {
        // Properties
        private int ID;
        private string DriverName;
        private string VehicleNumber;
        private string Destination;
        private int Days;
        private int Revenue;

        // Getters
        public int GetID() => this.ID;
        public string GetDriverName() => this.DriverName;
        public string GetVehicleNumber() => this.VehicleNumber;
        public string GetDestination() => this.Destination;
        public int GetDays() => this.Days;
        public int GetRevenue() => this.Revenue;

        // Constructor
        public OutTownBus(int id, string driverName, string vehicleNumber, string destination, int days, int revenue)
        {
            this.ID = id > 0 ? id : 0;
            this.DriverName = driverName.Trim() == "" ? "#UNDEFINED" : driverName;
            this.VehicleNumber = vehicleNumber.Trim() == "" ? "#UNDEFINED" : vehicleNumber;
            this.Destination = destination.Trim() == "" ? "#UNDEFINED" : destination;
            this.Days = days > 0 ? days : 0;
            this.Revenue = revenue > 0 ? revenue : 0;
        }
    }
}
