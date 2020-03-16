namespace agricultorApp.formularios
{
    partial class manterClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manterClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbcel = new System.Windows.Forms.MaskedTextBox();
            this.lblcel = new System.Windows.Forms.Label();
            this.mtbtel = new System.Windows.Forms.MaskedTextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.txtcpfcnpj = new System.Windows.Forms.TextBox();
            this.lblcpfcnpj = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbcel);
            this.groupBox1.Controls.Add(this.lblcel);
            this.groupBox1.Controls.Add(this.mtbtel);
            this.groupBox1.Controls.Add(this.lbltel);
            this.groupBox1.Controls.Add(this.txtcpfcnpj);
            this.groupBox1.Controls.Add(this.lblcpfcnpj);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // mtbcel
            // 
            this.mtbcel.Location = new System.Drawing.Point(312, 118);
            this.mtbcel.Mask = "(99) 00000-0000";
            this.mtbcel.Name = "mtbcel";
            this.mtbcel.Size = new System.Drawing.Size(100, 23);
            this.mtbcel.TabIndex = 9;
            // 
            // lblcel
            // 
            this.lblcel.AutoSize = true;
            this.lblcel.Location = new System.Drawing.Point(261, 121);
            this.lblcel.Name = "lblcel";
            this.lblcel.Size = new System.Drawing.Size(45, 15);
            this.lblcel.TabIndex = 8;
            this.lblcel.Text = "Celular";
            // 
            // mtbtel
            // 
            this.mtbtel.Location = new System.Drawing.Point(139, 118);
            this.mtbtel.Mask = "(99) 0000-0000";
            this.mtbtel.Name = "mtbtel";
            this.mtbtel.Size = new System.Drawing.Size(100, 23);
            this.mtbtel.TabIndex = 7;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(79, 118);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(54, 15);
            this.lbltel.TabIndex = 6;
            this.lbltel.Text = "Telefone";
            // 
            // txtcpfcnpj
            // 
            this.txtcpfcnpj.Location = new System.Drawing.Point(139, 84);
            this.txtcpfcnpj.Name = "txtcpfcnpj";
            this.txtcpfcnpj.Size = new System.Drawing.Size(273, 23);
            this.txtcpfcnpj.TabIndex = 5;
            // 
            // lblcpfcnpj
            // 
            this.lblcpfcnpj.AutoSize = true;
            this.lblcpfcnpj.Location = new System.Drawing.Point(74, 92);
            this.lblcpfcnpj.Name = "lblcpfcnpj";
            this.lblcpfcnpj.Size = new System.Drawing.Size(59, 15);
            this.lblcpfcnpj.TabIndex = 4;
            this.lblcpfcnpj.Text = "CPF/CNPJ";
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(139, 55);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(454, 23);
            this.txtnome.TabIndex = 3;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(22, 58);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(111, 15);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome/Razão Social";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(139, 26);
            this.txtcodigo.MaxLength = 4;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(73, 23);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(89, 29);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(44, 15);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtuf);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtcidade);
            this.groupBox2.Controls.Add(this.lblcidade);
            this.groupBox2.Controls.Add(this.txtendereco);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço do Cliente";
            // 
            // txtuf
            // 
            this.txtuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtuf.Location = new System.Drawing.Point(599, 55);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(57, 23);
            this.txtuf.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "UF";
            // 
            // txtcidade
            // 
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcidade.Location = new System.Drawing.Point(139, 55);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(406, 23);
            this.txtcidade.TabIndex = 3;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(88, 55);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(44, 15);
            this.lblcidade.TabIndex = 2;
            this.lblcidade.Text = "Cidade";
            // 
            // txtendereco
            // 
            this.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendereco.Location = new System.Drawing.Point(139, 26);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(518, 23);
            this.txtendereco.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Logradouro";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(686, 61);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operações";
            // 
            // button1
            // 
            this.button1.Image = global::agricultorApp.Properties.Resources.button_cancel1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(553, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::agricultorApp.Properties.Resources.edit_add;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(428, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // manterClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 361);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "manterClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgricultorApp [Manutenção de Clientes]";
            this.Load += new System.EventHandler(this.manterClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbcel;
        private System.Windows.Forms.Label lblcel;
        private System.Windows.Forms.MaskedTextBox mtbtel;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox txtcpfcnpj;
        private System.Windows.Forms.Label lblcpfcnpj;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcodigo;

        public System.Windows.Forms.TextBox Txtcodigo
        {
            get { return txtcodigo; }
            set { txtcodigo = value; }
        }
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}