using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_4_TammyDresen
{
    public partial class AddQuote : Form
    {
        #region Declarations

        string CustomerName = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0;
        Materials Finish;
        int RushDays = 0;
        int QuotePrice = 0;

        #endregion

        // constructor runs when form opens
        public AddQuote()
        {
            InitializeComponent();

            // use List<T> class to populate ComboBox of materials
            List<Materials> MaterialsList = Enum.GetValues(typeof(Materials)).Cast<Materials>().ToList();
            materialComboBox.DataSource = MaterialsList;
        }

        // when main menu button clicks, main menu opens and this form closes.
        private void CancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }

        // validate userwidth box.
        private void UserWidth_Validating(object sender, CancelEventArgs e)
        {
            // check to see if integer
            if (int.TryParse(userWidth.Text, out int result))
            { // if yes, check to see if within min and max.
                if (int.Parse(userWidth.Text) < Desk.MIN_WIDTH || int.Parse(userWidth.Text) > Desk.MAX_WIDTH)
                { // if not, cancel and ask user to fill in correct number.
                    MessageBox.Show("Width must be a number between " + Desk.MIN_WIDTH + " and " + Desk.MAX_WIDTH + ".");
                    userWidth.Text = String.Empty;
                    userWidth.BackColor = Color.LightPink;
                    userWidth.Focus();
                } // if yes, turn color to white
                else
                {
                    userWidth.BackColor = Color.White;
                }
            }
            else
            {
                userWidth.Text = String.Empty;
                userWidth.BackColor = Color.LightPink;
                userWidth.Focus();

            }
        }

        // validate userDepth to make sure it is int and is between correct range.
        private void UserDepth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(userDepth.Text, out int result))
            {
                if (int.Parse(userDepth.Text) < Desk.MIN_DEPTH || int.Parse(userDepth.Text) > Desk.MAX_DEPTH)
                {
                    MessageBox.Show("Depth must be a number between " + Desk.MIN_DEPTH + " and " + Desk.MAX_DEPTH + ".");
                    userDepth.Text = String.Empty;
                    userDepth.BackColor = Color.LightPink;
                    userDepth.Focus();
                }
                else
                {
                    userDepth.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid depth.");
                userDepth.Text = "";
                userDepth.Focus();

            }
        }


        // keypress validator disallows any non digit character on userDepth and userWidth
        private void UserDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void UserWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // submit the quote.
        private void SubmitQuote_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerName = userName.Text;
                DeskWidth = int.Parse(userWidth.Text);
                DeskDepth = int.Parse(userDepth.Text);
                Drawers = int.Parse(userDrawers.Text);
                Finish = (Materials)materialComboBox.SelectedValue;
                RushDays = int.Parse(userSpeed.Text);

                // instantiate new deskQuote
                DeskQuote NewQuote = new DeskQuote(DeskWidth, DeskDepth, Drawers, Finish, RushDays, CustomerName);
                // Save the Quote Price
                QuotePrice = NewQuote.CalculateQuotePrice();

                // store the user input, the quote amount, and the date of the quote
                // create CSV string
                string csvString = CustomerName + "," + DeskWidth + "," + DeskDepth + "," + Drawers + "," +
                    Finish + "," + RushDays + "," + QuotePrice + "," + DateTime.Now;
                string csvFile = @"quotes.txt";
                // check if file exists. If no, create file
                if (!File.Exists(csvFile))
                {
                    using (StreamWriter sw = File.CreateText(csvFile))
                    {
                        sw.WriteLine(csvString);
                    }
                }
                // if yes, append to file
                else
                {
                    using (StreamWriter sw = File.AppendText(csvFile))
                    {
                        sw.WriteLine(csvString);
                    }
                }
                // output the price quote to the screen along with the original user input 
                DisplayQuote displayQuote = new DisplayQuote(NewQuote)
                { Tag = this };
                displayQuote.Show(this);
                Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Please fill in all fields.");
                // validate fields
                if (CustomerName == "")
                {
                    userName.BackColor = Color.LightPink;

                }
                if (DeskWidth == 0)
                {
                    userWidth.BackColor = Color.LightPink;

                }
                if (DeskDepth == 0)
                {
                    userDepth.BackColor = Color.LightPink;

                }
                if (userSpeed.Text == "")
                {
                    userSpeed.BackColor = Color.LightPink;

                }
                this.Show();
            }

            {


            }

            
        }

        private string ToString(object selectedItem)
        {
            throw new NotImplementedException();
        }

        private void UserSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            userSpeed.BackColor = Color.White;
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            userName.BackColor = Color.White;
        }

        
    }
}
