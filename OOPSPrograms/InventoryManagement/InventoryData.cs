using OOPSPrograms.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPrograms.InventoryManagement
{
    public class InventoryData //model class for inventory
    {
        public List<Inventory> Rice { get; set; }
        public List<Inventory> Wheat { get; set; }

        public List<Inventory> Pulses { get; set; }

    }
}
