using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FucaLetrasBD;

namespace fucaletras
{
    public partial class EditarLetra : Form
    {
        public EditarLetra(string txtCaminho)
        {
            InitializeComponent();
            textBox1.Text = txtCaminho;
        }

        private void EditarLetra_Load(object sender, EventArgs e)
        {
            EdLetraRTxt.ReadOnly = false;
            label1.Text = "Favor escrever a letra utilizando os paragrafos corretos.\n" + 
            "Se não o fizer, as letras serão mostradas de formas incorretas.";
        }

        private void BttOk_Click(object sender, EventArgs e)
        {
            try
            {
                AcessoDados ace = new AcessoDados();

                ace.AdicionarParametro("@letra", EdLetraRTxt.Text);
                ace.AdicionarParametro("@caminho", textBox1.Text);
                ace.ExecutarManipulacao(CommandType.StoredProcedure, "UpdateLetra");

                MessageBox.Show("Letra Editada com Sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                OpenFileDialog F = new OpenFileDialog();

                F.FileName = textBox1.Text;
                MessageBox.Show("Não foi possivel editar a letra da música: " + F.FileName + " O erro é: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
