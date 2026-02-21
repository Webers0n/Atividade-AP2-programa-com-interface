namespace Atividade_Pratica_AP1
{
    partial class Ap2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            EnviarAvaliacao = new Button();
            ListBox = new ComboBox();
            radioExcelente = new RadioButton();
            radioBom = new RadioButton();
            radioRegular = new RadioButton();
            radioRuim = new RadioButton();
            radioPessimo = new RadioButton();
            inputNome = new MaskedTextBox();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(278, 33);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 1;
            label2.Text = "Serviço Avaliado";
            label2.Click += label2_Click;
            // 
            // EnviarAvaliacao
            // 
            EnviarAvaliacao.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            EnviarAvaliacao.Location = new Point(35, 216);
            EnviarAvaliacao.Name = "EnviarAvaliacao";
            EnviarAvaliacao.Size = new Size(131, 62);
            EnviarAvaliacao.TabIndex = 2;
            EnviarAvaliacao.Text = "Enviar Avaliação";
            EnviarAvaliacao.UseVisualStyleBackColor = true;
            EnviarAvaliacao.Click += EnviarAvaliacao_Click;
            // 
            // ListBox
            // 
            ListBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(421, 32);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(195, 28);
            ListBox.TabIndex = 3;
            ListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // radioExcelente
            // 
            radioExcelente.AutoSize = true;
            radioExcelente.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            radioExcelente.Location = new Point(16, 50);
            radioExcelente.Name = "radioExcelente";
            radioExcelente.Size = new Size(104, 27);
            radioExcelente.TabIndex = 6;
            radioExcelente.TabStop = true;
            radioExcelente.Text = "Excelente";
            radioExcelente.UseVisualStyleBackColor = true;
            radioExcelente.CheckedChanged += radioExcelente_CheckedChanged_1;
            // 
            // radioBom
            // 
            radioBom.AutoSize = true;
            radioBom.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            radioBom.Location = new Point(16, 80);
            radioBom.Name = "radioBom";
            radioBom.Size = new Size(66, 27);
            radioBom.TabIndex = 7;
            radioBom.TabStop = true;
            radioBom.Text = "Bom";
            radioBom.UseVisualStyleBackColor = true;
            radioBom.CheckedChanged += radioBom_CheckedChanged;
            // 
            // radioRegular
            // 
            radioRegular.AutoSize = true;
            radioRegular.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            radioRegular.Location = new Point(16, 110);
            radioRegular.Name = "radioRegular";
            radioRegular.Size = new Size(90, 27);
            radioRegular.TabIndex = 8;
            radioRegular.TabStop = true;
            radioRegular.Text = "Regular";
            radioRegular.UseVisualStyleBackColor = true;
            radioRegular.CheckedChanged += radioRegular_CheckedChanged;
            // 
            // radioRuim
            // 
            radioRuim.AutoSize = true;
            radioRuim.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            radioRuim.Location = new Point(13, 140);
            radioRuim.Name = "radioRuim";
            radioRuim.Size = new Size(71, 27);
            radioRuim.TabIndex = 9;
            radioRuim.TabStop = true;
            radioRuim.Text = "Ruim";
            radioRuim.UseVisualStyleBackColor = true;
            radioRuim.CheckedChanged += radioRuim_CheckedChanged;
            // 
            // radioPessimo
            // 
            radioPessimo.AutoSize = true;
            radioPessimo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            radioPessimo.Location = new Point(16, 170);
            radioPessimo.Name = "radioPessimo";
            radioPessimo.Size = new Size(92, 27);
            radioPessimo.TabIndex = 10;
            radioPessimo.TabStop = true;
            radioPessimo.Text = "Péssimo";
            radioPessimo.UseVisualStyleBackColor = true;
            radioPessimo.CheckedChanged += radioPessimo_CheckedChanged;
            // 
            // inputNome
            // 
            inputNome.Location = new Point(77, 30);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(195, 27);
            inputNome.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioRegular);
            groupBox1.Controls.Add(radioExcelente);
            groupBox1.Controls.Add(radioBom);
            groupBox1.Controls.Add(radioPessimo);
            groupBox1.Controls.Add(EnviarAvaliacao);
            groupBox1.Controls.Add(radioRuim);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(639, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 294);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metodo de Avaliação";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 83);
            listView1.Name = "listView1";
            listView1.Size = new Size(598, 255);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // Ap2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 370);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(inputNome);
            Controls.Add(ListBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "Ap2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AP2 - Sistema de Avaliação";
            Load += Ap2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button EnviarAvaliacao;
        private ComboBox ListBox;
        private RadioButton radioExcelente;
        private RadioButton radioBom;
        private RadioButton radioRegular;
        private RadioButton radioRuim;
        private RadioButton radioPessimo;
        private MaskedTextBox inputNome;
        private GroupBox groupBox1;
        private ListView listView1;
    }
}