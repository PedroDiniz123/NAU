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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EntradaNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EntradaComplemento = new System.Windows.Forms.TextBox();
            this.BtnNota = new System.Windows.Forms.RadioButton();
            this.BtnRecibo = new System.Windows.Forms.RadioButton();
            this.BtnBoleto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblData
            // 
            this.LblData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(229, 74);
            this.LblData.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(52, 24);
            this.LblData.TabIndex = 0;
            this.LblData.Text = "Data:";
            // 
            // LblRazao
            // 
            this.LblRazao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblRazao.AutoSize = true;
            this.LblRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazao.Location = new System.Drawing.Point(157, 124);
            this.LblRazao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblRazao.Name = "LblRazao";
            this.LblRazao.Size = new System.Drawing.Size(124, 24);
            this.LblRazao.TabIndex = 0;
            this.LblRazao.Text = "Razão Social:";
            // 
            // LblSetor
            // 
            this.LblSetor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblSetor.AutoSize = true;
            this.LblSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetor.Location = new System.Drawing.Point(222, 224);
            this.LblSetor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblSetor.Name = "LblSetor";
            this.LblSetor.Size = new System.Drawing.Size(59, 24);
            this.LblSetor.TabIndex = 0;
            this.LblSetor.Text = "Setor:";
            // 
            // LblValor
            // 
            this.LblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor.Location = new System.Drawing.Point(147, 274);
            this.LblValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(134, 24);
            this.LblValor.TabIndex = 0;
            this.LblValor.Text = "Complemento:";
            // 
            // EntradaRazao
            // 
            this.EntradaRazao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EntradaRazao.Location = new System.Drawing.Point(292, 123);
            this.EntradaRazao.Name = "EntradaRazao";
            this.EntradaRazao.Size = new System.Drawing.Size(458, 26);
            this.EntradaRazao.TabIndex = 5;
            // 
            // EntradaData
            // 
            this.EntradaData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaData.Checked = false;
            this.EntradaData.CustomFormat = "dd/MM/yyyy";
            this.EntradaData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EntradaData.Location = new System.Drawing.Point(292, 73);
            this.EntradaData.Name = "EntradaData";
            this.EntradaData.Size = new System.Drawing.Size(173, 26);
            this.EntradaData.TabIndex = 4;
            // 
            // EntradaSetor
            // 
            this.EntradaSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaSetor.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.EntradaSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.EntradaSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.EntradaSetor.Location = new System.Drawing.Point(292, 222);
            this.EntradaSetor.Name = "EntradaSetor";
            this.EntradaSetor.Size = new System.Drawing.Size(458, 28);
            this.EntradaSetor.Sorted = true;
            this.EntradaSetor.TabIndex = 7;
            // 
            // EntradaValor
            // 
            this.EntradaValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaValor.DecimalPlaces = 2;
            this.EntradaValor.Location = new System.Drawing.Point(292, 326);
            this.EntradaValor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EntradaValor.Name = "EntradaValor";
            this.EntradaValor.Size = new System.Drawing.Size(173, 26);
            this.EntradaValor.TabIndex = 9;
            this.EntradaValor.ThousandsSeparator = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAdd.Location = new System.Drawing.Point(10, 99);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(130, 41);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.Location = new System.Drawing.Point(10, 102);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 38);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::NAU_Financeiro_0._5.Properties.Resources.NAU_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(373, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.panel1.Size = new System.Drawing.Size(941, 170);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(781, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(150, 150);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 400);
            this.panel4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da Nota:";
            // 
            // EntradaNumero
            // 
            this.EntradaNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EntradaNumero.Location = new System.Drawing.Point(292, 173);
            this.EntradaNumero.Name = "EntradaNumero";
            this.EntradaNumero.Size = new System.Drawing.Size(458, 26);
            this.EntradaNumero.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de Nota:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblRazao, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EntradaNumero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.EntradaSetor, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblSetor, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblValor, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.EntradaRazao, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EntradaData, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.EntradaValor, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.EntradaComplemento, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 379);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnNota);
            this.panel5.Controls.Add(this.BtnRecibo);
            this.panel5.Controls.Add(this.BtnBoleto);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(292, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(322, 41);
            this.panel5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor:";
            // 
            // EntradaComplemento
            // 
            this.EntradaComplemento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EntradaComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EntradaComplemento.Location = new System.Drawing.Point(292, 273);
            this.EntradaComplemento.Name = "EntradaComplemento";
            this.EntradaComplemento.Size = new System.Drawing.Size(458, 26);
            this.EntradaComplemento.TabIndex = 8;
            // 
            // BtnNota
            // 
            this.BtnNota.AutoSize = true;
            this.BtnNota.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnNota.Location = new System.Drawing.Point(0, 0);
            this.BtnNota.Name = "BtnNota";
            this.BtnNota.Size = new System.Drawing.Size(106, 41);
            this.BtnNota.TabIndex = 1;
            this.BtnNota.TabStop = true;
            this.BtnNota.Text = "Nota Fiscal";
            this.BtnNota.UseVisualStyleBackColor = true;
            // 
            // BtnRecibo
            // 
            this.BtnRecibo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnRecibo.AutoSize = true;
            this.BtnRecibo.Location = new System.Drawing.Point(130, 8);
            this.BtnRecibo.Name = "BtnRecibo";
            this.BtnRecibo.Size = new System.Drawing.Size(77, 24);
            this.BtnRecibo.TabIndex = 2;
            this.BtnRecibo.TabStop = true;
            this.BtnRecibo.Text = "Recibo";
            this.BtnRecibo.UseVisualStyleBackColor = true;
            // 
            // BtnBoleto
            // 
            this.BtnBoleto.AutoSize = true;
            this.BtnBoleto.Checked = true;
            this.BtnBoleto.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBoleto.Location = new System.Drawing.Point(249, 0);
            this.BtnBoleto.Name = "BtnBoleto";
            this.BtnBoleto.Size = new System.Drawing.Size(73, 41);
            this.BtnBoleto.TabIndex = 3;
            this.BtnBoleto.TabStop = true;
            this.BtnBoleto.Text = "Boleto";
            this.BtnBoleto.UseVisualStyleBackColor = true;
            // 
            // Adicionar_Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(941, 570);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Adicionar_Nota";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EntradaValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox EntradaNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EntradaComplemento;
        private System.Windows.Forms.RadioButton BtnNota;
        private System.Windows.Forms.RadioButton BtnRecibo;
        private System.Windows.Forms.RadioButton BtnBoleto;
    }
}

