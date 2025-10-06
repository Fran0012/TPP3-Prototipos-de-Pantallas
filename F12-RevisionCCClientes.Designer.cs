namespace TPP3___Prototipos_de_Pantallas
{
    partial class F12_RevisionCCClientes
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
            label1 = new Label();
            lblTitulo = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            TipoMov = new DataGridViewTextBoxColumn();
            NGuia = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            button3 = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(597, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.Control;
            lblTitulo.Cursor = Cursors.IBeam;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(306, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(641, 40);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cuentas Corrientes - Clientes";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "AAA123", "BBB456", "CCC789" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AAA123", "BBB456", "CCC789" });
            comboBox1.Location = new Point(32, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 31);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 28);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 4;
            label3.Text = "Inicio del plazo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(267, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(268, 120);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(292, 27);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 93);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 6;
            label4.Text = "Fin del plazo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 93);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 9;
            label5.Text = "Tipo de transporte";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Larga distancia", "Ultima milla" });
            comboBox2.Location = new Point(32, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(198, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 172);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // button2
            // 
            button2.Location = new Point(647, 52);
            button2.Name = "button2";
            button2.Size = new Size(136, 34);
            button2.TabIndex = 11;
            button2.Text = "Limpiar filtros";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(647, 93);
            button1.Name = "button1";
            button1.Size = new Size(136, 54);
            button1.TabIndex = 10;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, TipoMov, NGuia, Importe, Estado });
            dataGridView1.Location = new Point(90, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1052, 181);
            dataGridView1.TabIndex = 11;
            // 
            // Fecha
            // 
            Fecha.Frozen = true;
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 200;
            // 
            // TipoMov
            // 
            TipoMov.Frozen = true;
            TipoMov.HeaderText = "Tipo Movimiento";
            TipoMov.MinimumWidth = 6;
            TipoMov.Name = "TipoMov";
            TipoMov.ReadOnly = true;
            TipoMov.Width = 200;
            // 
            // NGuia
            // 
            NGuia.Frozen = true;
            NGuia.HeaderText = "N° de Guía";
            NGuia.MinimumWidth = 6;
            NGuia.Name = "NGuia";
            NGuia.ReadOnly = true;
            NGuia.Width = 200;
            // 
            // Importe
            // 
            Importe.Frozen = true;
            Importe.HeaderText = "Importe";
            Importe.MinimumWidth = 6;
            Importe.Name = "Importe";
            Importe.ReadOnly = true;
            Importe.Width = 200;
            // 
            // Estado
            // 
            Estado.Frozen = true;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 200;
            // 
            // button3
            // 
            button3.Location = new Point(909, 538);
            button3.Name = "button3";
            button3.Size = new Size(110, 34);
            button3.TabIndex = 12;
            button3.Text = "Facturar";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(92, 477);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(657, 102);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen de consumos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 45);
            label6.Name = "label6";
            label6.Size = new Size(349, 20);
            label6.TabIndex = 14;
            label6.Text = "Monto adeudado por cuentas en estado pendiente:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(402, 45);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(211, 31);
            textBox1.TabIndex = 13;
            textBox1.Text = "$1200.50";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.Location = new Point(1035, 538);
            button4.Name = "button4";
            button4.Size = new Size(107, 34);
            button4.TabIndex = 14;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            // 
            // F12_RevisionCCClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 600);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Name = "F12_RevisionCCClientes";
            Text = "F12_RevisionCCClientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitulo;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn TipoMov;
        private DataGridViewTextBoxColumn NGuia;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn Estado;
        private Button button3;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label6;
        private Button button4;
    }
}