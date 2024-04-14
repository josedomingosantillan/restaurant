namespace Restaurant
{
    partial class EliminarComandas
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
            actualizaruser = new Button();
            selectComandas = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(126, 303);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 36;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // actualizaruser
            // 
            actualizaruser.Font = new Font("Arial Rounded MT Bold", 16.2F);
            actualizaruser.Location = new Point(416, 303);
            actualizaruser.Name = "actualizaruser";
            actualizaruser.Size = new Size(177, 49);
            actualizaruser.TabIndex = 35;
            actualizaruser.Text = "Eliminar";
            actualizaruser.UseVisualStyleBackColor = true;
            actualizaruser.Click += actualizaruser_Click;
            // 
            // selectComandas
            // 
            selectComandas.FormattingEnabled = true;
            selectComandas.Location = new Point(227, 182);
            selectComandas.Name = "selectComandas";
            selectComandas.Size = new Size(397, 28);
            selectComandas.TabIndex = 34;
            selectComandas.Text = "Selecciona una Comanda.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(41, 176);
            label5.Name = "label5";
            label5.Size = new Size(180, 34);
            label5.TabIndex = 33;
            label5.Text = "Comandas:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(796, 93);
            label1.TabIndex = 32;
            label1.Text = "Eliminar Comandas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(633, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // EliminarComandas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuprincipal);
            Controls.Add(actualizaruser);
            Controls.Add(selectComandas);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EliminarComandas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EliminarComandas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuprincipal;
        private Button actualizaruser;
        private ComboBox selectComandas;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}