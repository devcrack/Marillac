namespace WindowsFormsApplication1
{
    partial class cuotaBeneficiario
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cuotaBeneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillacDataSet1 = new WindowsFormsApplication1.MarillacDataSet();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillacDataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.actividadTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.ActividadTableAdapter();
            this.cuotaBeneficiarioTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.CuotaBeneficiarioTableAdapter();
            this.idCuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBeneficiarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaBeneficiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.actividadBindingSource;
            this.comboBox1.DisplayMember = "nombreActividad";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 91);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 31);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Tag = "";
            this.comboBox1.ValueMember = "idActividad";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Limpiar búsqueda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCuotaDataGridViewTextBoxColumn,
            this.idBeneficiarioDataGridViewTextBoxColumn,
            this.idActividadDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechaPagoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cuotaBeneficiarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(484, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(364, 244);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 66);
            this.label9.TabIndex = 11;
            this.label9.Text = "Pagos";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(243, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cuotaBeneficiarioBindingSource
            // 
            this.cuotaBeneficiarioBindingSource.DataMember = "CuotaBeneficiario";
            this.cuotaBeneficiarioBindingSource.DataSource = this.marillacDataSet1;
            // 
            // marillacDataSet1
            // 
            this.marillacDataSet1.DataSetName = "MarillacDataSet";
            this.marillacDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cuotaBeneficiarioTableAdapter
            // 
            this.cuotaBeneficiarioTableAdapter.ClearBeforeFill = true;
            // 
            // idCuotaDataGridViewTextBoxColumn
            // 
            this.idCuotaDataGridViewTextBoxColumn.DataPropertyName = "idCuota";
            this.idCuotaDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.idCuotaDataGridViewTextBoxColumn.Name = "idCuotaDataGridViewTextBoxColumn";
            this.idCuotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCuotaDataGridViewTextBoxColumn.Width = 70;
            // 
            // idBeneficiarioDataGridViewTextBoxColumn
            // 
            this.idBeneficiarioDataGridViewTextBoxColumn.DataPropertyName = "idBeneficiario";
            this.idBeneficiarioDataGridViewTextBoxColumn.HeaderText = "idBeneficiario";
            this.idBeneficiarioDataGridViewTextBoxColumn.Name = "idBeneficiarioDataGridViewTextBoxColumn";
            this.idBeneficiarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBeneficiarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // idActividadDataGridViewTextBoxColumn
            // 
            this.idActividadDataGridViewTextBoxColumn.DataPropertyName = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.HeaderText = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.Name = "idActividadDataGridViewTextBoxColumn";
            this.idActividadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idActividadDataGridViewTextBoxColumn.Visible = false;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "fechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha de pago";
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            this.fechaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaPagoDataGridViewTextBoxColumn.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Actividad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Costo: ";
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(109, 128);
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Size = new System.Drawing.Size(100, 31);
            this.costo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Saldo: ";
            // 
            // saldo
            // 
            this.saldo.Location = new System.Drawing.Point(377, 128);
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Size = new System.Drawing.Size(100, 31);
            this.saldo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Monto a pagar: ";
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(150, 165);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(180, 31);
            this.monto.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha de pago: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 202);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 31);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 38);
            this.button3.TabIndex = 22;
            this.button3.Text = "Hacer pago";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 38);
            this.button4.TabIndex = 23;
            this.button4.Text = "Eliminar pago";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cuotaBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(868, 350);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "cuotaBeneficiario";
            this.ShowIcon = false;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.cuotaBeneficiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuotaBeneficiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private MarillacDataSet marillacDataSet;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private MarillacDataSetTableAdapters.ActividadTableAdapter actividadTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private MarillacDataSet marillacDataSet1;
        private System.Windows.Forms.BindingSource cuotaBeneficiarioBindingSource;
        private MarillacDataSetTableAdapters.CuotaBeneficiarioTableAdapter cuotaBeneficiarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBeneficiarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}