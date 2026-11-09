using Microsoft.EntityFrameworkCore;

public class Mihali_Antonia_Lab2Context(DbContextOptions<Mihali_Antonia_Lab2Context> options) : DbContext(options)
{
    public DbSet<Mihali_Antonia_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Mihali_Antonia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Mihali_Antonia_Lab2.Models.Author> Author { get; set; } = default!;
    public DbSet<Mihali_Antonia_Lab2.Models.Category> Category { get; set; } = default!;
    public DbSet<Mihali_Antonia_Lab2.Models.Member> Member { get; set; } = default!;
    public DbSet<Mihali_Antonia_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;
}