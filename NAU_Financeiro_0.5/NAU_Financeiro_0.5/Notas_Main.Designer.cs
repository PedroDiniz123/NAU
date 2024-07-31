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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas_Main));
            this.NotasView = new System.Windows.Forms.DataGridView();
            this.EntradaPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.BtnNova = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NotasView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NotasView
            // 
            this.NotasView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotasView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.NotasView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.NotasView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotasView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NotasView.Location = new System.Drawing.Point(0, 203);
            this.NotasView.Margin = new System.Windows.Forms.Padding(6);
            this.NotasView.Name = "NotasView";
            this.NotasView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotasView.Size = new System.Drawing.Size(1467, 627);
            this.NotasView.TabIndex = 5;
            // 
            // EntradaPesquisar
            // 
            this.EntradaPesquisar.Location = new System.Drawing.Point(936, 167);
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
            this.lblPesquisar.Location = new System.Drawing.Point(830, 170);
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
            this.label1.Location = new System.Drawing.Point(1272, 170);
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
            this.lblSoma.Location = new System.Drawing.Point(1337, 170);
            this.lblSoma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(49, 24);
            this.lblSoma.TabIndex = 7;
            this.lblSoma.Text = "0,00";
            this.lblSoma.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSoma.Click += new System.EventHandler(this.label1_Click);
            // 
            // Notas_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1467, 830);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnNova);
            this.Controls.Add(this.EntradaPesquisar);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.NotasView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Notas_Main";
            this.Text = "NAU Financeiro";
            this.Load += new System.EventHandler(this.Notas_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotasView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NotasView;
        private System.Windows.Forms.TextBox EntradaPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button BtnNova;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoma;
    }
}