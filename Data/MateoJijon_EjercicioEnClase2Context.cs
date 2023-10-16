using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MateoJijon_EjercicioEnClase2.Models;

namespace MateoJijon_EjercicioEnClase2.Data
{
    public class MateoJijon_EjercicioEnClase2Context : DbContext
    {
        public MateoJijon_EjercicioEnClase2Context (DbContextOptions<MateoJijon_EjercicioEnClase2Context> options)
            : base(options)
        {
        }

        public DbSet<MateoJijon_EjercicioEnClase2.Models.Cita> Cita { get; set; } = default!;
    }
}
