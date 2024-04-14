namespace Restaurant
{
    partial class ConsultarClientes
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
            clientes = new DataGridView();
            idcliente = new TextBox();
            consultar_clientes_esp = new Button();
            menuprincipal = new Button();
            consultar_clientes = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelSuma = new Label();
            labelPromedio = new Label();
            labelMinimo = new Label();
            labelMaximo = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 94);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 27;
            label2.Text = "No. de Cliente:";
            // 
            // clientes
            // 
            clientes.AllowUserToAddRows = false;
            clientes.AllowUserToDeleteRows = false;
            clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientes.Location = new Point(12, 165);
            clientes.Name = "clientes";
            clientes.ReadOnly = true;
            clientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            clientes.ScrollBars = ScrollBars.Horizontal;
            clientes.Size = new Size(525, 240);
            clientes.TabIndex = 26;
            // 
            // idcliente
            // 
            idcliente.Location = new Point(197, 120);
            idcliente.Name = "idcliente";
            idcliente.Size = new Size(164, 27);
            idcliente.TabIndex = 25;
            // 
            // consultar_clientes_esp
            // 
            consultar_clientes_esp.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultar_clientes_esp.Location = new Point(367, 108);
            consultar_clientes_esp.Name = "consultar_clientes_esp";
            consultar_clientes_esp.Size = new Size(170, 42);
            consultar_clientes_esp.TabIndex = 24;
            consultar_clientes_esp.Text = "Específico";
            consultar_clientes_esp.UseVisualStyleBackColor = true;
            consultar_clientes_esp.Click += consultar_clientes_esp_Click;
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(543, 339);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 23;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // consultar_clientes
            // 
            consultar_clientes.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultar_clientes.Location = new Point(12, 108);
            consultar_clientes.Name = "consultar_clientes";
            consultar_clientes.Size = new Size(137, 42);
            consultar_clientes.TabIndex = 22;
            consultar_clientes.Text = "General";
            consultar_clientes.UseVisualStyleBackColor = true;
            consultar_clientes.Click += consultar_clientes_Click;
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
            label1.Size = new Size(678, 46);
            label1.TabIndex = 20;
            label1.Text = "Consultar Clientes del Restaurant";
            // 
            // labelSuma
            // 
            labelSuma.AutoSize = true;
            labelSuma.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSuma.Location = new Point(12, 424);
            labelSuma.Name = "labelSuma";
            labelSuma.Size = new Size(137, 21);
            labelSuma.TabIndex = 28;
            labelSuma.Text = "Total Clientes:";
            // 
            // labelPromedio
            // 
            labelPromedio.AutoSize = true;
            labelPromedio.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPromedio.Location = new Point(194, 424);
            labelPromedio.Name = "labelPromedio";
            labelPromedio.Size = new Size(200, 17);
            labelPromedio.TabIndex = 29;
            labelPromedio.Text = "Promedio de Letras Email:";
            // 
            // labelMinimo
            // 
            labelMinimo.AutoSize = true;
            labelMinimo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMinimo.Location = new Point(419, 424);
            labelMinimo.Name = "labelMinimo";
            labelMinimo.Size = new Size(159, 17);
            labelMinimo.TabIndex = 30;
            labelMinimo.Text = "Mínimo Letras Email:";
            // 
            // labelMaximo
            // 
            labelMaximo.AutoSize = true;
            labelMaximo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMaximo.Location = new Point(611, 424);
            labelMaximo.Name = "labelMaximo";
            labelMaximo.Size = new Size(163, 17);
            labelMaximo.TabIndex = 31;
            labelMaximo.Text = "Máximo Letras Email:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(12, 461);
            button1.Name = "button1";
            button1.Size = new Size(144, 42);
            button1.TabIndex = 32;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(194, 461);
            button2.Name = "button2";
            button2.Size = new Size(145, 42);
            button2.TabIndex = 33;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button3.Location = new Point(419, 461);
            button3.Name = "button3";
            button3.Size = new Size(148, 42);
            button3.TabIndex = 34;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button4.Location = new Point(611, 461);
            button4.Name = "button4";
            button4.Size = new Size(146, 42);
            button4.TabIndex = 35;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(543, 275);
            button5.Name = "button5";
            button5.Size = new Size(242, 49);
            button5.TabIndex = 36;
            button5.Text = "Generar PDF";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 515);
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
            Controls.Add(clientes);
            Controls.Add(idcliente);
            Controls.Add(consultar_clientes_esp);
            Controls.Add(menuprincipal);
            Controls.Add(consultar_clientes);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ConsultarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarClientes";
            ((System.ComponentModel.ISupportInitialize)clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView clientes;
        private TextBox idcliente;
        private Button consultar_clientes_esp;
        private Button menuprincipal;
        private Button consultar_clientes;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelSuma;
        private Label labelPromedio;
        private Label labelMinimo;
        private Label labelMaximo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}