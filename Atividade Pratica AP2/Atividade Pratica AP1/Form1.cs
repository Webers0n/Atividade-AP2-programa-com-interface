namespace Atividade_Pratica_AP1
{
    public partial class AP1 : Form
    {
        public AP1()
        {
            InitializeComponent();
        }

        // Evento de clique do botão AP1
        // Esse botão é responsável por abrir a janela do AP1
        private void btnAP1_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário FormAP1
            FormAP1 telaAP1 = new FormAP1();

            // Exibe o formulário AP1 na tela
            telaAP1.Show();
        }

        private void btnAP2_Click(object sender, EventArgs e)
        {
            Ap2 telaAP2 = new Ap2();

            telaAP2.Show();
        }
    }
}
