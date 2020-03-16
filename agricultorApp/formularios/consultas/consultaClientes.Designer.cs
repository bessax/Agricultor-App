namespace agricultorApp.formularios.consultas
{
    partial class consultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaClientes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agricultorDataSet = new agricultorApp.AgricultorDataSet();
            this.ClientesTableAdapter = new agricultorApp.AgricultorDataSetTableAdapters.CLIENTESTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cODCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMERAZAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cPFCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEFIXODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONECELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agricultorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCLIENTEDataGridViewTextBoxColumn,
            this.nOMERAZAODataGridViewTextBoxColumn,
            this.sTATUSDataGridViewCheckBoxColumn,
            this.cPFCNPJDataGridViewTextBoxColumn,
            this.tELEFONEFIXODataGridViewTextBoxColumn,
            this.tELEFONECELDataGridViewTextBoxColumn,
            this.eNDERECODataGridViewTextBoxColumn,
            this.cIDADEDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ClientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1102, 163);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "CLIENTES";
            this.ClientesBindingSource.DataSource = this.agricultorDataSet;
            // 
            // agricultorDataSet
            // 
            this.agricultorDataSet.DataSetName = "AgricultorDataSet";
            this.agricultorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientesTableAdapter
            // 
            this.ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Image = global::agricultorApp.Properties.Resources.button_ok;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(822, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::agricultorApp.Properties.Resources.button_cancel;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(966, 172);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cODCLIENTEDataGridViewTextBoxColumn
            // 
            this.cODCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "COD_CLIENTE";
            this.cODCLIENTEDataGridViewTextBoxColumn.HeaderText = "COD_CLIENTE";
            this.cODCLIENTEDataGridViewTextBoxColumn.Name = "cODCLIENTEDataGridViewTextBoxColumn";
            this.cODCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCLIENTEDataGridViewTextBoxColumn.Width = 50;
            // 
            // nOMERAZAODataGridViewTextBoxColumn
            // 
            this.nOMERAZAODataGridViewTextBoxColumn.DataPropertyName = "NOME_RAZAO";
            this.nOMERAZAODataGridViewTextBoxColumn.HeaderText = "NOME_RAZAO";
            this.nOMERAZAODataGridViewTextBoxColumn.Name = "nOMERAZAODataGridViewTextBoxColumn";
            this.nOMERAZAODataGridViewTextBoxColumn.Width = 200;
            // 
            // sTATUSDataGridViewCheckBoxColumn
            // 
            this.sTATUSDataGridViewCheckBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.Name = "sTATUSDataGridViewCheckBoxColumn";
            this.sTATUSDataGridViewCheckBoxColumn.Width = 50;
            // 
            // cPFCNPJDataGridViewTextBoxColumn
            // 
            this.cPFCNPJDataGridViewTextBoxColumn.DataPropertyName = "CPF_CNPJ";
            this.cPFCNPJDataGridViewTextBoxColumn.HeaderText = "CPF_CNPJ";
            this.cPFCNPJDataGridViewTextBoxColumn.Name = "cPFCNPJDataGridViewTextBoxColumn";
            this.cPFCNPJDataGridViewTextBoxColumn.Width = 150;
            // 
            // tELEFONEFIXODataGridViewTextBoxColumn
            // 
            this.tELEFONEFIXODataGridViewTextBoxColumn.DataPropertyName = "TELEFONE_FIXO";
            this.tELEFONEFIXODataGridViewTextBoxColumn.HeaderText = "TELEFONE_FIXO";
            this.tELEFONEFIXODataGridViewTextBoxColumn.Name = "tELEFONEFIXODataGridViewTextBoxColumn";
            // 
            // tELEFONECELDataGridViewTextBoxColumn
            // 
            this.tELEFONECELDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE_CEL";
            this.tELEFONECELDataGridViewTextBoxColumn.HeaderText = "TELEFONE_CEL";
            this.tELEFONECELDataGridViewTextBoxColumn.Name = "tELEFONECELDataGridViewTextBoxColumn";
            // 
            // eNDERECODataGridViewTextBoxColumn
            // 
            this.eNDERECODataGridViewTextBoxColumn.DataPropertyName = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.HeaderText = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.Name = "eNDERECODataGridViewTextBoxColumn";
            this.eNDERECODataGridViewTextBoxColumn.Width = 200;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            this.cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // consultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 206);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "consultaClientes";
            this.Text = "AgricultorApp [Consulta de Clientes]";
            this.Load += new System.EventHandler(this.consultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agricultorDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AgricultorDataSet agricultorDataSet;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private AgricultorDataSetTableAdapters.CLIENTESTableAdapter ClientesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMERAZAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATUSDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEFIXODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONECELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
    }
}