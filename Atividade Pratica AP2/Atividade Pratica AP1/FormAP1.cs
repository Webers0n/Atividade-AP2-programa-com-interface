namespace Atividade_Pratica_AP1
{
    // Classe do formulário AP1, que herda de Form
    public partial class FormAP1 : Form
    {
        // Variável global que armazena a quantidade de cliques
        int contador = 0;

        // Construtor do formulário
        public FormAP1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // nenuma ação definida aqui.
        }

        // Evento Load do formulário
        private void FormAP1_Load(object sender, EventArgs e)
        {
            // Define o texto inicial do label ao abrir a janela
            lblContador.Text = "Cliques: 0";

        }
        // Evento de clique do formulário
        // É acionado sempre que o usuário clica em qualquer área do Form
        private void FormAP1_Click(object sender, EventArgs e)
        {

            // Incrementa o contador a cada clique
            contador++;

            // Atualiza o texto do label exibindo o total de cliques
            lblContador.Text = "Cliques: " + contador;
        }
    }
}
