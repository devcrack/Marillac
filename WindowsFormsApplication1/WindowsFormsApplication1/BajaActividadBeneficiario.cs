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
    public partial class BajaActividadBeneficiario : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;
        private Int64 idAct;

        public BajaActividadBeneficiario()
        {
            InitializeComponent();
            con = new SqlConnection();
            connectionString = @"Data Source=CESARJOSUE_PC\SQLSERVER_V2;Initial Catalog=Marillac;Integrated Security=True";
            //connectionString = @"Data Source=MAUVALDES\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            //connectionString = @"Data Source=DEVCRACK-PC\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();
        }

        private void BajaActividadBeneficiario_Load(object sender, EventArgs e)
        {
            this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
            // TODO: This line of code loads data into the 'marillacDataSet.Beneficiario' table. You can move, or remove it, as needed.
            this.beneficiarioTableAdapter.FillBy1(this.marillacDataSet.Beneficiario, idAct);
            // TODO: This line of code loads data into the 'marillacDataSet.Actividad' table. You can move, or remove it, as needed.
            dataGridView1.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.beneficiarioTableAdapter.FillBy1(this.marillacDataSet.Beneficiario, ((long)(System.Convert.ChangeType(cveActToolStripTextBox.Text, typeof(long)))));
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
                idAct = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                this.beneficiarioTableAdapter.FillBy1(this.marillacDataSet.Beneficiario, idAct);
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 idAct;
            Int64 idBen;

            if (dataGridView1.SelectedRows.Count != 0)
            {
                idAct = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                idBen = Convert.ToInt64(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString());
                try
                {
                    con.Open();
                    string query = "DELETE FROM Administracion.InscripcionBeneficiario WHERE idActividad=" + idAct + "AND idBeneficiario=" + idBen;
                    adapter.InsertCommand = new SqlCommand(query, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
                    MessageBox.Show("Beneficiario dado de baja");
                    this.Close();
                }

                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("No se puede dar de Baja al Beneficiario");
                }
            }
        }

    }
}
