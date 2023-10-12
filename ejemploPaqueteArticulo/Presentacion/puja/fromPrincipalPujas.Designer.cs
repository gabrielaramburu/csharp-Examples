namespace Presentacion.puja
{
    partial class fromPrincipalPujas
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMonoMaximoPuja = new TextBox();
            txtFechaLimitePuja = new TextBox();
            txtUsuarioPuja = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            botPujar = new Button();
            txtMonto = new TextBox();
            txtUsuario = new TextBox();
            Monto = new Label();
            Usuario = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 6);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Remates Activos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 73);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Monto Máximo Puja";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 73);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 3;
            label3.Text = "Fecha Limite";
            // 
            // txtMonoMaximoPuja
            // 
            txtMonoMaximoPuja.Enabled = false;
            txtMonoMaximoPuja.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonoMaximoPuja.Location = new Point(21, 95);
            txtMonoMaximoPuja.Name = "txtMonoMaximoPuja";
            txtMonoMaximoPuja.Size = new Size(144, 39);
            txtMonoMaximoPuja.TabIndex = 4;
            // 
            // txtFechaLimitePuja
            // 
            txtFechaLimitePuja.Enabled = false;
            txtFechaLimitePuja.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtFechaLimitePuja.Location = new Point(519, 95);
            txtFechaLimitePuja.Name = "txtFechaLimitePuja";
            txtFechaLimitePuja.Size = new Size(269, 39);
            txtFechaLimitePuja.TabIndex = 5;
            // 
            // txtUsuarioPuja
            // 
            txtUsuarioPuja.Enabled = false;
            txtUsuarioPuja.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioPuja.Location = new Point(191, 95);
            txtUsuarioPuja.Name = "txtUsuarioPuja";
            txtUsuarioPuja.Size = new Size(144, 39);
            txtUsuarioPuja.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 77);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Usuario Puja";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(botPujar);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(Monto);
            groupBox1.Controls.Add(Usuario);
            groupBox1.Location = new Point(24, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 181);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva puja";
            // 
            // botPujar
            // 
            botPujar.Location = new Point(231, 50);
            botPujar.Name = "botPujar";
            botPujar.Size = new Size(171, 51);
            botPujar.TabIndex = 4;
            botPujar.Text = "Pujar";
            botPujar.UseVisualStyleBackColor = true;
            botPujar.Click += botPujar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.Location = new Point(12, 133);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(186, 39);
            txtMonto.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(15, 50);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(179, 39);
            txtUsuario.TabIndex = 2;
            // 
            // Monto
            // 
            Monto.AutoSize = true;
            Monto.Location = new Point(15, 32);
            Monto.Name = "Monto";
            Monto.Size = new Size(47, 15);
            Monto.TabIndex = 1;
            Monto.Text = "Usuario";
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(15, 115);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(43, 15);
            Usuario.TabIndex = 0;
            Usuario.Text = "Monto";
            // 
            // fromPrincipalPujas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(txtUsuarioPuja);
            Controls.Add(txtFechaLimitePuja);
            Controls.Add(txtMonoMaximoPuja);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "fromPrincipalPujas";
            Text = "fromPrincipalPujas";
            Load += fromPrincipalPujas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMonoMaximoPuja;
        private TextBox txtFechaLimitePuja;
        private TextBox txtUsuarioPuja;
        private Label label4;
        private GroupBox groupBox1;
        private Button botPujar;
        private TextBox txtMonto;
        private TextBox txtUsuario;
        private Label Monto;
        private Label Usuario;
    }
}