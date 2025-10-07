namespace TPP3___Prototipos_de_Pantallas
{
    partial class InicioSesionForm
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblIniciarsesion = new Label();
            button1 = new Button();
            grpCredenciales = new GroupBox();
            grpCredenciales.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(13, 45);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += label1_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(13, 122);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 3;
            // 
            // lblIniciarsesion
            // 
            lblIniciarsesion.AutoSize = true;
            lblIniciarsesion.Font = new Font("Segoe UI", 16F);
            lblIniciarsesion.Location = new Point(193, 30);
            lblIniciarsesion.Name = "lblIniciarsesion";
            lblIniciarsesion.Size = new Size(199, 37);
            lblIniciarsesion.TabIndex = 4;
            lblIniciarsesion.Text = "Inicio de sesión";
            // 
            // button1
            // 
            button1.Location = new Point(223, 304);
            button1.Name = "button1";
            button1.Size = new Size(145, 53);
            button1.TabIndex = 5;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            // 
            // grpCredenciales
            // 
            grpCredenciales.Controls.Add(textBox2);
            grpCredenciales.Controls.Add(lblUsuario);
            grpCredenciales.Controls.Add(lblContraseña);
            grpCredenciales.Controls.Add(textBox1);
            grpCredenciales.Location = new Point(180, 92);
            grpCredenciales.Name = "grpCredenciales";
            grpCredenciales.Size = new Size(231, 189);
            grpCredenciales.TabIndex = 6;
            grpCredenciales.TabStop = false;
            grpCredenciales.Text = "Credenciales";
            grpCredenciales.Enter += groupBox1_Enter;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 397);
            Controls.Add(grpCredenciales);
            Controls.Add(button1);
            Controls.Add(lblIniciarsesion);
            Name = "InicioSesion";
            Text = "Form1";
            Load += InicioSesion_Load;
            grpCredenciales.ResumeLayout(false);
            grpCredenciales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblIniciarsesion;
        private Button button1;
        private GroupBox grpCredenciales;
    }
}
