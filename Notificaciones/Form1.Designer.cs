namespace Notificaciones
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            btnAgregar = new Button();
            label3 = new Label();
            txtMensaje = new TextBox();
            btnEnviarEmail = new Button();
            btnEnviarSMS = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 24);
            label1.Name = "label1";
            label1.Size = new Size(204, 38);
            label1.TabIndex = 0;
            label1.Text = "Notificaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(60, 98);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(193, 98);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(403, 34);
            txtUsuario.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(636, 93);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 44);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(60, 166);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 4;
            label3.Text = "Mensaje:";
            // 
            // txtMensaje
            // 
            txtMensaje.Font = new Font("Segoe UI", 12F);
            txtMensaje.Location = new Point(193, 163);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(403, 174);
            txtMensaje.TabIndex = 5;
            // 
            // btnEnviarEmail
            // 
            btnEnviarEmail.Font = new Font("Segoe UI", 12F);
            btnEnviarEmail.Location = new Point(193, 381);
            btnEnviarEmail.Name = "btnEnviarEmail";
            btnEnviarEmail.Size = new Size(200, 44);
            btnEnviarEmail.TabIndex = 6;
            btnEnviarEmail.Text = "Enviar por Email";
            btnEnviarEmail.UseVisualStyleBackColor = true;
            btnEnviarEmail.Click += btnEnviarEmail_Click;
            // 
            // btnEnviarSMS
            // 
            btnEnviarSMS.Font = new Font("Segoe UI", 12F);
            btnEnviarSMS.Location = new Point(399, 381);
            btnEnviarSMS.Name = "btnEnviarSMS";
            btnEnviarSMS.Size = new Size(200, 44);
            btnEnviarSMS.TabIndex = 7;
            btnEnviarSMS.Text = "Enviar por SMS";
            btnEnviarSMS.UseVisualStyleBackColor = true;
            btnEnviarSMS.Click += btnEnviarSMS_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviarSMS);
            Controls.Add(btnEnviarEmail);
            Controls.Add(txtMensaje);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Notificaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Button btnAgregar;
        private Label label3;
        private TextBox txtMensaje;
        private Button btnEnviarEmail;
        private Button btnEnviarSMS;
    }
}
