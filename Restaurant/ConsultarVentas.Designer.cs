namespace Restaurant
{
    partial class ConsultarVentas
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
            ventas = new DataGridView();
            idventa = new TextBox();
            consultarventaesp = new Button();
            menuprincipal = new Button();
            consultarvent = new Button();
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
            ((System.ComponentModel.ISupportInitialize)ventas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 94);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 51;
            label2.Text = "No. de Venta:";
            // 
            // ventas
            // 
            ventas.AllowUserToAddRows = false;
            ventas.AllowUserToDeleteRows = false;
            ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ventas.Location = new Point(12, 165);
            ventas.Name = "ventas";
            ventas.ReadOnly = true;
            ventas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            ventas.ScrollBars = ScrollBars.Horizontal;
            ventas.Size = new Size(525, 240);
            ventas.TabIndex = 50;
            // 
            // idventa
            // 
            idventa.Location = new Point(197, 120);
            idventa.Name = "idventa";
            idventa.Size = new Size(164, 27);
            idventa.TabIndex = 49;
            // 
            // consultarventaesp
            // 
            consultarventaesp.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultarventaesp.Location = new Point(367, 108);
            consultarventaesp.Name = "consultarventaesp";
            consultarventaesp.Size = new Size(170, 42);
            consultarventaesp.TabIndex = 48;
            consultarventaesp.Text = "Específico";
            consultarventaesp.UseVisualStyleBackColor = true;
            consultarventaesp.Click += consultarventaesp_Click;
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(564, 344);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 47;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // consultarvent
            // 
            consultarvent.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultarvent.Location = new Point(12, 108);
            consultarvent.Name = "consultarvent";
            consultarvent.Size = new Size(137, 42);
            consultarvent.TabIndex = 46;
            consultarvent.Text = "General";
            consultarvent.UseVisualStyleBackColor = true;
            consultarvent.Click += consultarvent_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(564, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(654, 46);
            label1.TabIndex = 44;
            label1.Text = "Consultar Ventas del Restaurant";
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button4.Location = new Point(621, 460);
            button4.Name = "button4";
            button4.Size = new Size(146, 42);
            button4.TabIndex = 59;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button3.Location = new Point(419, 460);
            button3.Name = "button3";
            button3.Size = new Size(148, 42);
            button3.TabIndex = 58;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(194, 460);
            button2.Name = "button2";
            button2.Size = new Size(145, 42);
            button2.TabIndex = 57;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(12, 460);
            button1.Name = "button1";
            button1.Size = new Size(144, 42);
            button1.TabIndex = 56;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelMaximo
            // 
            labelMaximo.AutoSize = true;
            labelMaximo.Font = new Font("Arial Rounded MT Bold", 10.8F);
            labelMaximo.Location = new Point(621, 423);
            labelMaximo.Name = "labelMaximo";
            labelMaximo.Size = new Size(139, 21);
            labelMaximo.TabIndex = 55;
            labelMaximo.Text = "Venta Máxima:";
            // 
            // labelMinimo
            // 
            labelMinimo.AutoSize = true;
            labelMinimo.Font = new Font("Arial Rounded MT Bold", 10.8F);
            labelMinimo.Location = new Point(419, 423);
            labelMinimo.Name = "labelMinimo";
            labelMinimo.Size = new Size(135, 21);
            labelMinimo.TabIndex = 54;
            labelMinimo.Text = "Venta Mínima:";
            // 
            // labelPromedio
            // 
            labelPromedio.AutoSize = true;
            labelPromedio.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPromedio.Location = new Point(194, 423);
            labelPromedio.Name = "labelPromedio";
            labelPromedio.Size = new Size(167, 21);
            labelPromedio.TabIndex = 53;
            labelPromedio.Text = "Promedio Ventas:";
            // 
            // labelSuma
            // 
            labelSuma.AutoSize = true;
            labelSuma.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSuma.Location = new Point(12, 423);
            labelSuma.Name = "labelSuma";
            labelSuma.Size = new Size(117, 20);
            labelSuma.TabIndex = 52;
            labelSuma.Text = "Total Ventas:";
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(564, 277);
            button5.Name = "button5";
            button5.Size = new Size(242, 49);
            button5.TabIndex = 60;
            button5.Text = "Generar PDF";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ConsultarVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 519);
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
            Controls.Add(ventas);
            Controls.Add(idventa);
            Controls.Add(consultarventaesp);
            Controls.Add(menuprincipal);
            Controls.Add(consultarvent);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ConsultarVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarVentas";
            ((System.ComponentModel.ISupportInitialize)ventas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView ventas;
        private TextBox idventa;
        private Button consultarventaesp;
        private Button menuprincipal;
        private Button consultarvent;
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