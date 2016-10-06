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

        private string diasSemana;    //dias de la semana que se imparte la actividad
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
            diasSemana = "";

            con = new SqlConnection();
            connectionString = @"Data Source=CESARJOSUE_PC\SQLSERVER_V2;Initial Catalog=Marillac;Integrated Security=True";
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
            carga_datos();
        }

        void carga_datos()
        {
            // TODO: This line of code loads data into the 'marillacDataSet4.vista_actividades' table. You can move, or remove it, as needed.
            this.vista_actividadesTableAdapter3.Fill(this.marillacDataSet4.vista_actividades);
            // TODO: This line of code loads data into the 'marillacDataSet3.vista_actividades' table. You can move, or remove it, as needed.
            this.vista_actividadesTableAdapter2.Fill(this.marillacDataSet3.vista_actividades);
            // TODO: This line of code loads data into the 'marillacDataSet2.vista_actividades' table. You can move, or remove it, as needed.
            this.vista_actividadesTableAdapter1.Fill(this.marillacDataSet2.vista_actividades);
            // TODO: This line of code loads data into the 'marillacDataSet11.vista_actividades' table. You can move, or remove it, as needed.
            this.vista_actividadesTableAdapter.Fill(this.marillacDataSet11.vista_actividades);
            // TODO: This line of code loads data into the 'marillacDataSet1.Actividad' table. You can move, or remove it, as needed.
            this.actividadTableAdapter.Fill(this.marillacDataSet1.Actividad);
            // TODO: This line of code loads data into the 'marillacDataSet.Hijo' table. You can move, or remove it, as needed.
            //this.hijoTableAdapter.FillBy(this.marillacDataSet.Hijo, idAct);
            this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
            //this.beneficiarioTableAdapter.FillBy(this.marillacDataSet.Beneficiario, idAct);

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
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
                diasSemana = verificaDias();
                string query = "INSERT INTO Administracion.Actividad (idProfesor, nombreActividad, diasImparte, horaInicio, horaFinal, cupo, costo) VALUES (" + idProfesor + ",'" + nombreActividad.Text + "', '" + diasSemana + "', '" + horaInicio.Text + "', '" + horaFinal.Text + "', '" + cupo.Text + "'," + costo.Text + ")";
                adapter.InsertCommand = new SqlCommand(query, con);
                adapter.InsertCommand.ExecuteNonQuery();
                limpiarTextBox();
                con.Close();

                //this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
                carga_datos();
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Se deben llenar todos los campos para poner agregar una actividad");
            }
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
                    diasSemana = verificaDias();
                    string query = "UPDATE Administracion.Actividad SET nombreActividad ='" + nombreActividad.Text + "', idProfesor=" + idProfesor + ", diasImparte='" + diasSemana + "', horaInicio='" + horaInicio.Text + "', horaFinal='" + horaFinal.Text + "', cupo='" + cupo.Text + "', costo=" + costo.Text + " WHERE idActividad=" + idModificar;
                    adapter.InsertCommand = new SqlCommand(query, con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    //this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
                    carga_datos();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    con.Close();
                }
            }
        }

        string verificaDias()
        {
            string str = "";
            if (checkBox1.Checked == true)
                str += "Lunes ";
            if (checkBox2.Checked == true)
                str += "Martes ";
            if (checkBox3.Checked == true)
                str += "Miercoles ";
            if (checkBox4.Checked == true)
                str += "Jueves ";
            if (checkBox5.Checked == true)
                str += "Viernes ";
            if (checkBox6.Checked == true)
                str += "Sabado ";
            if (checkBox7.Checked == true)
                str += "Domingo ";
            return str;
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

                    //this.actividadTableAdapter.Fill(this.marillacDataSet.Actividad);
                    carga_datos();
                }

                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("No se puede eliminar la actividad. Beneficiarios y/o Hijos inscritos.");
                }
            }
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
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }

        //FUNCI�N QUE LLENA LOS TEXT BOX CUANDO SE SELECCIONA UN CAMPO DEL DATA GRID
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                string aux;
                nombreActividad.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                aux = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
                if (aux.Contains("Lunes"))
                    checkBox1.Checked = true;
                else
                    checkBox1.Checked = false;
                if (aux.Contains("Martes"))
                    checkBox2.Checked = true;
                else
                    checkBox2.Checked = false;
                if (aux.Contains("Miercoles"))
                    checkBox3.Checked = true;
                else
                    checkBox3.Checked = false;
                if (aux.Contains("Jueves"))
                    checkBox4.Checked = true;
                else
                    checkBox4.Checked = false;
                if (aux.Contains("Viernes"))
                    checkBox5.Checked = true;
                else
                    checkBox5.Checked = false;
                if (aux.Contains("Sabado"))
                    checkBox6.Checked = true;
                else
                    checkBox6.Checked = false;
                if (aux.Contains("Domingo"))
                    checkBox7.Checked = true;
                else
                    checkBox7.Checked = false;

                horaInicio.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                horaFinal.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value);
                cupo.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value);
                costo.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value);
                textBox1.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);

                idAct = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                idProfesor = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());

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
            muestraProfesor_Actividades mp= new muestraProfesor_Actividades(idProfesor);
            mp.ShowDialog();
            idProfesor = mp.regresa();
            string cadena = mp.regresa2();
            if(idProfesor == 3)
            {
                MessageBox.Show("La asignación de profesor quedará pendiente");
                textBox1.Text = "Pendiente";
            }
            else
            {
                //MessageBox.Show("Has seleccionado al Profesor con el ID: " + idProfesor);
                textBox1.Text = cadena;
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

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.actividadTableAdapter.FillBy1(this.marillacDataSet.Actividad);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.actividadTableAdapter.FillBy1(this.marillacDataSet.Actividad);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.actividadTableAdapter.Fill(this.marillacDataSet1.Actividad);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void manipulaDias (bool checado, string cadena)
        {
            if (checado)
            {
                if (diasSemana.Contains(cadena) == false)
                    diasSemana += cadena;
            }
            {
                if (diasSemana.Contains(cadena) == true)
                {
                    string texto2;
                    texto2 = diasSemana.Replace(cadena, string.Empty);
                    diasSemana = texto2;
                }
            }
        }

        //LUNES
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.manipulaDias(this.checkBox1.Checked, "Lunes ");
        }

        //MARTES
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.manipulaDias(this.checkBox1.Checked, "Martes ");
        }

        //MIERCOLES
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.manipulaDias(this.checkBox1.Checked, "Miércoles ");
        }

        //JUEVES
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.manipulaDias(this.checkBox1.Checked, "Jueves ");
        }

        //VIERNES
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.manipulaDias(this.checkBox1.Checked, "Viernes ");
        }

        //SABADO

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.manipulaDias(this.checkBox1.Checked, "Sábado ");
        }

        //DOMINGO
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            this.manipulaDias(this.checkBox1.Checked, "Domingo ");
        }
    }
}