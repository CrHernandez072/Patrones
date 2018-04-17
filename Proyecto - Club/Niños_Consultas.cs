using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto___Club
{
    public partial class Niños_Consultas : MetroFramework.Forms.MetroForm
    {
<<<<<<< HEAD

        Niños_Menu menuNiños;


        public Niños_Consultas(Niños_Menu menuNiños)
=======
        cls_conexion miBD = new cls_conexion();

        public Niños_Consultas()
>>>>>>> reporte_cristian
        {
            this.menuNiños = menuNiños;
            InitializeComponent();
            ocultar_paneles_busqueda();
        }

        private void cambio_filtro(object sender, EventArgs e)
        {
            ocultar_paneles_busqueda();
            MetroFramework.Controls.MetroComboBox combobox = sender as MetroFramework.Controls.MetroComboBox;
            
            if (combobox.Text.Equals("Miembro"))
                panel_nomiembro.Visible = true;
            else if (combobox.Text.Equals("Nombre"))
                panel_nombre.Visible = true;
            else if (combobox.Text.Equals("Apellido"))
                panel_apellido.Visible = true;
            else if (combobox.Text.Equals("Edad"))
                panel_edad.Visible = true;

        }

        public void ocultar_paneles_busqueda()
        {
            panel_nomiembro.Visible = false;
            panel_nombre.Visible = false;
            panel_apellido.Visible = false;
            panel_edad.Visible = false;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
          
        }
        private void Niños_Consultas_Load(object sender, EventArgs e)
        {

        }

        private void Niños_Consultas_FormClosed(object sender, FormClosedEventArgs e)
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
