namespace Restaurant
{
    partial class ConsultarComandas
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
            label2 = new Label();
            comandas = new DataGridView();
            idcomanda = new TextBox();
            consultarcomandaesp = new Button();
            menuprincipal = new Button();
            consultarcomanda = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            labelMaximo = new Label();
            labelMinimo = new Label();
            labelPromedio = new Label();
            labelSuma = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)comandas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 94);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 27;
            label2.Text = "No. de Comanda:";
            // 
            // comandas
            // 
            comandas.AllowUserToAddRows = false;
            comandas.AllowUserToDeleteRows = false;
            comandas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comandas.Location = new Point(12, 165);
            comandas.Name = "comandas";
            comandas.ReadOnly = true;
            comandas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            comandas.ScrollBars = ScrollBars.Horizontal;
            comandas.Size = new Size(525, 240);
            comandas.TabIndex = 26;
            // 
            // idcomanda
            // 
            idcomanda.Location = new Point(197, 120);
            idcomanda.Name = "idcomanda";
            idcomanda.Size = new Size(164, 27);
            idcomanda.TabIndex = 25;
            // 
            // consultarcomandaesp
            // 
            consultarcomandaesp.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultarcomandaesp.Location = new Point(367, 108);
            consultarcomandaesp.Name = "consultarcomandaesp";
            consultarcomandaesp.Size = new Size(170, 42);
            consultarcomandaesp.TabIndex = 24;
            consultarcomandaesp.Text = "Específico";
            consultarcomandaesp.UseVisualStyleBackColor = true;
            consultarcomandaesp.Click += consultarcomandaesp_Click;
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(543, 344);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 23;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // consultarcomanda
            // 
            consultarcomanda.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultarcomanda.Location = new Point(12, 108);
            consultarcomanda.Name = "consultarcomanda";
            consultarcomanda.Size = new Size(137, 42);
            consultarcomanda.TabIndex = 22;
            consultarcomanda.Text = "General";
            consultarcomanda.UseVisualStyleBackColor = true;
            consultarcomanda.Click += consultarcomanda_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(543, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(726, 46);
            label1.TabIndex = 20;
            label1.Text = "Consultar Comandas del Restaurant";
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button4.Location = new Point(614, 460);
            button4.Name = "button4";
            button4.Size = new Size(146, 42);
            button4.TabIndex = 43;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button3.Location = new Point(422, 460);
            button3.Name = "button3";
            button3.Size = new Size(148, 42);
            button3.TabIndex = 42;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(197, 460);
            button2.Name = "button2";
            button2.Size = new Size(145, 42);
            button2.TabIndex = 41;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(15, 460);
            button1.Name = "button1";
            button1.Size = new Size(144, 42);
            button1.TabIndex = 40;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelMaximo
            // 
            labelMaximo.AutoSize = true;
            labelMaximo.Font = new Font("Arial Rounded MT Bold", 9F);
            labelMaximo.Location = new Point(614, 423);
            labelMaximo.Name = "labelMaximo";
            labelMaximo.Size = new Size(141, 17);
            labelMaximo.TabIndex = 39;
            labelMaximo.Text = "Comanda Máxima:";
            // 
            // labelMinimo
            // 
            labelMinimo.AutoSize = true;
            labelMinimo.Font = new Font("Arial Rounded MT Bold", 9F);
            labelMinimo.Location = new Point(422, 423);
            labelMinimo.Name = "labelMinimo";
            labelMinimo.Size = new Size(137, 17);
            labelMinimo.TabIndex = 38;
            labelMinimo.Text = "Comanda Mínima:";
            // 
            // labelPromedio
            // 
            labelPromedio.AutoSize = true;
            labelPromedio.Font = new Font("Arial Rounded MT Bold", 9F);
            labelPromedio.Location = new Point(197, 423);
            labelPromedio.Name = "labelPromedio";
            labelPromedio.Size = new Size(164, 17);
            labelPromedio.TabIndex = 37;
            labelPromedio.Text = "Promedio Comandas:";
            // 
            // labelSuma
            // 
            labelSuma.AutoSize = true;
            labelSuma.Font = new Font("Arial Rounded MT Bold", 9F);
            labelSuma.Location = new Point(15, 423);
            labelSuma.Name = "labelSuma";
            labelSuma.Size = new Size(130, 17);
            labelSuma.TabIndex = 36;
            labelSuma.Text = "Total Comandas:";
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(543, 280);
            button5.Name = "button5";
            button5.Size = new Size(242, 49);
            button5.TabIndex = 44;
            button5.Text = "Generar PDF";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ConsultarComandas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelMaximo);
            Controls.Add(labelMinimo);
            Controls.Add(labelPromedio);
            Controls.Add(labelSuma);
            Controls.Add(label2);
            Controls.Add(comandas);
            Controls.Add(idcomanda);
            Controls.Add(consultarcomandaesp);
            Controls.Add(menuprincipal);
            Controls.Add(consultarcomanda);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ConsultarComandas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarComandas";
            ((System.ComponentModel.ISupportInitialize)comandas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView comandas;
        private TextBox idcomanda;
        private Button consultarcomandaesp;
        private Button menuprincipal;
        private Button consultarcomanda;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label labelMaximo;
        private Label labelMinimo;
        private Label labelPromedio;
        private Label labelSuma;
        private Button button5;
    }
}