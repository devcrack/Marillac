using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_Psicologo : Form
    {
        /// <summary>
        /// Forma Padre
        /// </summary>
        Menu main_Form;
        C_Connection sql;
        F_Pacientes form_Pac;


        public Form_Psicologo(Menu m_Form, string connection_str)
        {
            InitializeComponent();
            this.main_Form = m_Form;
            this.sql = new C_Connection(connection_str);
            //this.Form
        }


        private void Form_Psicologo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }





        private void btt_Alta_Psic_Click(object sender, EventArgs e)
        {
            if (this.check_Values_Controls() == true)
            {
                string query = this.sql.DML[0]
                +
                this.sql.Tables[0, 0]
                +
                this.sql.Tables[1, 0]
                +
                this.sql.DML[1]
                + "('" +
                this.txt_Box_Nom.Text
                + "', '" +
                this.txt_Apellido_Pat.Text
                + "', '" +
                this.txt_Box_Apelli_Mat.Text
                + "', '" +
                this.txt_Box_Dir.Text
                + "', '" +
                this.txt_Box_Col.Text
                + "', " +
                this.txt_Box_Tel.Text
                + ", '" +
                this.txt_Box_Working_Days.Text
                + "', '" +
                this.get_Sexo()
                + "', " +
                this.numericUpDown_Pac_Limit.Value
                + ", '" +
                this.dateTime_Birth_Date.Value.Year
                + "-" +
                this.dateTime_Birth_Date.Value.Month
                + "-" +
                this.dateTime_Birth_Date.Value.Day
                + "')"
                ;
                if (this.sql.execute_Query(query) == true)
                {
                    this.psicologoTableAdapter.Fill(this.marillac_DataSet.Psicologo);
                    this.Reset_Controls();
                }
            }
        }

        private char get_Sexo()
        {
            return (this.radioButt_Male.Checked) ? 'M' : 'F';
        }

        private void Reset_Controls()
        {
            foreach (Control c in this.Controls)
            {
                if (c is GroupBox)
                {
                    foreach (Control c2 in ((GroupBox)c).Controls)
                    {
                        if (c2 is TextBox)
                            ((TextBox)c2).Clear();
                        else if (c2 is RadioButton)
                        {
                            if (((RadioButton)c2).Checked)
                                ((RadioButton)c2).Checked = false;
                        }
                        else if (c2 is NumericUpDown)
                            ((NumericUpDown)c2).Value = 0;
                        else if (c2 is DateTimePicker)
                            ((DateTimePicker)c2).ResetText();
                        else if (c2 is CheckBox)
                            ((CheckBox)c2).Checked = false;
                    }
                }
            }
        }

        private void psicologoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.psicologoBindingSource.EndEdit();
        }

        private void psicologoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.psicologoBindingSource.EndEdit();
        }

        private void psicologoBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.psicologoBindingSource.EndEdit();
        }

        private void Form_Psicologo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marillac_DataSet.Psicologo' table. You can move, or remove it, as needed.
            this.psicologoTableAdapter.Fill(this.marillac_DataSet.Psicologo);
        }

        private void btt_Modificaciones_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Int64 idModificar;
                string name_Table = this.sql.Tables_s.Keys.ElementAt(0);

                idModificar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

                string query =
                    this.sql.DML[2]//UPDATE
                    +
                    name_Table//Tabla Piscologos
                    +
                    this.sql.DML[3] //SET
                    +
                    (this.sql.Tables_s[name_Table])[0]
                    + " = " +
                    "'" + this.txt_Box_Nom.Text + "',"
                    +
                    (this.sql.Tables_s[name_Table])[1]
                    + " = " +
                    "'" + this.txt_Apellido_Pat.Text + "',"
                    +
                    (this.sql.Tables_s[name_Table])[2]
                    + " = " +
                    "'" + this.txt_Box_Apelli_Mat.Text + "',"
                    +
                    (this.sql.Tables_s[name_Table])[3]
                    + " = " +
                    "'" + this.txt_Box_Dir.Text + "',"
                    +
                    (this.sql.Tables_s[name_Table])[4]
                    + " = " +
                    "'" + this.txt_Box_Col.Text + "',"
                    +
                    (this.sql.Tables_s[name_Table])[5]
                    + " = " +
                    "'" + this.txt_Box_Tel.Text + "',"
                    +
                    (this.sql.Tables_s[name_Table])[6]
                    + " = " +
                    "'" + this.txt_Box_Working_Days.Text + "',"
                    +
                    (this.sql.Tables_s[name_Table])[7]
                    + " = " +
                    "'" + this.get_Sexo() + "',"
                    +
                    (this.sql.Tables_s[name_Table])[8]
                    + " = " +
                    "'" + this.numericUpDown_Pac_Limit.Value + "',"
                    +
                    (this.sql.Tables_s[name_Table])[9]
                    + " = " +
                    "'" + this.dateTime_Birth_Date.Value.Year
                    + "-" +
                    this.dateTime_Birth_Date.Value.Month
                     + "-" +
                     this.dateTime_Birth_Date.Value.Day
                     + "'" +
                     this.sql.DML[4]
                     + (this.sql.Tables_s[name_Table])[10]
                     + "=" +
                     idModificar
                     ;
                if (this.sql.execute_Query(query) == true)
                {
                    this.psicologoTableAdapter.Fill(this.marillac_DataSet.Psicologo);
                    this.dataGridView1.ClearSelection();
                    this.Reset_Controls();
                }
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.Reset_Controls();
            try
            {
                this.txt_Box_Nom.Text = Convert.ToString(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value);
                this.txt_Apellido_Pat.Text = Convert.ToString(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value);
                this.txt_Box_Apelli_Mat.Text = Convert.ToString(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                this.txt_Box_Dir.Text = Convert.ToString(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value);
                this.txt_Box_Col.Text = Convert.ToString(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value);
                this.txt_Box_Tel.Text = Convert.ToString(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value);
                this.txt_Box_Working_Days.Text = Convert.ToString(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value);
                this.fill_CheckBoxes();
                this.radio_Button_Change(Convert.ToChar(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value));
                this.numericUpDown_Pac_Limit.Value = Convert.ToInt32(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[9].Value);
                this.dateTime_Birth_Date.Value = DateTime.Parse(Convert.ToString(this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[11].Value));
            }
            catch { }
        }

        private void radio_Button_Change(char c)
        {
            if (c == 'M')
                this.radioButt_Male.Checked = true;
            else
                this.radioButt_Female.Checked = true;
        }


        private void limpiarCamposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Reset_Controls();
        }


        private void darDeAltaPacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int is_limit = Convert.ToInt32(this.numericUpDown_Pac_Limit.Value);
            if ((Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[10].Value.ToString()) + 1) < Convert.ToInt32(this.numericUpDown_Pac_Limit.Value))
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    Int64 idModificar;

                    idModificar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    this.form_Pac = new F_Pacientes(this.sql.Conect_String, 1, idModificar);
                    if (this.form_Pac.ShowDialog() == DialogResult.OK)
                    {
                        this.psicologoTableAdapter.Fill(this.marillac_DataSet.Psicologo);
                    }
                }
                else
                    MessageBox.Show("Seleccione Primero a un Psicologo");
            }
            else
                MessageBox.Show("Se ha excedido el Limite de Pacientes");
        }


        private void darDeBajaPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[10].Value.ToString()) > 0)
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    Int64 idModificar;

                    idModificar = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    this.form_Pac = new F_Pacientes(this.sql.Conect_String, 2, idModificar);
                    if (this.form_Pac.ShowDialog() == DialogResult.OK)
                    {
                        this.psicologoTableAdapter.Fill(this.marillac_DataSet.Psicologo);
                    }
                }
                else
                    MessageBox.Show("Seleccione Primero a un Psicologo");
            }
            else
                MessageBox.Show("No hay pacientes que puedan ser dados de baja");
        }

        private bool check_Values_Controls()
        {

            foreach (Control c in this.Controls)
            {
                if (c is GroupBox)
                {
                    foreach (Control c2 in ((GroupBox)c).Controls)
                    {
                        if (c2 is TextBox)
                            if (string.Compare(((TextBox)c2).Text, string.Empty) == 0)
                            {
                                MessageBox.Show("No debe de haber campos de texto Vacios");
                                return false;
                            }
                            else if (c2 is NumericUpDown)
                            {
                                if (((NumericUpDown)c2).Value == 0)
                                {
                                    MessageBox.Show("Se debe de tener algun limite de Pacientes");
                                    return false;
                                }
                            }
                    }
                }
            }
            if (!this.radioButt_Female.Checked)
            {
                if (!radioButt_Male.Checked)
                {
                    MessageBox.Show("El sexo debe de ser definido");
                    return false;
                }
            }
            return true;
        }

        private void btt_Bajas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string idModificar = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string name_Table = this.sql.Tables_s.Keys.ElementAt(0);
                //UPDATE Persona.Beneficiario SET idPsicologo = NULL where idPsicologo = este_ID
                string tble_Beneficiario = this.sql.Tables_s.Keys.ElementAt(1);
                string tble_Hijo = this.sql.Tables_s.Keys.ElementAt(2);
                string query = this.sql.DML[2] +//UPDATE
                               tble_Beneficiario + //Persona.Beneficiario
                               this.sql.DML[3] + //SET
                               (this.sql.Tables_s[tble_Beneficiario])[1] + " = " //idPsicologo =
                               + " NULL" + this.sql.DML[4] + (this.sql.Tables_s[tble_Beneficiario])[1] + " = " + idModificar;
                this.sql.execute_Query(query);
                query = this.sql.DML[2] +//UPDATE
                               tble_Hijo + //Persona.Beneficiario
                               this.sql.DML[3] + //SET
                               (this.sql.Tables_s[tble_Hijo])[2] + " = " //idPsicologo =
                               + " NULL" + this.sql.DML[4] + (this.sql.Tables_s[tble_Hijo])[2] + " = " + idModificar; ;
                this.sql.execute_Query(query);
                query = this.sql.DML[11] + //DELETE
                               this.sql.DML[6] + //FROM 
                               name_Table + // Persona.Psicologo
                               this.sql.DML[4] + //WHERE
                               (this.sql.Tables_s[name_Table])[10] + " = " +//idPsicologo =
                               idModificar;
                if (this.sql.execute_Query(query) == true)
                {
                    this.psicologoTableAdapter.Fill(this.marillac_DataSet.Psicologo);
                    this.dataGridView1.ClearSelection();
                    this.Reset_Controls();
                }
            }
        }

        private void checkBox_Lunes_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.checkBox_Lunes.Checked, "Lunes");
            this.sort_days();
        }

        private void checkBox_Martes_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.checkBox_Martes.Checked, "Martes");
            this.sort_days();
        }

        private void manage_Days(bool is_check, string str)
        {
            if (is_check)
            {
                if (this.txt_Box_Working_Days.Text.Contains(str) == false)
                    this.txt_Box_Working_Days.Text += str;
            }
            else
            {
                if (this.txt_Box_Working_Days.Text.Contains(str) == true)
                {
                    string str_1 = this.txt_Box_Working_Days.Text;
                    str_1 = str_1.Replace(str, string.Empty);
                    this.txt_Box_Working_Days.Text = str_1;
                }
            }
        }
        private void checkBox_Miercoles_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.checkBox_Miercoles.Checked, "Miercoles");
            this.sort_days();
        }

        private void checkBox_Jueves_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.checkBox_Jueves.Checked, "Jueves");
            this.sort_days();
        }

        private void checkBox_Viernes_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.checkBox_Viernes.Checked, "Viernes");
            this.sort_days();
        }

        private void checkBox_Sabado_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.checkBox_Sabado.Checked, "Sabado");
            this.sort_days();
        }

        private void checkBox_Domingo_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.checkBox_Domingo.Checked, "Domingo");
            this.sort_days();
        }

        public void sort_days()
        {
            string main_String = this.txt_Box_Working_Days.Text;
            string txt_Aux = string.Empty;
            string[] days = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            List<string> days_List = new List<string>();

            foreach (string m_day in days)
            {
                if (main_String.Contains(m_day) == true)
                {
                    days_List.Add(m_day);
                    main_String = main_String.Replace(m_day, string.Empty);
                }
            }
            this.txt_Box_Working_Days.Text = string.Empty;
            foreach (string str in days_List)
            {
                if (string.Compare(this.txt_Box_Working_Days.Text, string.Empty) == 0)
                    this.txt_Box_Working_Days.Text += str;
                else
                    this.txt_Box_Working_Days.Text += "-" + str;
            }
        }

        private void fill_CheckBoxes()
        {
            string[] days = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            for (int index = 0; index < days.Length; index++)
            {
                if (this.txt_Box_Working_Days.Text.Contains(days[index]) == true)
                {
                    switch (index)
                    {
                        case 0:
                            this.checkBox_Lunes.Checked = true;
                            break;
                        case 1:
                            this.checkBox_Martes.Checked = true;
                            break;
                        case 2:
                            this.checkBox_Miercoles.Checked = true;
                            break;
                        case 3:
                            this.checkBox_Jueves.Checked = true;
                            break;
                        case 4:
                            this.checkBox_Viernes.Checked = true;
                            break;
                        case 5:
                            this.checkBox_Sabado.Checked = true;
                            break;
                        case 6:
                            this.checkBox_Domingo.Checked = true;
                            break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

