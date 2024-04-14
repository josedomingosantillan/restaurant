namespace Restaurant
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            passw = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(510, 46);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al Restaurant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label2.Location = new Point(58, 233);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 16.2F);
            label3.Location = new Point(429, 233);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            label3.Click += label3_Click;
            // 
            // username
            // 
            username.Location = new Point(58, 279);
            username.Name = "username";
            username.Size = new Size(294, 27);
            username.TabIndex = 3;
            // 
            // passw
            // 
            passw.Location = new Point(429, 279);
            passw.Name = "passw";
            passw.Size = new Size(294, 27);
            passw.TabIndex = 4;
            passw.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(266, 346);
            button1.Name = "button1";
            button1.Size = new Size(246, 54);
            button1.TabIndex = 5;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_usuario;
            pictureBox1.Location = new Point(302, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(passw);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private TextBox passw;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
