using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk__4_StuartPennington_HunterOakey
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote(this);
            addNewQuoteForm.Show();
            this.Hide();
        }

        private void viewQuoteMainMenu_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes(this);
            viewAllQuotesForm.Show();
            this.Hide();
        }

        private void searchQuotesMainMenu_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes(this);
            searchQuotesForm.Show();
            this.Hide();
        }

        private void exitApplicationMainMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
