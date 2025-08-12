using DTOs;
using API.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AlumnoListado : Form
    {
        public AlumnoListado()
        {
            InitializeComponent();
        }

        private async void AlumnoListado_Load(object sender, EventArgs e)
        {
            await this.GetAllAndLoad();
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await GetAllAndLoad();
        }

        private async Task GetAllAndLoad()
        {
            try
            {
                this.AlumnoDataGridView.DataSource = null;
                this.AlumnoDataGridView.DataSource = await AlumnoApiClient.GetAllAsync();

                if (this.AlumnoDataGridView.Rows.Count > 0)
                {
                    this.AlumnoDataGridView.Rows[0].Selected = true;
                    this.eliminarButton.Enabled = true;
                    this.modificarButton.Enabled = true;
                }
                else
                {
                    this.eliminarButton.Enabled = false;
                    this.modificarButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de alumnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private AlumnoDTO SelectedItem()
        {
            AlumnoDTO alumno;

            alumno = (AlumnoDTO)AlumnoDataGridView.SelectedRows[0].DataBoundItem;

            return alumno;
        }

        private async void agregarButton_Click(object sender, EventArgs e)
        {
            var alumnoDetalle = new AlumnoDetalle();

            var newAlumno = new AlumnoDTO();

            alumnoDetalle.Mode = FormMode.Add;
            alumnoDetalle.Alumno = newAlumno;

            alumnoDetalle.ShowDialog();

            await this.GetAllAndLoad();

        }

        private async void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var alumnoDetalle = new AlumnoDetalle();

                int id = this.SelectedItem().Id;

                var alum = await AlumnoApiClient.GetAsync(id);

                alumnoDetalle.Mode = FormMode.Update;
                alumnoDetalle.Alumno = alum;

                alumnoDetalle.ShowDialog();

                await this.GetAllAndLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar alumno para modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = this.SelectedItem().Id;

                var result = MessageBox.Show($"¿Está seguro que desea eliminar el alumno con Id {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    await AlumnoApiClient.DeleteAsync(id);
                    await this.GetAllAndLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar alumno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
