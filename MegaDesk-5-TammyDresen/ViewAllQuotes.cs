using System;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_4_TammyDresen
{
    public partial class ViewAllQuotes : Form
    {
        private string csvFile = @"quotes.txt";
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        // close back main menu
        private void btnAllCancel_Click(object sender, EventArgs e)
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
                using (StreamReader sr = new StreamReader(csvFile))
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
                }
            }
            catch (Exception)
            {

                Console.Write("Error populating form.");
            }
        }
    }
}
