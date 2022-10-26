using Client_manager.Models;
using Microsoft.EntityFrameworkCore;


namespace Client_manager.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<ClientModel> Client { get; set; }
  }
}