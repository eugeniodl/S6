namespace FacturacionProductos
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
            cmboTipoProducto = new ComboBox();
            label3 = new Label();
            txtNombreProducto = new TextBox();
            label4 = new Label();
            txtPrecioBase = new TextBox();
            lblCaducidad = new Label();
            dtpFechaCaducidad = new DateTimePicker();
            btnCalcular = new Button();
            lblResultado = new Label();
            btnMostrarProductos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 38);
            label1.TabIndex = 0;
            label1.Text = "Facturación de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 76);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Producto:";
            // 
            // cmboTipoProducto
            // 
            cmboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboTipoProducto.FormattingEnabled = true;
            cmboTipoProducto.Items.AddRange(new object[] { "General", "Electrónico", "Descuento", "Perecedero" });
            cmboTipoProducto.Location = new Point(258, 73);
            cmboTipoProducto.Name = "cmboTipoProducto";
            cmboTipoProducto.Size = new Size(151, 28);
            cmboTipoProducto.TabIndex = 2;
            cmboTipoProducto.SelectedIndexChanged += cmboTipoProducto_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 131);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre del Producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(258, 128);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(151, 27);
            txtNombreProducto.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 188);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 5;
            label4.Text = "Precio base:";
            // 
            // txtPrecioBase
            // 
            txtPrecioBase.Location = new Point(258, 185);
            txtPrecioBase.Name = "txtPrecioBase";
            txtPrecioBase.Size = new Size(151, 27);
            txtPrecioBase.TabIndex = 6;
            // 
            // lblCaducidad
            // 
            lblCaducidad.AutoSize = true;
            lblCaducidad.Location = new Point(83, 249);
            lblCaducidad.Name = "lblCaducidad";
            lblCaducidad.Size = new Size(146, 20);
            lblCaducidad.TabIndex = 7;
            lblCaducidad.Text = "Fecha de Caducidad:";
            lblCaducidad.Visible = false;
            // 
            // dtpFechaCaducidad
            // 
            dtpFechaCaducidad.Format = DateTimePickerFormat.Short;
            dtpFechaCaducidad.Location = new Point(258, 244);
            dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            dtpFechaCaducidad.Size = new Size(151, 27);
            dtpFechaCaducidad.TabIndex = 8;
            dtpFechaCaducidad.Visible = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(154, 338);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(281, 340);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(107, 23);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Precio Final:";
            // 
            // btnMostrarProductos
            // 
            btnMostrarProductos.Location = new Point(461, 338);
            btnMostrarProductos.Name = "btnMostrarProductos";
            btnMostrarProductos.Size = new Size(172, 29);
            btnMostrarProductos.TabIndex = 11;
            btnMostrarProductos.Text = "Mostrar Productos";
            btnMostrarProductos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 394);
            Controls.Add(btnMostrarProductos);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(dtpFechaCaducidad);
            Controls.Add(lblCaducidad);
            Controls.Add(txtPrecioBase);
            Controls.Add(label4);
            Controls.Add(txtNombreProducto);
            Controls.Add(label3);
            Controls.Add(cmboTipoProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Facturación de Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmboTipoProducto;
        private Label label3;
        private TextBox txtNombreProducto;
        private Label label4;
        private TextBox txtPrecioBase;
        private Label lblCaducidad;
        private DateTimePicker dtpFechaCaducidad;
        private Button btnCalcular;
        private Label lblResultado;
        private Button btnMostrarProductos;
    }
}
