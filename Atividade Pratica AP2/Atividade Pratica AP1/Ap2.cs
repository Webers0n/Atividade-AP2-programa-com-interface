using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Pratica_AP1
{
    public partial class Ap2 : Form
    {
        public Ap2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioExcelente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnviarAvaliacao_Click(object sender, EventArgs e)
        {
            string inputNomeValue = inputNome.Text;
            string listServicos = ListBox.SelectedItem?.ToString();
            string avalicao = "";
            string dataHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Verificar qual RadioButton está selecionado
            if (radioExcelente.Checked) avalicao = radioExcelente.Text;
            else if (radioBom.Checked) avalicao = radioBom.Text;
            else if (radioRegular.Checked) avalicao = radioRegular.Text;
            else if (radioRuim.Checked) avalicao = radioRuim.Text;
            else if (radioPessimo.Checked) avalicao = radioPessimo.Text;

            // Validação correta
            if (!string.IsNullOrEmpty(inputNomeValue) &&
                !string.IsNullOrEmpty(listServicos) &&
                !string.IsNullOrEmpty(avalicao))
            {
                // Criar item
                ListViewItem itemsAdd = new ListViewItem(inputNomeValue);

                itemsAdd.SubItems.Add(listServicos);
                itemsAdd.SubItems.Add(avalicao);
                itemsAdd.SubItems.Add(dataHora);

                listView1.Items.Add(itemsAdd);

                // Limpar campos
                inputNome.Clear();
                ListBox.SelectedIndex = -1;

                radioExcelente.Checked = false;
                radioBom.Checked = false;
                radioRegular.Checked = false;
                radioRuim.Checked = false;
                radioPessimo.Checked = false;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Ap2_Load(object sender, EventArgs e)
        {

            ListBox.DataSource = null;
            ListBox.Items.Clear();

            ListBox.Items.Add("Atendimento");
            ListBox.Items.Add("Produto");
            ListBox.Items.Add("Ambiente");

            // carregamento da listaView1

            listView1.View = View.Details;

            listView1.Columns.Add("Nome",160);
            listView1.Columns.Add("Serviço", 140);
            listView1.Columns.Add("Avaliação",140);
            listView1.Columns.Add("Data e Hora", 130);




        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioExcelente_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioBom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioRegular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioRuim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioPessimo_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
