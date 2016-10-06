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
    public partial class muestraProfesor_Actividades : Form
    {

        public Int64 valor;
        public string nombre;

        public muestraProfesor_Actividades(Int64 id22)
        {
            InitializeComponent();
        }

        private void muestraProfesor_Actividades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marillacDataSet.Profesor' table. You can move, or remove it, as needed.
            this.profesorTableAdapter.Fill(this.marillacDataSet.Profesor);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Int64 extra;
            string str = "";
            extra = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            str += Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString());
            str += " ";
            str += Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString());
            str += " ";
            str += Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString());
            valor = extra;
            nombre = str;
        }

        public Int64 regresa()
        {
            return valor;
        }

        public string regresa2()
        {
            return nombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 extra;
            extra = Convert.ToInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //regresa(extra);
            this.Close();
        }
    }
}
