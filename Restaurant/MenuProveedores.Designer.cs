namespace Restaurant
{
    partial class MenuProveedores
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
            consultar_prov = new Button();
            insertar_prov = new Button();
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
            menuprincipal.Location = new Point(533, 309);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 20;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // consultar_prov
            // 
            consultar_prov.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultar_prov.Location = new Point(282, 95);
            consultar_prov.Name = "consultar_prov";
            consultar_prov.Size = new Size(176, 86);
            consultar_prov.TabIndex = 19;
            consultar_prov.Text = "Consultar Proveedores";
            consultar_prov.UseVisualStyleBackColor = true;
            consultar_prov.Click += consultar_prov_Click;
            // 
            // insertar_prov
            // 
            insertar_prov.Font = new Font("Arial Rounded MT Bold", 16.2F);
            insertar_prov.Location = new Point(33, 95);
            insertar_prov.Name = "insertar_prov";
            insertar_prov.Size = new Size(176, 86);
            insertar_prov.TabIndex = 18;
            insertar_prov.Text = "Agregar Proveedores";
            insertar_prov.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(533, 95);
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
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(569, 46);
            label1.TabIndex = 16;
            label1.Text = "Proveedores del Restaurant";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(282, 244);
            button1.Name = "button1";
            button1.Size = new Size(176, 86);
            button1.TabIndex = 22;
            button1.Text = "Eliminar Proveedores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(33, 244);
            button2.Name = "button2";
            button2.Size = new Size(176, 86);
            button2.TabIndex = 21;
            button2.Text = "Editar Proveedores";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MenuProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(menuprincipal);
            Controls.Add(consultar_prov);
            Controls.Add(insertar_prov);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "MenuProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuProveedores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuprincipal;
        private Button consultar_prov;
        private Button insertar_prov;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}