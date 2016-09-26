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
    public partial class F_Beneficiario : Form
    {
        Form main_Form;
        Form beneficiarioPsicologo;

        private SqlConnection con;
        private SqlDataAdapter adapter;
        private string connectionString;

        public F_Beneficiario(Form m_Form, string cadena)
        {
            InitializeComponent();
            this.main_Form = m_Form;

            con = new SqlConnection();
            connectionString = cadena;
            con.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();

            dateTimePicker1.CustomFormat = "dd-MMMM-yyyy";
        }

        private void form_is_Closing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }

        private void F_Beneficiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'marillacDataSet.Beneficiario' Puede moverla o quitarla según sea necesario.
            this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);
            limpiarTextBox();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.main_Form.Show();
            this.Close();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (nombre.Text != "" && paterno.Text != "" && direccion.Text != "" && colonia.Text != "" && telefono.Text != "" && sexo.Text != "")
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Persona.Beneficiario(nombre, paterno, materno, direccion, colonia, telefono, sexo, fechaNacimiento) VALUES('" + nombre.Text + "', '" + paterno.Text + "', '" + materno.Text + "', '" + direccion.Text + "', '" + colonia.Text + "'," + telefono.Text + ", '" + sexo.Text + "', '" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "')";
                    adapter.InsertCommand = new SqlCommand(query, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    con.Close();

                    this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);
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
            direccion.Clear();
            colonia.Clear();
            telefono.Clear();
            sexo.Clear();
            psicologo.Clear();
            dateTimePicker1.Value = new DateTime(1990, 01, 01);
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            Int64 idEliminar;
            Int64 idPsicologo;

            if (dataGridView1.SelectedRows.Count != 0)
            {
                idEliminar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                try { idPsicologo = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString()); }
                catch { idPsicologo = -1; }
                if(idPsicologo<0)
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Persona.Beneficiario WHERE idBeneficiario=" + idEliminar;
                        adapter.InsertCommand = new SqlCommand(query, con);
                        adapter.InsertCommand.ExecuteNonQuery();
                        con.Close();

                        this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);
                        limpiarTextBox();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar a un beneficiario que tenga un psicólogo asignado");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                nombre.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                paterno.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                materno.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                psicologo.Text=cargarPsicologo();
                direccion.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                colonia.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value);
                telefono.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value);
                sexo.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value);
                dateTimePicker1.Value = DateTime.Parse(Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value));
            }
            catch { }
        }

        private string cargarPsicologo()
        {
            DataTable dt = new DataTable();
            Int64 idPsicologo;
            try { idPsicologo = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString()); }
            catch { idPsicologo = -1; }
            if(idPsicologo>0)
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

        private void botonModificar_Click(object sender, EventArgs e)
        {
            Int64 idModificar;

            if(dataGridView1.SelectedRows.Count!=0)
            {
                idModificar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

                if (nombre.Text != "" && paterno.Text != "" && direccion.Text != "" && colonia.Text != "" && telefono.Text != "" && sexo.Text != "")
                {
                    try
                    {
                        con.Open();
                        string query = "UPDATE Persona.Beneficiario SET nombre='" + nombre.Text + "', paterno='" + paterno.Text + "', materno='" + materno.Text + "', direccion='" + direccion.Text + "', colonia='" + colonia.Text + "', telefono=" + telefono.Text + ", sexo='" + sexo.Text + "', fechaNacimiento='" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "' WHERE idBeneficiario=" + idModificar;
                        adapter.InsertCommand = new SqlCommand(query, con);
                        adapter.InsertCommand.ExecuteNonQuery();
                        con.Close();

                        this.beneficiarioTableAdapter.Fill(this.marillacDataSet.Beneficiario);
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

        private void botonPsicologo_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=0)
            {
                Int64 idPsi;
                try { idPsi = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString()); }
                catch { idPsi = -1; }
                this.beneficiarioPsicologo = new beneficiarioPsicologo(this, connectionString, idPsi);
                this.beneficiarioPsicologo.ShowDialog();
            }
        }
    }
}
