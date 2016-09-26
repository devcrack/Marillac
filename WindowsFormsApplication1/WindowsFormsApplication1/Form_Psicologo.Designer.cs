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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_Sig_Pac = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTime_Birth_Date = new System.Windows.Forms.DateTimePicker();
            this.btt_Alta_Psic = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limit_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign_Pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psicologoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillac_DataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.psicologoTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.PsicologoTableAdapter();
            this.txt_Box_Working_Days = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pac_Limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sig_Pac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psicologoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillac_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Psicologos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre :";
            // 
            // txt_Box_Nom
            // 
            this.txt_Box_Nom.Location = new System.Drawing.Point(196, 61);
            this.txt_Box_Nom.Name = "txt_Box_Nom";
            this.txt_Box_Nom.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Nom.TabIndex = 0;
            this.txt_Box_Nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Paterno:";
            // 
            // txt_Apellido_Pat
            // 
            this.txt_Apellido_Pat.Location = new System.Drawing.Point(196, 104);
            this.txt_Apellido_Pat.Name = "txt_Apellido_Pat";
            this.txt_Apellido_Pat.Size = new System.Drawing.Size(281, 20);
            this.txt_Apellido_Pat.TabIndex = 1;
            this.txt_Apellido_Pat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellido Materno:";
            // 
            // txt_Box_Apelli_Mat
            // 
            this.txt_Box_Apelli_Mat.Location = new System.Drawing.Point(196, 147);
            this.txt_Box_Apelli_Mat.Name = "txt_Box_Apelli_Mat";
            this.txt_Box_Apelli_Mat.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Apelli_Mat.TabIndex = 2;
            this.txt_Box_Apelli_Mat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Direccion:";
            // 
            // txt_Box_Dir
            // 
            this.txt_Box_Dir.Location = new System.Drawing.Point(196, 190);
            this.txt_Box_Dir.Name = "txt_Box_Dir";
            this.txt_Box_Dir.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Dir.TabIndex = 3;
            this.txt_Box_Dir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Colonia:";
            // 
            // txt_Box_Col
            // 
            this.txt_Box_Col.Location = new System.Drawing.Point(196, 233);
            this.txt_Box_Col.Name = "txt_Box_Col";
            this.txt_Box_Col.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Col.TabIndex = 4;
            this.txt_Box_Col.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefono:";
            // 
            // txt_Box_Tel
            // 
            this.txt_Box_Tel.Location = new System.Drawing.Point(196, 276);
            this.txt_Box_Tel.Name = "txt_Box_Tel";
            this.txt_Box_Tel.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Tel.TabIndex = 5;
            this.txt_Box_Tel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dias Laborales:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Limite de Pacientes:";
            // 
            // numericUpDown_Pac_Limit
            // 
            this.numericUpDown_Pac_Limit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Pac_Limit.Location = new System.Drawing.Point(198, 388);
            this.numericUpDown_Pac_Limit.Name = "numericUpDown_Pac_Limit";
            this.numericUpDown_Pac_Limit.Size = new System.Drawing.Size(38, 31);
            this.numericUpDown_Pac_Limit.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pacientes: Inscritos:";
            // 
            // numericUpDown_Sig_Pac
            // 
            this.numericUpDown_Sig_Pac.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Sig_Pac.Location = new System.Drawing.Point(198, 433);
            this.numericUpDown_Sig_Pac.Name = "numericUpDown_Sig_Pac";
            this.numericUpDown_Sig_Pac.Size = new System.Drawing.Size(38, 31);
            this.numericUpDown_Sig_Pac.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Fecha de Nacimiento:";
            // 
            // dateTime_Birth_Date
            // 
            this.dateTime_Birth_Date.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Birth_Date.Location = new System.Drawing.Point(198, 478);
            this.dateTime_Birth_Date.Name = "dateTime_Birth_Date";
            this.dateTime_Birth_Date.Size = new System.Drawing.Size(200, 31);
            this.dateTime_Birth_Date.TabIndex = 11;
            // 
            // btt_Alta_Psic
            // 
            this.btt_Alta_Psic.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Alta_Psic.Location = new System.Drawing.Point(15, 558);
            this.btt_Alta_Psic.Name = "btt_Alta_Psic";
            this.btt_Alta_Psic.Size = new System.Drawing.Size(138, 35);
            this.btt_Alta_Psic.TabIndex = 12;
            this.btt_Alta_Psic.Text = "Alta";
            this.btt_Alta_Psic.UseVisualStyleBackColor = true;
            this.btt_Alta_Psic.Click += new System.EventHandler(this.btt_Alta_Psic_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Baja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btt_Modificaciones
            // 
            this.btt_Modificaciones.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Modificaciones.Location = new System.Drawing.Point(667, 558);
            this.btt_Modificaciones.Name = "btt_Modificaciones";
            this.btt_Modificaciones.Size = new System.Drawing.Size(156, 35);
            this.btt_Modificaciones.TabIndex = 14;
            this.btt_Modificaciones.Text = "Modificaciones";
            this.btt_Modificaciones.UseVisualStyleBackColor = true;
            this.btt_Modificaciones.Click += new System.EventHandler(this.btt_Modificaciones_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1002, 558);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sexo:";
            // 
            // radioButt_Male
            // 
            this.radioButt_Male.AutoSize = true;
            this.radioButt_Male.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButt_Male.Location = new System.Drawing.Point(196, 349);
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
            this.radioButt_Female.Location = new System.Drawing.Point(305, 349);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_psicologo,
            this.nombre,
            this.apellido_Pat,
            this.Apellido_Mat,
            this.dir,
            this.tel,
            this.work_days,
            this.limit_pac,
            this.sign_Pac,
            this.birth_Day,
            this.edadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.psicologoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(503, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(635, 394);
            this.dataGridView1.TabIndex = 16;
            // 
            // PK_psicologo
            // 
            this.PK_psicologo.DataPropertyName = "idPsicologo";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PK_psicologo.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.txt_Box_Working_Days.Location = new System.Drawing.Point(196, 314);
            this.txt_Box_Working_Days.Name = "txt_Box_Working_Days";
            this.txt_Box_Working_Days.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Working_Days.TabIndex = 6;
            this.txt_Box_Working_Days.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_Psicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 618);
            this.Controls.Add(this.radioButt_Female);
            this.Controls.Add(this.radioButt_Male);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btt_Modificaciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btt_Alta_Psic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTime_Birth_Date);
            this.Controls.Add(this.numericUpDown_Sig_Pac);
            this.Controls.Add(this.numericUpDown_Pac_Limit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Box_Working_Days);
            this.Controls.Add(this.txt_Box_Tel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Box_Col);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Box_Dir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Box_Apelli_Mat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Apellido_Pat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Box_Nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Psicologo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apellido Paterno:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Psicologo_FormClosing);
            this.Load += new System.EventHandler(this.Form_Psicologo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pac_Limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sig_Pac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psicologoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillac_DataSet)).EndInit();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_Sig_Pac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTime_Birth_Date;
        private System.Windows.Forms.Button btt_Alta_Psic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btt_Modificaciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButt_Male;
        private System.Windows.Forms.RadioButton radioButt_Female;
        private MarillacDataSet marillac_DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource psicologoBindingSource;
        private MarillacDataSetTableAdapters.PsicologoTableAdapter psicologoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_psicologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_Pat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_days;
        private System.Windows.Forms.DataGridViewTextBoxColumn limit_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sign_Pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_Box_Working_Days;
    }
}