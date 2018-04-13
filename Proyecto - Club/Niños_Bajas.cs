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
    public partial class Niños_Bajas : MetroFramework.Forms.MetroForm
    {
        Niños_Menu menuNiños;


        public Niños_Bajas(Niños_Menu menuNiños)
        {
            this.menuNiños = menuNiños;
            InitializeComponent();
        }



        private void Niños_Bajas_Load(object sender, EventArgs e)
        {
          
        }

        private void Niños_Bajas_FormClosed(object sender, FormClosedEventArgs e)
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
