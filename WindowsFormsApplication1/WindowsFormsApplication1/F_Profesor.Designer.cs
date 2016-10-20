namespace WindowsFormsApplication1
{
    partial class F_Profesor
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
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillacDataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.beneficiarioTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.BeneficiarioTableAdapter();
            this.cuotaHijoTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.CuotaHijoTableAdapter();
            this.paterno = new System.Windows.Forms.TextBox();
            this.cuotaHijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.telefono = new System.Windows.Forms.TextBox();
            this.colonia = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.materno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dias = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.ProfesorTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sexo1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaHijoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // botonSalir
            // 
            this.botonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonSalir.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.Location = new System.Drawing.Point(505, 603);
            this.botonSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(123, 42);
            this.botonSalir.TabIndex = 47;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(374, 603);
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(124, 42);
            this.botonEliminar.TabIndex = 46;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Location = new System.Drawing.Point(113, 603);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(124, 42);
            this.botonAgregar.TabIndex = 45;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificar.Location = new System.Drawing.Point(245, 603);
            this.botonModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(123, 42);
            this.botonModificar.TabIndex = 44;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
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
            // cuotaHijoTableAdapter
            // 
            this.cuotaHijoTableAdapter.ClearBeforeFill = true;
            // 
            // paterno
            // 
            this.paterno.Font = new System.Drawing.Font("Calibri", 14F);
            this.paterno.Location = new System.Drawing.Point(363, 151);
            this.paterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paterno.Name = "paterno";
            this.paterno.Size = new System.Drawing.Size(265, 36);
            this.paterno.TabIndex = 26;
            // 
            // cuotaHijoBindingSource
            // 
            this.cuotaHijoBindingSource.DataMember = "CuotaHijo";
            this.cuotaHijoBindingSource.DataSource = this.marillacDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(653, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 254);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(865, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 82);
            this.label9.TabIndex = 40;
            this.label9.Text = "Profesores";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 14F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 410);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 36);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Calibri", 14F);
            this.telefono.Location = new System.Drawing.Point(363, 330);
            this.telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(265, 36);
            this.telefono.TabIndex = 34;
            // 
            // colonia
            // 
            this.colonia.Font = new System.Drawing.Font("Calibri", 14F);
            this.colonia.Location = new System.Drawing.Point(363, 290);
            this.colonia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colonia.Name = "colonia";
            this.colonia.Size = new System.Drawing.Size(265, 36);
            this.colonia.TabIndex = 33;
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Calibri", 14F);
            this.direccion.Location = new System.Drawing.Point(363, 228);
            this.direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(265, 58);
            this.direccion.TabIndex = 30;
            // 
            // materno
            // 
            this.materno.Font = new System.Drawing.Font("Calibri", 14F);
            this.materno.Location = new System.Drawing.Point(363, 188);
            this.materno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materno.Name = "materno";
            this.materno.Size = new System.Drawing.Size(265, 36);
            this.materno.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(123, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Fecha de nacimiento: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.Location = new System.Drawing.Point(123, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Sexo (M/F): ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(123, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Teléfono: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(123, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Colonia: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(123, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Dirección: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(120, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellido Materno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(120, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellido Paterno: ";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombre.Location = new System.Drawing.Point(363, 112);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(265, 36);
            this.nombre.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(120, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre/es:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F);
            this.label11.Location = new System.Drawing.Point(123, 458);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 29);
            this.label11.TabIndex = 28;
            this.label11.Text = "Dias Laborales";
            // 
            // dias
            // 
            this.dias.Enabled = false;
            this.dias.Font = new System.Drawing.Font("Calibri", 14F);
            this.dias.Location = new System.Drawing.Point(363, 450);
            this.dias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dias.Name = "dias";
            this.dias.Size = new System.Drawing.Size(265, 36);
            this.dias.TabIndex = 39;
            this.dias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dias.TextChanged += new System.EventHandler(this.dias_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(653, 432);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(728, 150);
            this.dataGridView2.TabIndex = 52;
            this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F);
            this.label10.Location = new System.Drawing.Point(896, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 29);
            this.label10.TabIndex = 28;
            this.label10.Text = "Actividades del profesor";
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.marillacDataSet;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(821, 647);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 10;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(364, 210);
            this.dataGridView3.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14F);
            this.label12.Location = new System.Drawing.Point(486, 689);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 29);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nombre Actividad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F);
            this.label13.Location = new System.Drawing.Point(486, 743);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 29);
            this.label13.TabIndex = 28;
            this.label13.Text = "Hora Inicio:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F);
            this.label14.Location = new System.Drawing.Point(486, 794);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 29);
            this.label14.TabIndex = 28;
            this.label14.Text = "Inscritos:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 14F);
            this.label15.Location = new System.Drawing.Point(520, 700);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 29);
            this.label15.TabIndex = 28;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(125, 516);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 33);
            this.checkBox1.TabIndex = 54;
            this.checkBox1.Text = "Lunes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(125, 543);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 33);
            this.checkBox2.TabIndex = 54;
            this.checkBox2.Text = "Martes";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(242, 516);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 33);
            this.checkBox3.TabIndex = 54;
            this.checkBox3.Text = "Miercoles";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(242, 543);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 33);
            this.checkBox4.TabIndex = 54;
            this.checkBox4.Text = "Jueves";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(376, 516);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(109, 33);
            this.checkBox5.TabIndex = 54;
            this.checkBox5.Text = "Viernes";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(360, 543);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(109, 33);
            this.checkBox6.TabIndex = 54;
            this.checkBox6.Text = "Sabado";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(491, 516);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(125, 33);
            this.checkBox7.TabIndex = 54;
            this.checkBox7.Text = "Domingo";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 14F);
            this.label16.Location = new System.Drawing.Point(905, 616);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 29);
            this.label16.TabIndex = 28;
            this.label16.Text = "Personas Inscritas";
            // 
            // sexo1
            // 
            this.sexo1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo1.FormattingEnabled = true;
            this.sexo1.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexo1.Location = new System.Drawing.Point(364, 371);
            this.sexo1.Name = "sexo1";
            this.sexo1.Size = new System.Drawing.Size(264, 36);
            this.sexo1.TabIndex = 55;
            // 
            // F_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 886);
            this.Controls.Add(this.sexo1);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.paterno);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.colonia);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.dias);
            this.Controls.Add(this.materno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Profesores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Profesor_FormClosing);
            this.Load += new System.EventHandler(this.F_Profesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaHijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private MarillacDataSet marillacDataSet;
        private MarillacDataSetTableAdapters.BeneficiarioTableAdapter beneficiarioTableAdapter;
        private MarillacDataSetTableAdapters.CuotaHijoTableAdapter cuotaHijoTableAdapter;
        private System.Windows.Forms.TextBox paterno;
        private System.Windows.Forms.BindingSource cuotaHijoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox colonia;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox materno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dias;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private MarillacDataSetTableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox sexo1;
    }
}