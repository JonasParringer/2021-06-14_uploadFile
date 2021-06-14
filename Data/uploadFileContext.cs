using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2021_06_14_uploadFile.Models;

    public class uploadFileContext : DbContext
    {
        public uploadFileContext (DbContextOptions<uploadFileContext> options)
            : base(options)
        {
        }

        public DbSet<_2021_06_14_uploadFile.Models.File> File { get; set; }
    }
