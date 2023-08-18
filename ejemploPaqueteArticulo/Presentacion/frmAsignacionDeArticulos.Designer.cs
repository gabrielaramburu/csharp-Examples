namespace Presentacion
{
    partial class frmAsignacionDeArticulos
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
            panel1 = new Panel();
            label1 = new Label();
            comboPaquetesAsignacion = new ComboBox();
            button3 = new Button();
            butSacar = new Button();
            butAgregar = new Button();
            label4 = new Label();
            listDestino = new ListBox();
            label3 = new Label();
            listOrigen = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label8 = new Label();
            listArtPaquetes = new ListBox();
            txtFechaPaquete = new TextBox();
            label7 = new Label();
            txtDescPaquete = new TextBox();
            label6 = new Label();
            label5 = new Label();
            comboPaquetesDisponibles = new ComboBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboPaquetesAsignacion);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(butSacar);
            panel1.Controls.Add(butAgregar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(listDestino);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(listOrigen);
            panel1.Location = new Point(17, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 442);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 24;
            label1.Text = "Paquetes Disponibles";
            // 
            // comboPaquetesAsignacion
            // 
            comboPaquetesAsignacion.FormattingEnabled = true;
            comboPaquetesAsignacion.Location = new Point(30, 45);
            comboPaquetesAsignacion.Name = "comboPaquetesAsignacion";
            comboPaquetesAsignacion.Size = new Size(274, 23);
            comboPaquetesAsignacion.TabIndex = 23;
            comboPaquetesAsignacion.SelectedIndexChanged += comboPaquetesAsignacion_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(607, 391);
            button3.Name = "button3";
            button3.Size = new Size(143, 30);
            button3.TabIndex = 22;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // butSacar
            // 
            butSacar.Location = new Point(355, 298);
            butSacar.Name = "butSacar";
            butSacar.Size = new Size(106, 31);
            butSacar.TabIndex = 21;
            butSacar.Text = "<<";
            butSacar.UseVisualStyleBackColor = true;
            butSacar.Click += butSacar_Click_1;
            // 
            // butAgregar
            // 
            butAgregar.Location = new Point(357, 191);
            butAgregar.Name = "butAgregar";
            butAgregar.Size = new Size(98, 39);
            butAgregar.TabIndex = 20;
            butAgregar.Text = ">>";
            butAgregar.UseVisualStyleBackColor = true;
            butAgregar.Click += butAgregar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 130);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 19;
            label4.Text = "Artículos con paquete";
            // 
            // listDestino
            // 
            listDestino.FormattingEnabled = true;
            listDestino.ItemHeight = 15;
            listDestino.Location = new Point(489, 156);
            listDestino.Name = "listDestino";
            listDestino.Size = new Size(261, 229);
            listDestino.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 130);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 17;
            label3.Text = "Artículos sin paquete";
            // 
            // listOrigen
            // 
            listOrigen.FormattingEnabled = true;
            listOrigen.ItemHeight = 15;
            listOrigen.Location = new Point(26, 155);
            listOrigen.Name = "listOrigen";
            listOrigen.Size = new Size(278, 229);
            listOrigen.TabIndex = 16;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(33, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(859, 494);
            tabControl1.TabIndex = 13;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(851, 466);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Asignar articulos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(listArtPaquetes);
            tabPage2.Controls.Add(txtFechaPaquete);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtDescPaquete);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(comboPaquetesDisponibles);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(851, 466);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ver Paquetes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(532, 41);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 7;
            label8.Text = "Artículos del paquete";
            // 
            // listArtPaquetes
            // 
            listArtPaquetes.FormattingEnabled = true;
            listArtPaquetes.ItemHeight = 15;
            listArtPaquetes.Location = new Point(532, 68);
            listArtPaquetes.Name = "listArtPaquetes";
            listArtPaquetes.Size = new Size(264, 349);
            listArtPaquetes.TabIndex = 6;
            // 
            // txtFechaPaquete
            // 
            txtFechaPaquete.Location = new Point(30, 158);
            txtFechaPaquete.Name = "txtFechaPaquete";
            txtFechaPaquete.Size = new Size(132, 23);
            txtFechaPaquete.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 140);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 4;
            label7.Text = "Fecha";
            // 
            // txtDescPaquete
            // 
            txtDescPaquete.Location = new Point(30, 105);
            txtDescPaquete.Name = "txtDescPaquete";
            txtDescPaquete.Size = new Size(196, 23);
            txtDescPaquete.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 87);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 2;
            label6.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 23);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 1;
            label5.Text = "Paquetes disponibles";
            // 
            // comboPaquetesDisponibles
            // 
            comboPaquetesDisponibles.FormattingEnabled = true;
            comboPaquetesDisponibles.Location = new Point(30, 41);
            comboPaquetesDisponibles.Name = "comboPaquetesDisponibles";
            comboPaquetesDisponibles.Size = new Size(262, 23);
            comboPaquetesDisponibles.TabIndex = 0;
            comboPaquetesDisponibles.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // frmAsignacionDeArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 518);
            Controls.Add(tabControl1);
            Name = "frmAsignacionDeArticulos";
            Text = "Asignación de Artículos";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button3;
        private Button butSacar;
        private Button butAgregar;
        private Label label4;
        private ListBox listDestino;
        private Label label3;
        private ListBox listOrigen;
        private TextBox txtFechaPaquete;
        private Label label7;
        private TextBox txtDescPaquete;
        private Label label6;
        private Label label5;
        private ComboBox comboPaquetesDisponibles;
        private Label label8;
        private ListBox listArtPaquetes;
        private Label label1;
        private ComboBox comboPaquetesAsignacion;
    }
}