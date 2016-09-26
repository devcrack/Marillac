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
    public partial class hijosDeBeneficiario : Form
    {
        private Form main_form;
        private Int64 idBen;

        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;

        public hijosDeBeneficiario(Form m_form, string c, Int64 id)
        {
            InitializeComponent();
            this.main_form = m_form;

            con = new SqlConnection();
            connectionString = c;
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();

            dateTimePicker1.CustomFormat = "dd-MMMM-yyyy";
            dataGridView1.ClearSelection();

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Calibri"), 11);
            dataGridView1.DefaultCellStyle.Font = new Font(new FontFamily("Calibri"), 11);

            idBen = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hijosDeBeneficiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'marillacDataSet.Hijo' Puede moverla o quitarla según sea necesario.
            this.hijoTableAdapter.FillBy(this.marillacDataSet.Hijo, idBen);
            fillByToolStripButton_Click(sender, e);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hijoTableAdapter.FillBy(this.marillacDataSet.Hijo,idBen);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                nombre.Text= Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                paterno.Text= Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                materno.Text= Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                sexo.Text= Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                dateTimePicker1.Value= DateTime.Parse(Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value));
                edad.Text= Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value);
                psicologo.Text = cargarPsicologo();
            }
            catch { }
        }

        private string cargarPsicologo()
        {
            DataTable dt = new DataTable();
            Int64 idPsicologo;
            try { idPsicologo = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString()); }
            catch { idPsicologo = -1; }
            if (idPsicologo > 0)
            {
                try
                {
                    con.Open();
                    string query = "SELECT nombre, paterno, materno FROM Persona.Psicologo WHERE idPsicologo=" + idPsicologo;
                    string nombrePsicologo;
                    adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                    nombrePsicologo = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                    con.Close();
                    return nombrePsicologo;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
            return "";
        }
    }
}
