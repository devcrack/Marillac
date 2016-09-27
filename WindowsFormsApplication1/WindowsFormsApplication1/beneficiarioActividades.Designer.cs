namespace WindowsFormsApplication1
{
    partial class beneficiarioActividades
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.profesor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.final = new System.Windows.Forms.TextBox();
            this.inicio = new System.Windows.Forms.TextBox();
            this.dias = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillacDataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.actividadTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.ActividadTableAdapter();
            this.idActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProfesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasImparteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscritosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(272, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 66);
            this.label9.TabIndex = 11;
            this.label9.Text = "Actividades";
            // 
            // profesor
            // 
            this.profesor.Font = new System.Drawing.Font("Calibri", 14F);
            this.profesor.Location = new System.Drawing.Point(114, 171);
            this.profesor.Margin = new System.Windows.Forms.Padding(2);
            this.profesor.Name = "profesor";
            this.profesor.ReadOnly = true;
            this.profesor.Size = new System.Drawing.Size(266, 30);
            this.profesor.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(11, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "Profesor: ";
            // 
            // costo
            // 
            this.costo.Font = new System.Drawing.Font("Calibri", 14F);
            this.costo.Location = new System.Drawing.Point(114, 239);
            this.costo.Margin = new System.Windows.Forms.Padding(2);
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Size = new System.Drawing.Size(87, 30);
            this.costo.TabIndex = 47;
            // 
            // final
            // 
            this.final.Font = new System.Drawing.Font("Calibri", 14F);
            this.final.Location = new System.Drawing.Point(283, 205);
            this.final.Margin = new System.Windows.Forms.Padding(2);
            this.final.Name = "final";
            this.final.ReadOnly = true;
            this.final.Size = new System.Drawing.Size(97, 30);
            this.final.TabIndex = 46;
            // 
            // inicio
            // 
            this.inicio.Font = new System.Drawing.Font("Calibri", 14F);
            this.inicio.Location = new System.Drawing.Point(161, 205);
            this.inicio.Margin = new System.Windows.Forms.Padding(2);
            this.inicio.Name = "inicio";
            this.inicio.ReadOnly = true;
            this.inicio.Size = new System.Drawing.Size(97, 30);
            this.inicio.TabIndex = 45;
            // 
            // dias
            // 
            this.dias.Font = new System.Drawing.Font("Calibri", 14F);
            this.dias.Location = new System.Drawing.Point(114, 134);
            this.dias.Margin = new System.Windows.Forms.Padding(2);
            this.dias.Name = "dias";
            this.dias.ReadOnly = true;
            this.dias.Size = new System.Drawing.Size(266, 30);
            this.dias.TabIndex = 44;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombre.Location = new System.Drawing.Point(114, 100);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(266, 30);
            this.nombre.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(11, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Costo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(11, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Hora Inicio/Final: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(11, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Días: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(11, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(263, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "-";
            // 
            // saldo
            // 
            this.saldo.Font = new System.Drawing.Font("Calibri", 14F);
            this.saldo.Location = new System.Drawing.Point(114, 273);
            this.saldo.Margin = new System.Windows.Forms.Padding(2);
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Size = new System.Drawing.Size(87, 30);
            this.saldo.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(11, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Saldo: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActividadDataGridViewTextBoxColumn,
            this.idProfesorDataGridViewTextBoxColumn,
            this.nombreActividadDataGridViewTextBoxColumn,
            this.diasImparteDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaFinalDataGridViewTextBoxColumn,
            this.cupoDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.inscritosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.actividadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(410, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(422, 203);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataMember = "Actividad";
            this.actividadBindingSource.DataSource = this.marillacDataSet;
            // 
            // marillacDataSet
            // 
            this.marillacDataSet.DataSetName = "MarillacDataSet";
            this.marillacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actividadTableAdapter
            // 
            this.actividadTableAdapter.ClearBeforeFill = true;
            // 
            // idActividadDataGridViewTextBoxColumn
            // 
            this.idActividadDataGridViewTextBoxColumn.DataPropertyName = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.HeaderText = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.Name = "idActividadDataGridViewTextBoxColumn";
            this.idActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idActividadDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProfesorDataGridViewTextBoxColumn
            // 
            this.idProfesorDataGridViewTextBoxColumn.DataPropertyName = "idProfesor";
            this.idProfesorDataGridViewTextBoxColumn.HeaderText = "idProfesor";
            this.idProfesorDataGridViewTextBoxColumn.Name = "idProfesorDataGridViewTextBoxColumn";
            this.idProfesorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProfesorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "nombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "Nombre ";
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            this.nombreActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreActividadDataGridViewTextBoxColumn.Width = 150;
            // 
            // diasImparteDataGridViewTextBoxColumn
            // 
            this.diasImparteDataGridViewTextBoxColumn.DataPropertyName = "diasImparte";
            this.diasImparteDataGridViewTextBoxColumn.HeaderText = "Días de clase ";
            this.diasImparteDataGridViewTextBoxColumn.Name = "diasImparteDataGridViewTextBoxColumn";
            this.diasImparteDataGridViewTextBoxColumn.ReadOnly = true;
            this.diasImparteDataGridViewTextBoxColumn.Width = 250;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "horaInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "Hora inicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaFinalDataGridViewTextBoxColumn
            // 
            this.horaFinalDataGridViewTextBoxColumn.DataPropertyName = "horaFinal";
            this.horaFinalDataGridViewTextBoxColumn.HeaderText = "Hora final";
            this.horaFinalDataGridViewTextBoxColumn.Name = "horaFinalDataGridViewTextBoxColumn";
            this.horaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoDataGridViewTextBoxColumn
            // 
            this.cupoDataGridViewTextBoxColumn.DataPropertyName = "cupo";
            this.cupoDataGridViewTextBoxColumn.HeaderText = "cupo";
            this.cupoDataGridViewTextBoxColumn.Name = "cupoDataGridViewTextBoxColumn";
            this.cupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cupoDataGridViewTextBoxColumn.Visible = false;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoDataGridViewTextBoxColumn.Width = 80;
            // 
            // inscritosDataGridViewTextBoxColumn
            // 
            this.inscritosDataGridViewTextBoxColumn.DataPropertyName = "inscritos";
            this.inscritosDataGridViewTextBoxColumn.HeaderText = "inscritos";
            this.inscritosDataGridViewTextBoxColumn.Name = "inscritosDataGridViewTextBoxColumn";
            this.inscritosDataGridViewTextBoxColumn.ReadOnly = true;
            this.inscritosDataGridViewTextBoxColumn.Visible = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(283, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 54;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // beneficiarioActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(852, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.profesor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.final);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.dias);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "beneficiarioActividades";
            this.ShowIcon = false;
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.beneficiarioActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox profesor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.TextBox final;
        private System.Windows.Forms.TextBox inicio;
        private System.Windows.Forms.TextBox dias;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox saldo;
        private System.Windows.Forms.Label label4;
        private MarillacDataSet marillacDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private MarillacDataSetTableAdapters.ActividadTableAdapter actividadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasImparteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscritosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}