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

        private Int64 idProfesor;
        private Int64 idAct;
        private Int64 idHijo;
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;

        public Form_Actividades(Menu m_Form)
        {
            InitializeComponent();
            this.main_Form = m_Form;
            idHijo = idAct = -1;
            idProfesor = 100;

            con = new SqlConnection();
            connectionString = @"Data Source=MAUVALDES\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
            //connectionString = @"Data Source=MAUVALDES\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
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
            // TODO: This line of code loads data into the 'marillacDataSet.Hijo' table. You can move, or remove it, as needed.
            this.hijoTableAdapter.FillBy(this.marillacDataSet.Hijo, idAct);
            this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
            this.beneficiarioTableAdapter.FillBy(this.marillacDataSet.Beneficiario, idAct);
            dataGridView1.ClearSelection();
            limpiarTextBox();
        }

        //BOT�N PARA SALIR
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCI�N PARA AGREGAR REGISTRO A LA BASE DE DATOS
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Administracion.Actividad (idProfesor, nombreActividad, diasImparte, horaInicio, horaFinal, cupo, costo) VALUES (" + idProfesor + ",'" + nombreActividad.Text + "', '" + diasImpartida.Text + "', '" + horaInicio.Text + "', '" + horaFinal.Text + "', '" + cupo.Text + "'," + costo.Text + ")";
                adapter.InsertCommand = new SqlCommand(query, con);
                adapter.InsertCommand.ExecuteNonQuery();
                limpiarTextBox();
                con.Close();

                this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Se deben llenar todos los campos para poner agregar una actividad");
            }
            limpiarTextBox();
        }

        //FUNCI�N PARA LIMPIAR LOS CAMPOS DE CAPTURA DE DATOS
        private void limpiarTextBox()
        {
            nombreActividad.Clear();
            diasImpartida.Clear();
            horaInicio.Clear();
            horaFinal.Clear();
            cupo.Clear();
            costo.Clear();
            textBox1.Clear();
            idProfesor = 100;
            //idProfesor.Clear();
        }

        //FUNCI�N PARA ELIMINAR REGISTRO DE LA BASE DE DATOS
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
                    MessageBox.Show("No se puede eliminar la actividad ya que hay Beneficiarios y/o Hijos inscritos en ella.");
                }
            }
            limpiarTextBox();
        }

        //FUNCI�N PARA MODIFICAR EL REGISTRO SELECCIONADO DEL DATAGRID
        private void button2_Click(object sender, EventArgs e)
        {
            Int64 idModificar;

            if (dataGridView1.SelectedRows.Count != 0)
            {
                idModificar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

                try
                {
                    con.Open();
                    string query = "UPDATE Administracion.Actividad SET idProfesor=" + idProfesor + ", diasImparte='" + diasImpartida.Text + "', horaInicio='" + horaInicio.Text + "', horaFinal='" + horaFinal.Text + "', cupo='" + cupo.Text + "', costo=" + costo.Text + " WHERE idActividad=" + idModificar;
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
            limpiarTextBox();
        }

        //FUNCI�N QUE LLENA LOS TEXT BOX CUANDO SE SELECCIONA UN CAMPO DEL DATA GRID
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
                textBox1.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                if (textBox1.Text == "3")
                    textBox1.Text = "pendiente";
                idAct = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                this.beneficiarioTableAdapter.FillBy(this.marillacDataSet.Beneficiario, idAct);
                this.hijoTableAdapter.FillBy1(this.marillacDataSet.Hijo, idAct);
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

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hijoTableAdapter.FillBy1(this.marillacDataSet.Hijo, ((long)(System.Convert.ChangeType(claveActividadToolStripTextBox.Text, typeof(long)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiarTextBox();
        }

        //BOTON PARA LLAMAR A LA FORMA EN DONDE ESTAN TODOS LOS PROFESORES
        private void button6_Click(object sender, EventArgs e)
        {
            /*this.hijosDeBeneficiario = new hijosDeBeneficiario(this,connectionString,idBen);
                this.hijosDeBeneficiario.ShowDialog();;*/
            muestraProfesor_Actividades mp= new muestraProfesor_Actividades(idProfesor);
            mp.ShowDialog();
            idProfesor = mp.regresa();
            if(idProfesor == 3)
            {
                MessageBox.Show("La asignación de profesor quedará pendiente");
                textBox1.Text = "pendiente";
            }
            else
            {
                MessageBox.Show("Has seleccionado al Profesor con el ID: " + idProfesor);
                textBox1.Text = idProfesor.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AltaActividadBeneficiario aa = new AltaActividadBeneficiario();
            aa.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AltaActividadHijo aah = new AltaActividadHijo();
            aah.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BajaActividadBeneficiario bab = new BajaActividadBeneficiario();
            bab.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BajaActividadHijo bah = new BajaActividadHijo();
            bah.ShowDialog();
        }
    }
}