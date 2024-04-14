namespace Restaurant
{
    partial class ConsultarInventario
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
            inventario = new DataGridView();
            idproducto = new TextBox();
            consultarinvesp = new Button();
            menuprincipal = new Button();
            consultarinv = new Button();
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
            ((System.ComponentModel.ISupportInitialize)inventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 94);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 35;
            label2.Text = "No. de Producto:";
            // 
            // inventario
            // 
            inventario.AllowUserToAddRows = false;
            inventario.AllowUserToDeleteRows = false;
            inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventario.Location = new Point(12, 165);
            inventario.Name = "inventario";
            inventario.ReadOnly = true;
            inventario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            inventario.ScrollBars = ScrollBars.Horizontal;
            inventario.Size = new Size(525, 240);
            inventario.TabIndex = 34;
            // 
            // idproducto
            // 
            idproducto.Location = new Point(197, 120);
            idproducto.Name = "idproducto";
            idproducto.Size = new Size(164, 27);
            idproducto.TabIndex = 33;
            // 
            // consultarinvesp
            // 
            consultarinvesp.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultarinvesp.Location = new Point(367, 108);
            consultarinvesp.Name = "consultarinvesp";
            consultarinvesp.Size = new Size(170, 42);
            consultarinvesp.TabIndex = 32;
            consultarinvesp.Text = "Específico";
            consultarinvesp.UseVisualStyleBackColor = true;
            consultarinvesp.Click += consultarinvesp_Click;
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(571, 343);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 31;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // consultarinv
            // 
            consultarinv.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultarinv.Location = new Point(12, 108);
            consultarinv.Name = "consultarinv";
            consultarinv.Size = new Size(137, 42);
            consultarinv.TabIndex = 30;
            consultarinv.Text = "General";
            consultarinv.UseVisualStyleBackColor = true;
            consultarinv.Click += consultarinv_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(571, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(716, 46);
            label1.TabIndex = 28;
            label1.Text = "Consultar Inventario del Restaurant";
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button4.Location = new Point(624, 454);
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
            button3.Location = new Point(422, 454);
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
            button2.Location = new Point(197, 454);
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
            button1.Location = new Point(15, 454);
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
            labelMaximo.Font = new Font("Arial Rounded MT Bold", 10.8F);
            labelMaximo.Location = new Point(624, 417);
            labelMaximo.Name = "labelMaximo";
            labelMaximo.Size = new Size(179, 21);
            labelMaximo.TabIndex = 39;
            labelMaximo.Text = "Máximo Existencia:";
            // 
            // labelMinimo
            // 
            labelMinimo.AutoSize = true;
            labelMinimo.Font = new Font("Arial Rounded MT Bold", 10.8F);
            labelMinimo.Location = new Point(422, 417);
            labelMinimo.Name = "labelMinimo";
            labelMinimo.Size = new Size(175, 21);
            labelMinimo.TabIndex = 38;
            labelMinimo.Text = "Mínimo Existencia:";
            // 
            // labelPromedio
            // 
            labelPromedio.AutoSize = true;
            labelPromedio.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPromedio.Location = new Point(197, 417);
            labelPromedio.Name = "labelPromedio";
            labelPromedio.Size = new Size(197, 21);
            labelPromedio.TabIndex = 37;
            labelPromedio.Text = "Promedio Existencia:";
            // 
            // labelSuma
            // 
            labelSuma.AutoSize = true;
            labelSuma.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSuma.Location = new Point(15, 417);
            labelSuma.Name = "labelSuma";
            labelSuma.Size = new Size(145, 20);
            labelSuma.TabIndex = 36;
            labelSuma.Text = "Total Existencia:";
            labelSuma.Click += labelSuma_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(571, 279);
            button5.Name = "button5";
            button5.Size = new Size(242, 49);
            button5.TabIndex = 45;
            button5.Text = "Generar PDF";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ConsultarInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 510);
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
            Controls.Add(inventario);
            Controls.Add(idproducto);
            Controls.Add(consultarinvesp);
            Controls.Add(menuprincipal);
            Controls.Add(consultarinv);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ConsultarInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarInventario";
            ((System.ComponentModel.ISupportInitialize)inventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView inventario;
        private TextBox idproducto;
        private Button consultarinvesp;
        private Button menuprincipal;
        private Button consultarinv;
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