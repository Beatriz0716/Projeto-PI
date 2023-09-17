namespace Projeto_PI_V3
{
    partial class Entrada
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
            label7 = new Label();
            label8 = new Label();
            txtValorEntrada = new TextBox();
            txtDescricao = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(75, 173);
            label7.Name = "label7";
            label7.Size = new Size(68, 26);
            label7.TabIndex = 17;
            label7.Text = "Valor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(75, 91);
            label8.Name = "label8";
            label8.Size = new Size(118, 26);
            label8.TabIndex = 16;
            label8.Text = "Descrição";
            // 
            // txtValorEntrada
            // 
            txtValorEntrada.BackColor = Color.White;
            txtValorEntrada.ForeColor = Color.Black;
            txtValorEntrada.Location = new Point(75, 212);
            txtValorEntrada.Name = "txtValorEntrada";
            txtValorEntrada.Size = new Size(162, 32);
            txtValorEntrada.TabIndex = 15;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.White;
            txtDescricao.Location = new Point(75, 130);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(456, 32);
            txtDescricao.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(190, 24);
            label2.Name = "label2";
            label2.Size = new Size(211, 53);
            label2.TabIndex = 18;
            label2.Text = "ENTRADA";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.CornflowerBlue;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(75, 262);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(456, 36);
            btnCalcular.TabIndex = 24;
            btnCalcular.Text = "CONFIRMAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Entrada
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(611, 349);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtValorEntrada);
            Controls.Add(txtDescricao);
            Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "Entrada";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Entrada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label8;
        private TextBox txtValorEntrada;
        private TextBox txtDescricao;
        private Label label2;
        private Button btnCalcular;
    }
}