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
    public partial class Form_Actividades : Form
    {
        Menu main_Form;

        private Int64 idAct;
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;

        public Form_Actividades(Menu m_Form)
        {
            InitializeComponent();
            this.main_Form = m_Form;
            idAct = 0;

            con = new SqlConnection();
            connectionString = @"Data Source=CESARJOSUE_PC\SQLSERVER_V2;Initial Catalog=Marillac;Integrated Security=True";
            //connectionString = @"Data Source=DEVCRACK-PC\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();
        }

        private void Form_Actividades_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }

        private void Form_Actividades_Load(object sender, EventArgs e)
        {
            this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
            this.beneficiarioTableAdapter.FillBy(this.marillacDataSet.Beneficiario, idAct);
            dataGridView1.ClearSelection();
            limpiarTextBox();
        }

        //BOTÓN PARA SALIR
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCIÓN PARA AGREGAR REGISTRO A LA BASE DE DATOS
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Administracion.Actividad (idProfesor, nombreActividad, diasImparte, horaInicio, horaFinal, cupo, costo) VALUES ('" + idProfesor.Text + "' , '" + nombreActividad.Text + "', '" + diasImpartida.Text + "', '" + horaInicio.Text + "', '" + horaFinal.Text + "', '" + cupo.Text + "'," + costo.Text + ")";
                adapter.InsertCommand = new SqlCommand(query, con);
                adapter.InsertCommand.ExecuteNonQuery();
                limpiarTextBox();
                con.Close();

                this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //FUNCIÓN PARA LIMPIAR LOS CAMPOS DE CAPTURA DE DATOS
        private void limpiarTextBox()
        {
            nombreActividad.Clear();
            diasImpartida.Clear();
            horaInicio.Clear();
            horaFinal.Clear();
            cupo.Clear();
            costo.Clear();
            idProfesor.Clear();
        }

        //FUNCIÓN PARA ELIMINAR REGISTRO DE LA BASE DE DATOS
        private void button3_Click(object sender, EventArgs e)
        {
            Int64 idEliminar;

            if (dataGridView1.SelectedRows.Count != 0)
            {
                idEliminar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                try
                {
                    con.Open();
                    string query = "DELETE FROM Administracion.Actividad WHERE idActividad=" + idEliminar;
                    adapter.InsertCommand = new SqlCommand(query, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
                    limpiarTextBox();
                }

                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        //FUNCIÓN PARA MODIFICAR EL REGISTRO SELECCIONADO DEL DATAGRID
        private void button2_Click(object sender, EventArgs e)
        {
            Int64 idModificar;

            if (dataGridView1.SelectedRows.Count != 0)
            {
                idModificar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

                try
                {
                    con.Open();
                    string query = "UPDATE Administracion.Actividad SET nombreActividad='" + nombreActividad.Text + "', diasImparte='" + diasImpartida.Text + "', horaInicio='" + horaInicio.Text + "', horaFinal='" + horaFinal.Text + "', cupo='" + cupo.Text + "', costo=" + costo.Text + ", idProfesor='" + idProfesor.Text + "' WHERE idActividad=" + idModificar;
                    adapter.InsertCommand = new SqlCommand(query, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
                    limpiarTextBox();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    con.Close();
                }
            }
        }

        //FUNCIÓN QUE LLENA LOS TEXT BOX CUANDO SE SELECCIONA UN CAMPO DEL DATA GRID
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                nombreActividad.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                diasImpartida.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                horaInicio.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
                horaFinal.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                cupo.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value);
                costo.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value);
                idProfesor.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                idAct = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                this.beneficiarioTableAdapter.FillBy(this.marillacDataSet.Beneficiario, idAct);
            }
            catch
            {
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.beneficiarioTableAdapter.FillBy(this.marillacDataSet.Beneficiario, ((long)(System.Convert.ChangeType(claveActividadToolStripTextBox.Text, typeof(long)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.beneficiarioTableAdapter.FillBy(this.marillacDataSet.Beneficiario, ((long)(System.Convert.ChangeType(claveActividadToolStripTextBox1.Text, typeof(long)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}