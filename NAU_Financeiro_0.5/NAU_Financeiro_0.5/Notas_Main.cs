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

        private void Notas_Main_Load(object sender, EventArgs e)
        {
            //Load Data on Data GRidview
            DataTable dt = nota.Select();
            NotasView.DataSource = dt;

            object sumObject;
            sumObject = dt.Compute("Sum(valor)", string.Empty);
            lblSoma.Text = sumObject.ToString();
        }

        private void BtnNova_Click(object sender, EventArgs e)
        {
            Adicionar_Nota adicionar = new Adicionar_Nota();
            adicionar.ShowDialog();
            AtualizarTabela();


        }

        private void AtualizarTabela()
        {
            dt = nota.Select();
            NotasView.DataSource = dt;
            object sumObject;
            sumObject = dt.Compute("Sum(valor)", string.Empty);
            lblSoma.Text = sumObject.ToString();
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
            string keyword = EntradaPesquisar.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TabelaNotas WHERE razao LIKE '%" + keyword + "%' OR setor LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            dt = new DataTable();
            sda.Fill(dt);
            NotasView.DataSource = dt;
            object sumObject;
            sumObject = dt.Compute("Sum(valor)", string.Empty);
            lblSoma.Text = sumObject.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
