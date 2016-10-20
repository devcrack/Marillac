namespace WindowsFormsApplication1
{
    partial class Form_Psicologo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Box_Nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Apellido_Pat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Box_Apelli_Mat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Box_Dir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Box_Col = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Box_Tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_Pac_Limit = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTime_Birth_Date = new System.Windows.Forms.DateTimePicker();
            this.btt_Alta_Psic = new System.Windows.Forms.Button();
            this.btt_Bajas = new System.Windows.Forms.Button();
            this.btt_Modificaciones = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButt_Male = new System.Windows.Forms.RadioButton();
            this.radioButt_Female = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PK_psicologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_Pat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limit_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign_Pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psicologoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillac_DataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.psicologoTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.PsicologoTableAdapter();
            this.txt_Box_Working_Days = new System.Windows.Forms.TextBox();
            this.ctx_Menu_PsicOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.darDeAltaPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaPacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.darDeBajaPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.limpiarCamposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pac_Limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psicologoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillac_DataSet)).BeginInit();
            this.ctx_Menu_PsicOption.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Psicologos Registrados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre :";
            // 
            // txt_Box_Nom
            // 
            this.txt_Box_Nom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Nom.Location = new System.Drawing.Point(185, 33);
            this.txt_Box_Nom.Name = "txt_Box_Nom";
            this.txt_Box_Nom.Size = new System.Drawing.Size(281, 27);
            this.txt_Box_Nom.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Paterno:";
            // 
            // txt_Apellido_Pat
            // 
            this.txt_Apellido_Pat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido_Pat.Location = new System.Drawing.Point(183, 70);
            this.txt_Apellido_Pat.Name = "txt_Apellido_Pat";
            this.txt_Apellido_Pat.Size = new System.Drawing.Size(281, 27);
            this.txt_Apellido_Pat.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellido Materno:";
            // 
            // txt_Box_Apelli_Mat
            // 
            this.txt_Box_Apelli_Mat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Apelli_Mat.Location = new System.Drawing.Point(185, 107);
            this.txt_Box_Apelli_Mat.Name = "txt_Box_Apelli_Mat";
            this.txt_Box_Apelli_Mat.Size = new System.Drawing.Size(281, 27);
            this.txt_Box_Apelli_Mat.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(504, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Direccion:";
            // 
            // txt_Box_Dir
            // 
            this.txt_Box_Dir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Dir.Location = new System.Drawing.Point(597, 74);
            this.txt_Box_Dir.Name = "txt_Box_Dir";
            this.txt_Box_Dir.Size = new System.Drawing.Size(281, 27);
            this.txt_Box_Dir.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Colonia:";
            // 
            // txt_Box_Col
            // 
            this.txt_Box_Col.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Col.Location = new System.Drawing.Point(595, 107);
            this.txt_Box_Col.Name = "txt_Box_Col";
            this.txt_Box_Col.Size = new System.Drawing.Size(281, 27);
            this.txt_Box_Col.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(879, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefono:";
            // 
            // txt_Box_Tel
            // 
            this.txt_Box_Tel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Tel.Location = new System.Drawing.Point(970, 29);
            this.txt_Box_Tel.Name = "txt_Box_Tel";
            this.txt_Box_Tel.Size = new System.Drawing.Size(281, 27);
            this.txt_Box_Tel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dias Laborales:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(878, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Limite de Pacientes:";
            // 
            // numericUpDown_Pac_Limit
            // 
            this.numericUpDown_Pac_Limit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Pac_Limit.Location = new System.Drawing.Point(1058, 72);
            this.numericUpDown_Pac_Limit.Name = "numericUpDown_Pac_Limit";
            this.numericUpDown_Pac_Limit.Size = new System.Drawing.Size(38, 31);
            this.numericUpDown_Pac_Limit.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Fecha de Nacimiento:";
            // 
            // dateTime_Birth_Date
            // 
            this.dateTime_Birth_Date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Birth_Date.Location = new System.Drawing.Point(684, 154);
            this.dateTime_Birth_Date.Name = "dateTime_Birth_Date";
            this.dateTime_Birth_Date.Size = new System.Drawing.Size(305, 31);
            this.dateTime_Birth_Date.TabIndex = 11;
            // 
            // btt_Alta_Psic
            // 
            this.btt_Alta_Psic.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Alta_Psic.Location = new System.Drawing.Point(41, 207);
            this.btt_Alta_Psic.Name = "btt_Alta_Psic";
            this.btt_Alta_Psic.Size = new System.Drawing.Size(138, 35);
            this.btt_Alta_Psic.TabIndex = 12;
            this.btt_Alta_Psic.Text = "Alta";
            this.btt_Alta_Psic.UseVisualStyleBackColor = true;
            this.btt_Alta_Psic.Click += new System.EventHandler(this.btt_Alta_Psic_Click);
            // 
            // btt_Bajas
            // 
            this.btt_Bajas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Bajas.Location = new System.Drawing.Point(392, 207);
            this.btt_Bajas.Name = "btt_Bajas";
            this.btt_Bajas.Size = new System.Drawing.Size(138, 35);
            this.btt_Bajas.TabIndex = 13;
            this.btt_Bajas.Text = "Baja";
            this.btt_Bajas.UseVisualStyleBackColor = true;
            this.btt_Bajas.Click += new System.EventHandler(this.btt_Bajas_Click);
            // 
            // btt_Modificaciones
            // 
            this.btt_Modificaciones.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Modificaciones.Location = new System.Drawing.Point(743, 207);
            this.btt_Modificaciones.Name = "btt_Modificaciones";
            this.btt_Modificaciones.Size = new System.Drawing.Size(138, 35);
            this.btt_Modificaciones.TabIndex = 14;
            this.btt_Modificaciones.Text = "Modificaciones";
            this.btt_Modificaciones.UseVisualStyleBackColor = true;
            this.btt_Modificaciones.Click += new System.EventHandler(this.btt_Modificaciones_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1094, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(878, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sexo:";
            // 
            // radioButt_Male
            // 
            this.radioButt_Male.AutoSize = true;
            this.radioButt_Male.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButt_Male.Location = new System.Drawing.Point(934, 109);
            this.radioButt_Male.Name = "radioButt_Male";
            this.radioButt_Male.Size = new System.Drawing.Size(91, 27);
            this.radioButt_Male.TabIndex = 7;
            this.radioButt_Male.TabStop = true;
            this.radioButt_Male.Text = "Hombre";
            this.radioButt_Male.UseVisualStyleBackColor = true;
            // 
            // radioButt_Female
            // 
            this.radioButt_Female.AutoSize = true;
            this.radioButt_Female.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButt_Female.Location = new System.Drawing.Point(1058, 107);
            this.radioButt_Female.Name = "radioButt_Female";
            this.radioButt_Female.Size = new System.Drawing.Size(75, 27);
            this.radioButt_Female.TabIndex = 8;
            this.radioButt_Female.TabStop = true;
            this.radioButt_Female.Text = "Mujer";
            this.radioButt_Female.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_psicologo,
            this.nombre,
            this.apellido_Pat,
            this.Apellido_Mat,
            this.dir,
            this.colonia,
            this.tel,
            this.work_days,
            this.sexo,
            this.limit_pac,
            this.sign_Pac,
            this.birth_Day,
            this.edadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.psicologoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 292);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1260, 331);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // PK_psicologo
            // 
            this.PK_psicologo.DataPropertyName = "idPsicologo";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PK_psicologo.DefaultCellStyle = dataGridViewCellStyle1;
            this.PK_psicologo.HeaderText = "Clave Psicologo";
            this.PK_psicologo.Name = "PK_psicologo";
            this.PK_psicologo.ReadOnly = true;
            this.PK_psicologo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // apellido_Pat
            // 
            this.apellido_Pat.DataPropertyName = "paterno";
            this.apellido_Pat.HeaderText = "Apeellido Paterno";
            this.apellido_Pat.Name = "apellido_Pat";
            this.apellido_Pat.ReadOnly = true;
            this.apellido_Pat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Apellido_Mat
            // 
            this.Apellido_Mat.DataPropertyName = "materno";
            this.Apellido_Mat.HeaderText = "Apellido Materno";
            this.Apellido_Mat.Name = "Apellido_Mat";
            this.Apellido_Mat.ReadOnly = true;
            this.Apellido_Mat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dir
            // 
            this.dir.DataPropertyName = "direccion";
            this.dir.HeaderText = "Direccion";
            this.dir.Name = "dir";
            this.dir.ReadOnly = true;
            this.dir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colonia
            // 
            this.colonia.DataPropertyName = "colonia";
            this.colonia.HeaderText = "Colonia";
            this.colonia.Name = "colonia";
            this.colonia.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "telefono";
            this.tel.HeaderText = "Telefono";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // work_days
            // 
            this.work_days.DataPropertyName = "diasLaborales";
            this.work_days.HeaderText = "Dias Laborales";
            this.work_days.Name = "work_days";
            this.work_days.ReadOnly = true;
            this.work_days.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // limit_pac
            // 
            this.limit_pac.DataPropertyName = "limitePacientes";
            this.limit_pac.HeaderText = "Limite de Pacientes";
            this.limit_pac.Name = "limit_pac";
            this.limit_pac.ReadOnly = true;
            this.limit_pac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sign_Pac
            // 
            this.sign_Pac.DataPropertyName = "pacientesInscritos";
            this.sign_Pac.HeaderText = "Pacientes Inscritos";
            this.sign_Pac.Name = "sign_Pac";
            this.sign_Pac.ReadOnly = true;
            this.sign_Pac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // birth_Day
            // 
            this.birth_Day.DataPropertyName = "fechaNacimiento";
            this.birth_Day.HeaderText = "Fecha de Nacimiento";
            this.birth_Day.Name = "birth_Day";
            this.birth_Day.ReadOnly = true;
            this.birth_Day.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psicologoBindingSource
            // 
            this.psicologoBindingSource.DataMember = "Psicologo";
            this.psicologoBindingSource.DataSource = this.marillac_DataSet;
            // 
            // marillac_DataSet
            // 
            this.marillac_DataSet.DataSetName = "Marillac_DataSet";
            this.marillac_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // psicologoTableAdapter
            // 
            this.psicologoTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Box_Working_Days
            // 
            this.txt_Box_Working_Days.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Box_Working_Days.Location = new System.Drawing.Point(185, 145);
            this.txt_Box_Working_Days.Name = "txt_Box_Working_Days";
            this.txt_Box_Working_Days.Size = new System.Drawing.Size(281, 27);
            this.txt_Box_Working_Days.TabIndex = 6;
            // 
            // ctx_Menu_PsicOption
            // 
            this.ctx_Menu_PsicOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaPacienteToolStripMenuItem,
            this.toolStripSeparator1,
            this.limpiarCamposToolStripMenuItem});
            this.ctx_Menu_PsicOption.Name = "contextMenuStrip1";
            this.ctx_Menu_PsicOption.Size = new System.Drawing.Size(194, 58);
            // 
            // darDeAltaPacienteToolStripMenuItem
            // 
            this.darDeAltaPacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaPacienteToolStripMenuItem1,
            this.toolStripSeparator3,
            this.darDeBajaPacienteToolStripMenuItem});
            this.darDeAltaPacienteToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darDeAltaPacienteToolStripMenuItem.Name = "darDeAltaPacienteToolStripMenuItem";
            this.darDeAltaPacienteToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.darDeAltaPacienteToolStripMenuItem.Text = "Psicologo";
            // 
            // darDeAltaPacienteToolStripMenuItem1
            // 
            this.darDeAltaPacienteToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darDeAltaPacienteToolStripMenuItem1.Name = "darDeAltaPacienteToolStripMenuItem1";
            this.darDeAltaPacienteToolStripMenuItem1.Size = new System.Drawing.Size(225, 24);
            this.darDeAltaPacienteToolStripMenuItem1.Text = "Dar de Alta Paciente";
            this.darDeAltaPacienteToolStripMenuItem1.Click += new System.EventHandler(this.darDeAltaPacienteToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // darDeBajaPacienteToolStripMenuItem
            // 
            this.darDeBajaPacienteToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.darDeBajaPacienteToolStripMenuItem.Name = "darDeBajaPacienteToolStripMenuItem";
            this.darDeBajaPacienteToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.darDeBajaPacienteToolStripMenuItem.Text = "Dar de Baja Pacientes";
            this.darDeBajaPacienteToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaPacienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // limpiarCamposToolStripMenuItem
            // 
            this.limpiarCamposToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarCamposToolStripMenuItem.Name = "limpiarCamposToolStripMenuItem";
            this.limpiarCamposToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.limpiarCamposToolStripMenuItem.Text = "Limpiar Campos :)";
            this.limpiarCamposToolStripMenuItem.Click += new System.EventHandler(this.limpiarCamposToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Box_Nom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.radioButt_Female);
            this.groupBox1.Controls.Add(this.btt_Modificaciones);
            this.groupBox1.Controls.Add(this.txt_Apellido_Pat);
            this.groupBox1.Controls.Add(this.btt_Bajas);
            this.groupBox1.Controls.Add(this.radioButt_Male);
            this.groupBox1.Controls.Add(this.btt_Alta_Psic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Box_Apelli_Mat);
            this.groupBox1.Controls.Add(this.dateTime_Birth_Date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Box_Dir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Box_Col);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDown_Pac_Limit);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Box_Tel);
            this.groupBox1.Controls.Add(this.txt_Box_Working_Days);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1261, 248);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Psicologo";
            // 
            // Form_Psicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 635);
            this.ContextMenuStrip = this.ctx_Menu_PsicOption;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Psicologo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apellido Paterno:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Psicologo_FormClosing);
            this.Load += new System.EventHandler(this.Form_Psicologo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pac_Limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psicologoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillac_DataSet)).EndInit();
            this.ctx_Menu_PsicOption.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Box_Nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Apellido_Pat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Box_Apelli_Mat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Box_Dir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Box_Col;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Box_Tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_Pac_Limit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTime_Birth_Date;
        private System.Windows.Forms.Button btt_Alta_Psic;
        private System.Windows.Forms.Button btt_Bajas;
        private System.Windows.Forms.Button btt_Modificaciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButt_Male;
        private System.Windows.Forms.RadioButton radioButt_Female;
        private MarillacDataSet marillac_DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource psicologoBindingSource;
        private MarillacDataSetTableAdapters.PsicologoTableAdapter psicologoTableAdapter;
        private System.Windows.Forms.TextBox txt_Box_Working_Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_psicologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_Pat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_days;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn limit_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sign_Pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip ctx_Menu_PsicOption;
        private System.Windows.Forms.ToolStripMenuItem limpiarCamposToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaPacienteToolStripMenuItem1;
    }
}