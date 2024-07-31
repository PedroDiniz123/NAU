using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NAU_Financeiro_0._5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["NAU_Financeiro_0._5.Properties.Settings.NAU_FinanceiroConnectionString"].ConnectionString;

        SqlConnection sqlConnection = new SqlConnection(myconnstrng);

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usuario = entradaUsuario.Text;
            string senha = entradaSenha.Text;

            try
            {
                string querry = "SELECT * FROM Logins WHERE usuario = '" + usuario + "' AND senha = '" + senha + "'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, myconnstrng);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    usuario = entradaUsuario.Text;
                    senha = entradaSenha.Text;

                    Notas_Main notas_Main = new Notas_Main(usuario);
                    notas_Main.Show();

                    this.Hide();
                } 
                else
                {
                    MessageBox.Show("Login inválido!", "Erro!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!");
            }
            finally 
            {
                sqlConnection.Close();
            }
        }
    }
}
