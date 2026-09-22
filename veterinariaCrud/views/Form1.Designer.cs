namespace veterinariaCrud;

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
        this.dgvMascotas = new System.Windows.Forms.DataGridView();
        this.grpFichaMascota = new System.Windows.Forms.GroupBox();
        this.lblNombre = new System.Windows.Forms.Label();
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.lblEspecie = new System.Windows.Forms.Label();
        this.txtEspecie = new System.Windows.Forms.TextBox();
        this.lblRaza = new System.Windows.Forms.Label();
        this.txtRaza = new System.Windows.Forms.TextBox();
        this.lblNumDueno = new System.Windows.Forms.Label();
        this.txtNumDueno = new System.Windows.Forms.TextBox();
        this.lblNombreDueno = new System.Windows.Forms.Label();
        this.txtNombreDueno = new System.Windows.Forms.TextBox();
        this.btnAlta = new System.Windows.Forms.Button();
        this.btnModificar = new System.Windows.Forms.Button();
        this.btnBaja = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
        this.grpFichaMascota.SuspendLayout();
        this.SuspendLayout();
        //
        // dgvMascotas
        //
        this.dgvMascotas.AllowUserToAddRows = false;
        this.dgvMascotas.AllowUserToDeleteRows = false;
        this.dgvMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left))));
        this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvMascotas.Location = new System.Drawing.Point(10, 20);
        this.dgvMascotas.MultiSelect = false;
        this.dgvMascotas.Name = "dgvMascotas";
        this.dgvMascotas.ReadOnly = true;
        this.dgvMascotas.RowHeadersVisible = false;
        this.dgvMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvMascotas.Size = new System.Drawing.Size(285, 320);
        this.dgvMascotas.TabIndex = 0;
        this.dgvMascotas.SelectionChanged += new System.EventHandler(this.dgvMascotas_SelectionChanged);
        //
        // grpFichaMascota
        //
        this.grpFichaMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.grpFichaMascota.Controls.Add(this.lblNombre);
        this.grpFichaMascota.Controls.Add(this.txtNombre);
        this.grpFichaMascota.Controls.Add(this.lblEspecie);
        this.grpFichaMascota.Controls.Add(this.txtEspecie);
        this.grpFichaMascota.Controls.Add(this.lblRaza);
        this.grpFichaMascota.Controls.Add(this.txtRaza);
        this.grpFichaMascota.Controls.Add(this.lblNumDueno);
        this.grpFichaMascota.Controls.Add(this.txtNumDueno);
        this.grpFichaMascota.Controls.Add(this.lblNombreDueno);
        this.grpFichaMascota.Controls.Add(this.txtNombreDueno);
        this.grpFichaMascota.Location = new System.Drawing.Point(320, 20);
        this.grpFichaMascota.Name = "grpFichaMascota";
        this.grpFichaMascota.Size = new System.Drawing.Size(260, 320);
        this.grpFichaMascota.TabIndex = 1;
        this.grpFichaMascota.TabStop = false;
        this.grpFichaMascota.Text = "Ficha de Mascota";
        //
        // lblNombre
        //
        this.lblNombre.AutoSize = true;
        this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.lblNombre.ForeColor = System.Drawing.SystemColors.GrayText;
        this.lblNombre.Location = new System.Drawing.Point(15, 20);
        this.lblNombre.Name = "lblNombre";
        this.lblNombre.Text = "Nombre";
        //
        // txtNombre
        //
        this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtNombre.Location = new System.Drawing.Point(15, 35);
        this.txtNombre.Name = "txtNombre";
        this.txtNombre.Size = new System.Drawing.Size(220, 23);
        this.txtNombre.TabIndex = 0;
        //
        // lblEspecie
        //
        this.lblEspecie.AutoSize = true;
        this.lblEspecie.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.lblEspecie.ForeColor = System.Drawing.SystemColors.GrayText;
        this.lblEspecie.Location = new System.Drawing.Point(15, 68);
        this.lblEspecie.Name = "lblEspecie";
        this.lblEspecie.Text = "Especie";
        //
        // txtEspecie
        //
        this.txtEspecie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtEspecie.Location = new System.Drawing.Point(15, 83);
        this.txtEspecie.Name = "txtEspecie";
        this.txtEspecie.Size = new System.Drawing.Size(220, 23);
        this.txtEspecie.TabIndex = 1;
        //
        // lblRaza
        //
        this.lblRaza.AutoSize = true;
        this.lblRaza.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.lblRaza.ForeColor = System.Drawing.SystemColors.GrayText;
        this.lblRaza.Location = new System.Drawing.Point(15, 116);
        this.lblRaza.Name = "lblRaza";
        this.lblRaza.Text = "Raza";
        //
        // txtRaza
        //
        this.txtRaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtRaza.Location = new System.Drawing.Point(15, 131);
        this.txtRaza.Name = "txtRaza";
        this.txtRaza.Size = new System.Drawing.Size(220, 23);
        this.txtRaza.TabIndex = 2;
        //
        // lblNumDueno
        //
        this.lblNumDueno.AutoSize = true;
        this.lblNumDueno.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.lblNumDueno.ForeColor = System.Drawing.SystemColors.GrayText;
        this.lblNumDueno.Location = new System.Drawing.Point(15, 164);
        this.lblNumDueno.Name = "lblNumDueno";
        this.lblNumDueno.Text = "Teléfono";
        //
        // txtNumDueno
        //
        this.txtNumDueno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtNumDueno.Location = new System.Drawing.Point(15, 179);
        this.txtNumDueno.Name = "txtNumDueno";
        this.txtNumDueno.Size = new System.Drawing.Size(220, 23);
        this.txtNumDueno.TabIndex = 3;
        //
        // lblNombreDueno
        //
        this.lblNombreDueno.AutoSize = true;
        this.lblNombreDueno.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.lblNombreDueno.ForeColor = System.Drawing.SystemColors.GrayText;
        this.lblNombreDueno.Location = new System.Drawing.Point(15, 212);
        this.lblNombreDueno.Name = "lblNombreDueno";
        this.lblNombreDueno.Text = "Nombre del Dueño";
        //
        // txtNombreDueno
        //
        this.txtNombreDueno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtNombreDueno.Location = new System.Drawing.Point(15, 227);
        this.txtNombreDueno.Name = "txtNombreDueno";
        this.txtNombreDueno.Size = new System.Drawing.Size(220, 23);
        this.txtNombreDueno.TabIndex = 4;
        //
        // btnAlta
        //
        this.btnAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnAlta.Location = new System.Drawing.Point(320, 350);
        this.btnAlta.Name = "btnAlta";
        this.btnAlta.Size = new System.Drawing.Size(80, 30);
        this.btnAlta.TabIndex = 2;
        this.btnAlta.Text = "Alta";
        this.btnAlta.UseVisualStyleBackColor = true;
        this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
        //
        // btnModificar
        //
        this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnModificar.Location = new System.Drawing.Point(405, 350);
        this.btnModificar.Name = "btnModificar";
        this.btnModificar.Size = new System.Drawing.Size(80, 30);
        this.btnModificar.TabIndex = 3;
        this.btnModificar.Text = "Modificar";
        this.btnModificar.UseVisualStyleBackColor = true;
        this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
        //
        // btnBaja
        //
        this.btnBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnBaja.Location = new System.Drawing.Point(490, 350);
        this.btnBaja.Name = "btnBaja";
        this.btnBaja.Size = new System.Drawing.Size(80, 30);
        this.btnBaja.TabIndex = 4;
        this.btnBaja.Text = "Baja";
        this.btnBaja.UseVisualStyleBackColor = true;
        this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
        //
        // Form1
        //
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(660, 400);
        this.Controls.Add(this.dgvMascotas);
        this.Controls.Add(this.grpFichaMascota);
        this.Controls.Add(this.btnAlta);
        this.Controls.Add(this.btnModificar);
        this.Controls.Add(this.btnBaja);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Veterinaria - Gestión de Mascotas";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
        this.grpFichaMascota.ResumeLayout(false);
        this.grpFichaMascota.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.DataGridView dgvMascotas;
    private System.Windows.Forms.GroupBox grpFichaMascota;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblEspecie;
    private System.Windows.Forms.TextBox txtEspecie;
    private System.Windows.Forms.Label lblRaza;
    private System.Windows.Forms.TextBox txtRaza;
    private System.Windows.Forms.Label lblNumDueno;
    private System.Windows.Forms.TextBox txtNumDueno;
    private System.Windows.Forms.Label lblNombreDueno;
    private System.Windows.Forms.TextBox txtNombreDueno;
    private System.Windows.Forms.Button btnAlta;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Button btnBaja;
}