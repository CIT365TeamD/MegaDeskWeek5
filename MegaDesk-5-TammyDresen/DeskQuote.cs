using System;
using System.IO;

namespace MegaDesk_4_TammyDresen
{
    public class DeskQuote
    {
        // This class will define the attributes of a quote including Desk,
        // rush days, customer name, and quote date. This class will also hold the
        // logic in determining the line item cost.
        #region member variables
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public int TurnAround { get; set; }
        public int QuotePrice { get; set; }
        public int DeskPrice { get; set; }
        public int DrawerPrice { get; set; }
        public int RushPrice { get; set; }
        public Desk Desk = new Desk();
        #endregion

        // constants to avoid magic numbers
        #region constants
        private const int PRICE_BASE = 200;
        public const int PRICE_DRAWER = 50;
        private const int PRICE_SQ_FOOT = 1;
        private const int BASE_SIZE = 1000;
        private const int UPPER_SIZE = 2000;
        // rush fee array
        private readonly int[,] RUSH_FEE = new int[3, 3]
            {
                { 60, 70, 80 },
                { 40, 50, 60 },
                { 30, 35, 40 }
            };
        #endregion

        // constructor creates new quote
        public DeskQuote(int width, int depth, int drawers, Materials finish,
            int rushDays, string name)
        {
            // save name and date to quote
            CustomerName = name;
            QuoteDate = DateTime.Now.Date;
            // save inputs to desk object
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.Drawers = drawers;
            TurnAround = rushDays;
            //Desk.Finish = (Materials)Enum.Parse(typeof(Materials), finish);
            Desk.Finish = finish;
            // calculate desk area.
            Desk.Area = width * depth;         
        }

        // calculate quote price
        public int CalculateQuotePrice()
        {
            QuotePrice = PRICE_BASE + SurfaceAreaCost() + DrawerCost() + (int)Desk.Finish + RushFee();
            return QuotePrice;
        }

        // figure cost of surface area larger than 1000sf
        public int SurfaceAreaCost()
        {
            if (Desk.Area > BASE_SIZE)
            {
                int surfaceCost = (Desk.Area - BASE_SIZE) * PRICE_SQ_FOOT;
                DeskPrice = surfaceCost + PRICE_BASE;
                return surfaceCost;
            }
            else
            {
                DeskPrice = PRICE_BASE;
                return 0;
            }
        }

        // calculate price of drawers
        public int DrawerCost()
        {
            int drawerPrice = Desk.Drawers * PRICE_DRAWER;
            DrawerPrice = drawerPrice;
            return drawerPrice;
        }

        

        // calculate rush fee based on surface area and speed
        public int RushFee()
        {
            // set size index based on surface area
            int sizeIndex = 0;
            int rush = 0;
            if (Desk.Area < BASE_SIZE)
            {
                sizeIndex = 0;
            }
            else if (Desk.Area <= UPPER_SIZE)
            {
                sizeIndex = 1;
            }
            else
            {
                sizeIndex = 2;
            }
            // return rush fee based on sizeIndex and speed
            if (TurnAround == 3)
            {
                rush = RUSH_FEE[0, sizeIndex];

            }
            else if (TurnAround == 5)
            {
                rush = RUSH_FEE[1, sizeIndex];
            }
            else if (TurnAround == 7)
            {
                rush = RUSH_FEE[2, sizeIndex];
            }
            else
            {
                rush = 0;
            }
            RushPrice = rush;
            return rush;
        }


        
        
    }
}
