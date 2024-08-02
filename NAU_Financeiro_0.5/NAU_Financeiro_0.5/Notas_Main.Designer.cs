namespace NAU_Financeiro_0._5
{
    partial class Notas_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas_Main));
            this.EntradaPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.BtnNova = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataInicial = new System.Windows.Forms.DateTimePicker();
            this.DataFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.NotasView = new ADGV.AdvancedDataGridView();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAUDataSet3 = new NAU_Financeiro_0._5.NAUDataSet3();
            this.notasTableAdapter = new NAU_Financeiro_0._5.NAUDataSet3TableAdapters.NotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NotasView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAUDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // EntradaPesquisar
            // 
            this.EntradaPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EntradaPesquisar.Location = new System.Drawing.Point(622, 5);
            this.EntradaPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.EntradaPesquisar.Name = "EntradaPesquisar";
            this.EntradaPesquisar.Size = new System.Drawing.Size(292, 29);
            this.EntradaPesquisar.TabIndex = 3;
            this.EntradaPesquisar.TextChanged += new System.EventHandler(this.EntradaPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(515, 8);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(98, 24);
            this.lblPesquisar.TabIndex = 7;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // BtnNova
            // 
            this.BtnNova.Location = new System.Drawing.Point(24, 0);
            this.BtnNova.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNova.Name = "BtnNova";
            this.BtnNova.Size = new System.Drawing.Size(147, 37);
            this.BtnNova.TabIndex = 4;
            this.BtnNova.Text = "Nova Nota";
            this.BtnNova.UseVisualStyleBackColor = true;
            this.BtnNova.Click += new System.EventHandler(this.BtnNova_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(178, 0);
            this.BtnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(147, 37);
            this.BtnAtualizar.TabIndex = 5;
            this.BtnAtualizar.Text = "Atualizar Nota";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(328, 0);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(147, 37);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Apagar Nota";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(921, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Soma: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSoma
            // 
            this.lblSoma.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSoma.AutoSize = true;
            this.lblSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoma.ForeColor = System.Drawing.Color.Green;
            this.lblSoma.Location = new System.Drawing.Point(994, 8);
            this.lblSoma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(49, 24);
            this.lblSoma.TabIndex = 7;
            this.lblSoma.Text = "0,00";
            this.lblSoma.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSoma.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "e";
            // 
            // DataInicial
            // 
            this.DataInicial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataInicial.CustomFormat = "dd-MM-yyyy";
            this.DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataInicial.Location = new System.Drawing.Point(124, 50);
            this.DataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.Size = new System.Drawing.Size(112, 29);
            this.DataInicial.TabIndex = 1;
            this.DataInicial.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.DataInicial.ValueChanged += new System.EventHandler(this.DataInicial_ValueChanged);
            // 
            // DataFinal
            // 
            this.DataFinal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataFinal.CustomFormat = "dd-MM-yyyy";
            this.DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataFinal.Location = new System.Drawing.Point(274, 50);
            this.DataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.Size = new System.Drawing.Size(112, 29);
            this.DataFinal.TabIndex = 2;
            this.DataFinal.ValueChanged += new System.EventHandler(this.DataFinal_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entre";
            // 
            // NotasView
            // 
            this.NotasView.AllowUserToAddRows = false;
            this.NotasView.AllowUserToDeleteRows = false;
            this.NotasView.AutoGenerateColumns = false;
            this.NotasView.AutoGenerateContextFilters = true;
            this.NotasView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotasView.BackgroundColor = System.Drawing.Color.White;
            this.NotasView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotasView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.razaoDataGridViewTextBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.complemento,
            this.tipo,
            this.numero,
            this.valorDataGridViewTextBoxColumn});
            this.NotasView.DataSource = this.notasBindingSource;
            this.NotasView.DateWithTime = false;
            this.NotasView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotasView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.NotasView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NotasView.Location = new System.Drawing.Point(0, 0);
            this.NotasView.Margin = new System.Windows.Forms.Padding(4);
            this.NotasView.Name = "NotasView";
            this.NotasView.ReadOnly = true;
            this.NotasView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NotasView.ShowEditingIcon = false;
            this.NotasView.Size = new System.Drawing.Size(1122, 346);
            this.NotasView.TabIndex = 7;
            this.NotasView.TimeFilter = false;
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemento";
            this.complemento.HeaderText = "complemento";
            this.complemento.MinimumWidth = 22;
            this.complemento.Name = "complemento";
            this.complemento.ReadOnly = true;
            this.complemento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "tipo";
            this.tipo.MinimumWidth = 22;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "numero";
            this.numero.MinimumWidth = 22;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 167);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(722, 127);
            this.panel5.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::NAU_Financeiro_0._5.Properties.Resources.NAU_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(456, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.DataInicial);
            this.panel4.Controls.Add(this.DataFinal);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(722, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel4.Size = new System.Drawing.Size(400, 127);
            this.panel4.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnNova);
            this.panel3.Controls.Add(this.btnRemover);
            this.panel3.Controls.Add(this.BtnAtualizar);
            this.panel3.Controls.Add(this.lblPesquisar);
            this.panel3.Controls.Add(this.EntradaPesquisar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblSoma);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 127);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1122, 40);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NotasView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 167);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 346);
            this.panel2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // razaoDataGridViewTextBoxColumn
            // 
            this.razaoDataGridViewTextBoxColumn.DataPropertyName = "razao";
            this.razaoDataGridViewTextBoxColumn.HeaderText = "razao";
            this.razaoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.razaoDataGridViewTextBoxColumn.Name = "razaoDataGridViewTextBoxColumn";
            this.razaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // setorDataGridViewTextBoxColumn
            // 
            this.setorDataGridViewTextBoxColumn.DataPropertyName = "setor";
            this.setorDataGridViewTextBoxColumn.HeaderText = "setor";
            this.setorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            this.setorDataGridViewTextBoxColumn.ReadOnly = true;
            this.setorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.nAUDataSet3;
            // 
            // nAUDataSet3
            // 
            this.nAUDataSet3.DataSetName = "NAUDataSet3";
            this.nAUDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // Notas_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1122, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Notas_Main";
            this.Text = "NAU Financeiro";
            this.Load += new System.EventHandler(this.Notas_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotasView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAUDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox EntradaPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button BtnNova;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataInicial;
        private System.Windows.Forms.DateTimePicker DataFinal;
        private System.Windows.Forms.Label label4;
        private ADGV.AdvancedDataGridView NotasView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NAUDataSet3 nAUDataSet3;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private NAUDataSet3TableAdapters.NotasTableAdapter notasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}