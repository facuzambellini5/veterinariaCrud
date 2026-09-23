using veterinariaCrud.models;
using Microsoft.EntityFrameworkCore;

namespace veterinariaCrud.controllers;

using System.Collections.Generic;
using System.Linq;

public class MascotaController
{

    public List<Mascota> ObtenerMascotas()
    {
        using var context = new AppDbContext();
        return context.Mascotas.AsNoTracking().ToList();
    }

    // Buscar mascota por ID
    public Mascota ObtenerMascotaPorId(int id)
    {
        using var context = new AppDbContext();
        return context.Mascotas.AsNoTracking().FirstOrDefault(m => m.IdMascota == id);
    }

    // Crear nueva mascota
    public void CrearMascota(Mascota mascota)
    {
        using var context = new AppDbContext();
        context.Mascotas.Add(mascota);
        context.SaveChanges();
    }

    // Actualizar mascota existente
    public void ActualizarMascota(Mascota mascota)
    {
        using var context = new AppDbContext();
        context.Mascotas.Update(mascota);
        context.SaveChanges();
    }

    // Eliminar mascota
    public void EliminarMascota(int id)
    {
        using var context = new AppDbContext();
        var mascota = context.Mascotas.FirstOrDefault(m => m.IdMascota == id);
        if (mascota != null)
        {
            context.Mascotas.Remove(mascota);
            context.SaveChanges();
        }
    }
}