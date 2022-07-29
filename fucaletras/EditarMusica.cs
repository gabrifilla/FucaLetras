using System;
using System.Data;
using System.Windows.Forms;
using FucaLetrasBD;

namespace fucaletras
{
    public partial class EditarMusica : Form
    {
        public EditarMusica(string txtCaminho)
        {
            InitializeComponent();
            textBox1.Text = txtCaminho;
        }
        OpenFileDialog open = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AcessoDados BD = new AcessoDados();
                open.FileName = textBox1.Text;
                TagLib.File f = TagLib.File.Create(open.FileName);
                f.Tag.Title = txtNome.Text;
                f.Tag.Performers = null;
                f.Tag.Performers = new string[] { txtArt.Text };
                f.Tag.Album = txtAlb.Text;
                f.Tag.Lyrics = txtGen.Text;
                f.Save();

                BD.UpdateMusica(CommandType.StoredProcedure, "UpdateMusica");
                BD.AdicionarParametro("@nome", txtNome.Text);
                BD.AdicionarParametro("@nome_banda", txtArt.Text);
                BD.AdicionarParametro("@nome_genero", txtGen.Text);
                BD.AdicionarParametro("@nome_album", txtAlb.Text);

                MessageBox.Show("Música modificada com Sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                OpenFileDialog F = new OpenFileDialog();
                F.FileName = textBox1.Text;
                MessageBox.Show("Não foi possível editar as informações da música: " + F.FileName); 
                throw ex;
            }

        }
    }
}
