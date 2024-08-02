using NAU_Financeiro_0._5.nauClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAU_Financeiro_0._5
{
    public partial class Atualizar_Nota : Form
    {
        public Atualizar_Nota(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        Nota nota = new Nota();
        int id;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            try
            {
                nota = nota.Search(id);

                if (nota != null)
                {
                    string tipo = nota.Tipo;
                    if (tipo == "Nota Fiscal") BtnNota.Checked = true;
                    if (tipo == "Recibo") BtnRecibo.Checked = true;
                    if (tipo == "Boleto") BtnBoleto.Checked = true;

                    EntradaData.Value = (DateTime) nota.Data;
                    EntradaRazao.Text = nota.Razao;
                    EntradaSetor.Text = nota.Setor;
                    EntradaValor.Value = Convert.ToDecimal((nota.Valor));
                    EntradaNumero.Text = nota.Numero.ToString();
                    EntradaComplemento.Text = nota.Complemento;
                }
            }
            catch (Exception ex)
            {
                
            } 
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (EntradaRazao.Text != "")
            {
                nota.Id = (int)numericUpDown1.Value;
                nota.Data = EntradaData.Value;
                nota.Razao = EntradaRazao.Text;
                nota.Setor = EntradaSetor.Text;
                nota.Valor = Convert.ToString(EntradaValor.Value).Replace(".", "").Replace(",", ".");
                nota.Numero = Convert.ToInt32(EntradaNumero.Text);
                nota.Complemento = EntradaComplemento.Text;

                string tipo = "Nota Fiscal";

                if (BtnBoleto.Checked) tipo = "Boleto";
                if (BtnRecibo.Checked) tipo = "Recibo";

                nota.Tipo = tipo;

                bool success = nota.Update(nota);

                if (success == true)
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Pop-up Blocked.wav");
                    simpleSound.Play();
                    Close(); return;

                }
                else
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                    simpleSound.Play();
                    //FAiled to Add Contact
                    MessageBox.Show("Erro Atualizando nota. Cheque os campos e tente novamente.");
                    
                }
            } else 
            {
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                simpleSound.Play();
                MessageBox.Show("Erro atualizando nota. Cheque os campos e tente novamente.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close(); return;
        }

        private void Atualizar_Nota_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = id;
            numericUpDown1_ValueChanged(numericUpDown1.Value, e);
        }
    }
}
