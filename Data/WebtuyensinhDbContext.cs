using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webtuyensinh.Models;

public class WebtuyensinhDbContext : DbContext
{
    public WebtuyensinhDbContext (DbContextOptions<WebtuyensinhDbContext> options)
        : base(options)
    {
    }

    public DbSet<AdmissionModel> AdmissionModel { get; set; }
    public DbSet<UserModel> UserModel { get; set; }
    public DbSet<CategoryModel> CategoryModel { get; set; }
    public DbSet<PostModel> PostModel { get; set; }

}
