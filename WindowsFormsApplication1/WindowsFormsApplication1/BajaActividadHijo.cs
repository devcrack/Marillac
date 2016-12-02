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
    public partial class BajaActividadHijo : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;
        private Int64 idAct;

        public BajaActividadHijo()
        {
            InitializeComponent();

            con = new SqlConnection();
            connectionString = @"Data Source=MAUVALDES\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            //connectionString = @"Data Source=MAUVALDES\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            //connectionString = @"Data Source=DEVCRACK-PC\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();
        }

        private void BajaActividadHijo_Load(object sender, EventArgs e)
        {
            this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
            // TODO: This line of code loads data into the 'marillacDataSet.Hijo' table. You can move, or remove it, as needed.
            this.hijoTableAdapter.FillBy1(this.marillacDataSet.Hijo, idAct);
            // TODO: This line of code loads data into the 'marillacDataSet.Actividad' table. You can move, or remove it, as needed.
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idAct = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                this.hijoTableAdapter.FillBy1(this.marillacDataSet.Hijo, idAct);
            }
            catch
            {

            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hijoTableAdapter.FillBy1(this.marillacDataSet.Hijo, ((long)(System.Convert.ChangeType(cveActToolStripTextBox.Text, typeof(long)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Int64 idAct;
            Int64 idBen;

            if (dataGridView1.SelectedRows.Count != 0)
            {
                try
                {
                    idAct = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    idBen = Convert.ToInt64(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value.ToString());
                
                    con.Open();
                    //
                    string query = "DELETE FROM Administracion.InscripcionHijo WHERE idActividad=" + idAct + "AND idHijo=" + idBen;
                    adapter.InsertCommand = new SqlCommand(query, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
                    MessageBox.Show("Hijo dado de baja");
                }

                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Actividad sin inscritos");
                }
            }
        }
    }
}
