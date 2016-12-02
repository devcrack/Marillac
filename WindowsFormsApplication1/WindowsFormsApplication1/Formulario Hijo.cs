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
    public partial class Formulario_Hijo : Form
    {
        Menu main_Form;

        private SqlConnection con;
        private SqlDataAdapter adapter;


        public SqlConnection conexion;

        private string connectionString;

        public Formulario_Hijo(Form m_form, string cadena)
        {
            InitializeComponent();
            this.main_Form = (Menu)m_form;
                
            

            con = new SqlConnection();
            connectionString = cadena;
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();
            conexion = new SqlConnection(connectionString);
            dateTimePicker1.CustomFormat = "dd-MMMM-yyyy";
            dataGridView1.ClearSelection();
        
    }

        private void Formulario_Hijo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }


        private void form_is_Closing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }


        private void Formulario_Hijo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marillacDataSet.Hijo' table. You can move, or remove it, as needed.
           
            this.hijoTableAdapter.Fill(this.marillacDataSet.Hijo);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            dataGridView4.MultiSelect = false;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            limpiarTextBox();
            rellenaActividad();
            actividadtxt.Clear();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView2.DataSource = null;
            dataGridView4.DataSource = null;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.main_Form.Show();
            this.Close();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (nombre.Text != "" && paterno.Text != "" && sexo1.Text != "")
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Persona.Hijo(nombre, paterno,materno,sexo, fechaNacimiento,idBeneficiario) VALUES('" + nombre.Text + "', '" + paterno.Text + "', '" + materno.Text + "', '" + sexo1.Text + "', '" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "', '" +beneficiario.Text+  "')";
                    adapter.InsertCommand = new SqlCommand(query, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    con.Close();
                    this.hijoTableAdapter.Fill(this.marillacDataSet.Hijo);
                    dataGridView1.ClearSelection();
                    limpiarTextBox();
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("No se pueden dejar campos vacíos");
        }


        private void limpiarTextBox()
        {
            nombre.Clear();
            paterno.Clear();
            materno.Clear();
            beneficiario.Clear();
            sexo1.Text = "";
            psicologo.Clear();
            dateTimePicker1.Value = new DateTime(1990, 01, 01);
            nombretxt.Clear();
            actividadtxt.Clear();
            montotxt.Clear();
            pagotxt.Text = "";
            nombrebene.Clear();
            nombrepsi.Clear();
        }

        public bool validapago()
        {

            if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.SelectedCells.Count > 0 &&
                montotxt.Text != "" && pagotxt.Text != "") return true;
            return false;


        }

        public string textoben(string text)
        {
            string cad = "SELECT paterno,materno,nombre  From Persona.Beneficiario where idBeneficiario ="+ text;

            return Consulta(cad).Tables[0].Rows[0].ItemArray[0].ToString()+" "+ Consulta(cad).Tables[0].Rows[0].ItemArray[1].ToString()+" "+Consulta(cad).Tables[0].Rows[0].ItemArray[2].ToString();

        }


        public string textopsi(string text)
        {
            string cad = "SELECT paterno,materno,nombre  From Persona.Psicologo where idPsicologo =" + text;

            return Consulta(cad).Tables[0].Rows[0].ItemArray[0].ToString() + " " + Consulta(cad).Tables[0].Rows[0].ItemArray[1].ToString() + " " + Consulta(cad).Tables[0].Rows[0].ItemArray[2].ToString();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.ClearSelection();
                beneficiario.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                psicologo.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                nombre.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                paterno.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
                materno.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                sexo1.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value);
                dateTimePicker1.Value = DateTime.Parse(Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value));

                nombrebene.Text = textoben(beneficiario.Text);
                if (psicologo.Text != "")
                    nombrepsi.Text = textopsi(psicologo.Text);
                else
                    nombrepsi.Text = "";

                actividaddata();
                dataGridView2.ClearSelection();
                actividadtxt.Clear();
                rellenadatpago1();

                consultapagos();
                    
            }   
            catch { }
        }

        public void rellenadatpago1()
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                nombretxt.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString() + " " +
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString() + " " +
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
            }


        }
        private void botonEliminar_Click(object sender, EventArgs e)
        {
            Int64 idEliminar;
            Int64 idPsicologo;

            if (dataGridView1.SelectedRows.Count != 0)
            {
                idEliminar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                try { idPsicologo = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString()); }
                catch { idPsicologo = -1; }
               // if (idPsicologo < 0)
                //{
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Persona.Hijo WHERE idHijo=" + idEliminar;
                        adapter.InsertCommand = new SqlCommand(query, con);
                        adapter.InsertCommand.ExecuteNonQuery();
                        con.Close();

                        this.hijoTableAdapter.Fill(this.marillacDataSet.Hijo);
                        dataGridView1.ClearSelection();
                        limpiarTextBox();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message.ToString());
                    }
                //}
                //else
                //{
                   // MessageBox.Show("No se puede eliminar a un Hijo que tenga un psicólogo asignado");
                //}
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            Int64 idModificar;

            if (dataGridView1.SelectedRows.Count != 0)
            {
                idModificar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

                if (nombre.Text != "" && paterno.Text != "" && sexo1.Text != "")
                {
                    try
                    {
                        con.Open();
                        string query = "UPDATE Persona.Hijo SET nombre='" + nombre.Text +"',idBeneficiario='"+beneficiario.Text+"', paterno='" + paterno.Text + "', materno='" + materno.Text + "', sexo='" + sexo1.Text + "', fechaNacimiento='" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "' WHERE idHijo=" + idModificar;
                        adapter.InsertCommand = new SqlCommand(query, con);
                        adapter.InsertCommand.ExecuteNonQuery();
                        con.Close();

                        this.hijoTableAdapter.Fill(this.marillacDataSet.Hijo);
                        dataGridView1.ClearSelection();
                        limpiarTextBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        con.Close();
                    }
                }
                else
                    MessageBox.Show("No se pueden dejar campos vacíos");
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiartodo();
        }

        public void limpiartodo()
        {

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            limpiarTextBox();
            dataGridView2.DataSource = null;
            dataGridView4.DataSource = null;

        }

        public DataSet Consulta(string consulta)
        {
            SqlCommand cmd;
            SqlDataAdapter adaptador = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string textocmd = consulta;
            //algo
            try
            {
                conexion.Close();
                conexion.Open();
                cmd = new SqlCommand(textocmd, conexion);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(ds);
                adaptador.Dispose();
                cmd.Dispose();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return (ds);
        }

        public void actividaddata()
        {

            string cad = "Select act.idActividad,act.nombreActividad,act.diasImparte,act.horaInicio,act.horaFinal " +
            ",act.inscritos,CONCAT(prof.nombre, ' ', prof.paterno) as Profesor,inhijo.saldo From Administracion.Actividad as act " +
            "inner join Administracion.InscripcionHijo as inhijo on inhijo.idActividad = act.idActividad " +
            "inner join Persona.Profesor as prof on act.idProfesor = prof.idProfesor where inhijo.idHijo =" + dataGridView1.SelectedCells[0].Value.ToString();

            dataGridView2.DataSource = Consulta(cad).Tables[0];

        }

        public void rellenaActividad()
        {

            string cad = "SELECT * From Administracion.Actividad";

            dataGridView3.DataSource = Consulta(cad).Tables[0];



        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

            //label5.Text = "IdActividad a Inscribir : " + dataGridView3.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();



        }

        public void conDatos(string cadenaCon)
        {
            try
            {
                conexion.Close();
                conexion.Open();
                string textoCmd = cadenaCon;
                SqlCommand cmd = new SqlCommand(textoCmd, conexion);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            // act_datos();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count>0 && dataGridView3.SelectedCells.Count > 0)
            {
                string cad;
                cad = "INSERT INTO Administracion.InscripcionHijo(idHijo,idActividad) "
                + "VALUES('" + dataGridView1.SelectedCells[0].Value.ToString()+ "','" + dataGridView3.SelectedCells[0].Value.ToString() + "')";
                conDatos(cad);
                actividaddata();
                
                //limpiartodo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0 && dataGridView1.SelectedCells.Count>0)
             {
                string cad;
                cad = "DELETE FROM  Administracion.InscripcionHijo where idActividad = " +
                dataGridView2.SelectedCells[0].Value.ToString() + " and  idHijo = " + dataGridView1.SelectedCells[0].Value.ToString();
                conDatos(cad);
                actividaddata();
                dataGridView2.ClearSelection();
            }
        }

        private void botonHijos_Click(object sender, EventArgs e)
        {
            string cad = "SELECT paterno, materno,nombre, idBeneficiario From Persona.Beneficiario";
            dataGridView5.DataSource = Consulta(cad).Tables[0];
            dataGridView5.ClearSelection();
            groupBox2.Visible = true;
        }

        private void botonPsicologo_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedCells.Count>0)
            {
                actividadtxt.Text = dataGridView2.SelectedCells[1].Value.ToString();
                saldotxt.Text = dataGridView2.SelectedCells[7].Value.ToString();
            }
                
        }


        public void consultapagos()
        {

            string cad = "";
            
            if (dataGridView1.SelectedCells.Count>0)
            {
                cad = "SELECT * FROM Administracion.CuotaHijo where idHijo =" + dataGridView1.SelectedCells[0].Value.ToString();
                dataGridView4.DataSource = Consulta(cad).Tables[0];
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            insertapago();
          
        }


        public void insertapago()
        {
            
            if (dataGridView1.SelectedCells.Count > 0 && dataGridView2.SelectedCells.Count > 0 && montotxt.Text!="")
            {
                string cad;
                cad = "INSERT INTO Administracion.Cuotahijo(idHijo,idActividad,monto,fechaPago) "
                + "VALUES('" + dataGridView1.SelectedCells[0].Value.ToString() + "','" + dataGridView2.SelectedCells[0].Value.ToString() + "','" + montotxt.Text+"','" +pagotxt.Text+ "')";
                conDatos(cad);
            
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cad;


            if (dataGridView4.SelectedCells.Count > 0)
            {
                
                cad = "DELETE FROM  Administracion.CuotaHijo where idCuota = " +
                dataGridView4.SelectedCells[0].Value.ToString();
                conDatos(cad);
                actividaddata();
                dataGridView2.ClearSelection();
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            if(dataGridView5.SelectedCells.Count>0)
            {
                nombrebene.Text = dataGridView5.SelectedCells[0].Value.ToString()+" "+ dataGridView5.SelectedCells[1].Value.ToString() + " " + dataGridView5.SelectedCells[2].Value.ToString();
                beneficiario.Text = dataGridView5.SelectedCells[3].Value.ToString();
            }
            dataGridView5.ClearSelection();
        }
    }
}
