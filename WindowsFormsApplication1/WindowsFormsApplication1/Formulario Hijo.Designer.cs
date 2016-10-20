namespace WindowsFormsApplication1
{
    partial class Formulario_Hijo
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
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonHijos = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillacDataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.beneficiarioTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.BeneficiarioTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.paterno = new System.Windows.Forms.TextBox();
            this.materno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hijoTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.HijoTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pagotxt = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.actividadtxt = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.saldotxt = new System.Windows.Forms.TextBox();
            this.montotxt = new System.Windows.Forms.TextBox();
            this.sexo1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nombrebene = new System.Windows.Forms.TextBox();
            this.nombrepsi = new System.Windows.Forms.TextBox();
            this.beneficiario = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.psicologo = new System.Windows.Forms.TextBox();
            this.idHijoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBeneficiarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPsicologoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hijoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Font = new System.Drawing.Font("Calibri", 14F);
            this.botonLimpiar.Location = new System.Drawing.Point(40, 443);
            this.botonLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(136, 42);
            this.botonLimpiar.TabIndex = 53;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonHijos
            // 
            this.botonHijos.Font = new System.Drawing.Font("Calibri", 11F);
            this.botonHijos.Location = new System.Drawing.Point(551, 325);
            this.botonHijos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonHijos.Name = "botonHijos";
            this.botonHijos.Size = new System.Drawing.Size(33, 32);
            this.botonHijos.TabIndex = 52;
            this.botonHijos.Text = "...";
            this.botonHijos.UseVisualStyleBackColor = true;
            this.botonHijos.Click += new System.EventHandler(this.botonHijos_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonSalir.Font = new System.Drawing.Font("Calibri", 14F);
            this.botonSalir.Location = new System.Drawing.Point(181, 444);
            this.botonSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(136, 42);
            this.botonSalir.TabIndex = 48;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Font = new System.Drawing.Font("Calibri", 14F);
            this.botonEliminar.Location = new System.Drawing.Point(324, 382);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(136, 42);
            this.botonEliminar.TabIndex = 47;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Font = new System.Drawing.Font("Calibri", 14F);
            this.botonAgregar.Location = new System.Drawing.Point(40, 382);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(136, 42);
            this.botonAgregar.TabIndex = 46;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Font = new System.Drawing.Font("Calibri", 14F);
            this.botonModificar.Location = new System.Drawing.Point(181, 382);
            this.botonModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(136, 42);
            this.botonModificar.TabIndex = 45;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F);
            this.label10.Location = new System.Drawing.Point(53, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 29);
            this.label10.TabIndex = 44;
            this.label10.Text = "Psicólogo/a";
            // 
            // beneficiarioBindingSource
            // 
            this.beneficiarioBindingSource.DataMember = "Beneficiario";
            this.beneficiarioBindingSource.DataSource = this.marillacDataSet;
            // 
            // marillacDataSet
            // 
            this.marillacDataSet.DataSetName = "MarillacDataSet";
            this.marillacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beneficiarioTableAdapter
            // 
            this.beneficiarioTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHijoDataGridViewTextBoxColumn,
            this.idBeneficiarioDataGridViewTextBoxColumn,
            this.idPsicologoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.paternoDataGridViewTextBoxColumn,
            this.maternoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hijoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(589, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 258);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // hijoBindingSource
            // 
            this.hijoBindingSource.DataMember = "Hijo";
            this.hijoBindingSource.DataSource = this.marillacDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(593, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 82);
            this.label9.TabIndex = 41;
            this.label9.Text = "Hijos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 14F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 276);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 36);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // paterno
            // 
            this.paterno.Font = new System.Drawing.Font("Calibri", 14F);
            this.paterno.Location = new System.Drawing.Point(279, 118);
            this.paterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paterno.Name = "paterno";
            this.paterno.Size = new System.Drawing.Size(265, 36);
            this.paterno.TabIndex = 27;
            // 
            // materno
            // 
            this.materno.Font = new System.Drawing.Font("Calibri", 14F);
            this.materno.Location = new System.Drawing.Point(279, 155);
            this.materno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materno.Name = "materno";
            this.materno.Size = new System.Drawing.Size(265, 36);
            this.materno.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(53, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Fecha de nacimiento: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.Location = new System.Drawing.Point(53, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Sexo (M/F): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(53, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Apellido Materno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(53, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Apellido Paterno: ";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombre.Location = new System.Drawing.Point(279, 79);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(265, 36);
            this.nombre.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(53, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre/es:";
            // 
            // hijoTableAdapter
            // 
            this.hijoTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F);
            this.label11.Location = new System.Drawing.Point(57, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 29);
            this.label11.TabIndex = 44;
            this.label11.Text = "Beneficiario";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(568, 400);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(749, 116);
            this.dataGridView2.TabIndex = 54;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(563, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Actividades Inscritas";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 762);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(36, 96);
            this.dataGridView3.TabIndex = 54;
            this.dataGridView3.Visible = false;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 722);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 34);
            this.button1.TabIndex = 55;
            this.button1.Text = "Inscribir Actividad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 862);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 37);
            this.button2.TabIndex = 55;
            this.button2.Text = "Eliminar Actividad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pagotxt
            // 
            this.pagotxt.Font = new System.Drawing.Font("Calibri", 14F);
            this.pagotxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pagotxt.Location = new System.Drawing.Point(144, 203);
            this.pagotxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagotxt.Name = "pagotxt";
            this.pagotxt.Size = new System.Drawing.Size(165, 36);
            this.pagotxt.TabIndex = 36;
            this.pagotxt.Value = new System.DateTime(2016, 10, 2, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pagotxt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.nombretxt);
            this.groupBox1.Controls.Add(this.actividadtxt);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.saldotxt);
            this.groupBox1.Controls.Add(this.montotxt);
            this.groupBox1.Location = new System.Drawing.Point(45, 521);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(851, 311);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Pagos";
            this.groupBox1.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14F);
            this.label15.Location = new System.Drawing.Point(43, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 29);
            this.label15.TabIndex = 44;
            this.label15.Text = "Saldo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F);
            this.label14.Location = new System.Drawing.Point(43, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 29);
            this.label14.TabIndex = 44;
            this.label14.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(25, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "Actividad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14F);
            this.label12.Location = new System.Drawing.Point(25, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 29);
            this.label12.TabIndex = 44;
            this.label12.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(11, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fecha pago";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(399, 71);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(371, 150);
            this.dataGridView4.TabIndex = 54;
            // 
            // nombretxt
            // 
            this.nombretxt.Enabled = false;
            this.nombretxt.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombretxt.Location = new System.Drawing.Point(139, 46);
            this.nombretxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(240, 36);
            this.nombretxt.TabIndex = 31;
            // 
            // actividadtxt
            // 
            this.actividadtxt.Enabled = false;
            this.actividadtxt.Font = new System.Drawing.Font("Calibri", 14F);
            this.actividadtxt.Location = new System.Drawing.Point(139, 102);
            this.actividadtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actividadtxt.Name = "actividadtxt";
            this.actividadtxt.Size = new System.Drawing.Size(241, 36);
            this.actividadtxt.TabIndex = 31;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 14F);
            this.button6.Location = new System.Drawing.Point(571, 261);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 42);
            this.button6.TabIndex = 46;
            this.button6.Text = "Eliminar Pago";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 14F);
            this.button4.Location = new System.Drawing.Point(399, 261);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 42);
            this.button4.TabIndex = 46;
            this.button4.Text = "Registrar Pago";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F);
            this.label13.Location = new System.Drawing.Point(395, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 29);
            this.label13.TabIndex = 44;
            this.label13.Text = "Cuotas ";
            // 
            // saldotxt
            // 
            this.saldotxt.Font = new System.Drawing.Font("Calibri", 14F);
            this.saldotxt.Location = new System.Drawing.Point(144, 153);
            this.saldotxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saldotxt.Name = "saldotxt";
            this.saldotxt.Size = new System.Drawing.Size(165, 36);
            this.saldotxt.TabIndex = 29;
            // 
            // montotxt
            // 
            this.montotxt.Font = new System.Drawing.Font("Calibri", 14F);
            this.montotxt.Location = new System.Drawing.Point(144, 261);
            this.montotxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.montotxt.Name = "montotxt";
            this.montotxt.Size = new System.Drawing.Size(165, 36);
            this.montotxt.TabIndex = 29;
            // 
            // sexo1
            // 
            this.sexo1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo1.FormattingEnabled = true;
            this.sexo1.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexo1.Location = new System.Drawing.Point(279, 234);
            this.sexo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sexo1.Name = "sexo1";
            this.sexo1.Size = new System.Drawing.Size(265, 36);
            this.sexo1.TabIndex = 57;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 14F);
            this.button5.Location = new System.Drawing.Point(324, 443);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 42);
            this.button5.TabIndex = 47;
            this.button5.Text = "Pagos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(5, 30);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(344, 150);
            this.dataGridView5.TabIndex = 54;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 14F);
            this.button7.Location = new System.Drawing.Point(16, 220);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 42);
            this.button7.TabIndex = 58;
            this.button7.Text = "Aceptar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView5);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(961, 521);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(356, 311);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecciona Beneficiario";
            this.groupBox2.Visible = false;
            // 
            // nombrebene
            // 
            this.nombrebene.Enabled = false;
            this.nombrebene.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombrebene.Location = new System.Drawing.Point(276, 318);
            this.nombrebene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombrebene.Name = "nombrebene";
            this.nombrebene.Size = new System.Drawing.Size(268, 36);
            this.nombrebene.TabIndex = 37;
            // 
            // nombrepsi
            // 
            this.nombrepsi.Enabled = false;
            this.nombrepsi.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombrepsi.Location = new System.Drawing.Point(279, 194);
            this.nombrepsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombrepsi.Name = "nombrepsi";
            this.nombrepsi.Size = new System.Drawing.Size(268, 36);
            this.nombrepsi.TabIndex = 31;
            // 
            // beneficiario
            // 
            this.beneficiario.Enabled = false;
            this.beneficiario.Font = new System.Drawing.Font("Calibri", 14F);
            this.beneficiario.Location = new System.Drawing.Point(45, 567);
            this.beneficiario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.beneficiario.Name = "beneficiario";
            this.beneficiario.Size = new System.Drawing.Size(40, 36);
            this.beneficiario.TabIndex = 37;
            this.beneficiario.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 11F);
            this.button3.Location = new System.Drawing.Point(92, 572);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 32);
            this.button3.TabIndex = 52;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.botonHijos_Click);
            // 
            // psicologo
            // 
            this.psicologo.Enabled = false;
            this.psicologo.Font = new System.Drawing.Font("Calibri", 14F);
            this.psicologo.Location = new System.Drawing.Point(131, 567);
            this.psicologo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.psicologo.Name = "psicologo";
            this.psicologo.Size = new System.Drawing.Size(41, 36);
            this.psicologo.TabIndex = 31;
            this.psicologo.Visible = false;
            // 
            // idHijoDataGridViewTextBoxColumn
            // 
            this.idHijoDataGridViewTextBoxColumn.DataPropertyName = "idHijo";
            this.idHijoDataGridViewTextBoxColumn.HeaderText = "idHijo";
            this.idHijoDataGridViewTextBoxColumn.Name = "idHijoDataGridViewTextBoxColumn";
            this.idHijoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHijoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idBeneficiarioDataGridViewTextBoxColumn
            // 
            this.idBeneficiarioDataGridViewTextBoxColumn.DataPropertyName = "idBeneficiario";
            this.idBeneficiarioDataGridViewTextBoxColumn.HeaderText = "idBeneficiario";
            this.idBeneficiarioDataGridViewTextBoxColumn.Name = "idBeneficiarioDataGridViewTextBoxColumn";
            this.idBeneficiarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBeneficiarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPsicologoDataGridViewTextBoxColumn
            // 
            this.idPsicologoDataGridViewTextBoxColumn.DataPropertyName = "idPsicologo";
            this.idPsicologoDataGridViewTextBoxColumn.HeaderText = "idPsicologo";
            this.idPsicologoDataGridViewTextBoxColumn.Name = "idPsicologoDataGridViewTextBoxColumn";
            this.idPsicologoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPsicologoDataGridViewTextBoxColumn.Visible = false;
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
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Formulario_Hijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 843);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sexo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.botonHijos);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nombrebene);
            this.Controls.Add(this.beneficiario);
            this.Controls.Add(this.nombrepsi);
            this.Controls.Add(this.psicologo);
            this.Controls.Add(this.paterno);
            this.Controls.Add(this.materno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario_Hijo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Hijo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulario_Hijo_FormClosing);
            this.Load += new System.EventHandler(this.Formulario_Hijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonHijos;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private MarillacDataSet marillacDataSet;
        private MarillacDataSetTableAdapters.BeneficiarioTableAdapter beneficiarioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox paterno;
        private System.Windows.Forms.TextBox materno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hijoBindingSource;
        private MarillacDataSetTableAdapters.HijoTableAdapter hijoTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker pagotxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox actividadtxt;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox sexo1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox montotxt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox saldotxt;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nombrebene;
        private System.Windows.Forms.TextBox nombrepsi;
        private System.Windows.Forms.TextBox beneficiario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox psicologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHijoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBeneficiarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPsicologoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
    }
}