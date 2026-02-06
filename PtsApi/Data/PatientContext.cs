using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PtsApi.Models;

    public class PatientContext : DbContext
    {
        public PatientContext (DbContextOptions<PatientContext> options)
            : base(options)
        {
        }

        public DbSet<PtsApi.Models.Patient> Patient { get; set; } = default!;
    }
