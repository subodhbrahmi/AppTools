namespace ReadData_BPMRD
{
    partial class Network_Operation_Metrics
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new ReadData_BPMRD.DataSet1();
            this.bPMMETRICSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bPMMETRICSTableAdapter = new ReadData_BPMRD.DataSet1TableAdapters.BPMMETRICSTableAdapter();
            this.pROJECTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALLSREDUCEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMARTCHATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRJSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRKGRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROJECTMONTHYEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPMMETRICSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(366, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add Records";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(538, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Update Records";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROJECTNAMEDataGridViewTextBoxColumn,
            this.cALLSREDUCEDDataGridViewTextBoxColumn,
            this.sMARTCHATDataGridViewTextBoxColumn,
            this.tTKTDataGridViewTextBoxColumn,
            this.pRJSTATUSDataGridViewTextBoxColumn,
            this.wRKGRPDataGridViewTextBoxColumn,
            this.PROJECTMONTHYEAR});
            this.dataGridView1.DataSource = this.bPMMETRICSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(91, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 427);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bPMMETRICSBindingSource
            // 
            this.bPMMETRICSBindingSource.DataMember = "BPMMETRICS";
            this.bPMMETRICSBindingSource.DataSource = this.dataSet1;
            // 
            // bPMMETRICSTableAdapter
            // 
            this.bPMMETRICSTableAdapter.ClearBeforeFill = true;
            // 
            // pROJECTNAMEDataGridViewTextBoxColumn
            // 
            this.pROJECTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROJECT_NAME";
            this.pROJECTNAMEDataGridViewTextBoxColumn.HeaderText = "PROJECT_NAME";
            this.pROJECTNAMEDataGridViewTextBoxColumn.Name = "pROJECTNAMEDataGridViewTextBoxColumn";
            // 
            // cALLSREDUCEDDataGridViewTextBoxColumn
            // 
            this.cALLSREDUCEDDataGridViewTextBoxColumn.DataPropertyName = "CALLSREDUCED";
            this.cALLSREDUCEDDataGridViewTextBoxColumn.HeaderText = "CALLSREDUCED";
            this.cALLSREDUCEDDataGridViewTextBoxColumn.Name = "cALLSREDUCEDDataGridViewTextBoxColumn";
            // 
            // sMARTCHATDataGridViewTextBoxColumn
            // 
            this.sMARTCHATDataGridViewTextBoxColumn.DataPropertyName = "SMARTCHAT";
            this.sMARTCHATDataGridViewTextBoxColumn.HeaderText = "SMARTCHAT";
            this.sMARTCHATDataGridViewTextBoxColumn.Name = "sMARTCHATDataGridViewTextBoxColumn";
            // 
            // tTKTDataGridViewTextBoxColumn
            // 
            this.tTKTDataGridViewTextBoxColumn.DataPropertyName = "TTKT";
            this.tTKTDataGridViewTextBoxColumn.HeaderText = "DISPATCHES";
            this.tTKTDataGridViewTextBoxColumn.Name = "tTKTDataGridViewTextBoxColumn";
            // 
            // pRJSTATUSDataGridViewTextBoxColumn
            // 
            this.pRJSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PRJ_STATUS";
            this.pRJSTATUSDataGridViewTextBoxColumn.HeaderText = "PRJ_STATUS";
            this.pRJSTATUSDataGridViewTextBoxColumn.Name = "pRJSTATUSDataGridViewTextBoxColumn";
            // 
            // wRKGRPDataGridViewTextBoxColumn
            // 
            this.wRKGRPDataGridViewTextBoxColumn.DataPropertyName = "WRKGRP";
            this.wRKGRPDataGridViewTextBoxColumn.HeaderText = "WRKGRP";
            this.wRKGRPDataGridViewTextBoxColumn.Name = "wRKGRPDataGridViewTextBoxColumn";
            // 
            // PROJECTMONTHYEAR
            // 
            this.PROJECTMONTHYEAR.DataPropertyName = "PROJECTMONTHYEAR";
            this.PROJECTMONTHYEAR.HeaderText = "MONTH";
            this.PROJECTMONTHYEAR.Name = "PROJECTMONTHYEAR";
            // 
            // Network_Operation_Metrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 733);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Network_Operation_Metrics";
            this.Text = "DDR_ProjectMetrics";
            this.Load += new System.EventHandler(this.Network_Operation_Metrics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPMMETRICSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bPMMETRICSBindingSource;
        private DataSet1TableAdapters.BPMMETRICSTableAdapter bPMMETRICSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALLSREDUCEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMARTCHATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRJSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRKGRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROJECTMONTHYEAR;
    }
}