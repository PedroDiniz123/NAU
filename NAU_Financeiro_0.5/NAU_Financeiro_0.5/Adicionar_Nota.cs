using NAU_Financeiro_0._5.nauClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Media;

namespace NAU_Financeiro_0._5
{
    public partial class Adicionar_Nota : Form
    {

        

        public Adicionar_Nota()
        {
            InitializeComponent();
        }

        // Nova Classe
        Nota nota = new Nota();


        public void Clear()
        {
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Get the value from the input fields
            nota.Data = EntradaData.Value;
            nota.Razao = EntradaRazao.Text;
            nota.Setor = EntradaSetor.Text;
            nota.Valor = Convert.ToString(EntradaValor.Value).Replace(".", "").Replace(",", ".");


            // Inserting Data into DAtabase uing the method we created in previous episode
            bool success = nota.Insert(nota);
            if (success == true)
            {
                // Successfully Inserted
                // Call the Clear Method Here
                // Clear();
                EntradaValor.Value = 0;
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Pop-up Blocked.wav");
                simpleSound.Play();
            }
            
            else
            {
                //FAiled to Add Contact
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                simpleSound.Play();
                MessageBox.Show("Erro adicionando nota. Cheque os campos e tente novamente.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
