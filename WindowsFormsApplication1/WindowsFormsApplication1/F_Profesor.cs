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
    public partial class F_Profesor : Form
    {

        public SqlConnection conexion;
        Form main_Form;
        private string datosConexion;

        private void F_Profesor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marillacDataSet.Profesor' table. You can move, or remove it, as needed.
            
            conexion_db();
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            act_datos();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void act_datos()
        {
            dataGridView1.DataSource = Consulta("SELECT * FROM Persona.Profesor").Tables[0];
            dataGridView1.ClearSelection();
            limpiaDatos();
        }


        public void conexion_db()
        {
           
                conexion = new SqlConnection(datosConexion);
        }


        public F_Profesor(Menu m_form,string cadenaconexion)
        {
            datosConexion = cadenaconexion;
            InitializeComponent();
            this.main_Form = m_form;
        }


        private void F_Profesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
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


        private void botonAgregar_Click(object sender, EventArgs e)
        {
            inserta();
            act_datos();
        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 1 )
            {
                rell_datos();
                if( nombre.Text != "")
                    conActividades();
            }

            ultimaparte();
        }

        public void ultimaparte()
        {

            dataGridView2.ClearSelection();
            dataGridView3.DataSource = null;
            label12.Text = "Nombre Actividad: " ;
            label13.Text = "Hora Inicio: " ;
            label14.Text = "Inscritos: " ;

        }

        public bool validacampos()
        {

            for (int i = 0; i < 10; i++)
                if (dataGridView1.SelectedCells[i].Value == null)
                    return false;
            return true;

        }

        public void rell_datos()
        {
            try
            {
                if (validacampos())
                {
                    nombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
                    paterno.Text = dataGridView1.SelectedCells[2].Value.ToString();
                    materno.Text = dataGridView1.SelectedCells[3].Value.ToString();
                    direccion.Text = dataGridView1.SelectedCells[4].Value.ToString();
                    colonia.Text = dataGridView1.SelectedCells[5].Value.ToString();
                    telefono.Text = dataGridView1.SelectedCells[6].Value.ToString();
                    dias.Text = dataGridView1.SelectedCells[7].Value.ToString();
                    sexo.Text = dataGridView1.SelectedCells[8].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.SelectedCells[9].Value.ToString();
                    checkBox1.Checked = (bool)dataGridView1.SelectedCells[11].Value;
                    checkBox2.Checked = (bool)dataGridView1.SelectedCells[12].Value;
                    checkBox3.Checked = (bool)dataGridView1.SelectedCells[13].Value;
                    checkBox4.Checked = (bool)dataGridView1.SelectedCells[14].Value;
                    checkBox5.Checked = (bool)dataGridView1.SelectedCells[15].Value;
                    checkBox6.Checked = (bool)dataGridView1.SelectedCells[16].Value;
                    checkBox7.Checked = (bool)dataGridView1.SelectedCells[17].Value;
                    concatdias();
                }

            }
            catch { }
        }


        public void concatdias()
        {
            dias.Text = "";
            if ((bool)dataGridView1.SelectedCells[11].Value == true)
                dias.Text = dias.Text + "lunes";
            if ((bool)dataGridView1.SelectedCells[12].Value == true)
                dias.Text = dias.Text + "martes";
            if ((bool)dataGridView1.SelectedCells[13].Value == true)
                dias.Text = dias.Text + "miercoles";
            if ((bool)dataGridView1.SelectedCells[14].Value == true)
                dias.Text = dias.Text + "jueves";
            if ((bool)dataGridView1.SelectedCells[15].Value == true)
                dias.Text = dias.Text + "viernes";
            if ((bool)dataGridView1.SelectedCells[16].Value == true)
                dias.Text = dias.Text + "sabado";
            if ((bool)dataGridView1.SelectedCells[17].Value == true)
                dias.Text = dias.Text + "domingo";
            



        }
           
        public void limpiaDatos()
        {
            nombre.Clear();
            paterno.Clear();
            materno.Clear();
            direccion.Clear();
            colonia.Clear();
            telefono.Clear();
            dias.Clear();
            sexo.Clear();
            dateTimePicker1.Text = "";

            dataGridView2.ClearSelection();
            dataGridView3.DataSource = null;

            
        }

        public bool validatxt()
        {

            if (nombre.Text != "" && paterno.Text != "" && materno.Text != ""
            && direccion.Text != "" && colonia.Text != "" && telefono.Text != ""
            && dias.Text != "" && sexo.Text != "" && dateTimePicker1.Text != "")
                return true;
            return false;
        }

        public void elimina()
        {
            if(dataGridView1.SelectedRows.Count>0 && dataGridView1.SelectedCells[0].Value != null)
                conDatos("DELETE FROM Persona.Profesor WHERE IdProfesor =" + dataGridView1.SelectedCells[0].Value.ToString());

            act_datos();
        }


        public void inserta()
        {
            string cad;
            cad = "INSERT INTO Persona.Profesor(nombre,paterno,materno,direccion,colonia,telefono,diasLaborales,sexo,fechaNacimiento,lunes,martes,miercoles,jueves,viernes,sabado,domingo)"
            + "VALUES('"  +  nombre.Text  + "','" + paterno.Text + "','" + materno.Text + "','" + direccion.Text + "','" + colonia.Text +
            "','" +telefono.Text + "','" + dias.Text + "','" + sexo.Text + "','" + dateTimePicker1.Text +"','"+checkBox1.Checked.ToString() + "','" + checkBox2.Checked.ToString()+"','" + checkBox3.Checked.ToString() +
            "','"+checkBox4.Checked.ToString()+ "','" + checkBox5.Checked.ToString() +"','"+ checkBox6.Checked.ToString()+"','"+ checkBox7.Checked.ToString() +"')";
            conDatos(cad);
            act_datos();
        }


        public void actualiza()
        {
            string cad;

            if (dataGridView1.SelectedRows.Count > 0 && validatxt() != false)
            {
                cad = "UPDATE Persona.Profesor SET nombre='" + nombre.Text + "',paterno='" + paterno.Text + "',materno='" + materno.Text
                + "',direccion='" + direccion.Text + "',colonia='" + colonia.Text + "',telefono='" + telefono.Text
                + "',diasLaborales='" + dias.Text + "',sexo='" + sexo.Text + "',fechaNacimiento='" + dateTimePicker1.Text+
                "',lunes='"+checkBox1.Checked+ "',martes='" + checkBox2.Checked+ "',miercoles='" + checkBox3.Checked+
                "',jueves='" + checkBox4.Checked+ "',viernes='" + checkBox5.Checked+ "',sabado='" + checkBox6.Checked
                + "',domingo='" + checkBox7.Checked+ "' WHERE IdProfesor =" + dataGridView1.SelectedCells[0].Value.ToString();
                conDatos(cad);
                act_datos();
            }
            else
                MessageBox.Show("Campo vacio no permitido");
          
        }


        private void botonEliminar_Click(object sender, EventArgs e)
        {
            elimina();
        }


        private void botonModificar_Click(object sender, EventArgs e)
        {
            actualiza();
        }


        public void conActividades()
        {
            string cad,idprofesor;

            if (dataGridView1.SelectedCells[0].Value != null)
            {
                idprofesor = dataGridView1.SelectedCells[0].Value.ToString();
                cad = "Select * From Administracion.Actividad Where idProfesor = " + dataGridView1.SelectedCells[0].Value.ToString();
                dataGridView2.DataSource = Consulta(cad).Tables[0];
            }
        }

        private void dias_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.main_Form.Show();
            this.Close();


            
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {

            if(dataGridView2.SelectedCells.Count>0)
                actividaddata();
            
        }

        public void actividaddata()
        {

            label12.Text = "Nombre Actividad: " + dataGridView2.SelectedCells[2].Value.ToString();
            label13.Text = "Hora Inicio: " + dataGridView2.SelectedCells[4].Value.ToString();
            label14.Text = "Inscritos: " + dataGridView2.SelectedCells[8].Value.ToString();

            string cad = "SELECT   CONCAT(hijo.nombre, '  ', hijo.Paterno, '   ', hijo.materno, '  ', '(hijo)') " +
            "as Nombre  From Administracion.InscripcionHijo as inhijo inner join Persona.Hijo as hijo on inhijo.idHijo = hijo.idHijo " +
            "where inhijo.idActividad = " + dataGridView2.SelectedCells[0].Value.ToString() + " UNION ALL " +
            "SELECT CONCAT (ben.nombre , '  ', ben.Paterno, '   ', ben.Materno, '  ', '(beneficiario)') From Administracion.InscripcionBeneficiario as inben " +
            "inner join Persona.Beneficiario as ben on inben.idBeneficiario = ben.idBeneficiario where inben.idActividad = "+ dataGridView2.SelectedCells[0].Value.ToString();

            dataGridView3.DataSource = Consulta(cad).Tables[0];

        }
    }
}
