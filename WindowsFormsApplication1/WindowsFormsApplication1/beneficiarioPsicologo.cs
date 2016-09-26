using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class beneficiarioPsicologo : Form
    {
        Form main_form;
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;
        private Int64 idPsicologo;
        private DataTable dt;

        public beneficiarioPsicologo(Form m_form, string cadena, Int64 id)
        {
            InitializeComponent();
            this.main_form = m_form;

            idPsicologo = id;

            con = new SqlConnection();
            connectionString = cadena;
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();

            dt = new DataTable();
            cargarInformacion();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarInformacion()
        {
            if(idPsicologo>0)
            {
                mostrarInformacion();
                try
                {
                    con.Open();
                    string query = "SELECT nombre, paterno, materno, telefono FROM Persona.Psicologo WHERE idPsicologo=" + idPsicologo;
                    adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                    nombreImprimir.Text = dt.Rows[0][0].ToString();
                    paternoImprimir.Text = dt.Rows[0][1].ToString();
                    maternoImprimir.Text = dt.Rows[0][2].ToString();
                    telefonoImprimir.Text = dt.Rows[0][3].ToString();
                    con.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
            else
            {
                mostrarError();
            }
        }

        private void mostrarError()
        {
            nombre.Hide();
            paterno.Hide();
            materno.Hide();
            telefono.Hide();
            nombreImprimir.Hide();
            paternoImprimir.Hide();
            maternoImprimir.Hide();
            telefonoImprimir.Hide();
        }

        private void mostrarInformacion()
        {
            error.Hide();
        }
    }
}
