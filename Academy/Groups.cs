using Microsoft.EntityFrameworkCore;

public class Groups(DbContextOptions<Groups> options) : DbContext(options)
{
    public DbSet<Academy.Models.Group> Group { get; set; } = default!;
}
