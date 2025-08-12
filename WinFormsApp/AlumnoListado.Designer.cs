namespace WinFormsApp
{
    partial class AlumnoListado
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
            eliminarButton = new Button();
            modificarButton = new Button();
            agregarButton = new Button();
            AlumnoDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AlumnoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(897, 500);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(98, 34);
            eliminarButton.TabIndex = 7;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(547, 500);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(98, 34);
            modificarButton.TabIndex = 6;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(222, 500);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(98, 34);
            agregarButton.TabIndex = 5;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // AlumnoDataGridView
            // 
            AlumnoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AlumnoDataGridView.Location = new Point(12, 12);
            AlumnoDataGridView.Name = "AlumnoDataGridView";
            AlumnoDataGridView.Size = new Size(1192, 470);
            AlumnoDataGridView.TabIndex = 4;
            // 
            // AlumnoListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 552);
            Controls.Add(eliminarButton);
            Controls.Add(modificarButton);
            Controls.Add(agregarButton);
            Controls.Add(AlumnoDataGridView);
            Name = "AlumnoListado";
            Text = "AlumnoListado";
            Load += AlumnoListado_Load;
            ((System.ComponentModel.ISupportInitialize)AlumnoDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button eliminarButton;
        private Button modificarButton;
        private Button agregarButton;
        private DataGridView AlumnoDataGridView;
    }
}