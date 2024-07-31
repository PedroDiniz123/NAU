namespace NAU_Financeiro_0._5
{
    partial class Apagar_Nota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apagar_Nota));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSair = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.EntradaValor = new System.Windows.Forms.NumericUpDown();
            this.EntradaSetor = new System.Windows.Forms.ComboBox();
            this.EntradaData = new System.Windows.Forms.DateTimePicker();
            this.EntradaRazao = new System.Windows.Forms.TextBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.LblSetor = new System.Windows.Forms.Label();
            this.LblRazao = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(423, 216);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(291, 26);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(524, 437);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 38);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Location = new System.Drawing.Point(622, 437);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(92, 38);
            this.BtnApagar.TabIndex = 18;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // EntradaValor
            // 
            this.EntradaValor.DecimalPlaces = 2;
            this.EntradaValor.Location = new System.Drawing.Point(423, 380);
            this.EntradaValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EntradaValor.Name = "EntradaValor";
            this.EntradaValor.Size = new System.Drawing.Size(291, 26);
            this.EntradaValor.TabIndex = 17;
            this.EntradaValor.ThousandsSeparator = true;
            // 
            // EntradaSetor
            // 
            this.EntradaSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaSetor.FormattingEnabled = true;
            this.EntradaSetor.Items.AddRange(new object[] {
            "Teste 1",
            "Teste 2"});
            this.EntradaSetor.Location = new System.Drawing.Point(423, 339);
            this.EntradaSetor.Name = "EntradaSetor";
            this.EntradaSetor.Size = new System.Drawing.Size(291, 28);
            this.EntradaSetor.TabIndex = 16;
            // 
            // EntradaData
            // 
            this.EntradaData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaData.Checked = false;
            this.EntradaData.CustomFormat = "dd/MM/yyyy";
            this.EntradaData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EntradaData.Location = new System.Drawing.Point(423, 258);
            this.EntradaData.Name = "EntradaData";
            this.EntradaData.Size = new System.Drawing.Size(291, 26);
            this.EntradaData.TabIndex = 14;
            // 
            // EntradaRazao
            // 
            this.EntradaRazao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EntradaRazao.Location = new System.Drawing.Point(423, 299);
            this.EntradaRazao.Name = "EntradaRazao";
            this.EntradaRazao.Size = new System.Drawing.Size(291, 26);
            this.EntradaRazao.TabIndex = 15;
            // 
            // LblValor
            // 
            this.LblValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(203, 379);
            this.LblValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(59, 24);
            this.LblValor.TabIndex = 20;
            this.LblValor.Text = "Valor:";
            // 
            // LblSetor
            // 
            this.LblSetor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSetor.AutoSize = true;
            this.LblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetor.Location = new System.Drawing.Point(203, 339);
            this.LblSetor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSetor.Name = "LblSetor";
            this.LblSetor.Size = new System.Drawing.Size(59, 24);
            this.LblSetor.TabIndex = 21;
            this.LblSetor.Text = "Setor:";
            // 
            // LblRazao
            // 
            this.LblRazao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRazao.AutoSize = true;
            this.LblRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazao.Location = new System.Drawing.Point(203, 299);
            this.LblRazao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblRazao.Name = "LblRazao";
            this.LblRazao.Size = new System.Drawing.Size(124, 24);
            this.LblRazao.TabIndex = 22;
            this.LblRazao.Text = "Razão Social:";
            // 
            // LblID
            // 
            this.LblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(203, 216);
            this.LblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(32, 24);
            this.LblID.TabIndex = 23;
            this.LblID.Text = "ID:";
            // 
            // LblData
            // 
            this.LblData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(203, 258);
            this.LblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(52, 24);
            this.LblData.TabIndex = 24;
            this.LblData.Text = "Data:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NAU_Financeiro_0._5.Properties.Resources.NAU_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(358, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Apagar_Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.EntradaValor);
            this.Controls.Add(this.EntradaSetor);
            this.Controls.Add(this.EntradaData);
            this.Controls.Add(this.EntradaRazao);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.LblSetor);
            this.Controls.Add(this.LblRazao);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Apagar_Nota";
            this.Text = "Apagar_Nota";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.NumericUpDown EntradaValor;
        private System.Windows.Forms.ComboBox EntradaSetor;
        private System.Windows.Forms.DateTimePicker EntradaData;
        private System.Windows.Forms.TextBox EntradaRazao;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label LblSetor;
        private System.Windows.Forms.Label LblRazao;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}