using veterinariaCrud.models;

namespace veterinariaCrud.controllers;

using System.Collections.Generic;
using System.Linq;

public class MascotaController
{
    private readonly AppDbContext _context;

    public MascotaController()
    {
        _context = new AppDbContext();
    }

    // Listar todas las mascotas
    public List<Mascota> ObtenerMascotas()
    {
        return _context.Mascotas.ToList();
    }

    // Buscar mascota por ID
    public Mascota ObtenerMascotaPorId(int id)
    {
        // solo retorna si la mascota existe, sino retorna null
        return _context.Mascotas.FirstOrDefault(m => m.IdMascota == id);
    }

    // Crear nueva mascota
    public void CrearMascota(Mascota mascota)
    {
        _context.Mascotas.Add(mascota);
        _context.SaveChanges();
    }

    // Actualizar mascota existente
    public void ActualizarMascota(Mascota mascota)
    {
        _context.Mascotas.Update(mascota);
        _context.SaveChanges();
    }

    // Eliminar mascota
    public void EliminarMascota(int id)
    {
        var mascota = _context.Mascotas.FirstOrDefault(m => m.IdMascota == id);
        if (mascota != null)
        {
            _context.Mascotas.Remove(mascota);
            _context.SaveChanges();
        }
    }
}
