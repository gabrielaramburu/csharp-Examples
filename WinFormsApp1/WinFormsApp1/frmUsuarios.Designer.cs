namespace WinFormsApp1
{
    partial class frmUsuarios
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(578, 272);
            button1.Name = "button1";
            button1.Size = new Size(115, 34);
            button1.TabIndex = 0;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(354, 222);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(15, 272);
            button2.Name = "button2";
            button2.Size = new Size(115, 34);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 80);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(400, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(400, 154);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(247, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(400, 206);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 132);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 184);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 8;
            label3.Text = "Repetir contrasea";
            // 
            // button3
            // 
            button3.Location = new Point(254, 272);
            button3.Name = "button3";
            button3.Size = new Size(115, 34);
            button3.TabIndex = 9;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(136, 272);
            button4.Name = "button4";
            button4.Size = new Size(115, 34);
            button4.TabIndex = 10;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 28);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 11;
            label4.Text = "id";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(400, 50);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(78, 23);
            textBox4.TabIndex = 12;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 327);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "frmUsuarios";
            Text = "Mantenimiento de usuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button4;
        private Label label4;
        private TextBox textBox4;
    }
}