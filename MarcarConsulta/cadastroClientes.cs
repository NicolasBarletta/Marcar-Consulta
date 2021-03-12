using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcarConsulta
{
    public partial class marcaConsulta : Form
    {
        public marcaConsulta()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marcaConsultaDataSet);

        }
        private void marcaConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'marcaConsultaDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.marcaConsultaDataSet.Table);

        }


        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista listas = new lista();
            listas.ShowDialog();
        }
    }
}
