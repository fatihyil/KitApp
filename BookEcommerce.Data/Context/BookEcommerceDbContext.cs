using BookEcommerce.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookEcommerce.Data.Context
{
    public class BookEcommerceDbContext : DbContext
    {
        public BookEcommerceDbContext(DbContextOptions<BookEcommerceDbContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<AppUser>()
        //        .Property(e => e.Id)
        //        .ValueGeneratedOnAdd();
        //    base.OnModelCreating(builder);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<ShoppingBox> ShoppingBox { get; set; }
    }
}
