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
    public partial class Niños : MetroFramework.Forms.MetroForm
    {
//<<<<<<< HEAD

//        Niños_Menu menuNiños;


//        public Niños(Niños_Menu menuNiños)
//=======
//        cls_conexion miBD = new cls_conexion();

//        public Niños()
//>>>>>>> reporte_cristian
//        {
//            this.menuNiños = menuNiños;
//            InitializeComponent();
//        }

//<<<<<<< HEAD
//        private void Niños_Load(object sender, EventArgs e)
//        {

//        }

//        private void Niños_FormClosed(object sender, FormClosedEventArgs e)
//        {

          
//            try
//            {
//                menuNiños.Show();
//            }
//            catch
//            {

//                MessageBox.Show("Error: Utilice el constructor sobrecargado de la clase.");
//            }
//        }
//=======
//        private void dg_btn_guardar_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                miBD.conexion.Close();

//                string campos = "@no_miembro, @nombres, @ap_paterno, @ap_materno, @fecha_nac, @lugar_nac, @nacionalidad, @sexo" +
//                    "@inst_dechohabiente, @vive_con, @telefono, @dom_calle, @dom_numero, @dom_colonia, @dom_codpost, @dom_delegacion" +
//                    "@dom_municipio, @escuela, @esc_turno, @recoge1_nino, @parent_recoge1, @recoge2_nino, @parent_recoge2, @recoge3_nino" +
//                    "@parent_recoge3, @aviso_emergencia1, @aviso_emergencia2, @aviso_emergencia3, @fecha_inscripcion, @estado";

//                MySqlCommand alta = new MySqlCommand("insert into ninos_datos values(" + campos + ");", miBD.conexion);
//                alta.Parameters.AddWithValue("no_miembro", dg_noMiembro.Text);
//                alta.Parameters.AddWithValue("nombres", dg_nombres.Text);
//                alta.Parameters.AddWithValue("ap_paterno", dg_ap_pat.Text);
//                alta.Parameters.AddWithValue("ap_materno", dg_ap_mat.Text);
//                alta.Parameters.AddWithValue("fecha_nac", dg_fecha_nac.Text);
//                alta.Parameters.AddWithValue("lugar_nac", dg_lugar_nac.Text);
//                alta.Parameters.AddWithValue("nacionalidad", dg_nacionalidad.Text);
//                alta.Parameters.AddWithValue("sexo", dg_sexo.Text);

//                alta.Parameters.AddWithValue("inst_dechohabiente", derechohabiencia());
//                alta.Parameters.AddWithValue("vive_con", dg_vive_con.Text);
//                alta.Parameters.AddWithValue("telefono", dg_telefono.Text);
//                alta.Parameters.AddWithValue("dom_calle", dg_calle.Text);
//                alta.Parameters.AddWithValue("dom_numero", dg_numero.Text);
//                alta.Parameters.AddWithValue("dom_colonia", dg_colonia.Text);
//                alta.Parameters.AddWithValue("dom_codpost", dg_codPost.Text);
//                alta.Parameters.AddWithValue("dom_delegacion", dg_delegacion.Text);

//                alta.Parameters.AddWithValue("dom_municipio", dg_municipio.Text);
//                alta.Parameters.AddWithValue("escuela", dg_nombre_escuela.Text);
//                alta.Parameters.AddWithValue("esc_turno", dg_turno.Text);
//                alta.Parameters.AddWithValue("recoge1_nino", dg_recoge1_nino.Text);
//                alta.Parameters.AddWithValue("parent_recoge1", dg_parent_recoge1.Text);
//                alta.Parameters.AddWithValue("recoge2_nino", dg_recoge2_nino.Text);
//                alta.Parameters.AddWithValue("parent_recoge2", dg_parent_recoge2.Text);
//                alta.Parameters.AddWithValue("recoge3_nino", dg_recoge3_nino.Text);

//                alta.Parameters.AddWithValue("parent_recoge3", dg_parent_recoge3.Text);
//                alta.Parameters.AddWithValue("aviso_emergencia1", dg_aviso_emergencia1.Text);
//                alta.Parameters.AddWithValue("aviso_emergencia2", dg_aviso_emergencia2.Text);
//                alta.Parameters.AddWithValue("aviso_emergencia3", dg_aviso_emergencia3.Text);
//                alta.Parameters.AddWithValue("fecha_inscripcion", dg_fecha_inscripcion.Text);
//                alta.Parameters.AddWithValue("estado", "Activo");

//                miBD.conexion.Open();

//                //Almacena si hubo filas guardadas
//                int guardado = alta.ExecuteNonQuery();

//                miBD.conexion.Close();

//                if (guardado > 0)
//                {
//                    MessageBox.Show("Se ha guardado");
//                    limpiar_datos_generales();
//                }
//                else
//                {
//                    MessageBox.Show("No se guardo el usuario");
//                }
//            }
//            catch (MySqlException sqle)
//            {
//                MessageBox.Show("Error: " + sqle.Message);
//            }
//            finally
//            {
//                miBD.conexion.Close();
//            }
//        }

//        public string derechohabiencia()
//        {
//            string derecho = "";

//            if (dg_imss.Checked)
//                derecho += " imss";
//            if (dg_isste.Checked)
//                derecho += " isste";
//            if (dg_isstecali.Checked)
//                derecho += " isstecali";
//            if (dg_particular.Checked)
//                derecho += " particular";

//            return derecho;
//        }

//        //Métodos para limpiar campos
//        public void limpiar_datos_generales()
//        {
//            dg_noMiembro.Text = "";
//            dg_noMiembro.Text = "";
//            dg_nombres.Text = "";
//            dg_ap_pat.Text = "";
//            dg_ap_mat.Text = "";
//            dg_fecha_nac.Text = "";
//            dg_lugar_nac.Text = "";
//            dg_nacionalidad.Text = "";
//            dg_sexo.Text = "";

//            dg_vive_con.Text = "";
//            dg_telefono.Text = "";
//            dg_calle.Text = "";
//            dg_numero.Text = "";
//            dg_colonia.Text = "";
//            dg_codPost.Text = "";
//            dg_delegacion.Text = "";

//            dg_municipio.Text = "";
//            dg_nombre_escuela.Text = "";
//            dg_turno.Text = "";
//            dg_recoge1_nino.Text = "";
//            dg_parent_recoge1.Text = "";
//            dg_recoge2_nino.Text = "";
//            dg_parent_recoge2.Text = "";
//            dg_recoge3_nino.Text = "";

//            dg_parent_recoge3.Text = "";
//            dg_aviso_emergencia1.Text = "";
//            dg_aviso_emergencia2.Text = "";
//            dg_aviso_emergencia3.Text = "";
//            dg_fecha_inscripcion.Text = "";

//        }
//>>>>>>> reporte_cristian
    }
}
