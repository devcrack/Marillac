namespace WindowsFormsApplication1
{
    partial class F_Beneficiario
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materno = new System.Windows.Forms.TextBox();
            this.paterno = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.colonia = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillacDataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.beneficiarioTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.BeneficiarioTableAdapter();
            this.psicologo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonActividades = new System.Windows.Forms.Button();
            this.botonPagos = new System.Windows.Forms.Button();
            this.botonPsicologo = new System.Windows.Forms.Button();
            this.botonHijos = new System.Windows.Forms.Button();
            this.idBeneficiarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPsicologoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(14, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre/es:";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Calibri", 14F);
            this.nombre.Location = new System.Drawing.Point(191, 100);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(266, 30);
            this.nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(14, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido Paterno: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(14, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido Materno: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(14, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.Location = new System.Drawing.Point(14, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Colonia: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.Location = new System.Drawing.Point(14, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Teléfono: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.Location = new System.Drawing.Point(14, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sexo (M/F): ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F);
            this.label8.Location = new System.Drawing.Point(14, 426);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Fecha de nacimiento: ";
            // 
            // materno
            // 
            this.materno.Font = new System.Drawing.Font("Calibri", 14F);
            this.materno.Location = new System.Drawing.Point(191, 176);
            this.materno.Margin = new System.Windows.Forms.Padding(2);
            this.materno.Name = "materno";
            this.materno.Size = new System.Drawing.Size(266, 30);
            this.materno.TabIndex = 3;
            // 
            // paterno
            // 
            this.paterno.Font = new System.Drawing.Font("Calibri", 14F);
            this.paterno.Location = new System.Drawing.Point(191, 139);
            this.paterno.Margin = new System.Windows.Forms.Padding(2);
            this.paterno.Name = "paterno";
            this.paterno.Size = new System.Drawing.Size(266, 30);
            this.paterno.TabIndex = 2;
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Calibri", 14F);
            this.direccion.Location = new System.Drawing.Point(191, 251);
            this.direccion.Margin = new System.Windows.Forms.Padding(2);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(266, 58);
            this.direccion.TabIndex = 4;
            // 
            // colonia
            // 
            this.colonia.Font = new System.Drawing.Font("Calibri", 14F);
            this.colonia.Location = new System.Drawing.Point(191, 316);
            this.colonia.Margin = new System.Windows.Forms.Padding(2);
            this.colonia.Name = "colonia";
            this.colonia.Size = new System.Drawing.Size(266, 30);
            this.colonia.TabIndex = 5;
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Calibri", 14F);
            this.telefono.Location = new System.Drawing.Point(191, 352);
            this.telefono.Margin = new System.Windows.Forms.Padding(2);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(266, 30);
            this.telefono.TabIndex = 6;
            // 
            // sexo
            // 
            this.sexo.Font = new System.Drawing.Font("Calibri", 14F);
            this.sexo.Location = new System.Drawing.Point(191, 386);
            this.sexo.Margin = new System.Windows.Forms.Padding(2);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(266, 30);
            this.sexo.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 14F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 420);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 30);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 66);
            this.label9.TabIndex = 9;
            this.label9.Text = "Beneficiarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBeneficiarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.paternoDataGridViewTextBoxColumn,
            this.maternoDataGridViewTextBoxColumn,
            this.idPsicologoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.coloniaDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.beneficiarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(482, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 454);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // psicologo
            // 
            this.psicologo.Font = new System.Drawing.Font("Calibri", 14F);
            this.psicologo.Location = new System.Drawing.Point(191, 214);
            this.psicologo.Margin = new System.Windows.Forms.Padding(2);
            this.psicologo.Name = "psicologo";
            this.psicologo.ReadOnly = true;
            this.psicologo.Size = new System.Drawing.Size(266, 30);
            this.psicologo.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F);
            this.label10.Location = new System.Drawing.Point(14, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Psicólogo/a";
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(129, 462);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(89, 42);
            this.botonModificar.TabIndex = 15;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(34, 462);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(89, 42);
            this.botonAgregar.TabIndex = 16;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(224, 462);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(89, 42);
            this.botonEliminar.TabIndex = 17;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonSalir.Location = new System.Drawing.Point(319, 511);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(89, 42);
            this.botonSalir.TabIndex = 18;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonActividades
            // 
            this.botonActividades.Font = new System.Drawing.Font("Calibri", 11F);
            this.botonActividades.Location = new System.Drawing.Point(34, 510);
            this.botonActividades.Name = "botonActividades";
            this.botonActividades.Size = new System.Drawing.Size(89, 42);
            this.botonActividades.TabIndex = 19;
            this.botonActividades.Text = "Actividades";
            this.botonActividades.UseVisualStyleBackColor = true;
            // 
            // botonPagos
            // 
            this.botonPagos.Location = new System.Drawing.Point(129, 510);
            this.botonPagos.Name = "botonPagos";
            this.botonPagos.Size = new System.Drawing.Size(89, 42);
            this.botonPagos.TabIndex = 21;
            this.botonPagos.Text = "Pagos";
            this.botonPagos.UseVisualStyleBackColor = true;
            // 
            // botonPsicologo
            // 
            this.botonPsicologo.Location = new System.Drawing.Point(224, 511);
            this.botonPsicologo.Name = "botonPsicologo";
            this.botonPsicologo.Size = new System.Drawing.Size(89, 42);
            this.botonPsicologo.TabIndex = 22;
            this.botonPsicologo.Text = "Psicólogo";
            this.botonPsicologo.UseVisualStyleBackColor = true;
            this.botonPsicologo.Click += new System.EventHandler(this.botonPsicologo_Click);
            // 
            // botonHijos
            // 
            this.botonHijos.Font = new System.Drawing.Font("Calibri", 11F);
            this.botonHijos.Location = new System.Drawing.Point(321, 462);
            this.botonHijos.Name = "botonHijos";
            this.botonHijos.Size = new System.Drawing.Size(87, 44);
            this.botonHijos.TabIndex = 23;
            this.botonHijos.Text = "Hijos";
            this.botonHijos.UseVisualStyleBackColor = true;
            // 
            // idBeneficiarioDataGridViewTextBoxColumn
            // 
            this.idBeneficiarioDataGridViewTextBoxColumn.DataPropertyName = "idBeneficiario";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBeneficiarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idBeneficiarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idBeneficiarioDataGridViewTextBoxColumn.Name = "idBeneficiarioDataGridViewTextBoxColumn";
            this.idBeneficiarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBeneficiarioDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre/es";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // paternoDataGridViewTextBoxColumn
            // 
            this.paternoDataGridViewTextBoxColumn.DataPropertyName = "paterno";
            this.paternoDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
            this.paternoDataGridViewTextBoxColumn.Name = "paternoDataGridViewTextBoxColumn";
            this.paternoDataGridViewTextBoxColumn.ReadOnly = true;
            this.paternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // maternoDataGridViewTextBoxColumn
            // 
            this.maternoDataGridViewTextBoxColumn.DataPropertyName = "materno";
            this.maternoDataGridViewTextBoxColumn.HeaderText = "Apellido Materno";
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
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 250;
            // 
            // coloniaDataGridViewTextBoxColumn
            // 
            this.coloniaDataGridViewTextBoxColumn.DataPropertyName = "colonia";
            this.coloniaDataGridViewTextBoxColumn.HeaderText = "Colonia";
            this.coloniaDataGridViewTextBoxColumn.Name = "coloniaDataGridViewTextBoxColumn";
            this.coloniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.edadDataGridViewTextBoxColumn.Width = 50;
            // 
            // F_Beneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.botonSalir;
            this.ClientSize = new System.Drawing.Size(1221, 567);
            this.Controls.Add(this.botonHijos);
            this.Controls.Add(this.botonPsicologo);
            this.Controls.Add(this.botonPagos);
            this.Controls.Add(this.botonActividades);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.psicologo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.colonia);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.paterno);
            this.Controls.Add(this.materno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "F_Beneficiario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_is_Closing);
            this.Load += new System.EventHandler(this.F_Beneficiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox materno;
        private System.Windows.Forms.TextBox paterno;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox colonia;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox sexo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MarillacDataSet marillacDataSet;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private MarillacDataSetTableAdapters.BeneficiarioTableAdapter beneficiarioTableAdapter;
        private System.Windows.Forms.TextBox psicologo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonActividades;
        private System.Windows.Forms.Button botonPagos;
        private System.Windows.Forms.Button botonPsicologo;
        private System.Windows.Forms.Button botonHijos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBeneficiarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPsicologoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
    }
}