namespace WinFormsApp
{
    partial class MenuPrincipal : Form
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button3
            // 
            button3.Location = new Point(340, 127);
            button3.Name = "button3";
            button3.Size = new Size(128, 44);
            button3.TabIndex = 3;
            button3.Text = "Crear Alumno";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(340, 177);
            button4.Name = "button4";
            button4.Size = new Size(128, 48);
            button4.TabIndex = 4;
            button4.Text = "Modificar Alumno";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(340, 231);
            button5.Name = "button5";
            button5.Size = new Size(128, 44);
            button5.TabIndex = 5;
            button5.Text = "Eliminar Alumno";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 104);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 6;
            label1.Text = "Menú Principal";
            label1.Click += label1_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "MenuPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}
