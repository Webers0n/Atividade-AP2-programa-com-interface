namespace Atividade_Pratica_AP1
{
    partial class FormAP1
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
            lblContador = new Label();
            SuspendLayout();
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.BackColor = SystemColors.ControlLightLight;
            lblContador.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContador.Location = new Point(88, 106);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(113, 38);
            lblContador.TabIndex = 0;
            lblContador.Text = "Cliques:";
            lblContador.Click += label1_Click;
            // 
            // FormAP1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 265);
            Controls.Add(lblContador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAP1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AP1 - Contador de Cliques";
            Load += FormAP1_Load;
            Click += FormAP1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContador;
    }
}