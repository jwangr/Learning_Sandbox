using Microsoft.EntityFrameworkCore;

namespace PtsApi.Models;

public class PtContext(DbContextOptions<PtContext> options) : DbContext(options)
{
    public DbSet<Patient> Patients {get; set; }= null!;
}