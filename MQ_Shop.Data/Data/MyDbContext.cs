using Microsoft.EntityFrameworkCore;
using MQ_Shop.Data.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Shop.Data.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CategoriesTransaction> CategoryTranslations { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<producttransaction> ProductTranslations { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ProductImg> ProductImages { get; set; }
        public DbSet<Slide> Slides { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slide>(s =>
            {
                s.ToTable("Slide");
                s.HasKey(sl => sl.id);
                s.Property(sl => sl.Name).HasMaxLength(200).IsRequired();
                s.Property(sl => sl.Description).HasMaxLength(200).IsRequired();
                s.Property(sl => sl.Url).HasMaxLength(200).IsRequired();
                s.Property(sl => sl.Image).HasMaxLength(200).IsRequired();
            });
            modelBuilder.Entity<ProductImg>(pi =>
            {
                pi.ToTable("ProductImage");
                pi.HasKey(pri => pri.Id);
                pi.Property(pri => pri.ImagePath).HasMaxLength(200).IsRequired();
                pi.Property(pri => pri.Caption).HasMaxLength(200);
                pi.HasOne(p => p.Product).WithMany(pri => pri.productImgs).HasForeignKey(x => x.ProductId);
            });
            modelBuilder.Entity<Transaction>(t =>
            {
                t.ToTable("Transaction");
                t.HasKey(tr => tr.id);
                t.HasOne(tr => tr.User).WithMany(tr => tr.transactions).HasForeignKey(tr => tr.UserId);
            });
            modelBuilder.Entity<Promotion>(p =>
            {
                p.ToTable("Promotion");
                p.HasKey(pro => pro.id);
                p.Property(pro => pro.name).IsRequired();
            });
            modelBuilder.Entity<producttransaction>(pt =>
            {
                pt.ToTable("ProductTransaction");
                pt.HasKey(x => x.Id);
                pt.Property(x => x.Name).HasMaxLength(200).IsRequired();
                pt.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);
                pt.Property(x => x.Details).HasMaxLength(200);
                pt.Property(x => x.LanguageId).IsUnicode(false).HasMaxLength(5).IsRequired();
                pt.HasOne(x => x.Language).WithMany(x => x.producttransactions).HasForeignKey(x => x.LanguageId);
                pt.HasOne(x => x.Product).WithMany(x => x.producttransactions).HasForeignKey(x => x.ProductId);
            });
            modelBuilder.Entity<OrderDetail>(o =>
            {
                o.ToTable("OrderDetails");
                o.HasKey(x => new { x.orderid, x.productid });
                o.HasOne(x => x.order).WithMany(x => x.orderDetails).HasForeignKey(x => x.orderid);
                o.HasOne(x => x.products).WithMany(x => x.orderDetails).HasForeignKey(x => x.orderid);
            });
            modelBuilder.Entity<Order>(o =>
            {
                o.HasKey(x => x.id);

                o.Property(x => x.orderdate);

                o.Property(x => x.Email).IsRequired().IsUnicode(false).HasMaxLength(50);

                o.Property(x => x.shipName).IsRequired().HasMaxLength(200);

                o.Property(x => x.shipAddress).IsRequired().HasMaxLength(200);

                o.Property(x => x.shipPhone).IsRequired().HasMaxLength(200);

                o.HasOne(x => x.User).WithMany(x => x.orders).HasForeignKey(x => x.userid);
            });
            modelBuilder.Entity<Language>(l =>
            {
                l.ToTable("Languages");

                l.HasKey(x => x.Id);

                l.Property(x => x.Id).IsRequired().IsUnicode(false).HasMaxLength(5);

                l.Property(x => x.Name).IsRequired().HasMaxLength(20);
            });
            modelBuilder.Entity<Contact>(c =>
            {
                c.ToTable("Contacts");
                c.HasKey(x => x.Id);

                c.Property(x => x.Id).UseIdentityColumn();

                c.Property(x => x.Name).HasMaxLength(200).IsRequired();

                c.Property(x => x.Email).HasMaxLength(200).IsRequired();
                c.Property(x => x.PhoneNumber).HasMaxLength(200).IsRequired();
                c.Property(x => x.Message).IsRequired();
            });
            modelBuilder.Entity<CategoriesTransaction>(ct =>
            {
                ct.ToTable("CategoryTranslations");

                ct.HasKey(x => x.Id);

                ct.Property(x => x.Id).UseIdentityColumn();

                ct.Property(x => x.Name).IsRequired().HasMaxLength(200);

                ct.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

                ct.Property(x => x.SeoDescription).HasMaxLength(500);

                ct.Property(x => x.SeoTitle).HasMaxLength(200);

                ct.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

                ct.HasOne(x => x.Language).WithMany(x => x.categoriesTransactions).HasForeignKey(x => x.LanguageId);

                ct.HasOne(x => x.Category).WithMany(x => x.categoriesTransaction).HasForeignKey(x => x.CategoryId);

            });
            modelBuilder.Entity<Cart>(cr =>
            {
                cr.ToTable("Carts");
                cr.HasKey(x => x.id);
                cr.HasOne(x => x.Product).WithMany(x => x.carts).HasForeignKey(x => x.productid);
                cr.HasOne(x => x.AppUser).WithMany(x => x.carts).HasForeignKey(x => x.UserId);

            });
            modelBuilder.Entity<Config>(cf =>
            {
                cf.ToTable("AppConfigs");

                cf.HasKey(x => x.Key);

                cf.Property(x => x.Value).IsRequired(true);
            });
            modelBuilder.Entity<Category>(c =>
            {
                c.ToTable("Categories");
                c.HasKey(x => x.id);
                c.Property(x => x.Status).HasDefaultValue(status.Active);
            });
            modelBuilder.Entity<Products>(p =>
            {
                p.ToTable("Products");

                p.HasKey(x => x.id);
                p.Property(x => x.price).IsRequired();
                p.Property(x => x.stock).IsRequired().HasDefaultValue(0);
                p.Property(x => x.viewcount).IsRequired().HasDefaultValue(0);
            });
            modelBuilder.Entity<Roles>(r =>
            {
                r.ToTable("Roles");
                r.Property(x => x.Description).HasMaxLength(200).IsRequired();

            });
            modelBuilder.Entity<User>(u =>
            {
                u.ToTable("AppUsers");
                u.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
                u.Property(x => x.LastName).IsRequired().HasMaxLength(200);
                u.Property(x => x.DOB).IsRequired();
            });
        }
    }
}
