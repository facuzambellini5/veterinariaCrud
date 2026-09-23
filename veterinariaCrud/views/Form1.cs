using veterinariaCrud.controllers;

namespace veterinariaCrud;

public partial class Form1 : Form
{
    private readonly MascotaController _controller = new MascotaController();
    private int? _idSeleccionado;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        CargarGrid();
    }

    private void CargarGrid()
    {
        var mascotas = _controller.ObtenerMascotas();

        dgvMascotas.DataSource = null;
        dgvMascotas.DataSource = mascotas;

        if (dgvMascotas.Columns["IdMascota"] != null)
            dgvMascotas.Columns["IdMascota"].Visible = false;
        if (dgvMascotas.Columns["Raza"] != null)
            dgvMascotas.Columns["Raza"].Visible = false;
        if (dgvMascotas.Columns["NumDueno"] != null)
            dgvMascotas.Columns["NumDueno"].Visible = false;

        if (dgvMascotas.Columns["Nombre"] != null)
            dgvMascotas.Columns["Nombre"].HeaderText = "Nombre";
        if (dgvMascotas.Columns["Especie"] != null)
            dgvMascotas.Columns["Especie"].HeaderText = "Especie";
        if (dgvMascotas.Columns["NombreDueno"] != null)
            dgvMascotas.Columns["NombreDueno"].HeaderText = "Dueño";

        dgvMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        LimpiarFicha();
    }

    private void dgvMascotas_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvMascotas.CurrentRow?.DataBoundItem is not Mascota mascota)
            return;

        _idSeleccionado = mascota.IdMascota;
        txtNombre.Text = mascota.Nombre;
        txtEspecie.Text = mascota.Especie;
        txtRaza.Text = mascota.Raza;
        txtNumDueno.Text = mascota.NumDueno.ToString();
        txtNombreDueno.Text = mascota.NombreDueno;

        
        grpFichaMascota.Text = $"Ficha de Mascota — Editando: {mascota.Nombre}";
    }

    // Fix v2 (Error 2): filtra en tiempo real caracteres no numéricos.
    private void txtNumDueno_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void btnAlta_Click(object? sender, EventArgs e)
    {
        if (!ValidarFicha(out long numDueno))
            return;

        var nueva = new Mascota
        {
            Nombre = txtNombre.Text.Trim(),
            Especie = txtEspecie.Text.Trim(),
            Raza = txtRaza.Text.Trim(),
            NumDueno = numDueno,
            NombreDueno = txtNombreDueno.Text.Trim()
        };

        _controller.CrearMascota(nueva);
        CargarGrid();

        // Fix v2 (Error 1): confirmación visible tras el alta.
        MessageBox.Show($"'{nueva.Nombre}' fue dado de alta correctamente.", "Alta exitosa",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnModificar_Click(object? sender, EventArgs e)
    {
        if (_idSeleccionado is null)
        {
            MessageBox.Show("Seleccioná una mascota de la lista para modificar.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!ValidarFicha(out long numDueno))
            return;

        var actualizada = new Mascota
        {
            IdMascota = _idSeleccionado.Value,
            Nombre = txtNombre.Text.Trim(),
            Especie = txtEspecie.Text.Trim(),
            Raza = txtRaza.Text.Trim(),
            NumDueno = numDueno,
            NombreDueno = txtNombreDueno.Text.Trim()
        };

        _controller.ActualizarMascota(actualizada);
        CargarGrid();

        // Fix v2 (Error 1): confirmación visible tras la modificación.
        MessageBox.Show($"'{actualizada.Nombre}' fue modificado correctamente.", "Modificación exitosa",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnBaja_Click(object? sender, EventArgs e)
    {
        if (_idSeleccionado is null)
        {
            MessageBox.Show("Seleccioná una mascota de la lista para dar de baja.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmacion = MessageBox.Show(
            $"¿Seguro que querés eliminar a \"{txtNombre.Text}\"?",
            "Confirmar baja",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirmacion != DialogResult.Yes)
            return;

        _controller.EliminarMascota(_idSeleccionado.Value);
        CargarGrid();
    }

    private bool ValidarFicha(out long numDueno)
    {
        numDueno = 0;

        if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtEspecie.Text) ||
            string.IsNullOrWhiteSpace(txtNombreDueno.Text))
        {
            MessageBox.Show("Nombre, Especie y Nombre del Dueño son obligatorios.", "Datos incompletos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!long.TryParse(txtNumDueno.Text, out numDueno))
        {
            MessageBox.Show("Teléfono debe ser un número.", "Dato inválido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void LimpiarFicha()
    {
        _idSeleccionado = null;
        txtNombre.Clear();
        txtEspecie.Clear();
        txtRaza.Clear();
        txtNumDueno.Clear();
        txtNombreDueno.Clear();

        // Vuelve al modo "nueva mascota" tras un alta/baja o al limpiar.
        grpFichaMascota.Text = "Ficha de Mascota (nueva)";
    }
}