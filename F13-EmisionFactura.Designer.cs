namespace TPP3___Prototipos_de_Pantallas
{
    partial class F13_EmisionFactura
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            TipoMov = new DataGridViewTextBoxColumn();
            NGuia = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Factura = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(641, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 41);
            label1.TabIndex = 0;
            label1.Text = "Emisión de Facturas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 55);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 5;
            label2.Text = "Cliente";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "AAA123", "BBB456", "CCC789" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AAA123", "BBB456", "CCC789" });
            comboBox1.Location = new Point(36, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 31);
            comboBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(48, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1443, 333);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes a facturar";
            // 
            // button2
            // 
            button2.Location = new Point(196, 261);
            button2.Name = "button2";
            button2.Size = new Size(145, 47);
            button2.TabIndex = 18;
            button2.Text = "Generar Factura";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(37, 263);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 17;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(37, 213);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(304, 30);
            dateTimePicker2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 186);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 15;
            label4.Text = "Fin del plazo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(36, 145);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(305, 30);
            dateTimePicker1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 121);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 13;
            label3.Text = "Inicio del plazo";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, TipoMov, NGuia, Importe, Estado });
            dataGridView1.Location = new Point(366, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1053, 247);
            dataGridView1.TabIndex = 12;
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
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Cliente, Factura, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(366, 37);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(852, 207);
            dataGridView2.TabIndex = 13;
            // 
            // Cliente
            // 
            Cliente.Frozen = true;
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 200;
            // 
            // Factura
            // 
            Factura.Frozen = true;
            Factura.HeaderText = "N° Factura";
            Factura.MinimumWidth = 6;
            Factura.Name = "Factura";
            Factura.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Frozen = true;
            dataGridViewTextBoxColumn4.HeaderText = "Importe";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Frozen = true;
            dataGridViewTextBoxColumn5.HeaderText = "Estado";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(48, 428);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1254, 263);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Facturas emitidas";
            // 
            // button5
            // 
            button5.Location = new Point(97, 157);
            button5.Name = "button5";
            button5.Size = new Size(145, 54);
            button5.TabIndex = 20;
            button5.Text = "Imputar Cobro";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(97, 74);
            button4.Name = "button4";
            button4.Size = new Size(145, 55);
            button4.TabIndex = 19;
            button4.Text = "Registrar Factura ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1360, 638);
            button6.Name = "button6";
            button6.Size = new Size(107, 34);
            button6.TabIndex = 15;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(220, 78);
            button3.Name = "button3";
            button3.Size = new Size(121, 34);
            button3.TabIndex = 19;
            button3.Text = "Limpiar filtros";
            button3.UseVisualStyleBackColor = true;
            // 
            // F13_EmisionFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 716);
            Controls.Add(button6);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "F13_EmisionFactura";
            Text = "3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn TipoMov;
        private DataGridViewTextBoxColumn NGuia;
        private DataGridViewTextBoxColumn Importe;
        private DataGridViewTextBoxColumn Estado;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Factura;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private GroupBox groupBox2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
    }
}