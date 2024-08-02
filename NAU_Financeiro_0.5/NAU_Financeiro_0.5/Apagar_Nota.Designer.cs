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
            this.btnSair = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.EntradaValor = new System.Windows.Forms.NumericUpDown();
            this.EntradaSetor = new System.Windows.Forms.ComboBox();
            this.EntradaData = new System.Windows.Forms.DateTimePicker();
            this.EntradaRazao = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblValor = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.LblSetor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblRazao = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.TxtTipoNota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.EntradaComplemento = new System.Windows.Forms.TextBox();
            this.EntradaNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.Location = new System.Drawing.Point(10, 102);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 38);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnApagar.Location = new System.Drawing.Point(10, 102);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(130, 38);
            this.BtnApagar.TabIndex = 2;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // EntradaValor
            // 
            this.EntradaValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaValor.DecimalPlaces = 2;
            this.EntradaValor.Location = new System.Drawing.Point(285, 330);
            this.EntradaValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EntradaValor.Name = "EntradaValor";
            this.EntradaValor.Size = new System.Drawing.Size(173, 26);
            this.EntradaValor.TabIndex = 7;
            this.EntradaValor.TabStop = false;
            this.EntradaValor.ThousandsSeparator = true;
            // 
            // EntradaSetor
            // 
            this.EntradaSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaSetor.FormattingEnabled = true;
            this.EntradaSetor.Items.AddRange(new object[] {
            "Água e Esgoto",
            "Alimentação",
            "Aluguéis IPTU-FORO",
            "Assistência Contábil",
            "Assistência Médica URMES",
            "Aulas Extracurriculares",
            "Combustíveis - Locomoção",
            "Contribuições Sindicais",
            "Despesas Diversas",
            "Energia Elétrica",
            "FGTS",
            "Folha de Pagamento",
            "Gás",
            "GPS",
            "Limpeza e Higienização",
            "Manutenção",
            "Papelaria",
            "Telefonia e Informática",
            "Tributos Refis",
            "Tributos Simples",
            "Vale Transportes"});
            this.EntradaSetor.Location = new System.Drawing.Point(285, 243);
            this.EntradaSetor.Name = "EntradaSetor";
            this.EntradaSetor.Size = new System.Drawing.Size(458, 28);
            this.EntradaSetor.TabIndex = 5;
            this.EntradaSetor.TabStop = false;
            // 
            // EntradaData
            // 
            this.EntradaData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaData.Checked = false;
            this.EntradaData.CustomFormat = "dd/MM/yyyy";
            this.EntradaData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EntradaData.Location = new System.Drawing.Point(285, 108);
            this.EntradaData.Name = "EntradaData";
            this.EntradaData.Size = new System.Drawing.Size(173, 26);
            this.EntradaData.TabIndex = 10;
            this.EntradaData.TabStop = false;
            // 
            // EntradaRazao
            // 
            this.EntradaRazao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EntradaRazao.Location = new System.Drawing.Point(285, 152);
            this.EntradaRazao.Name = "EntradaRazao";
            this.EntradaRazao.Size = new System.Drawing.Size(458, 26);
            this.EntradaRazao.TabIndex = 0;
            this.EntradaRazao.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(916, 170);
            this.panel1.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(756, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(150, 150);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnApagar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::NAU_Financeiro_0._5.Properties.Resources.NAU_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(361, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.LblValor, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.EntradaValor, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.EntradaSetor, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblSetor, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.EntradaRazao, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EntradaData, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblRazao, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblData, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtTipoNota, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EntradaComplemento, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.EntradaNumero, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 379);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // LblValor
            // 
            this.LblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(215, 331);
            this.LblValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(59, 24);
            this.LblValor.TabIndex = 20;
            this.LblValor.Text = "Valor:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown1.Location = new System.Drawing.Point(285, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(173, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Complemento:";
            // 
            // LblSetor
            // 
            this.LblSetor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblSetor.AutoSize = true;
            this.LblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetor.Location = new System.Drawing.Point(215, 241);
            this.LblSetor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSetor.Name = "LblSetor";
            this.LblSetor.Size = new System.Drawing.Size(59, 24);
            this.LblSetor.TabIndex = 21;
            this.LblSetor.Text = "Setor:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número da Nota:";
            // 
            // LblRazao
            // 
            this.LblRazao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblRazao.AutoSize = true;
            this.LblRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazao.Location = new System.Drawing.Point(150, 153);
            this.LblRazao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblRazao.Name = "LblRazao";
            this.LblRazao.Size = new System.Drawing.Size(124, 24);
            this.LblRazao.TabIndex = 22;
            this.LblRazao.Text = "Razão Social:";
            // 
            // LblData
            // 
            this.LblData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(222, 109);
            this.LblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(52, 24);
            this.LblData.TabIndex = 24;
            this.LblData.Text = "Data:";
            // 
            // TxtTipoNota
            // 
            this.TxtTipoNota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtTipoNota.AutoSize = true;
            this.TxtTipoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoNota.Location = new System.Drawing.Point(287, 65);
            this.TxtTipoNota.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TxtTipoNota.Name = "TxtTipoNota";
            this.TxtTipoNota.Size = new System.Drawing.Size(63, 24);
            this.TxtTipoNota.TabIndex = 24;
            this.TxtTipoNota.Text = "Boleto";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tipo de Nota:";
            // 
            // LblID
            // 
            this.LblID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(242, 21);
            this.LblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(32, 24);
            this.LblID.TabIndex = 23;
            this.LblID.Text = "ID:";
            // 
            // EntradaComplemento
            // 
            this.EntradaComplemento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EntradaComplemento.Location = new System.Drawing.Point(285, 284);
            this.EntradaComplemento.Name = "EntradaComplemento";
            this.EntradaComplemento.Size = new System.Drawing.Size(458, 26);
            this.EntradaComplemento.TabIndex = 6;
            this.EntradaComplemento.TabStop = false;
            // 
            // EntradaNumero
            // 
            this.EntradaNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EntradaNumero.Location = new System.Drawing.Point(285, 196);
            this.EntradaNumero.Name = "EntradaNumero";
            this.EntradaNumero.Size = new System.Drawing.Size(458, 26);
            this.EntradaNumero.TabIndex = 4;
            this.EntradaNumero.TabStop = false;
            // 
            // Apagar_Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Apagar_Nota";
            this.Text = "Apagar_Nota";
            this.Load += new System.EventHandler(this.Apagar_Nota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.NumericUpDown EntradaValor;
        private System.Windows.Forms.ComboBox EntradaSetor;
        private System.Windows.Forms.DateTimePicker EntradaData;
        private System.Windows.Forms.TextBox EntradaRazao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblSetor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblRazao;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label TxtTipoNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox EntradaComplemento;
        private System.Windows.Forms.TextBox EntradaNumero;
    }
}