using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_TammyDresen
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote newQuote;

        public DisplayQuote(DeskQuote newQuote)
        {
            InitializeComponent();
            this.newQuote = newQuote;
            
        }

      

        private void BtnDisplayCancel_Click(object sender, EventArgs e)
        {
            var addQuote = (AddQuote)Tag;
            addQuote.Show();
            this.Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            displayName.Text = newQuote.CustomerName;
            displayDate.Text = newQuote.QuoteDate.ToString("MM/dd/yyyy");
            displayWidth.Text = newQuote.Desk.Width.ToString() + " inches";
            displayDepth.Text = newQuote.Desk.Depth.ToString() + " inches";
            displayDrawers.Text = newQuote.Desk.Drawers.ToString();
            displayMaterial.Text = (string)newQuote.Desk.Finish.ToString();
            displayDelivery.Text = newQuote.TurnAround.ToString();
            displayBasePrice.Text = newQuote.DeskPrice.ToString();
            area.Text = newQuote.Desk.Area.ToString() + " sq. in.";
            displayBasePrice.Text = "$" + newQuote.DeskPrice.ToString();
            drawerPrice.Text = "$" + newQuote.DrawerPrice.ToString();
            int finishPrice = (int)newQuote.Desk.Finish;
            materialPrice.Text = "$" + finishPrice.ToString();
            rushPrice.Text = "$" + newQuote.RushPrice.ToString();
            totalPrice.Text = "$" + newQuote.QuotePrice.ToString();
            drawerPriceLabel.Text = "x $" + DeskQuote.PRICE_DRAWER + " each:";
        }

       
    }
}
