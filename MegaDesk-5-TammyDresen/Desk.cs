using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_TammyDresen
{
    public class Desk
    {
        // This class will define the attributes of the desk object with width, depth,
        // number of drawers, and the surface material.
        // may contain validation of those attributes.
        public int Width { get; set;}
        public int Depth { get; set;}
        public int Drawers { get; set;}
        public Materials Finish { get; set; }
        //public string Finish { get; set; }
        public int Area { get; set; }

        
        #region constants
        public const int MAX_WIDTH = 96;
        public const int MIN_WIDTH = 24;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        #endregion

    }
    // enum is outside of desk class, but stored inside the file.
    public enum Materials
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 150
    }
}
