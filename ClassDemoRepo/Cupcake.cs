using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoRepo
{
    public class Cupcake
    {
        //POCO Plain Old C# Object
        public string Flavor { get; set; }
        public int CupcakeID { get; set; }
        public bool IsFrosted { get; set; }

        public Cupcake() { }
        public Cupcake(string flavor, int cupcakeID, bool isFrosted)
        {
            Flavor = flavor;
            CupcakeID = cupcakeID;
            IsFrosted = isFrosted;
        }
    }
}
