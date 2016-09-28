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
    public partial class F_Pacientes : Form
    {
        C_Connection slq_Connect;
        DataTable dt = new DataTable();
        DataSet nw_DSet = new DataSet();
        private int op_Vista; 
        private Int64 iD_Psico;
        private string nme_Table_Hijo;
        private string nme_Table_Beneficario;
        private bool is_Happend;
        public F_Pacientes(string conection, int vista, Int64 psico)
        {
            InitializeComponent();
            this.slq_Connect = new C_Connection(conection);
            this.op_Vista = vista;
            this.iD_Psico = psico;
            this.is_Happend = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void F_Pacientes_Load(object sender, EventArgs e)
        {
            nme_Table_Beneficario = this.slq_Connect.Tables_s.Keys.ElementAt(1);
            nme_Table_Hijo = this.slq_Connect.Tables_s.Keys.ElementAt(2);            

            switch (this.op_Vista)
            {
                case 1:
                    this.show_Vista_Alta();
                    break;
                case 2:
                    this.show_vista_Bajas();
                    break;
            }
            if (this.DialogResult == DialogResult.None) {
                int width = this.dataGridView1.Size.Width / 5;
                for (int i = 0; i < 5; i++)
                {
                    this.dataGridView1.Columns[i].Width = width;
                }
            }
        }


/// <summary>
/// @ 
/// </summary>
        private void show_Vista_Alta()
        {
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand();
            int cont_Beneficiarios = 0;
            int cont_Hijos = 0;

            string query = this.slq_Connect.DML[5]
                +
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[0] + " AS Clave," +//Id_Beneficiario
                this.slq_Connect.DML[9] + "("+
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[2] + "," +//Nombre
                " " +
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[3] + "," +//ApellidoP
                " " +
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[4] + //ApellidoM
                ") AS Nombre, "+
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[8]+ "," +
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[10] +
                this.slq_Connect.DML[6] + //FROM 
                nme_Table_Beneficario +
                this.slq_Connect.DML[4] +
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[1] +
                this.slq_Connect.DML[7] +
                this.slq_Connect.DML[8] +
                this.slq_Connect.DML[5] +
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[0] + "AS Clave," +//Id Hijo
                this.slq_Connect.DML[9] + "("+
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[3] + "," +
                " " +
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[4] + "," +
                " " +
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[5] +
                ") AS Nombre, " +
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[6] + "," +
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[8] +
                this.slq_Connect.DML[6] +
                nme_Table_Hijo +
                this.slq_Connect.DML[4] +
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[2] +//IdPsicologo
                this.slq_Connect.DML[7]
                ;
            this.slq_Connect.Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, this.slq_Connect.Con);
            adapter.Fill(nw_DSet);
            this.dataGridView1.DataSource = nw_DSet.Tables[0];
            this.slq_Connect.Con.Close();
            this.btt_Decline.Visible = false;
            if (this.dataGridView1.Columns.Count < 5) {
                this.dataGridView1.Columns.Add("tabla", "Ambito");
            }
            cmd.CommandType = CommandType.Text;
            query = this.slq_Connect.DML[5] + "COUNT(*) " + 
                    this.slq_Connect.DML[6] + this.nme_Table_Beneficario +
                    this.slq_Connect.DML[4] +    //WHERE
                    this.nme_Table_Beneficario + "." +(this.slq_Connect.Tables_s[this.nme_Table_Beneficario])[1] + //Persona.Beneficiario.idPsicologo
                    this.slq_Connect.DML[7]//IS NULL
                    ;
            cmd.CommandText = query;
            cmd.Connection = this.slq_Connect.Con;
            this.slq_Connect.Con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            cont_Beneficiarios = (int)dr[0];
            this.slq_Connect.Con.Close();
            for (int i = 0; i < cont_Beneficiarios; i++)  {
                this.dataGridView1.Rows[i].Cells[4].Value = nme_Table_Beneficario.Substring(nme_Table_Beneficario.IndexOf('.'));
            }
            query = this.slq_Connect.DML[5] + "COUNT(*) " + 
                    this.slq_Connect.DML[6] + this.nme_Table_Hijo + //FROM Persona.Hijo
                    this.slq_Connect.DML[4] + //WHERE
                    this.nme_Table_Hijo + "." + (this.slq_Connect.Tables_s[this.nme_Table_Hijo])[2] +  //Persona.Hijo.iPsicologo
                    this.slq_Connect.DML[7]; //IS NULL
            cmd.CommandText = query;
            cmd.Connection = this.slq_Connect.Con;
            this.slq_Connect.Con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            cont_Hijos = (int)dr[0];
            this.slq_Connect.Con.Close();
            for (int i = cont_Beneficiarios; i < (cont_Beneficiarios + cont_Hijos); i++)  {
                this.dataGridView1.Rows[i].Cells[4].Value = nme_Table_Hijo.Substring(nme_Table_Hijo.IndexOf('.'));
            }
            if (cont_Beneficiarios == 0 && cont_Hijos == 0 ) {
                MessageBox.Show("No hay mas Pacientes para dar de Alta");
                if (is_Happend) {
                    this.DialogResult = DialogResult.OK;                    
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }
        

        /// <summary>
        /// Bajas :p
        /// </summary>
        private void show_vista_Bajas()
        {
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand();
            int cont_Beneficiarios = 0;
            int cont_Hijos = 0;

            string query = this.slq_Connect.DML[5]
                +
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[0] + " AS Clave," +//Id_Beneficiario
                this.slq_Connect.DML[9] + "("+//CONCAT(
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[2] + "," +//Nombre
                " " +
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[3] + "," +//ApellidoP
                " " +
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[4] + //ApellidoM
                ") AS Nombre, "+
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[8]+ "," +//Sexo
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[10] + //Edad
                this.slq_Connect.DML[6] + //FROM 
                nme_Table_Beneficario +//TABLA BENEFICIARIO
                this.slq_Connect.DML[4] +//WHERE
                (this.slq_Connect.Tables_s[nme_Table_Beneficario])[1] + "=" + //Persona.Beneficiario.IDPSICOLOGO = 
                this.iD_Psico.ToString() +//ID_ESTE_PSICOLOGO
                this.slq_Connect.DML[8] +//UNION ALL
                this.slq_Connect.DML[5] +//SELECT
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[0] + "AS Clave," +//Id Hijo
                this.slq_Connect.DML[9] + "("+ //CONCAT
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[3] + "," +//nombre
                " " +
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[4] + "," +//App
                " " +
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[5] +//Apm
                ") AS Nombre, " +
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[6] + "," +//Sexo
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[8] +//Edad
                this.slq_Connect.DML[6] + //FROM 
                nme_Table_Hijo +//TABLA HIJOS
                this.slq_Connect.DML[4] + //WHERE
                (this.slq_Connect.Tables_s[nme_Table_Hijo])[2] + "=" +//IdPsicologo =
                this.iD_Psico.ToString()  //ID_este_Psicologo
                ;
            this.slq_Connect.Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, this.slq_Connect.Con);
            adapter.Fill(nw_DSet);
            this.dataGridView1.DataSource = nw_DSet.Tables[0];
            this.slq_Connect.Con.Close();
            this.btt_Atender.Visible = false;
            this.label1.Text = " Pacientes que son Atendidos";

            cmd.CommandType = CommandType.Text;
            query = this.slq_Connect.DML[5] + "COUNT(*) " + //SELECT COUNT 
                    this.slq_Connect.DML[6] + this.nme_Table_Beneficario + //FROM Personas.Beneficiarios
                    this.slq_Connect.DML[4] + //WHERE 
                    this.nme_Table_Beneficario + "." + (this.slq_Connect.Tables_s[this.nme_Table_Beneficario])[1] + "=" +
                    this.iD_Psico.ToString();//ID_este_Psicologo
            cmd.CommandText = query;
            cmd.Connection = this.slq_Connect.Con;
            this.slq_Connect.Con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            cont_Beneficiarios = (int)dr[0];
            this.slq_Connect.Con.Close();
            if (this.dataGridView1.Columns.Count < 5)  {
                this.dataGridView1.Columns.Add("tabla", "Ambito");
            }
            for (int i = 0; i < cont_Beneficiarios; i++) {
                this.dataGridView1.Rows[i].Cells[4].Value = nme_Table_Beneficario.Substring(nme_Table_Beneficario.IndexOf('.'));
            }


            query = this.slq_Connect.DML[5] + "COUNT(*) " + //SELECT COUNT
                    this.slq_Connect.DML[6] + this.nme_Table_Hijo + //FROM Personas.Hijos
                    this.slq_Connect.DML[4] + //WHERE 
                    this.nme_Table_Hijo + "." + (this.slq_Connect.Tables_s[this.nme_Table_Hijo])[2] + "=" +//Personas.Hijo.IDPSICOLOGO
                    this.iD_Psico.ToString();

            cmd.CommandText = query;
            cmd.Connection = this.slq_Connect.Con;
            this.slq_Connect.Con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            cont_Hijos = (int)dr[0];
            this.slq_Connect.Con.Close();
            for (int i = cont_Beneficiarios; i < (cont_Beneficiarios + cont_Hijos); i++) {
                this.dataGridView1.Rows[i].Cells[4].Value = nme_Table_Hijo.Substring(nme_Table_Hijo.IndexOf('.'));
            }
            if (cont_Hijos == 0 && cont_Beneficiarios == 0 ) {
                MessageBox.Show("No hay mas Pacientes que Dar de Baja");
                if (is_Happend)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }

        }

        private void btt_Atender_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                this.is_Happend = true;
                this.update_Pscologhyst(false, dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                this.show_Vista_Alta();                
            }
        }

        private void btt_Decline_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                this.is_Happend = true;
                this.update_Pscologhyst(true, dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                this.show_vista_Bajas();                
            }
        }

        private void update_Pscologhyst(bool is_NUll, string id_Pac)
        {
            string val = (!is_NUll) ? this.iD_Psico.ToString() : "NULL";
            string query = this.slq_Connect.DML[2];//UPDATE
            string who_table = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();

            if (who_table == ".Beneficiario")
            {
                query += //UPDATE
                        this.nme_Table_Beneficario +//Personas.BENEFICIARIOS
                        this.slq_Connect.DML[3] + //SET
                        (this.slq_Connect.Tables_s[this.nme_Table_Beneficario])[1] + " = " + //idPsicologo = ID_este_PSICOLOGO
                        val + this.slq_Connect.DML[4] +
                        (this.slq_Connect.Tables_s[this.nme_Table_Beneficario])[0] + " = " +
                        id_Pac;
            }
            else
            {
                query +=//UDPATE
                        this.nme_Table_Hijo +//Personas.Hijo
                        this.slq_Connect.DML[3] + //SET
                        (this.slq_Connect.Tables_s[this.nme_Table_Hijo])[2] + " = " + //idPsicologo = ID_este_PSICOLOGO
                        val + this.slq_Connect.DML[4] +
                        (this.slq_Connect.Tables_s[this.nme_Table_Hijo])[0] + "=" +
                        id_Pac;
            }
            this.slq_Connect.execute_Query(query);
            //this.dataGridView1.DataSource = null;
            for (int i = this.dataGridView1.Rows.Count - 1; i > -1; i--) {
                this.dataGridView1.Rows.RemoveAt(i);
            }
            //this.dataGridView1.Refresh();
        }

        private void F_Pacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None && !is_Happend) {
                this.DialogResult = DialogResult.Cancel;
            }
            if(is_Happend)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btt_Cancelar_Click(object sender, EventArgs e)
        {
            if (is_Happend)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
