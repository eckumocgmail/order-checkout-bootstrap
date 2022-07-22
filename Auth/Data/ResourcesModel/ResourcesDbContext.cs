using ApplicationCommon.CommonResources;
using ApplicationCommon.CommonServices.CommonResources;
 
 

using Microsoft.EntityFrameworkCore;

using System;
using System.Diagnostics;
using System.Threading.Tasks;


public partial class ApplicationDbContext : DbContext
{
    
    public virtual DbSet<FileCatalog> FileCatalogs { get; set; }
    public virtual DbSet<FileResource> FileResources { get; set; }

}
