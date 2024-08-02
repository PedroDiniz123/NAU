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
            // TODO: esta linha de código carrega dados na tabela 'nAUDataSet1.TabelaNotas'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaNotasTableAdapter.Fill(this.nAUDataSet1.TabelaNotas);
           

            dataInicial = DataInicial.Value;
            dataFinal = DataFinal.Value;

            try
            {
                object sumObject;
                sumObject = this.tabelaNotasTableAdapter.GetData().Compute("Sum(valor)", string.Empty);
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
            this.tabelaNotasTableAdapter.Fill(this.nAUDataSet1.TabelaNotas);


            BindingSource bs = new BindingSource();
            bs.DataSource = NotasView.DataSource;
            bs.Filter = string.Format("CONVERT(" + NotasView.Columns[2].DataPropertyName + ", System.String) like ' % " + EntradaPesquisar.Text.Replace("'", "''") + "%'CONVERT(" + NotasView.Columns[2].DataPropertyName + ", System.String) like '%" + EntradaPesquisar.Text.Replace("'", "''") + "%' or CONVERT(" + NotasView.Columns[3].DataPropertyName + ", System.String) like '%" + EntradaPesquisar.Text.Replace("'", "''") + "%'");
            NotasView.DataSource = bs;

            try
            {
                int total = NotasView.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[4].Value));
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
            Atualizar_Nota atualizar_nota = new Atualizar_Nota();
            atualizar_nota.ShowDialog();
            AtualizarTabela();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Apagar_Nota apagar = new Apagar_Nota();
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
            this.tabelaNotasBindingSource.Sort = this.NotasView.SortString;
        }

        private void NotasView_FilterStringChanged(object sender, EventArgs e)
        {
            this.tabelaNotasBindingSource.Filter = this.NotasView.FilterString;
        }

        private void tabelaNotasBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {

        }
    }
}
