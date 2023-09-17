namespace Projeto_PI_V3
{
    partial class AdicionarMat
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 60);
            label1.Name = "label1";
            label1.Size = new Size(360, 89);
            label1.TabIndex = 0;
            label1.Text = "EM BREVE";
            // 
            // AdicionarMat
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(549, 214);
            Controls.Add(label1);
            Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5, 5, 5, 5);
            Name = "AdicionarMat";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Material";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}