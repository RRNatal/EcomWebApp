﻿
using Ecom.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecom.DataAccess.Data;
public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Category { get; set; }
    public DbSet<MainCat> MainCat { get; set; }
    public DbSet<MenuItem> MenuItem { get; set; }
	public DbSet<ApplicationUser> ApplicationUser { get; set; }
    public DbSet<ShoppingCart> ShoppingCart{ get; set; }
    public DbSet<OrderHeader> OrderHeader { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
}
