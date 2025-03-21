using Test1.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {}

    public DbSet<tblClasses> TblClasses { get; set; }
    public DbSet<tblStudents> TblStudents { get; set; }
    public DbSet<tblTeachers> TblTeachers { get; set; }
    public DbSet<tblClassRoom> TblClassRooms { get; set; }
    public DbSet<tblUserAcc> TblUserAccs { get; set; }
}