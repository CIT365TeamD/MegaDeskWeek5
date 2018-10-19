using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_2_TammyDresen
{
    public partial class SearchQuotes : Form
    {
        // save csv file to constant
        private const string QUOTES = @"../../assets/quotes.txt";
        private const string JSON = @"../../assets/quotes.json";
        
        // constructor
        public SearchQuotes()
        {
            InitializeComponent();
            
        }

        // event when SearchQuotes form is loaded
        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            // populate material selection values
            MaterialsCombo.DataSource = Enum.GetNames(typeof(Materials));
        }

        // event when search button is clicked.
        private void Button1_Click(object sender, EventArgs e)
        {
            // get the material type from the combobox and then search the quotes.txt file.
            try
            {
                string selection = MaterialsCombo.Text;
               searchResultsList.Items.Clear();
                // using streamreader, open quotes.json
                if (File.Exists(@"../../assets/quotes.json"))
                {
                    using (StreamReader sr = File.OpenText(JSON))
                    {
                        string json = sr.ReadToEnd();
                        var list = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                        foreach (DeskQuote value in list)
                        {
                            string finish = (string)value.Desk.Finish.ToString();
                            if (finish == selection)
                            {
                                ListViewItem lvi = new ListViewItem(value.CustomerName);
                                lvi.SubItems.Add(value.Desk.Width.ToString() + " in.");
                                lvi.SubItems.Add(value.Desk.Depth.ToString() + " in.");
                                lvi.SubItems.Add(value.Desk.Drawers.ToString());
                                lvi.SubItems.Add(value.Desk.Finish.ToString());
                                lvi.SubItems.Add(value.TurnAround.ToString() + " days");
                                lvi.SubItems.Add("$" + value.QuotePrice.ToString());
                                lvi.SubItems.Add(value.QuoteDate.ToString("MM/dd/yyyy"));
                                searchResultsList.Items.Add(lvi);
                            }
                        }
                    }
                }
                    // using the streamreader, open quotes.txt
                    /*    using (StreamReader sr = File.OpenText(QUOTES))
                    {
                        // use readline to read each line
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            // see if each line contains selection
                            if (s.Contains(selection))
                            {
                                string[] columns = s.Split(',');
                                ListViewItem lvi = new ListViewItem(columns[0]);
                                lvi.SubItems.Add(columns[1] + " in.");
                                lvi.SubItems.Add(columns[2] + " in.");
                                lvi.SubItems.Add(columns[3]);
                                lvi.SubItems.Add(columns[4]);
                                lvi.SubItems.Add(columns[5] + " days");
                                lvi.SubItems.Add("$" + columns[6]);
                                string substr = columns[7].Substring(0, 10);
                                lvi.SubItems.Add(substr);
                                searchResultsList.Items.Add(lvi);

                            }
                        }
                    }
                    {*/

                


               


            }
            catch (Exception)
            {

                MessageBox.Show("Sorry. Unable to find quotes");
            }
        }

        // close and go back to main menu
        private void BtnSearchCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        
    }
}
