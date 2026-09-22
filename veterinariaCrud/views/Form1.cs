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

    // Trae las mascotas de la base y las vuelca en el grid,
    // ocultando columnas que no aportan al usuario (Id, Raza, NumDueno)
    // y dejando visibles solo Nombre, Especie y Dueño.
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

    // El usuario clickea una fila -> la ficha se completa sola.
    // Reconocimiento en vez de recuerdo (Lorés).
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

    // Validación mínima antes de Alta/Modificar.
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
    }
}