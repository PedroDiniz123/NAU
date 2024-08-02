using NAU_Financeiro_0._5.nauClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAU_Financeiro_0._5
{
    public partial class Notas_Main : Form
    {
        string usuario;
        public Notas_Main(string user)
        {
            InitializeComponent();
            usuario = user;
        }
        Nota nota = new Nota();
        DataTable dt;
        static string myconnstrng = ConfigurationManager.ConnectionStrings["NAU_Financeiro_0._5.Properties.Settings.NAU_FinanceiroConnectionString"].ConnectionString;
        
        DateTime dataInicial;
        DateTime dataFinal;

        private void Notas_Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nAUDataSet3.Notas' table. You can move, or remove it, as needed.
            this.notasTableAdapter.Fill(this.nAUDataSet3.Notas);
            DateTime now = DateTime.Now;
            DataFinal.Value = now;
            // TODO: esta linha de código carrega dados na tabela 'nAUDataSet2.TabelaNotas'. Você pode movê-la ou removê-la conforme necessário.
            //this.tabelaNotasTableAdapter1.Fill(this.nAUDataSet2.TabelaNotas);
            AtualizarTabela();
            //try
            //{
            //    this.tabelaNotasTableAdapter1.FillBy__(this.nAUDataSet2.TabelaNotas);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

            // TODO: esta linha de código carrega dados na tabela 'nAUDataSet1.TabelaNotas'. Você pode movê-la ou removê-la conforme necessário.
            //this.tabelaNotasTableAdapter.Fill(this.nAUDataSet1.TabelaNotas);


            dataInicial = DataInicial.Value;
            dataFinal = DataFinal.Value;

            try
            {
                object sumObject;
                sumObject = this.notasTableAdapter.GetData().Compute("Sum(valor)", string.Empty);
                lblSoma.Text = sumObject.ToString();
            } catch (Exception exception)
            {

            }
        }

        private void BtnNova_Click(object sender, EventArgs e)
        {
            Adicionar_Nota adicionar = new Adicionar_Nota();
            adicionar.ShowDialog();
            AtualizarTabela();


        }

        private void AtualizarTabela()
        {
            // string command = "SELECT * FROM TabelaNotas WHERE razao LIKE '%" + keyword + "%' OR setor LIKE '%" + keyword + "%';

            //if (EntradaPesquisar.Text != "")
            //{
            //    string keyword = EntradaPesquisar.Text;
            //    command = command + " AND ()";
            //}


            // SqlConnection conn = new SqlConnection(myconnstrng);
            // SqlDataAdapter sda = new SqlDataAdapter(command, conn);
            // DataTable dt = new DataTable();
            this.notasTableAdapter.Fill(this.nAUDataSet3.Notas);


            BindingSource bs = new BindingSource();
            bs.DataSource = NotasView.DataSource;
            bs.Filter = string.Format("data >= '" + DataInicial.Text + "' and  data <= '" + DataFinal.Text + "' and (razao like '%" + EntradaPesquisar.Text + "%' or setor like '%" + EntradaPesquisar.Text + "%' or complemento like '%" + EntradaPesquisar.Text + "%' or tipo like '%" + EntradaPesquisar.Text + "%')");
            NotasView.DataSource = bs;

            try
            {
                this.notasTableAdapter.FillBy1(this.nAUDataSet3.Notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            try
            {
                decimal total = NotasView.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells[7].Value));
                lblSoma.Text = total.ToString();
            }
            catch (Exception exception)
            {

            }

            //object sumObject;
            //sumObject = dt.Compute("Sum(valor)", string.Empty);
            //lblSoma.Text = sumObject.ToString();

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            int id = (int)NotasView.SelectedCells[0].Value;
            Atualizar_Nota atualizar_nota = new Atualizar_Nota(id);
            atualizar_nota.ShowDialog();
            AtualizarTabela();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int id = (int) NotasView.SelectedCells[0].Value;
            Apagar_Nota apagar = new Apagar_Nota(id);
            apagar.ShowDialog();
            AtualizarTabela();
        }

        private void EntradaPesquisar_TextChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataInicial_ValueChanged(object sender, EventArgs e)
        {
            dataInicial = DataInicial.Value;
            dataFinal = DataFinal.Value;

            if (dataInicial > dataFinal)
            {
                MessageBox.Show("Nota inicial maior que a final");
                DataInicial.Value = dataFinal;
            }
            AtualizarTabela();
        }

        private void DataFinal_ValueChanged(object sender, EventArgs e)
        {
            dataInicial = DataInicial.Value;
            dataFinal = DataFinal.Value;

            if (dataInicial > dataFinal)
            {
                MessageBox.Show("Nota inicial maior que a final");
                DataInicial.Value = dataFinal;
            }
            AtualizarTabela();
        }

        private void NotasView_SortStringChanged(object sender, EventArgs e)
        {
            this.notasBindingSource.Sort = this.NotasView.SortString;
        }

        private void NotasView_FilterStringChanged(object sender, EventArgs e)
        {
            this.notasBindingSource.Filter = this.NotasView.FilterString;
        }

        private void tabelaNotasBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notasTableAdapter.FillBy(this.nAUDataSet3.Notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notasTableAdapter.FillBy(this.nAUDataSet3.Notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy__ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.notasTableAdapter.FillBy(this.nAUDataSet3.Notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.notasTableAdapter.FillBy(this.nAUDataSet3.Notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy__ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.notasTableAdapter.FillBy(this.nAUDataSet3.Notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.notasTableAdapter.FillBy(this.nAUDataSet3.Notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.notasTableAdapter.FillBy1(this.nAUDataSet3.Notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
