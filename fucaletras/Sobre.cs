using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fucaletras
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sobre_Load(object sender, EventArgs e)
        {
            RtbSobre.Text = "O objetivo geral do nosso sistema é facilitar ao usuário o acesso às letras e músicas." +
                            "Foi notado que há poucos meios em que se pode escutar uma música e ler a letra simultaneamente. "+
                            "Esse fator nos motivou no desenvolvimento desse sistema.. ";
        }

        private void BttOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

     
    }
}
