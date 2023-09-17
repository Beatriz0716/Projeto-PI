namespace Projeto_PI_V3
{
    partial class telaCompra
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listaMateriais = new ListBox();
            label1 = new Label();
            txtMaterial = new TextBox();
            txtValorPeso = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTotalCaixa = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTara = new TextBox();
            txtPeso = new TextBox();
            label9 = new Label();
            lblTotalCompra = new Label();
            label6 = new Label();
            label10 = new Label();
            txtValorPagar = new TextBox();
            txtPesoLiq = new TextBox();
            btnLimpar = new Button();
            btnImprimir = new Button();
            btnCalcular = new Button();
            menuStrip1 = new MenuStrip();
            Arquivo = new ToolStripMenuItem();
            adicionarMateriaisToolStripMenuItem = new ToolStripMenuItem();
            entradaToolStripMenuItem = new ToolStripMenuItem();
            Ajuda = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            notaFical = new ListBox();
            label11 = new Label();
            btnSalvar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listaMateriais
            // 
            listaMateriais.BackColor = Color.FromArgb(64, 64, 64);
            listaMateriais.BorderStyle = BorderStyle.None;
            listaMateriais.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listaMateriais.ForeColor = Color.White;
            listaMateriais.FormattingEnabled = true;
            listaMateriais.ItemHeight = 25;
            listaMateriais.Location = new Point(42, 93);
            listaMateriais.Name = "listaMateriais";
            listaMateriais.Size = new Size(298, 500);
            listaMateriais.TabIndex = 0;
            listaMateriais.SelectedIndexChanged += selectMaterial;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 36);
            label1.Name = "label1";
            label1.Size = new Size(235, 53);
            label1.TabIndex = 1;
            label1.Text = "MATERIAIS";
            // 
            // txtMaterial
            // 
            txtMaterial.BackColor = Color.FromArgb(64, 64, 64);
            txtMaterial.BorderStyle = BorderStyle.None;
            txtMaterial.Enabled = false;
            txtMaterial.ForeColor = Color.Black;
            txtMaterial.Location = new Point(368, 148);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(262, 25);
            txtMaterial.TabIndex = 2;
            // 
            // txtValorPeso
            // 
            txtValorPeso.BackColor = Color.FromArgb(64, 64, 64);
            txtValorPeso.BorderStyle = BorderStyle.None;
            txtValorPeso.Enabled = false;
            txtValorPeso.ForeColor = Color.White;
            txtValorPeso.Location = new Point(681, 148);
            txtValorPeso.Name = "txtValorPeso";
            txtValorPeso.PlaceholderText = "R$ 0,00";
            txtValorPeso.Size = new Size(119, 25);
            txtValorPeso.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(493, 36);
            label2.Name = "label2";
            label2.Size = new Size(206, 53);
            label2.TabIndex = 5;
            label2.Text = "PESAGEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(368, 101);
            label3.Name = "label3";
            label3.Size = new Size(93, 27);
            label3.TabIndex = 6;
            label3.Text = "Material";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(681, 101);
            label4.Name = "label4";
            label4.Size = new Size(87, 27);
            label4.TabIndex = 7;
            label4.Text = "V./Peso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(368, 544);
            label5.Name = "label5";
            label5.Size = new Size(191, 46);
            label5.TabIndex = 8;
            label5.Text = "Total R$:";
            // 
            // lblTotalCaixa
            // 
            lblTotalCaixa.AutoSize = true;
            lblTotalCaixa.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCaixa.Location = new Point(565, 544);
            lblTotalCaixa.Name = "lblTotalCaixa";
            lblTotalCaixa.Size = new Size(43, 46);
            lblTotalCaixa.TabIndex = 9;
            lblTotalCaixa.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(638, 200);
            label7.Name = "label7";
            label7.Size = new Size(59, 26);
            label7.TabIndex = 13;
            label7.Text = "Tara";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(368, 200);
            label8.Name = "label8";
            label8.Size = new Size(66, 26);
            label8.TabIndex = 12;
            label8.Text = "Peso";
            // 
            // txtTara
            // 
            txtTara.AutoCompleteCustomSource.AddRange(new string[] { "0" });
            txtTara.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTara.BackColor = Color.White;
            txtTara.CausesValidation = false;
            txtTara.ForeColor = Color.Black;
            txtTara.Location = new Point(638, 239);
            txtTara.Name = "txtTara";
            txtTara.PlaceholderText = "0";
            txtTara.Size = new Size(162, 32);
            txtTara.TabIndex = 11;
            txtTara.Text = "0";
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.White;
            txtPeso.Location = new Point(368, 239);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "0";
            txtPeso.Size = new Size(227, 32);
            txtPeso.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft PhagsPa", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(697, 353);
            label9.Name = "label9";
            label9.Size = new Size(99, 29);
            label9.TabIndex = 14;
            label9.Text = "Total R$";
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCompra.Location = new Point(697, 401);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(25, 26);
            lblTotalCompra.TabIndex = 15;
            lblTotalCompra.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft PhagsPa", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(521, 353);
            label6.Name = "label6";
            label6.Size = new Size(111, 27);
            label6.TabIndex = 19;
            label6.Text = "V. á Pagar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft PhagsPa", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(370, 353);
            label10.Name = "label10";
            label10.Size = new Size(95, 27);
            label10.TabIndex = 18;
            label10.Text = "Peso líq.";
            // 
            // txtValorPagar
            // 
            txtValorPagar.BackColor = Color.FromArgb(64, 64, 64);
            txtValorPagar.BorderStyle = BorderStyle.None;
            txtValorPagar.Enabled = false;
            txtValorPagar.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorPagar.ForeColor = Color.White;
            txtValorPagar.Location = new Point(521, 398);
            txtValorPagar.Name = "txtValorPagar";
            txtValorPagar.PlaceholderText = "R$ 0,00";
            txtValorPagar.Size = new Size(151, 25);
            txtValorPagar.TabIndex = 17;
            // 
            // txtPesoLiq
            // 
            txtPesoLiq.BackColor = Color.FromArgb(64, 64, 64);
            txtPesoLiq.BorderStyle = BorderStyle.None;
            txtPesoLiq.Enabled = false;
            txtPesoLiq.ForeColor = Color.White;
            txtPesoLiq.Location = new Point(370, 398);
            txtPesoLiq.Name = "txtPesoLiq";
            txtPesoLiq.PlaceholderText = "0";
            txtPesoLiq.Size = new Size(127, 25);
            txtPesoLiq.TabIndex = 16;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.CornflowerBlue;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(370, 463);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(127, 36);
            btnLimpar.TabIndex = 20;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.CornflowerBlue;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimir.Location = new Point(675, 463);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(127, 36);
            btnImprimir.TabIndex = 22;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.CornflowerBlue;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(368, 298);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(432, 36);
            btnCalcular.TabIndex = 23;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Arquivo, Ajuda });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1154, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // Arquivo
            // 
            Arquivo.BackColor = Color.FromArgb(64, 64, 64);
            Arquivo.DropDownItems.AddRange(new ToolStripItem[] { adicionarMateriaisToolStripMenuItem, entradaToolStripMenuItem });
            Arquivo.ForeColor = Color.White;
            Arquivo.Name = "Arquivo";
            Arquivo.Size = new Size(61, 20);
            Arquivo.Text = "Arquivo";
            // 
            // adicionarMateriaisToolStripMenuItem
            // 
            adicionarMateriaisToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            adicionarMateriaisToolStripMenuItem.ForeColor = Color.White;
            adicionarMateriaisToolStripMenuItem.Name = "adicionarMateriaisToolStripMenuItem";
            adicionarMateriaisToolStripMenuItem.Size = new Size(176, 22);
            adicionarMateriaisToolStripMenuItem.Text = "Adicionar Materiais";
            // 
            // entradaToolStripMenuItem
            // 
            entradaToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            entradaToolStripMenuItem.ForeColor = Color.White;
            entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            entradaToolStripMenuItem.Size = new Size(176, 22);
            entradaToolStripMenuItem.Text = "Entrada";
            // 
            // Ajuda
            // 
            Ajuda.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            Ajuda.ForeColor = Color.White;
            Ajuda.ImageAlign = ContentAlignment.MiddleRight;
            Ajuda.Name = "Ajuda";
            Ajuda.Size = new Size(50, 20);
            Ajuda.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            sobreToolStripMenuItem.ForeColor = Color.White;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // notaFical
            // 
            notaFical.BackColor = Color.White;
            notaFical.BorderStyle = BorderStyle.None;
            notaFical.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            notaFical.ForeColor = Color.FromArgb(64, 64, 64);
            notaFical.FormattingEnabled = true;
            notaFical.ItemHeight = 25;
            notaFical.Location = new Point(831, 101);
            notaFical.Name = "notaFical";
            notaFical.Size = new Size(298, 500);
            notaFical.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft PhagsPa", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(880, 36);
            label11.Name = "label11";
            label11.Size = new Size(201, 53);
            label11.TabIndex = 26;
            label11.Text = "RELAÇÃO";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.CornflowerBlue;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(521, 463);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(127, 36);
            btnSalvar.TabIndex = 27;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // telaCompra
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1154, 636);
            Controls.Add(btnSalvar);
            Controls.Add(label11);
            Controls.Add(notaFical);
            Controls.Add(btnCalcular);
            Controls.Add(btnImprimir);
            Controls.Add(btnLimpar);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(txtValorPagar);
            Controls.Add(txtPesoLiq);
            Controls.Add(lblTotalCompra);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtTara);
            Controls.Add(txtPeso);
            Controls.Add(lblTotalCaixa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtValorPeso);
            Controls.Add(txtMaterial);
            Controls.Add(label1);
            Controls.Add(listaMateriais);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "telaCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compra";
            Load += telaCompra_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listaMateriais;
        private Label label1;
        private TextBox txtMaterial;
        private Button button1;
        private TextBox txtValorPeso;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTotalCaixa;
        private Label label7;
        private Label label8;
        private TextBox txtTara;
        private TextBox txtPeso;
        private Label label9;
        private Label lblTotalCompra;
        private Label label6;
        private Label label10;
        private TextBox txtValorPagar;
        private TextBox txtPesoLiq;
        private Button btnLimpar;
        private Button btnImprimir;
        private Button btnCalcular;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Arquivo;
        private ToolStripMenuItem adicionarMateriaisToolStripMenuItem;
        private ToolStripMenuItem Ajuda;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem entradaToolStripMenuItem;
        private ListBox notaFical;
        private Label label11;
        private Button btnSalvar;
    }
}