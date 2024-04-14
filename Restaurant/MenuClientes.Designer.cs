namespace Restaurant
{
    partial class MenuClientes
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
            menuprincipal = new Button();
            consultar_cli = new Button();
            insertar_cli = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(543, 309);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 15;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // consultar_cli
            // 
            consultar_cli.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultar_cli.Location = new Point(292, 95);
            consultar_cli.Name = "consultar_cli";
            consultar_cli.Size = new Size(176, 86);
            consultar_cli.TabIndex = 14;
            consultar_cli.Text = "Consultar Clientes";
            consultar_cli.UseVisualStyleBackColor = true;
            consultar_cli.Click += consultar_cli_Click;
            // 
            // insertar_cli
            // 
            insertar_cli.Font = new Font("Arial Rounded MT Bold", 16.2F);
            insertar_cli.Location = new Point(43, 95);
            insertar_cli.Name = "insertar_cli";
            insertar_cli.Size = new Size(176, 86);
            insertar_cli.TabIndex = 13;
            insertar_cli.Text = "Agregar Clientes";
            insertar_cli.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(543, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(477, 46);
            label1.TabIndex = 11;
            label1.Text = "Clientes del Restaurant";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(43, 229);
            button1.Name = "button1";
            button1.Size = new Size(176, 86);
            button1.TabIndex = 16;
            button1.Text = "Editar Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(292, 229);
            button2.Name = "button2";
            button2.Size = new Size(176, 86);
            button2.TabIndex = 17;
            button2.Text = "Eliminar Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MenuClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuprincipal);
            Controls.Add(consultar_cli);
            Controls.Add(insertar_cli);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "MenuClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuClientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuprincipal;
        private Button consultar_cli;
        private Button insertar_cli;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}