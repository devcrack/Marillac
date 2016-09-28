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
    public partial class cuotaBeneficiario : Form
    {
        private Form main_form;
        private Int64 idBen;
        private Int64 idAct;

        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;

        public cuotaBeneficiario(Form m_form, string c, Int64 id)
        {
            InitializeComponent();
            this.main_form = m_form;

            con = new SqlConnection();
            connectionString = c;
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();

            idBen = id;
            idAct = -1;
        }

        private void cuotaBeneficiario_Load(object sender, EventArgs e)
        {
            this.cuotaBeneficiarioTableAdapter.Fill(this.marillacDataSet1.CuotaBeneficiario);
            this.actividadTableAdapter.comboBoxCuotaBen(this.marillacDataSet.Actividad, idBen);
            
            limpiarDatos();
            dataGridView1.ClearSelection();
            comboBox1.SelectedItem = -1;
        }

        private void limpiarDatos()
        {
            monto.Text = "";
            saldo.Text = "";
            costo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idAct = -1;
            limpiarDatos();
            dataGridView1.ClearSelection();
            comboBox1.SelectedItem = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idAct == -1)
            {
                this.cuotaBeneficiarioTableAdapter.Fill(this.marillacDataSet1.CuotaBeneficiario);
            }
            else
            {
                idAct = Int64.Parse(comboBox1.SelectedValue.ToString());
                this.cuotaBeneficiarioTableAdapter.FillBy(this.marillacDataSet1.CuotaBeneficiario, idAct);
                saldo.Text = cargarSaldo().ToString();
                costo.Text = cargarCosto().ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex!= -1 && monto.Text!="")
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Administracion.CuotaBeneficiario (idBeneficiario, idActividad, monto, fechaPago) VALUES (" + idBen + ", " + idAct + ", " + monto.Text.ToString() + ", '" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "')";
                    adapter.InsertCommand= new SqlCommand(query, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    con.Close();
                    comboBox1.SelectedIndex = -1;
                    dataGridView1.ClearSelection();
                    monto.Text = "";
                    dateTimePicker1.Value = new DateTime(1990, 01, 01);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex!=-1)
            {
                if(dataGridView1.SelectedRows.Count!=0)
                {
                    Int64 idPago = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Administracion.CuotaBeneficiario WHERE idCuota="+idPago;
                        adapter.InsertCommand = new SqlCommand(query, con);
                        adapter.InsertCommand.ExecuteNonQuery();
                        con.Close();

                        comboBox1.SelectedIndex = -1;
                        dataGridView1.ClearSelection();
                        monto.Text = " ";
                        dateTimePicker1.Value = new DateTime(1990, 01, 01);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=0)
            {
                idAct =Int64.Parse(Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value));
                monto.Text= Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                saldo.Text = cargarSaldo().ToString();
                costo.Text = cargarCosto().ToString();
                dateTimePicker1.Value = DateTime.Parse(Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value));
                comboBox1.SelectedValue = idAct.ToString();
            }
        }

        private int cargarSaldo()
        {
            int saldo = 0;
            DataTable dt = new DataTable();
            if (idAct > 0 && idBen > 0)
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
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }

            return saldo;
        }

        private int cargarCosto()
        {
            int costo = 0;
            DataTable dt = new DataTable();
            if(idAct>0)
            {
                try
                {
                    con.Open();
                    string query = "SELECT costo FROM Administracion.Actividad WHERE idActividad="+idAct;
                    adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(dt);
                    costo = int.Parse(dt.Rows[0][0].ToString());
                    con.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
            return costo;
        }
        
    }
}
