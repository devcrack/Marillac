namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.btt_Beneficiario = new System.Windows.Forms.Button();
            this.btt_Psicologos = new System.Windows.Forms.Button();
            this.btt_Profesores = new System.Windows.Forms.Button();
            this.btt_Actividad = new System.Windows.Forms.Button();
            this.btt_Hijos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btt_Beneficiario
            // 
            this.btt_Beneficiario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Beneficiario.Location = new System.Drawing.Point(369, 23);
            this.btt_Beneficiario.Name = "btt_Beneficiario";
            this.btt_Beneficiario.Size = new System.Drawing.Size(125, 64);
            this.btt_Beneficiario.TabIndex = 0;
            this.btt_Beneficiario.Text = "Beneficiarios";
            this.btt_Beneficiario.UseVisualStyleBackColor = true;
            this.btt_Beneficiario.Click += new System.EventHandler(this.btt_Beneficiario_Click);
            // 
            // btt_Psicologos
            // 
            this.btt_Psicologos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Psicologos.Location = new System.Drawing.Point(39, 23);
            this.btt_Psicologos.Name = "btt_Psicologos";
            this.btt_Psicologos.Size = new System.Drawing.Size(125, 64);
            this.btt_Psicologos.TabIndex = 3;
            this.btt_Psicologos.Text = "Psicologos";
            this.btt_Psicologos.UseVisualStyleBackColor = true;
            this.btt_Psicologos.Click += new System.EventHandler(this.btt_Psicologos_Click);
            // 
            // btt_Profesores
            // 
            this.btt_Profesores.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Profesores.Location = new System.Drawing.Point(706, 23);
            this.btt_Profesores.Name = "btt_Profesores";
            this.btt_Profesores.Size = new System.Drawing.Size(125, 64);
            this.btt_Profesores.TabIndex = 4;
            this.btt_Profesores.Text = "Profesores";
            this.btt_Profesores.UseVisualStyleBackColor = true;
            this.btt_Profesores.Click += new System.EventHandler(this.btt_Profesores_Click);
            // 
            // btt_Actividad
            // 
            this.btt_Actividad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Actividad.Location = new System.Drawing.Point(39, 236);
            this.btt_Actividad.Name = "btt_Actividad";
            this.btt_Actividad.Size = new System.Drawing.Size(125, 64);
            this.btt_Actividad.TabIndex = 5;
            this.btt_Actividad.Text = "Actividad";
            this.btt_Actividad.UseVisualStyleBackColor = true;
            this.btt_Actividad.Click += new System.EventHandler(this.btt_Actividad_Click);
            // 
            // btt_Hijos
            // 
            this.btt_Hijos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Hijos.Location = new System.Drawing.Point(706, 236);
            this.btt_Hijos.Name = "btt_Hijos";
            this.btt_Hijos.Size = new System.Drawing.Size(125, 64);
            this.btt_Hijos.TabIndex = 6;
            this.btt_Hijos.Text = "Niños";
            this.btt_Hijos.UseVisualStyleBackColor = true;
            this.btt_Hijos.Click += new System.EventHandler(this.btt_Hijos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 312);
            this.Controls.Add(this.btt_Hijos);
            this.Controls.Add(this.btt_Actividad);
            this.Controls.Add(this.btt_Profesores);
            this.Controls.Add(this.btt_Psicologos);
            this.Controls.Add(this.btt_Beneficiario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Marillac";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_Beneficiario;
        private System.Windows.Forms.Button btt_Psicologos;
        private System.Windows.Forms.Button btt_Profesores;
        private System.Windows.Forms.Button btt_Actividad;
        private System.Windows.Forms.Button btt_Hijos;
    }
}

