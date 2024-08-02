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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataInicial = new System.Windows.Forms.DateTimePicker();
            this.DataFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.NotasView = new ADGV.AdvancedDataGridView();
            this.nAUDataSet1 = new NAU_Financeiro_0._5.NAUDataSet1();
            this.tabelaNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaNotasTableAdapter = new NAU_Financeiro_0._5.NAUDataSet1TableAdapters.TabelaNotasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotasView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EntradaPesquisar
            // 
            this.EntradaPesquisar.Location = new System.Drawing.Point(982, 167);
            this.EntradaPesquisar.Name = "EntradaPesquisar";
            this.EntradaPesquisar.Size = new System.Drawing.Size(291, 29);
            this.EntradaPesquisar.TabIndex = 8;
            this.EntradaPesquisar.TextChanged += new System.EventHandler(this.EntradaPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(876, 167);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(98, 24);
            this.lblPesquisar.TabIndex = 7;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // BtnNova
            // 
            this.BtnNova.Location = new System.Drawing.Point(12, 157);
            this.BtnNova.Name = "BtnNova";
            this.BtnNova.Size = new System.Drawing.Size(147, 37);
            this.BtnNova.TabIndex = 10;
            this.BtnNova.Text = "Nova Nota";
            this.BtnNova.UseVisualStyleBackColor = true;
            this.BtnNova.Click += new System.EventHandler(this.BtnNova_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(165, 157);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(146, 37);
            this.BtnAtualizar.TabIndex = 11;
            this.BtnAtualizar.Text = "Atualizar Nota";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(317, 157);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(146, 37);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Apagar Nota";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::NAU_Financeiro_0._5.Properties.Resources.NAU_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(618, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1281, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.lblSoma.Location = new System.Drawing.Point(1351, 170);
            this.lblSoma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.label2.Location = new System.Drawing.Point(1012, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.label3.Location = new System.Drawing.Point(1258, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "e";
            // 
            // DataInicial
            // 
            this.DataInicial.CustomFormat = "dd/MM/yyyy";
            this.DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataInicial.Location = new System.Drawing.Point(1137, 22);
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.Size = new System.Drawing.Size(113, 29);
            this.DataInicial.TabIndex = 14;
            this.DataInicial.ValueChanged += new System.EventHandler(this.DataInicial_ValueChanged);
            // 
            // DataFinal
            // 
            this.DataFinal.CustomFormat = "dd/MM/yyyy";
            this.DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataFinal.Location = new System.Drawing.Point(1285, 22);
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.Size = new System.Drawing.Size(113, 29);
            this.DataFinal.TabIndex = 15;
            this.DataFinal.ValueChanged += new System.EventHandler(this.DataFinal_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1074, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entre";
            // 
            // NotasView
            // 
            this.NotasView.AllowUserToAddRows = false;
            this.NotasView.AllowUserToDeleteRows = false;
            this.NotasView.AllowUserToOrderColumns = true;
            this.NotasView.AllowUserToResizeColumns = false;
            this.NotasView.AllowUserToResizeRows = false;
            this.NotasView.AutoGenerateColumns = false;
            this.NotasView.AutoGenerateContextFilters = true;
            this.NotasView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotasView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotasView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.razaoDataGridViewTextBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.NotasView.DataSource = this.tabelaNotasBindingSource;
            this.NotasView.DateWithTime = false;
            this.NotasView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.NotasView.Location = new System.Drawing.Point(12, 200);
            this.NotasView.Name = "NotasView";
            this.NotasView.ReadOnly = true;
            this.NotasView.Size = new System.Drawing.Size(1443, 629);
            this.NotasView.TabIndex = 16;
            this.NotasView.TimeFilter = false;
            this.NotasView.SortStringChanged += new System.EventHandler(this.NotasView_SortStringChanged);
            this.NotasView.FilterStringChanged += new System.EventHandler(this.NotasView_FilterStringChanged);
            // 
            // nAUDataSet1
            // 
            this.nAUDataSet1.DataSetName = "NAUDataSet1";
            this.nAUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabelaNotasBindingSource
            // 
            this.tabelaNotasBindingSource.DataMember = "TabelaNotas";
            this.tabelaNotasBindingSource.DataSource = this.nAUDataSet1;
            this.tabelaNotasBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.tabelaNotasBindingSource_ListChanged);
            // 
            // tabelaNotasTableAdapter
            // 
            this.tabelaNotasTableAdapter.ClearBeforeFill = true;
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
            // Notas_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1467, 830);
            this.Controls.Add(this.NotasView);
            this.Controls.Add(this.DataFinal);
            this.Controls.Add(this.DataInicial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnNova);
            this.Controls.Add(this.EntradaPesquisar);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPesquisar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Notas_Main";
            this.Text = "NAU Financeiro";
            this.Load += new System.EventHandler(this.Notas_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotasView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNotasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EntradaPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button BtnNova;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataInicial;
        private System.Windows.Forms.DateTimePicker DataFinal;
        private System.Windows.Forms.Label label4;
        private ADGV.AdvancedDataGridView NotasView;
        private NAUDataSet1 nAUDataSet1;
        private System.Windows.Forms.BindingSource tabelaNotasBindingSource;
        private NAUDataSet1TableAdapters.TabelaNotasTableAdapter tabelaNotasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}