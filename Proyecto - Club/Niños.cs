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
    public partial class Niños : MetroFramework.Forms.MetroForm
    {

        Niños_Menu menuNiños;


        public Niños(Niños_Menu menuNiños)
        {
            this.menuNiños = menuNiños;
            InitializeComponent();
        }

        private void Niños_Load(object sender, EventArgs e)
        {

        }

        private void Niños_FormClosed(object sender, FormClosedEventArgs e)
        {

          
            try
            {
                menuNiños.Show();
            }
            catch
            {

                MessageBox.Show("Error: Utilice el constructor sobrecargado de la clase.");
            }
        }
    }
}
