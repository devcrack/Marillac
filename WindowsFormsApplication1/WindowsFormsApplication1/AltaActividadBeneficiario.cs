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
    public partial class AltaActividadBeneficiario : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;
        private Int64 idBene;
        private Int64 idActi;

        public AltaActividadBeneficiario()
        {
            InitializeComponent();

            con = new SqlConnection();
            connectionString = @"Data Source=MAUVALDES\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            //connectionString = @"Data Source=MAUVALDES\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            //connectionString = @"Data Source=DEVCRACK-PC\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();
        }

        private void AltaActividadBeneficiario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marillacDataSet.Actividad' table. You can move, or remove it, as needed.
            this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
            // TODO: This line of code loads data into the 'marillacDataSet.Beneficiario' table. You can move, or remove it, as needed.
            this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Administracion.InscripcionBeneficiario (idActividad, idBeneficiario, saldo) values ("+ idActi +" , "+ idBene +", "+ 0 +")";
                adapter.InsertCommand = new SqlCommand(query, con);
                adapter.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Beneficiario dado de alta con éxito");
            }

            catch
            {
                MessageBox.Show("El Beneficiario ya se encuentra en esa Actividad");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            idBene = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            idActi = Convert.ToInt64(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString());
        }
    }
}
