namespace Restaurant
{
    partial class MenuInventario
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
            consultar_inv = new Button();
            insertar_inv = new Button();
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
            menuprincipal.Location = new Point(539, 309);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 20;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // consultar_inv
            // 
            consultar_inv.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultar_inv.Location = new Point(288, 95);
            consultar_inv.Name = "consultar_inv";
            consultar_inv.Size = new Size(176, 86);
            consultar_inv.TabIndex = 19;
            consultar_inv.Text = "Consultar Inventario";
            consultar_inv.UseVisualStyleBackColor = true;
            consultar_inv.Click += consultar_inv_Click;
            // 
            // insertar_inv
            // 
            insertar_inv.Font = new Font("Arial Rounded MT Bold", 16.2F);
            insertar_inv.Location = new Point(39, 95);
            insertar_inv.Name = "insertar_inv";
            insertar_inv.Size = new Size(176, 86);
            insertar_inv.TabIndex = 18;
            insertar_inv.Text = "Agregar Inventario";
            insertar_inv.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(539, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(515, 46);
            label1.TabIndex = 16;
            label1.Text = "Inventario del Restaurant";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(288, 228);
            button1.Name = "button1";
            button1.Size = new Size(176, 86);
            button1.TabIndex = 22;
            button1.Text = "Eliminar Inventario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(39, 228);
            button2.Name = "button2";
            button2.Size = new Size(176, 86);
            button2.TabIndex = 21;
            button2.Text = "Editar Inventario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MenuInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(menuprincipal);
            Controls.Add(consultar_inv);
            Controls.Add(insertar_inv);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "MenuInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuInventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuprincipal;
        private Button consultar_inv;
        private Button insertar_inv;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}