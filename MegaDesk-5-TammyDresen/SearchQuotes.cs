using System;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_4_TammyDresen
{
    public partial class SearchQuotes : Form
    {
        // save csv file to constant
        private const string QUOTES = @"quotes.txt";
        
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

                
                // using the streamreader, open quotes.txt
                using (StreamReader sr = File.OpenText(QUOTES))
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
                {

                }
                
                
                // if so, use writeline to write to list??


            }
            catch (Exception)
            {

                throw;
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
