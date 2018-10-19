using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_2_TammyDresen
{
    public partial class ViewAllQuotes : Form
    {
       // private string csvFile = @"../../assets/quotes.txt";
        private const string JSON = @"../../assets/quotes.json";

        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        // close back main menu
        private void BtnAllCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        // when form loads, data is populated
        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            try
            {   // use streamreader to open file
                /* using (StreamReader sr = new StreamReader(csvFile))
                 {   // readline stores line in s. If it isn't empty, store it in list view item
                     string s = "";
                     while ((s = sr.ReadLine()) != null )
                     {
                         string[] quote = s.Split(',');
                         ListViewItem lvi = new ListViewItem(quote[0]);
                         lvi.SubItems.Add(quote[1] + " in.");
                         lvi.SubItems.Add(quote[2] = " in.");
                         lvi.SubItems.Add(quote[3]);
                         lvi.SubItems.Add(quote[4]);
                         lvi.SubItems.Add(quote[5] + " days");
                         lvi.SubItems.Add("$" + quote[6]);
                         string substr = quote[7].Substring(0, 10);
                         lvi.SubItems.Add(substr);

                         QuoteListView.Items.Add(lvi);


                     }
                 }*/
                AllResultsList.Items.Clear(); 
                using (StreamReader sr = File.OpenText(JSON))
                {
                    string json = sr.ReadToEnd();
                    var list = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
                    foreach (DeskQuote value in list)
                    {
                        ListViewItem lvi = new ListViewItem(value.CustomerName);
                        lvi.SubItems.Add(value.Desk.Width.ToString() + " in.");
                        lvi.SubItems.Add(value.Desk.Depth.ToString() + " in.");
                        lvi.SubItems.Add(value.Desk.Drawers.ToString());
                        lvi.SubItems.Add(value.Desk.Finish.ToString());
                        lvi.SubItems.Add(value.TurnAround.ToString() + " days");
                        lvi.SubItems.Add("$" + value.QuotePrice.ToString());
                        lvi.SubItems.Add(value.QuoteDate.ToString("MM/dd/yyyy"));
                        AllResultsList.Items.Add(lvi);

                    }
                }
            }
            catch (Exception)
            {

                Console.Write("Error populating form.");
            }
        }
    }
}
