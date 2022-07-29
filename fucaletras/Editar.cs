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
    public partial class EditPlay : Form
    {
        public EditPlay()
        {
            InitializeComponent();
        }

        private void EditPlay_Load(object sender, EventArgs e)
        {
            // Nese exemplo o acesso ao database é feito pela classe dal
            try
            {
                // Cria um objeto da classe Dal
                AcessoDados dal = new AcessoDados();

                // Chama o método ExecutarConsulta da classe Dal
                // O metodo executa uma stored procedure
                // Coleta o resultado em um datatable
                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "select_cliente");

                // Associa o list view ao data table
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    listView1.Columns.Add(dt.Columns[i].ColumnName, 120, HorizontalAlignment.Left);
                }
                

                // Obtém os dados
                //gvCliente.DataBind();
            }
            catch (Exception error)
            {
                throw error;
            }

        }
    }
}
