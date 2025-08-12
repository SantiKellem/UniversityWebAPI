namespace WinFormsApp
{
    partial class AlumnoDetalle
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nombreTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            legajoTextBox = new TextBox();
            direccionTextBox = new TextBox();
            aceptarButton = new Button();
            cancelarButton = new Button();
            errorProvider = new ErrorProvider(components);
            label5 = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 84);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 149);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 211);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Legajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 273);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(62, 102);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(328, 23);
            nombreTextBox.TabIndex = 4;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(62, 167);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(328, 23);
            apellidoTextBox.TabIndex = 5;
            // 
            // legajoTextBox
            // 
            legajoTextBox.Location = new Point(62, 229);
            legajoTextBox.Name = "legajoTextBox";
            legajoTextBox.Size = new Size(328, 23);
            legajoTextBox.TabIndex = 6;
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(62, 291);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(328, 23);
            direccionTextBox.TabIndex = 7;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(62, 349);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(83, 34);
            aceptarButton.TabIndex = 8;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(307, 349);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(83, 34);
            cancelarButton.TabIndex = 9;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 41);
            label5.Name = "label5";
            label5.Size = new Size(166, 30);
            label5.TabIndex = 10;
            label5.Text = "Detalles Alumno";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(258, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(281, 50);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(109, 23);
            idTextBox.TabIndex = 12;
            // 
            // AlumnoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 426);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(label5);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(direccionTextBox);
            Controls.Add(legajoTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AlumnoDetalle";
            Text = "AlumnoDetalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nombreTextBox;
        private TextBox apellidoTextBox;
        private TextBox legajoTextBox;
        private TextBox direccionTextBox;
        private Button aceptarButton;
        private Button cancelarButton;
        private ErrorProvider errorProvider;
        private Label label5;
        private TextBox idTextBox;
        private Label idLabel;
    }
}