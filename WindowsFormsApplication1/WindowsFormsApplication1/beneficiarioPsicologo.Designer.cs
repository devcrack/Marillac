namespace WindowsFormsApplication1
{
    partial class beneficiarioPsicologo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.paterno = new System.Windows.Forms.Label();
            this.materno = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.nombreImprimir = new System.Windows.Forms.Label();
            this.paternoImprimir = new System.Windows.Forms.Label();
            this.maternoImprimir = new System.Windows.Forms.Label();
            this.telefonoImprimir = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Psicólogo";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombre.Location = new System.Drawing.Point(41, 94);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(82, 23);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre: ";
            // 
            // paterno
            // 
            this.paterno.AutoSize = true;
            this.paterno.Font = new System.Drawing.Font("Calibri", 14F);
            this.paterno.Location = new System.Drawing.Point(41, 126);
            this.paterno.Name = "paterno";
            this.paterno.Size = new System.Drawing.Size(146, 23);
            this.paterno.TabIndex = 2;
            this.paterno.Text = "Apellido paterno: ";
            // 
            // materno
            // 
            this.materno.AutoSize = true;
            this.materno.Font = new System.Drawing.Font("Calibri", 14F);
            this.materno.Location = new System.Drawing.Point(41, 158);
            this.materno.Name = "materno";
            this.materno.Size = new System.Drawing.Size(151, 23);
            this.materno.TabIndex = 3;
            this.materno.Text = "Apellido materno: ";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Font = new System.Drawing.Font("Calibri", 14F);
            this.telefono.Location = new System.Drawing.Point(41, 191);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(80, 23);
            this.telefono.TabIndex = 4;
            this.telefono.Text = "Teléfono:";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Calibri", 14F);
            this.error.Location = new System.Drawing.Point(41, 135);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(350, 23);
            this.error.TabIndex = 5;
            this.error.Text = "Esta persona no tiene un psicólogo asignado";
            // 
            // nombreImprimir
            // 
            this.nombreImprimir.AutoSize = true;
            this.nombreImprimir.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombreImprimir.Location = new System.Drawing.Point(129, 94);
            this.nombreImprimir.Name = "nombreImprimir";
            this.nombreImprimir.Size = new System.Drawing.Size(150, 23);
            this.nombreImprimir.TabIndex = 6;
            this.nombreImprimir.Text = "Nombre psicologo";
            // 
            // paternoImprimir
            // 
            this.paternoImprimir.AutoSize = true;
            this.paternoImprimir.Font = new System.Drawing.Font("Calibri", 14F);
            this.paternoImprimir.Location = new System.Drawing.Point(193, 126);
            this.paternoImprimir.Name = "paternoImprimir";
            this.paternoImprimir.Size = new System.Drawing.Size(214, 23);
            this.paternoImprimir.TabIndex = 7;
            this.paternoImprimir.Text = "Apellido paterno psicologo";
            // 
            // maternoImprimir
            // 
            this.maternoImprimir.AutoSize = true;
            this.maternoImprimir.Font = new System.Drawing.Font("Calibri", 14F);
            this.maternoImprimir.Location = new System.Drawing.Point(198, 158);
            this.maternoImprimir.Name = "maternoImprimir";
            this.maternoImprimir.Size = new System.Drawing.Size(219, 23);
            this.maternoImprimir.TabIndex = 8;
            this.maternoImprimir.Text = "Apellido materno psicologo";
            // 
            // telefonoImprimir
            // 
            this.telefonoImprimir.AutoSize = true;
            this.telefonoImprimir.Font = new System.Drawing.Font("Calibri", 14F);
            this.telefonoImprimir.Location = new System.Drawing.Point(127, 191);
            this.telefonoImprimir.Name = "telefonoImprimir";
            this.telefonoImprimir.Size = new System.Drawing.Size(100, 23);
            this.telefonoImprimir.TabIndex = 9;
            this.telefonoImprimir.Text = "111111111";
            // 
            // botonSalir
            // 
            this.botonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.Location = new System.Drawing.Point(161, 256);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(92, 27);
            this.botonSalir.TabIndex = 10;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // beneficiarioPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.botonSalir;
            this.ClientSize = new System.Drawing.Size(437, 300);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.telefonoImprimir);
            this.Controls.Add(this.maternoImprimir);
            this.Controls.Add(this.paternoImprimir);
            this.Controls.Add(this.nombreImprimir);
            this.Controls.Add(this.error);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.materno);
            this.Controls.Add(this.paterno);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "beneficiarioPsicologo";
            this.ShowIcon = false;
            this.Text = "Psicólogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label paterno;
        private System.Windows.Forms.Label materno;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label nombreImprimir;
        private System.Windows.Forms.Label paternoImprimir;
        private System.Windows.Forms.Label maternoImprimir;
        private System.Windows.Forms.Label telefonoImprimir;
        private System.Windows.Forms.Button botonSalir;
    }
}