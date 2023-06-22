namespace WinFormsApp1
{
    partial class frmLogin
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
            Usuario = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Usuario.Location = new Point(14, 22);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(102, 32);
            Usuario.TabIndex = 0;
            Usuario.Text = "Usuario";
            Usuario.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 126);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 1;
            label1.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(14, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(14, 161);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(305, 39);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(14, 251);
            button1.Name = "button1";
            button1.Size = new Size(305, 46);
            button1.TabIndex = 4;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 352);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Usuario);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Usuario;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}