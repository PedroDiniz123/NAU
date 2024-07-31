namespace NAU_Financeiro_0._5
{
    partial class Atualizar_Nota
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
            this.logoNAU = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.EntradaValor = new System.Windows.Forms.NumericUpDown();
            this.EntradaSetor = new System.Windows.Forms.ComboBox();
            this.EntradaData = new System.Windows.Forms.DateTimePicker();
            this.EntradaRazao = new System.Windows.Forms.TextBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.LblSetor = new System.Windows.Forms.Label();
            this.LblRazao = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoNAU
            // 
            this.logoNAU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoNAU.AutoSize = true;
            this.logoNAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoNAU.Location = new System.Drawing.Point(379, 8);
            this.logoNAU.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.logoNAU.Name = "logoNAU";
            this.logoNAU.Size = new System.Drawing.Size(170, 73);
            this.logoNAU.TabIndex = 1;
            this.logoNAU.Text = "NAU";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(526, 437);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 38);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(624, 437);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(92, 38);
            this.BtnAtualizar.TabIndex = 6;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // EntradaValor
            // 
            this.EntradaValor.DecimalPlaces = 2;
            this.EntradaValor.Location = new System.Drawing.Point(425, 380);
            this.EntradaValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EntradaValor.Name = "EntradaValor";
            this.EntradaValor.Size = new System.Drawing.Size(291, 26);
            this.EntradaValor.TabIndex = 5;
            this.EntradaValor.ThousandsSeparator = true;
            // 
            // EntradaSetor
            // 
            this.EntradaSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaSetor.FormattingEnabled = true;
            this.EntradaSetor.Items.AddRange(new object[] {
            "Teste 1",
            "Teste 2"});
            this.EntradaSetor.Location = new System.Drawing.Point(425, 339);
            this.EntradaSetor.Name = "EntradaSetor";
            this.EntradaSetor.Size = new System.Drawing.Size(291, 28);
            this.EntradaSetor.TabIndex = 4;
            // 
            // EntradaData
            // 
            this.EntradaData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaData.Checked = false;
            this.EntradaData.CustomFormat = "dd/MM/yyyy";
            this.EntradaData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EntradaData.Location = new System.Drawing.Point(425, 258);
            this.EntradaData.Name = "EntradaData";
            this.EntradaData.Size = new System.Drawing.Size(291, 26);
            this.EntradaData.TabIndex = 2;
            // 
            // EntradaRazao
            // 
            this.EntradaRazao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EntradaRazao.Location = new System.Drawing.Point(425, 299);
            this.EntradaRazao.Name = "EntradaRazao";
            this.EntradaRazao.Size = new System.Drawing.Size(291, 26);
            this.EntradaRazao.TabIndex = 3;
            // 
            // LblValor
            // 
            this.LblValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(205, 379);
            this.LblValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(59, 24);
            this.LblValor.TabIndex = 8;
            this.LblValor.Text = "Valor:";
            // 
            // LblSetor
            // 
            this.LblSetor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSetor.AutoSize = true;
            this.LblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetor.Location = new System.Drawing.Point(205, 339);
            this.LblSetor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSetor.Name = "LblSetor";
            this.LblSetor.Size = new System.Drawing.Size(59, 24);
            this.LblSetor.TabIndex = 9;
            this.LblSetor.Text = "Setor:";
            // 
            // LblRazao
            // 
            this.LblRazao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRazao.AutoSize = true;
            this.LblRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazao.Location = new System.Drawing.Point(205, 299);
            this.LblRazao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblRazao.Name = "LblRazao";
            this.LblRazao.Size = new System.Drawing.Size(124, 24);
            this.LblRazao.TabIndex = 10;
            this.LblRazao.Text = "Razão Social:";
            // 
            // LblData
            // 
            this.LblData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(205, 258);
            this.LblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(52, 24);
            this.LblData.TabIndex = 11;
            this.LblData.Text = "Data:";
            // 
            // LblID
            // 
            this.LblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(205, 177);
            this.LblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(32, 24);
            this.LblID.TabIndex = 11;
            this.LblID.Text = "ID:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(425, 177);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(291, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Atualizar_Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 561);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.EntradaValor);
            this.Controls.Add(this.EntradaSetor);
            this.Controls.Add(this.EntradaData);
            this.Controls.Add(this.EntradaRazao);
            this.Controls.Add(this.LblValor);
            this.Controls.Add(this.LblSetor);
            this.Controls.Add(this.LblRazao);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.logoNAU);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Atualizar_Nota";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoNAU;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.NumericUpDown EntradaValor;
        private System.Windows.Forms.ComboBox EntradaSetor;
        private System.Windows.Forms.DateTimePicker EntradaData;
        private System.Windows.Forms.TextBox EntradaRazao;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label LblSetor;
        private System.Windows.Forms.Label LblRazao;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}