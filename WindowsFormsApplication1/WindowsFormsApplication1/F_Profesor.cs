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
    public partial class F_Profesor : Form
    {
        Form main_Form;
        public F_Profesor(Menu m_form)
        {
            InitializeComponent();
            this.main_Form = m_form;
        }

        private void F_Profesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.main_Form.Show();
        }
    }
}
