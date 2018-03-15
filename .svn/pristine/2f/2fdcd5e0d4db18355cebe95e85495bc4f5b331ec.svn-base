using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantoorApplicatie.Models.Floor
{
    public class FloorMaterial
    {
        public int floorMaterialId { get; set; }
        public string name { get; set; }
        public ICollection<FloorType> floorTypeList { get; set; }

        public FloorMaterial() {
        }

        public FloorMaterial(string nm)
        {
            floorTypeList = new List<FloorType>();
            name = nm;
        }
    }
}
