using NAU_Financeiro_0._5.nauClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAU_Financeiro_0._5
{
    public partial class Apagar_Nota : Form
    {
        public Apagar_Nota(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        Nota nota = new Nota();
        int id;


        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
            simpleSound.Play();
            if (MessageBox.Show("Deseja apagar essa nota?", "Apagar Nota", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nota.Id = (int)numericUpDown1.Value;

                try
                {
                    nota.Delete(nota);
                    MessageBox.Show("Nota apagada.", "Apagar Nota");
                    simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Pop-up Blocked.wav");
                    simpleSound.Play();
                    Close();
                }
                catch (Exception ex)
                {
                    simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                    simpleSound.Play();
                    MessageBox.Show("Ocorreu um erro! Nota não apagada.", "Apagar Nota");
                }

            } else
            {
                simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Error.wav");
                simpleSound.Play();
                MessageBox.Show("Nota não apagada.", "Apagar Nota");
                
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            {
                int id = (int)numericUpDown1.Value;
                try
                {
                    nota = nota.Search(id);

                    if (nota != null)
                    {
                        EntradaData.Value = (DateTime)nota.Data;
                        EntradaRazao.Text = nota.Razao;
                        EntradaSetor.Text = nota.Setor;
                        EntradaValor.Value = Convert.ToDecimal((nota.Valor));
                        EntradaComplemento.Text = nota.Complemento;
                        EntradaNumero.Text = nota.Numero.ToString();
                        TxtTipoNota.Text = nota.Tipo;

                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Apagar_Nota_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = id;
            numericUpDown1_ValueChanged((object)numericUpDown1.Value, e);
        }
    }
}
