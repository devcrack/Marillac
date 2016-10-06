namespace WindowsFormsApplication1
{
    partial class AltaActividadBeneficiario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idBeneficiarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beneficiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marillacDataSet = new WindowsFormsApplication1.MarillacDataSet();
            this.beneficiarioTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.BeneficiarioTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreActividadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasImparteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscritosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actividadTableAdapter = new WindowsFormsApplication1.MarillacDataSetTableAdapters.ActividadTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Beneficiario que desee inscribir. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Después seleccione la actividad a la que desea inscribir a ese Beneficiario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBeneficiarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.paternoDataGridViewTextBoxColumn,
            this.maternoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.beneficiarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idBeneficiarioDataGridViewTextBoxColumn
            // 
            this.idBeneficiarioDataGridViewTextBoxColumn.DataPropertyName = "idBeneficiario";
            this.idBeneficiarioDataGridViewTextBoxColumn.HeaderText = "ID Beneficiario";
            this.idBeneficiarioDataGridViewTextBoxColumn.Name = "idBeneficiarioDataGridViewTextBoxColumn";
            this.idBeneficiarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paternoDataGridViewTextBoxColumn
            // 
            this.paternoDataGridViewTextBoxColumn.DataPropertyName = "paterno";
            this.paternoDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
            this.paternoDataGridViewTextBoxColumn.Name = "paternoDataGridViewTextBoxColumn";
            this.paternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maternoDataGridViewTextBoxColumn
            // 
            this.maternoDataGridViewTextBoxColumn.DataPropertyName = "materno";
            this.maternoDataGridViewTextBoxColumn.HeaderText = "Apellido Materno";
            this.maternoDataGridViewTextBoxColumn.Name = "maternoDataGridViewTextBoxColumn";
            this.maternoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idActividadDataGridViewTextBoxColumn,
            this.nombreActividadDataGridViewTextBoxColumn,
            this.diasImparteDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaFinalDataGridViewTextBoxColumn,
            this.cupoDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.inscritosDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.actividadBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 269);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(444, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // idActividadDataGridViewTextBoxColumn
            // 
            this.idActividadDataGridViewTextBoxColumn.DataPropertyName = "idActividad";
            this.idActividadDataGridViewTextBoxColumn.HeaderText = "ID Actividad";
            this.idActividadDataGridViewTextBoxColumn.Name = "idActividadDataGridViewTextBoxColumn";
            this.idActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreActividadDataGridViewTextBoxColumn
            // 
            this.nombreActividadDataGridViewTextBoxColumn.DataPropertyName = "nombreActividad";
            this.nombreActividadDataGridViewTextBoxColumn.HeaderText = "Nombre Actividad";
            this.nombreActividadDataGridViewTextBoxColumn.Name = "nombreActividadDataGridViewTextBoxColumn";
            this.nombreActividadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasImparteDataGridViewTextBoxColumn
            // 
            this.diasImparteDataGridViewTextBoxColumn.DataPropertyName = "diasImparte";
            this.diasImparteDataGridViewTextBoxColumn.HeaderText = "Dias Impartida";
            this.diasImparteDataGridViewTextBoxColumn.Name = "diasImparteDataGridViewTextBoxColumn";
            this.diasImparteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "horaInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "Hora Inicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaFinalDataGridViewTextBoxColumn
            // 
            this.horaFinalDataGridViewTextBoxColumn.DataPropertyName = "horaFinal";
            this.horaFinalDataGridViewTextBoxColumn.HeaderText = "Hora Final";
            this.horaFinalDataGridViewTextBoxColumn.Name = "horaFinalDataGridViewTextBoxColumn";
            this.horaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoDataGridViewTextBoxColumn
            // 
            this.cupoDataGridViewTextBoxColumn.DataPropertyName = "cupo";
            this.cupoDataGridViewTextBoxColumn.HeaderText = "Cupo";
            this.cupoDataGridViewTextBoxColumn.Name = "cupoDataGridViewTextBoxColumn";
            this.cupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inscritosDataGridViewTextBoxColumn
            // 
            this.inscritosDataGridViewTextBoxColumn.DataPropertyName = "inscritos";
            this.inscritosDataGridViewTextBoxColumn.HeaderText = "Inscritos";
            this.inscritosDataGridViewTextBoxColumn.Name = "inscritosDataGridViewTextBoxColumn";
            this.inscritosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actividadBindingSource
            // 
            this.actividadBindingSource.DataMember = "Actividad";
            this.actividadBindingSource.DataSource = this.marillacDataSet;
            // 
            // actividadTableAdapter
            // 
            this.actividadTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(538, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dar de Alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(538, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AltaActividadBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 441);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaActividadBeneficiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Actividad para un Beneficiario";
            this.Load += new System.EventHandler(this.AltaActividadBeneficiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beneficiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MarillacDataSet marillacDataSet;
        private System.Windows.Forms.BindingSource beneficiarioBindingSource;
        private MarillacDataSetTableAdapters.BeneficiarioTableAdapter beneficiarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBeneficiarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource actividadBindingSource;
        private MarillacDataSetTableAdapters.ActividadTableAdapter actividadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreActividadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasImparteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscritosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}