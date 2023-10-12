namespace Presentacion
{
    partial class Form2
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
            panel1 = new Panel();
            butPujar = new Button();
            textUsuario = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            butActualizar = new Button();
            textMontoMax = new TextBox();
            label2 = new Label();
            textFechaLimite = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(butPujar);
            panel1.Controls.Add(textUsuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(59, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 198);
            panel1.TabIndex = 14;
            // 
            // butPujar
            // 
            butPujar.Location = new Point(240, 67);
            butPujar.Name = "butPujar";
            butPujar.Size = new Size(140, 39);
            butPujar.TabIndex = 4;
            butPujar.Text = "Pujar";
            butPujar.UseVisualStyleBackColor = true;
            // 
            // textUsuario
            // 
            textUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textUsuario.Location = new Point(17, 114);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(156, 39);
            textUsuario.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 91);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 2;
            label4.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(15, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 39);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 0;
            label3.Text = "Monto";
            // 
            // butActualizar
            // 
            butActualizar.Location = new Point(516, 92);
            butActualizar.Name = "butActualizar";
            butActualizar.Size = new Size(124, 34);
            butActualizar.TabIndex = 13;
            butActualizar.Text = "Actualizar";
            butActualizar.UseVisualStyleBackColor = true;
            // 
            // textMontoMax
            // 
            textMontoMax.Location = new Point(310, 105);
            textMontoMax.Name = "textMontoMax";
            textMontoMax.Size = new Size(134, 23);
            textMontoMax.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 79);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 11;
            label2.Text = "Monto máximo actual";
            // 
            // textFechaLimite
            // 
            textFechaLimite.Location = new Point(54, 103);
            textFechaLimite.Name = "textFechaLimite";
            textFechaLimite.Size = new Size(162, 23);
            textFechaLimite.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 79);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 9;
            label1.Text = "Fecha limite";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(55, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(263, 23);
            comboBox1.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 374);
            Controls.Add(panel1);
            Controls.Add(butActualizar);
            Controls.Add(textMontoMax);
            Controls.Add(label2);
            Controls.Add(textFechaLimite);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button butPujar;
        private TextBox textUsuario;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Button butActualizar;
        private TextBox textMontoMax;
        private Label label2;
        private TextBox textFechaLimite;
        private Label label1;
        private ComboBox comboBox1;
    }
}