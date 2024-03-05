using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Classes
{
    public abstract class Part
    {
        private static int _nextPartID = 1;

        public int PartID { get; private set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        protected Part()
        {
            PartID = _nextPartID++;
        }
    }
}
