namespace Restaurant
{
    partial class MenuComandas
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
            consultar_com = new Button();
            insertar_com = new Button();
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
            menuprincipal.Location = new Point(536, 309);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 20;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // consultar_com
            // 
            consultar_com.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultar_com.Location = new Point(285, 95);
            consultar_com.Name = "consultar_com";
            consultar_com.Size = new Size(176, 86);
            consultar_com.TabIndex = 19;
            consultar_com.Text = "Consultar Comandas";
            consultar_com.UseVisualStyleBackColor = true;
            consultar_com.Click += consultar_com_Click;
            // 
            // insertar_com
            // 
            insertar_com.Font = new Font("Arial Rounded MT Bold", 16.2F);
            insertar_com.Location = new Point(36, 95);
            insertar_com.Name = "insertar_com";
            insertar_com.Size = new Size(176, 86);
            insertar_com.TabIndex = 18;
            insertar_com.Text = "Agregar Comandas";
            insertar_com.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(536, 95);
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
            label1.Location = new Point(106, 9);
            label1.Name = "label1";
            label1.Size = new Size(525, 46);
            label1.TabIndex = 16;
            label1.Text = "Comandas del Restaurant";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(285, 222);
            button1.Name = "button1";
            button1.Size = new Size(176, 86);
            button1.TabIndex = 22;
            button1.Text = "Eliminar Comandas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(36, 222);
            button2.Name = "button2";
            button2.Size = new Size(176, 86);
            button2.TabIndex = 21;
            button2.Text = "Editar Comandas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MenuComandas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(menuprincipal);
            Controls.Add(consultar_com);
            Controls.Add(insertar_com);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "MenuComandas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuComandas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuprincipal;
        private Button consultar_com;
        private Button insertar_com;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}