using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Club
{
    public partial class Niños_Menu : MetroFramework.Forms.MetroForm
    {
        public Niños_Menu()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Niños n = new Niños();
            n.ShowDialog();

        }
    }
}
