using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPrograms.InventoryDataManagement
{
    public class Inventory  //Model class for json file
    {
        public string Name { get; set; } 
        public int Weight { get; set; }
        public double PricePerKg { get; set; }
    }
}
