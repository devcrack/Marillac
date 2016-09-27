namespace WindowsFormsApplication1
{
    partial class F_Pacientes
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
            this.marillacDataSet1 = new WindowsFormsApplication1.MarillacDataSet();
            this.beneficiarioTableAdapter1 = new WindowsFormsApplication1.MarillacDataSetTableAdapters.BeneficiarioTableAdapter();
            this.hijoTableAdapter1 = new WindowsFormsApplication1.MarillacDataSetTableAdapters.HijoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btt_Atender = new System.Windows.Forms.Button();
            this.btt_Cancelar = new System.Windows.Forms.Button();
            this.btt_Decline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // marillacDataSet1
            // 
            this.marillacDataSet1.DataSetName = "MarillacDataSet";
            this.marillacDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beneficiarioTableAdapter1
            // 
            this.beneficiarioTableAdapter1.ClearBeforeFill = true;
            // 
            // hijoTableAdapter1
            // 
            this.hijoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(769, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacientes sin Atencion";
            // 
            // btt_Atender
            // 
            this.btt_Atender.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Atender.Location = new System.Drawing.Point(12, 245);
            this.btt_Atender.Name = "btt_Atender";
            this.btt_Atender.Size = new System.Drawing.Size(121, 33);
            this.btt_Atender.TabIndex = 2;
            this.btt_Atender.Text = "Atender";
            this.btt_Atender.UseVisualStyleBackColor = true;
            this.btt_Atender.Click += new System.EventHandler(this.btt_Atender_Click);
            // 
            // btt_Cancelar
            // 
            this.btt_Cancelar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Cancelar.Location = new System.Drawing.Point(660, 245);
            this.btt_Cancelar.Name = "btt_Cancelar";
            this.btt_Cancelar.Size = new System.Drawing.Size(121, 33);
            this.btt_Cancelar.TabIndex = 2;
            this.btt_Cancelar.Text = "Cancelar";
            this.btt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btt_Decline
            // 
            this.btt_Decline.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Decline.Location = new System.Drawing.Point(12, 245);
            this.btt_Decline.Name = "btt_Decline";
            this.btt_Decline.Size = new System.Drawing.Size(121, 33);
            this.btt_Decline.TabIndex = 3;
            this.btt_Decline.Text = "Declinar";
            this.btt_Decline.UseVisualStyleBackColor = true;
            this.btt_Decline.Click += new System.EventHandler(this.btt_Decline_Click);
            // 
            // F_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 290);
            this.Controls.Add(this.btt_Decline);
            this.Controls.Add(this.btt_Cancelar);
            this.Controls.Add(this.btt_Atender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "F_Pacientes";
            this.Load += new System.EventHandler(this.F_Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marillacDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MarillacDataSet marillacDataSet1;
        private MarillacDataSetTableAdapters.BeneficiarioTableAdapter beneficiarioTableAdapter1;
        private MarillacDataSetTableAdapters.HijoTableAdapter hijoTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btt_Atender;
        private System.Windows.Forms.Button btt_Cancelar;
        private System.Windows.Forms.Button btt_Decline;
    }
}