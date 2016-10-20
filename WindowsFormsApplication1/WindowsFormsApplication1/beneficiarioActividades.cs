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
    public partial class beneficiarioActividades : Form
    {
        private Form main_form;
        private Int64 idBen;

        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;

        public beneficiarioActividades(Form m_form, string c, Int64 id)
        {
            InitializeComponent();
            this.main_form = m_form;

            con = new SqlConnection();
            connectionString = c;
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();

            idBen = id;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Calibri"), 11);
            dataGridView1.DefaultCellStyle.Font = new Font(new FontFamily("Calibri"), 11);
        }

        private void beneficiarioActividades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'marillacDataSet.Actividad' Puede moverla o quitarla según sea necesario.
            this.actividadTableAdapter.FillBy(this.marillacDataSet.Actividad, idBen);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string auxHora;
                nombre.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                dias.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                profesor.Text = cargarProfesor();
                auxHora = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
                inicio.Text = auxHora[0].ToString() + auxHora[1].ToString() + ":" + auxHora[2].ToString() + auxHora[3].ToString();
                auxHora = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                final.Text = auxHora[0].ToString() + auxHora[1].ToString() + ":" + auxHora[2].ToString() + auxHora[3].ToString();
                costo.Text = "$" + Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value);
                saldo.Text = "$" + cargarSaldo().ToString();
            }
            catch { }
        }

        private string cargarProfesor()
        {
            string profesor = "";
            DataTable dt = new DataTable();
            Int64 idProf;
            try { idProf = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()); }
            catch { idProf = -1; }
            if(idProf>0)
            {
                try
                {
                    con.Open();
                    string query = "SELECT nombre, paterno, materno FROM Persona.Profesor WHERE idProfesor=" + idProf;
                    adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                    profesor= dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                    con.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
            return profesor;
        }

        private int cargarSaldo()
        {
            int saldo = 0;
            DataTable dt = new DataTable();
            Int64 idAct;
            try { idAct = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString()); }
            catch { idAct = -1; }
            if(idAct>0 && idBen>0)
            {
                try
                {
                    con.Open();
                    string query = "SELECT saldo FROM Administracion.InscripcionBeneficiario WHERE idActividad=" + idAct + " AND idBeneficiario=" + idBen;
                    adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                    saldo = int.Parse(dt.Rows[0][0].ToString());
                    con.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }

            return saldo;
        }
    }
}
