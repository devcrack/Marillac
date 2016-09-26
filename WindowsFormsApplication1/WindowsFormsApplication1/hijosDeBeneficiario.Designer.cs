namespace WindowsFormsApplication1
{
    partial class hijosDeBeneficiario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idHijoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPsicologoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillacDataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.psicologo = new System.Windows.Forms.TextBox();
            this.paterno = new System.Windows.Forms.TextBox();
            this.materno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sexo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hijoTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.HijoTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.idBenToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idBenToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hijoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 66);
            this.label9.TabIndex = 10;
            this.label9.Text = "Hijos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHijoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.paternoDataGridViewTextBoxColumn,
            this.maternoDataGridViewTextBoxColumn,
            this.idPsicologoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hijoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(479, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 279);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idHijoDataGridViewTextBoxColumn
            // 
            this.idHijoDataGridViewTextBoxColumn.DataPropertyName = "idHijo";
            this.idHijoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idHijoDataGridViewTextBoxColumn.Name = "idHijoDataGridViewTextBoxColumn";
            this.idHijoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHijoDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // paternoDataGridViewTextBoxColumn
            // 
            this.paternoDataGridViewTextBoxColumn.DataPropertyName = "paterno";
            this.paternoDataGridViewTextBoxColumn.HeaderText = "Apellido paterno";
            this.paternoDataGridViewTextBoxColumn.Name = "paternoDataGridViewTextBoxColumn";
            this.paternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.paternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // maternoDataGridViewTextBoxColumn
            // 
            this.maternoDataGridViewTextBoxColumn.DataPropertyName = "materno";
            this.maternoDataGridViewTextBoxColumn.HeaderText = "Apellido materno";
            this.maternoDataGridViewTextBoxColumn.Name = "maternoDataGridViewTextBoxColumn";
            this.maternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.maternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // idPsicologoDataGridViewTextBoxColumn
            // 
            this.idPsicologoDataGridViewTextBoxColumn.DataPropertyName = "idPsicologo";
            this.idPsicologoDataGridViewTextBoxColumn.HeaderText = "Psicólogo";
            this.idPsicologoDataGridViewTextBoxColumn.Name = "idPsicologoDataGridViewTextBoxColumn";
            this.idPsicologoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPsicologoDataGridViewTextBoxColumn.Width = 80;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexoDataGridViewTextBoxColumn.Width = 70;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha de nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNacimientoDataGridViewTextBoxColumn.Width = 200;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Width = 70;
            // 
            // hijoBindingSource
            // 
            this.hijoBindingSource.DataMember = "Hijo";
            this.hijoBindingSource.DataSource = this.marillacDataSet;
            // 
            // marillacDataSet
            // 
            this.marillacDataSet.DataSetName = "MarillacDataSet";
            this.marillacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F);
            this.label10.Location = new System.Drawing.Point(11, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Psicólogo/a";
            // 
            // psicologo
            // 
            this.psicologo.Font = new System.Drawing.Font("Calibri", 14F);
            this.psicologo.Location = new System.Drawing.Point(188, 199);
            this.psicologo.Margin = new System.Windows.Forms.Padding(2);
            this.psicologo.Name = "psicologo";
            this.psicologo.ReadOnly = true;
            this.psicologo.Size = new System.Drawing.Size(266, 30);
            this.psicologo.TabIndex = 19;
            // 
            // paterno
            // 
            this.paterno.Font = new System.Drawing.Font("Calibri", 14F);
            this.paterno.Location = new System.Drawing.Point(188, 124);
            this.paterno.Margin = new System.Windows.Forms.Padding(2);
            this.paterno.Name = "paterno";
            this.paterno.ReadOnly = true;
            this.paterno.Size = new System.Drawing.Size(266, 30);
            this.paterno.TabIndex = 15;
            // 
            // materno
            // 
            this.materno.Font = new System.Drawing.Font("Calibri", 14F);
            this.materno.Location = new System.Drawing.Point(188, 161);
            this.materno.Margin = new System.Windows.Forms.Padding(2);
            this.materno.Name = "materno";
            this.materno.ReadOnly = true;
            this.materno.Size = new System.Drawing.Size(266, 30);
            this.materno.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(11, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido Materno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(11, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellido Paterno: ";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombre.Location = new System.Drawing.Point(188, 85);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(266, 30);
            this.nombre.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(11, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre/es:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 14F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 267);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 30);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // sexo
            // 
            this.sexo.Font = new System.Drawing.Font("Calibri", 14F);
            this.sexo.Location = new System.Drawing.Point(188, 233);
            this.sexo.Margin = new System.Windows.Forms.Padding(2);
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Size = new System.Drawing.Size(266, 30);
            this.sexo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(11, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha de nacimiento: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.Location = new System.Drawing.Point(11, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sexo (M/F): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(11, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Edad: ";
            // 
            // edad
            // 
            this.edad.Font = new System.Drawing.Font("Calibri", 14F);
            this.edad.Location = new System.Drawing.Point(188, 301);
            this.edad.Margin = new System.Windows.Forms.Padding(2);
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Size = new System.Drawing.Size(62, 30);
            this.edad.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(355, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hijoTableAdapter
            // 
            this.hijoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idBenToolStripLabel,
            this.idBenToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(997, 25);
            this.fillByToolStrip.TabIndex = 28;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // idBenToolStripLabel
            // 
            this.idBenToolStripLabel.Name = "idBenToolStripLabel";
            this.idBenToolStripLabel.Size = new System.Drawing.Size(40, 22);
            this.idBenToolStripLabel.Text = "idBen:";
            this.idBenToolStripLabel.Visible = false;
            // 
            // idBenToolStripTextBox
            // 
            this.idBenToolStripTextBox.Name = "idBenToolStripTextBox";
            this.idBenToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.idBenToolStripTextBox.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Visible = false;
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // hijosDeBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(997, 384);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.psicologo);
            this.Controls.Add(this.paterno);
            this.Controls.Add(this.materno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "hijosDeBeneficiario";
            this.ShowIcon = false;
            this.Text = "Hijos";
            this.Load += new System.EventHandler(this.hijosDeBeneficiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox psicologo;
        private System.Windows.Forms.TextBox paterno;
        private System.Windows.Forms.TextBox materno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox sexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.Button button1;
        private MarillacDataSet marillacDataSet;
        private System.Windows.Forms.BindingSource hijoBindingSource;
        private MarillacDataSetTableAdapters.HijoTableAdapter hijoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHijoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPsicologoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel idBenToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idBenToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}