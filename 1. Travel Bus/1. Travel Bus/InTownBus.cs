using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Travel_Bus
{
    class InTownBus
    {
        // Properties
        private int ID;
        private string DriverName;
        private string VehicleNumber;
        private int LineNumber;
        private int Distance;
        private int Revenue;

        // Setters
        public void SetID(int id)
        {
            this.ID = id > 0 ? id : 0;
        }
        public void SetDriverName(string name)
        {
            this.DriverName = name.Trim() == "" ? "#UNDEFINED" : name;
        }
        public void SetVehicleNumber(string number)
        {
            this.VehicleNumber = number.Trim() == "" ? "#UNDEFINED" : number;
        }
        public void SetLineNumber(int number)
        {
            this.LineNumber = number > 0 ? number : 0;
        }
        public void SetDistance(int distance)
        {
            this.Distance = distance > 0 ? distance : 0;
        }
        public void SetRevenue(int revenue)
        {
            this.Revenue = revenue > 0 ? revenue : 0;
        }

        // Getters
        public int GetID() => this.ID;
        public string GetDriverName() => this.DriverName;
        public string GetVehicleNumber() => this.VehicleNumber;
        public int GetLineNumber() => this.LineNumber;
        public int GetDistance() => this.Distance;
        public int GetRevenue() => this.Revenue;

        // Constructor
        public InTownBus(int id, string driverName, string vehicleNumber, int lineNumber, int distance, int revenue)
        {
            this.ID = id > 0 ? id : 0;
            this.DriverName = driverName.Trim() == "" ? "#UNDEFINED" : driverName;
            this.VehicleNumber = vehicleNumber.Trim() == "" ? "#UNDEFINED" : vehicleNumber;
            this.LineNumber = lineNumber > 0 ? lineNumber : 0;
            this.Distance = distance > 0 ? distance : 0;
            this.Revenue = revenue > 0 ? revenue : 0;
        }
    }
}
