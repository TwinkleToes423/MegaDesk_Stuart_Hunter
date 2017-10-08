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
    public partial class ViewAllQuotes : Form
    {
        private Form _mainMenu2;

        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();
            _mainMenu2 = mainMenu;
        }
    }
}
