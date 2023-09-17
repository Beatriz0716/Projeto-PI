namespace Projeto_PI_V3
{
    partial class AdicionarMaterial
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(155, 497);
            label1.Name = "label1";
            label1.Size = new Size(131, 36);
            label1.TabIndex = 1;
            label1.Text = "Material:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(491, 497);
            label2.Name = "label2";
            label2.Size = new Size(95, 36);
            label2.TabIndex = 2;
            label2.Text = "Preço:";
            // 
            // AdicionarMaterial
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(773, 627);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "AdicionarMaterial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Material";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}