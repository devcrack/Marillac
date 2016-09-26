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
    public partial class Form_Actividades : Form
    {
        Menu main_Form; 

        public Form_Actividades(Menu m_Form)
        {
            InitializeComponent();
            this.main_Form = m_Form;
        }

        private void Form_Actividades_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }
    }
}
