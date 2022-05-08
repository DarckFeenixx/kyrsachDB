using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsDb
{
    public static class StaticHelpers
    {
        public static readonly string baseConnectionString = @"Server=localhost;Database=kyrsachDb_test;User Id=kyrsach;Password=1pq0!PQ)";
        public static readonly List<string> filtersInstalledCameras = new()
        { 
            "filtModelTB",
            "filtManufactorerTB",
            "filtDatePlacedTB",
            "filtOwnerTB",
            "filtIpTB",
            "filtMacTB",
            "filtCityTB",
            "filtRegionTB",
            "filtStreetTB",
            "filtHouseTB" 
        };
        public static readonly List<string> filtersCameras = new()
        {
            "filtModelTB",
            "filtManufactorerTB" 
        };
        public static readonly List<string> filtersOwners = new()
        {
            "filtOwnerTB",
            "filtCityTB",
            "filtRegionTB",
            "filtStreetTB",
            "filtHouseTB" 
        };
        public static readonly List<string> filtersAddress = new()
        {
            "filtCityTB",
            "filtRegionTB",
            "filtStreetTB",
            "filtHouseTB"
        };
        public static readonly List<string> filtersUsers = new() { };
    }
}
