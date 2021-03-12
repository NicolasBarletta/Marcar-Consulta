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
    public partial class lista : Form
    {
        public lista()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.marcaConsultaDataSet);

        }

        private void lista_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'marcaConsultaDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.marcaConsultaDataSet.Table);

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formulario consulta = new formulario();
            consulta.ShowDialog();
        }
    }
}
