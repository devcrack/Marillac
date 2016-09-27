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
        }
    }
}
