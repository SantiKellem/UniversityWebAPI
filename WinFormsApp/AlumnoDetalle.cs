using DTOs;
using API.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public enum FormMode
    {
        Add,
        Update
    }

    public partial class AlumnoDetalle : Form
    {
        private AlumnoDTO alumno;
        private FormMode mode;

        public AlumnoDTO Alumno
        {
            get { return alumno; }
            set
            {
                alumno = value;
                this.SetAlumno();
            }
        }

        public FormMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetFormMode(value);
            }
        }


        public AlumnoDetalle()
        {
            InitializeComponent();
            Mode = FormMode.Add;
        }

        private async void aceptarButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateAlumno())
            {
                try
                {
                    this.Alumno.Nombre = nombreTextBox.Text;
                    this.Alumno.Apellido = apellidoTextBox.Text;
                    this.Alumno.Legajo = int.Parse(legajoTextBox.Text);
                    this.Alumno.Direccion = direccionTextBox.Text;

                    if (this.Mode == FormMode.Update)
                    {
                        this.Alumno.Id = int.Parse(idTextBox.Text);
                        await AlumnoApiClient.UpdateAsync(this.Alumno);
                    }
                    else
                    {
                        await AlumnoApiClient.AddAsync(this.Alumno);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAlumno()
        {
            this.idTextBox.Text = this.Alumno.Id.ToString();
            this.nombreTextBox.Text = this.Alumno.Nombre;
            this.apellidoTextBox.Text = this.Alumno.Apellido;
            this.legajoTextBox.Text = this.Alumno.Legajo.ToString();
            this.direccionTextBox.Text = this.Alumno.Direccion;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;

            if (Mode == FormMode.Add)
            {
                idLabel.Visible = false;
                idTextBox.Visible = false;
            }

            if (Mode == FormMode.Update)
            {
                idLabel.Visible = true;
                idTextBox.Visible = true;
            }
        }

        private bool ValidateAlumno()
        {
            bool isValid = true;

            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(apellidoTextBox, string.Empty);
            errorProvider.SetError(legajoTextBox, string.Empty);
            errorProvider.SetError(direccionTextBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es requerido");
            }

            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(apellidoTextBox, "El Apellido es requerido");
            }

            if (this.legajoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(legajoTextBox, "El Legajo es requerido");
            }

            if (this.direccionTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(direccionTextBox, "La Direccion es requerida");
            }

            return isValid;
        }
    }
}
