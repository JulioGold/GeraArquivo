namespace GeraArquivo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.nudTamanho = new System.Windows.Forms.NumericUpDown();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.cboEscala = new System.Windows.Forms.ComboBox();
            this.lblEscala = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnCaminho = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.lblDescricaoTamanho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // nudTamanho
            // 
            this.nudTamanho.Location = new System.Drawing.Point(15, 25);
            this.nudTamanho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTamanho.Name = "nudTamanho";
            this.nudTamanho.Size = new System.Drawing.Size(120, 20);
            this.nudTamanho.TabIndex = 0;
            this.nudTamanho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTamanho.ValueChanged += new System.EventHandler(this.nudTamanho_ValueChanged);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(12, 9);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(52, 13);
            this.lblTamanho.TabIndex = 1;
            this.lblTamanho.Text = "Tamanho";
            // 
            // cboEscala
            // 
            this.cboEscala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEscala.FormattingEnabled = true;
            this.cboEscala.Items.AddRange(new object[] {
            "byte",
            "Kbyte",
            "Mbyte",
            "Gbyte"});
            this.cboEscala.Location = new System.Drawing.Point(151, 24);
            this.cboEscala.Name = "cboEscala";
            this.cboEscala.Size = new System.Drawing.Size(121, 21);
            this.cboEscala.TabIndex = 2;
            this.cboEscala.SelectedIndexChanged += new System.EventHandler(this.cboEscala_SelectedIndexChanged);
            // 
            // lblEscala
            // 
            this.lblEscala.AutoSize = true;
            this.lblEscala.Location = new System.Drawing.Point(148, 8);
            this.lblEscala.Name = "lblEscala";
            this.lblEscala.Size = new System.Drawing.Size(39, 13);
            this.lblEscala.TabIndex = 3;
            this.lblEscala.Text = "Escala";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(197, 138);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(15, 100);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(228, 20);
            this.txtCaminho.TabIndex = 5;
            this.txtCaminho.Text = "C:\\temp\\temp.txt";
            // 
            // btnCaminho
            // 
            this.btnCaminho.Location = new System.Drawing.Point(249, 97);
            this.btnCaminho.Name = "btnCaminho";
            this.btnCaminho.Size = new System.Drawing.Size(23, 23);
            this.btnCaminho.TabIndex = 6;
            this.btnCaminho.Text = "...";
            this.btnCaminho.UseVisualStyleBackColor = true;
            this.btnCaminho.Click += new System.EventHandler(this.btnCaminho_Click);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(12, 84);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(57, 13);
            this.lblCaminho.TabIndex = 7;
            this.lblCaminho.Text = "Salvar em:";
            // 
            // lblDescricaoTamanho
            // 
            this.lblDescricaoTamanho.AutoSize = true;
            this.lblDescricaoTamanho.Location = new System.Drawing.Point(12, 48);
            this.lblDescricaoTamanho.Name = "lblDescricaoTamanho";
            this.lblDescricaoTamanho.Size = new System.Drawing.Size(100, 13);
            this.lblDescricaoTamanho.TabIndex = 8;
            this.lblDescricaoTamanho.Text = "DescricaoTamanho";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.lblDescricaoTamanho);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.btnCaminho);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblEscala);
            this.Controls.Add(this.cboEscala);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.nudTamanho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gera arquivo";
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.ComboBox cboEscala;
        private System.Windows.Forms.Label lblEscala;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnCaminho;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Label lblDescricaoTamanho;

    }
}

