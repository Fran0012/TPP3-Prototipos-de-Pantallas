namespace TPP3___Prototipos_de_Pantallas
{
    partial class F2_RegistrarPedidoDeRetiro
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
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(321, 37);
            label1.TabIndex = 1;
            label1.Text = "Registrar pedido de retiro";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 315);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario de Ingreso de Datos";
            // 
            // F2_RegistrarPedidoDeRetiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 538);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "F2_RegistrarPedidoDeRetiro";
            Text = "F2_RegistrarPedidoDeRetiro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
    }
}