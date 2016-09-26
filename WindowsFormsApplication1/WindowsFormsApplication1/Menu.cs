using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace WindowsFormsApplication1
{
    /**
     * VALDES
       connectionString="Data Source=MAUVALDES\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True"
     *Yeyo
      connectionString="Data Source=DEVCRACK-PC\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True"
        */

    public partial class Menu : Form
    {
        F_Beneficiario form_Benificiario;
        F_Profesor form_Profesor;
        Formulario_Hijo form_hijos;
        Form_Actividades form_Actividades;
        Form_Psicologo form_Psicologo;
        string cadenaConexion;

        public Menu()
        {
            InitializeComponent();
            cadenaConexion = @"Data Source=MAUVALDES\SQLEXPRESS;Initial Catalog=Marillac;Integrated Security=True";
        }

        private void btt_Beneficiario_Click(object sender, EventArgs e)
        {
            this.form_Benificiario = new F_Beneficiario(this, cadenaConexion);
            this.Hide();
            this.form_Benificiario.Show();
        }

        private void btt_Psicologos_Click(object sender, EventArgs e)
        {
            this.form_Psicologo = new Form_Psicologo(this, cadenaConexion);
            this.Hide();
            this.form_Psicologo.Show();
        }

        private void btt_Profesores_Click(object sender, EventArgs e)
        {
            this.form_Profesor = new F_Profesor(this);
            this.Hide();
            this.form_Profesor.Show();
        }

        private void btt_Hijos_Click(object sender, EventArgs e)
        {
            this.form_hijos = new Formulario_Hijo(this);
            this.Hide();
            this.form_hijos.Show();
        }

        private void btt_Actividad_Click(object sender, EventArgs e)
        {
            this.form_Actividades = new Form_Actividades(this);
            this.Hide();
            this.form_Actividades.Show();
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            Bitmap image = new Bitmap(WindowsFormsApplication1.Properties.Resources.logoMarillac);
            Graphics g = e.Graphics;
            g.DrawImage(image, new Point((this.Width / 2) - 190, (this.Height/2)-30));
        }
    }
}
