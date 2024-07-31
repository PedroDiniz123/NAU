namespace NAU_Financeiro_0._5
{
    partial class Adicionar_Nota
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar_Nota));
            this.LblData = new System.Windows.Forms.Label();
            this.LblRazao = new System.Windows.Forms.Label();
            this.LblSetor = new System.Windows.Forms.Label();
            this.LblValor = new System.Windows.Forms.Label();
            this.EntradaRazao = new System.Windows.Forms.TextBox();
            this.EntradaData = new System.Windows.Forms.DateTimePicker();
            this.EntradaSetor = new System.Windows.Forms.ComboBox();
            this.EntradaValor = new System.Windows.Forms.NumericUpDown();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblData
            // 
            this.LblData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(208, 260);
            this.LblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(52, 24);
            this.LblData.TabIndex = 0;
            this.LblData.Text = "Data:";
            // 
            // LblRazao
            // 
            this.LblRazao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRazao.AutoSize = true;
            this.LblRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazao.Location = new System.Drawing.Point(208, 301);
            this.LblRazao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblRazao.Name = "LblRazao";
            this.LblRazao.Size = new System.Drawing.Size(124, 24);
            this.LblRazao.TabIndex = 0;
            this.LblRazao.Text = "Razão Social:";
            // 
            // LblSetor
            // 
            this.LblSetor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSetor.AutoSize = true;
            this.LblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetor.Location = new System.Drawing.Point(208, 341);
            this.LblSetor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSetor.Name = "LblSetor";
            this.LblSetor.Size = new System.Drawing.Size(59, 24);
            this.LblSetor.TabIndex = 0;
            this.LblSetor.Text = "Setor:";
            // 
            // LblValor
            // 
            this.LblValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(208, 381);
            this.LblValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(59, 24);
            this.LblValor.TabIndex = 0;
            this.LblValor.Text = "Valor:";
            // 
            // EntradaRazao
            // 
            this.EntradaRazao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EntradaRazao.Location = new System.Drawing.Point(428, 301);
            this.EntradaRazao.Name = "EntradaRazao";
            this.EntradaRazao.Size = new System.Drawing.Size(291, 26);
            this.EntradaRazao.TabIndex = 2;
            // 
            // EntradaData
            // 
            this.EntradaData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaData.Checked = false;
            this.EntradaData.CustomFormat = "dd/MM/yyyy";
            this.EntradaData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EntradaData.Location = new System.Drawing.Point(428, 260);
            this.EntradaData.Name = "EntradaData";
            this.EntradaData.Size = new System.Drawing.Size(291, 26);
            this.EntradaData.TabIndex = 1;
            // 
            // EntradaSetor
            // 
            this.EntradaSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaSetor.FormattingEnabled = true;
            this.EntradaSetor.Items.AddRange(new object[] {
            "Teste 1",
            "Teste 2"});
            this.EntradaSetor.Location = new System.Drawing.Point(428, 341);
            this.EntradaSetor.Name = "EntradaSetor";
            this.EntradaSetor.Size = new System.Drawing.Size(291, 28);
            this.EntradaSetor.TabIndex = 3;
            // 
            // EntradaValor
            // 
            this.EntradaValor.DecimalPlaces = 2;
            this.EntradaValor.Location = new System.Drawing.Point(428, 382);
            this.EntradaValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EntradaValor.Name = "EntradaValor";
            this.EntradaValor.Size = new System.Drawing.Size(291, 26);
            this.EntradaValor.TabIndex = 4;
            this.EntradaValor.ThousandsSeparator = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(627, 439);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(92, 38);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(529, 439);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 38);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NAU_Financeiro_0._5.Properties.Resources.NAU_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(339, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Adicionar_Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(916, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.EntradaValor);
            this.Controls.Add(this.EntradaSetor);
            this.Controls.Add(this.EntradaData);
            this.Controls.Add(this.EntradaRazao);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.LblSetor);
            this.Controls.Add(this.LblRazao);
            this.Controls.Add(this.LblData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Adicionar_Nota";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblRazao;
        private System.Windows.Forms.Label LblSetor;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox EntradaRazao;
        private System.Windows.Forms.DateTimePicker EntradaData;
        private System.Windows.Forms.ComboBox EntradaSetor;
        private System.Windows.Forms.NumericUpDown EntradaValor;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

