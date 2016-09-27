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

        public F_Pacientes(string conection, int vista, Int64 psico)
        {
            InitializeComponent();
            this.slq_Connect = new C_Connection(conection);
            this.op_Vista = vista;
            this.iD_Psico = psico;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void F_Pacientes_Load(object sender, EventArgs e)
        {
            switch(this.op_Vista)
            {
                case 1:
                    this.show_Vista_Alta();
                    break;
                case 2:
                    this.show_vista_Bajas();
                    break;
            }
          
             int width = this.dataGridView1.Size.Width / 4;
            for (int i = 0; i < 4; i++)
                this.dataGridView1.Columns[i].Width = width;           
        }


        private void show_Vista_Alta()
        {
            string nme_Table_Beneficario = this.slq_Connect.Tables_s.Keys.ElementAt(1);
            string nme_Table_Hijo = this.slq_Connect.Tables_s.Keys.ElementAt(2);
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
        }
        
        private void show_vista_Bajas()
        {
            
             string nme_Table_Beneficario = this.slq_Connect.Tables_s.Keys.ElementAt(1);
            string nme_Table_Hijo = this.slq_Connect.Tables_s.Keys.ElementAt(2);
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
                this.slq_Connect.DML[10] +
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
                this.slq_Connect.DML[10]
                ;
            this.slq_Connect.Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, this.slq_Connect.Con);
            adapter.Fill(nw_DSet);
            this.dataGridView1.DataSource = nw_DSet.Tables[0];
            this.slq_Connect.Con.Close();
            this.btt_Atender.Visible = false;
            this.label1.Text = " Pacientes que son Atendidos";
        }

        private void btt_Atender_Click(object sender, EventArgs e)
        {
            //this.slq_Connect.DML[2] 
        }

        private void btt_Decline_Click(object sender, EventArgs e)
        {
               
        }
    }
}
