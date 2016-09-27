namespace WindowsFormsApplication1
{
    partial class Form_Actividades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProfesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasImparteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscritosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillacDataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.nombreActividad = new System.Windows.Forms.TextBox();
            this.diasImpartida = new System.Windows.Forms.TextBox();
            this.horaInicio = new System.Windows.Forms.TextBox();
            this.horaFinal = new System.Windows.Forms.TextBox();
            this.cupo = new System.Windows.Forms.TextBox();
            this.costo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.idProfesor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.claveActividadToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.claveActividadToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.actividadTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.ActividadTableAdapter();
            this.beneficiarioTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.BeneficiarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(483, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 66);
            this.label9.TabIndex = 10;
            this.label9.Text = "Actividades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de la Actividad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(14, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "D�as que se imparte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(14, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hora Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(14, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hora Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(14, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cupo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(14, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Costo:";
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(482, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 226);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged_1);
            // 
            // idActividadDataGridViewTextBoxColumn
            // 
            this.idActividadDataGridViewTextBoxColumn.DataPropertyName = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.HeaderText = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.Name = "idActividadDataGridViewTextBoxColumn";
            this.idActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProfesorDataGridViewTextBoxColumn
            // 
            this.idProfesorDataGridViewTextBoxColumn.DataPropertyName = "idProfesor";
            this.idProfesorDataGridViewTextBoxColumn.HeaderText = "idProfesor";
            this.idProfesorDataGridViewTextBoxColumn.Name = "idProfesorDataGridViewTextBoxColumn";
            this.idProfesorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "nombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "nombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            this.nombreActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasImparteDataGridViewTextBoxColumn
            // 
            this.diasImparteDataGridViewTextBoxColumn.DataPropertyName = "diasImparte";
            this.diasImparteDataGridViewTextBoxColumn.HeaderText = "diasImparte";
            this.diasImparteDataGridViewTextBoxColumn.Name = "diasImparteDataGridViewTextBoxColumn";
            this.diasImparteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "horaInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "horaInicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaFinalDataGridViewTextBoxColumn
            // 
            this.horaFinalDataGridViewTextBoxColumn.DataPropertyName = "horaFinal";
            this.horaFinalDataGridViewTextBoxColumn.HeaderText = "horaFinal";
            this.horaFinalDataGridViewTextBoxColumn.Name = "horaFinalDataGridViewTextBoxColumn";
            this.horaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoDataGridViewTextBoxColumn
            // 
            this.cupoDataGridViewTextBoxColumn.DataPropertyName = "cupo";
            this.cupoDataGridViewTextBoxColumn.HeaderText = "cupo";
            this.cupoDataGridViewTextBoxColumn.Name = "cupoDataGridViewTextBoxColumn";
            this.cupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscritosDataGridViewTextBoxColumn
            // 
            this.inscritosDataGridViewTextBoxColumn.DataPropertyName = "inscritos";
            this.inscritosDataGridViewTextBoxColumn.HeaderText = "inscritos";
            this.inscritosDataGridViewTextBoxColumn.Name = "inscritosDataGridViewTextBoxColumn";
            this.inscritosDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nombreActividad
            // 
            this.nombreActividad.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombreActividad.Location = new System.Drawing.Point(207, 100);
            this.nombreActividad.Margin = new System.Windows.Forms.Padding(2);
            this.nombreActividad.Name = "nombreActividad";
            this.nombreActividad.Size = new System.Drawing.Size(266, 30);
            this.nombreActividad.TabIndex = 26;
            // 
            // diasImpartida
            // 
            this.diasImpartida.Font = new System.Drawing.Font("Calibri", 14F);
            this.diasImpartida.Location = new System.Drawing.Point(207, 150);
            this.diasImpartida.Margin = new System.Windows.Forms.Padding(2);
            this.diasImpartida.Name = "diasImpartida";
            this.diasImpartida.Size = new System.Drawing.Size(266, 30);
            this.diasImpartida.TabIndex = 27;
            // 
            // horaInicio
            // 
            this.horaInicio.Font = new System.Drawing.Font("Calibri", 14F);
            this.horaInicio.Location = new System.Drawing.Point(207, 200);
            this.horaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.horaInicio.Name = "horaInicio";
            this.horaInicio.Size = new System.Drawing.Size(87, 30);
            this.horaInicio.TabIndex = 28;
            // 
            // horaFinal
            // 
            this.horaFinal.Font = new System.Drawing.Font("Calibri", 14F);
            this.horaFinal.Location = new System.Drawing.Point(207, 250);
            this.horaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.horaFinal.Name = "horaFinal";
            this.horaFinal.Size = new System.Drawing.Size(87, 30);
            this.horaFinal.TabIndex = 29;
            // 
            // cupo
            // 
            this.cupo.Font = new System.Drawing.Font("Calibri", 14F);
            this.cupo.Location = new System.Drawing.Point(207, 300);
            this.cupo.Margin = new System.Windows.Forms.Padding(2);
            this.cupo.Name = "cupo";
            this.cupo.Size = new System.Drawing.Size(87, 30);
            this.cupo.TabIndex = 30;
            // 
            // costo
            // 
            this.costo.Font = new System.Drawing.Font("Calibri", 14F);
            this.costo.Location = new System.Drawing.Point(207, 350);
            this.costo.Margin = new System.Windows.Forms.Padding(2);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(87, 30);
            this.costo.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 34;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 42);
            this.button2.TabIndex = 35;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 487);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 42);
            this.button3.TabIndex = 36;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(358, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 42);
            this.button4.TabIndex = 37;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(14, 403);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 37;
            this.label8.Text = "ID Profesor:";
            // 
            // idProfesor
            // 
            this.idProfesor.Font = new System.Drawing.Font("Calibri", 14F);
            this.idProfesor.Location = new System.Drawing.Point(207, 400);
            this.idProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.idProfesor.Name = "idProfesor";
            this.idProfesor.Size = new System.Drawing.Size(87, 30);
            this.idProfesor.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(474, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Beneficiarios Inscritos";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.paternoDataGridViewTextBoxColumn,
            this.maternoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.beneficiarioBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(666, 353);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(544, 103);
            this.dataGridView2.TabIndex = 41;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paternoDataGridViewTextBoxColumn
            // 
            this.paternoDataGridViewTextBoxColumn.DataPropertyName = "paterno";
            this.paternoDataGridViewTextBoxColumn.HeaderText = "paterno";
            this.paternoDataGridViewTextBoxColumn.Name = "paternoDataGridViewTextBoxColumn";
            this.paternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maternoDataGridViewTextBoxColumn
            // 
            this.maternoDataGridViewTextBoxColumn.DataPropertyName = "materno";
            this.maternoDataGridViewTextBoxColumn.HeaderText = "materno";
            this.maternoDataGridViewTextBoxColumn.Name = "maternoDataGridViewTextBoxColumn";
            this.maternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beneficiarioBindingSource
            // 
            this.beneficiarioBindingSource.DataMember = "Beneficiario";
            this.beneficiarioBindingSource.DataSource = this.marillacDataSet;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.claveActividadToolStripLabel,
            this.claveActividadToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1230, 25);
            this.fillByToolStrip.TabIndex = 42;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // claveActividadToolStripLabel
            // 
            this.claveActividadToolStripLabel.Name = "claveActividadToolStripLabel";
            this.claveActividadToolStripLabel.Size = new System.Drawing.Size(87, 22);
            this.claveActividadToolStripLabel.Text = "claveActividad:";
            // 
            // claveActividadToolStripTextBox
            // 
            this.claveActividadToolStripTextBox.Name = "claveActividadToolStripTextBox";
            this.claveActividadToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // actividadTableAdapter
            // 
            this.actividadTableAdapter.ClearBeforeFill = true;
            // 
            // beneficiarioTableAdapter
            // 
            this.beneficiarioTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 567);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idProfesor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.cupo);
            this.Controls.Add(this.horaFinal);
            this.Controls.Add(this.horaInicio);
            this.Controls.Add(this.diasImpartida);
            this.Controls.Add(this.nombreActividad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Actividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Actividades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Actividades_FormClosing);
            this.Load += new System.EventHandler(this.Form_Actividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombreActividad;
        private System.Windows.Forms.TextBox diasImpartida;
        private System.Windows.Forms.TextBox horaInicio;
        private System.Windows.Forms.TextBox horaFinal;
        private System.Windows.Forms.TextBox cupo;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MarillacDataSet marillacDataSet;
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
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private MarillacDataSetTableAdapters.BeneficiarioTableAdapter beneficiarioTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel claveActividadToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox claveActividadToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
    }
}