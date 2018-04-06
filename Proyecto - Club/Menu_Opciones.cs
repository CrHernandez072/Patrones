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
    public partial class Menu_Opciones : MetroFramework.Forms.MetroForm
    {
        public Menu_Opciones()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Niños_Menu nm = new Niños_Menu();
            nm.ShowDialog();
        }
    }
}
