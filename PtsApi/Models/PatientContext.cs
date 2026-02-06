using Microsoft.EntityFrameworkCore;

namespace PtsApi.Models;

public class PtContext : DbContext
{
    public PtContext(DbContextOptions<PtContext> options)
        : base(options)
    {
        
    }

    public DbSet<Patient> Patients {get; set; }= null!;
}