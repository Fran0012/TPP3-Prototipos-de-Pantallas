namespace TPP3___Prototipos_de_Pantallas
{
    partial class F1_MenuPrincipalForm
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
            Label label3;
            Label label4;
            label1 = new Label();
            GrpUser = new GroupBox();
            label2 = new Label();
            lblUser = new Label();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button10 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button11 = new Button();
            label3 = new Label();
            label4 = new Label();
            GrpUser.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 41);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(599, 41);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 3;
            label4.Text = "dd/mm/YYYY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(310, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 0;
            label1.Text = "Menú Principal";
            label1.Click += label1_Click;
            // 
            // GrpUser
            // 
            GrpUser.Controls.Add(label4);
            GrpUser.Controls.Add(label3);
            GrpUser.Controls.Add(label2);
            GrpUser.Controls.Add(lblUser);
            GrpUser.Location = new Point(44, 60);
            GrpUser.Name = "GrpUser";
            GrpUser.Size = new Size(721, 84);
            GrpUser.TabIndex = 1;
            GrpUser.TabStop = false;
            GrpUser.Text = "Sesión actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 41);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "XXXX";
            label2.Click += label2_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(32, 41);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(62, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuario:";
            lblUser.Click += lblUser_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(44, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 442);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "OPERATIVO";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button6
            // 
            button6.Location = new Point(32, 317);
            button6.Name = "button6";
            button6.Size = new Size(275, 50);
            button6.TabIndex = 5;
            button6.Text = "Consulta de Guías";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(32, 205);
            button5.Name = "button5";
            button5.Size = new Size(275, 50);
            button5.TabIndex = 4;
            button5.Text = "Recepción de Hojas de ruta";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(32, 261);
            button4.Name = "button4";
            button4.Size = new Size(275, 50);
            button4.TabIndex = 3;
            button4.Text = "Despacho a Transportistas";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(32, 149);
            button3.Name = "button3";
            button3.Size = new Size(275, 50);
            button3.TabIndex = 2;
            button3.Text = "Preparación de Despacho";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(32, 92);
            button2.Name = "button2";
            button2.Size = new Size(275, 51);
            button2.TabIndex = 1;
            button2.Text = "Admisión de Guías";
            button2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(32, 373);
            button10.Name = "button10";
            button10.Size = new Size(275, 50);
            button10.TabIndex = 6;
            button10.Text = "Entrega a clientes";
            button10.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(32, 35);
            button1.Name = "button1";
            button1.Size = new Size(275, 51);
            button1.TabIndex = 0;
            button1.Text = "Pedido de Retiro / Imposición";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Location = new Point(446, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 218);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "FINANCIERO";
            // 
            // button7
            // 
            button7.Location = new Point(19, 35);
            button7.Name = "button7";
            button7.Size = new Size(275, 51);
            button7.TabIndex = 7;
            button7.Text = "Clientes";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(19, 92);
            button8.Name = "button8";
            button8.Size = new Size(275, 51);
            button8.TabIndex = 8;
            button8.Text = "Facturación";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(19, 149);
            button9.Name = "button9";
            button9.Size = new Size(275, 51);
            button9.TabIndex = 9;
            button9.Text = "Rendimientos";
            button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackColor = Color.Firebrick;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.ButtonFace;
            button11.Location = new Point(614, 558);
            button11.Name = "button11";
            button11.Size = new Size(151, 44);
            button11.TabIndex = 10;
            button11.Text = "Cerrar sesión";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // F1_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(button11);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(GrpUser);
            Controls.Add(label1);
            Name = "F1_MenuPrincipal";
            Text = "F1_MenuPrincipal";
            Load += F1_MenuPrincipal_Load;
            GrpUser.ResumeLayout(false);
            GrpUser.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox GrpUser;
        private Label lblUser;
        private Label label2;
        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button10;
        private Button button1;
        private GroupBox groupBox2;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button11;
    }
}