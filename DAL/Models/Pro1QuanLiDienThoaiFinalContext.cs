using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class Pro1QuanLiDienThoaiFinalContext : DbContext
{
    public Pro1QuanLiDienThoaiFinalContext()
    {
    }

    public Pro1QuanLiDienThoaiFinalContext(DbContextOptions<Pro1QuanLiDienThoaiFinalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Cpu> Cpus { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Imei> Imeis { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductColor> ProductColors { get; set; }

    public virtual DbSet<ProductCompany> ProductCompanys { get; set; }

    public virtual DbSet<ProductDetail> ProductDetails { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LOVESONGPC;Database=pro1QuanLiDienThoaiFinal;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Idaccount).HasName("PK__Accounts__1D323F907BE9E976");

            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");
            entity.Property(e => e.AccountName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PassAccount)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cpu>(entity =>
        {
            entity.HasKey(e => e.Idcpu).HasName("PK__CPUs__91A9763021297D3F");

            entity.ToTable("CPUs");

            entity.Property(e => e.Idcpu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IDCPU");
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameCpu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NameCPU");

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.Cpus)
                .HasForeignKey(d => d.Idaccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CPUs__IDAccount__3C69FB99");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Idcustomer).HasName("PK__Customer__701C9C3C3853D219");

            entity.Property(e => e.Idcustomer)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDCustomer");
            entity.Property(e => e.CustomerAddress).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(30);
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.Idaccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Customers__IDAcc__5629CD9C");
        });

        modelBuilder.Entity<Imei>(entity =>
        {
            entity.HasKey(e => e.ImeiNumber).HasName("PK__Imeis__8D582410C74F2BF4");

            entity.Property(e => e.ImeiNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");
            entity.Property(e => e.IdproductDetails)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IDProductDetails");

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.Imeis)
                .HasForeignKey(d => d.Idaccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Imeis__IDAccount__534D60F1");

            entity.HasOne(d => d.IdproductDetailsNavigation).WithMany(p => p.Imeis)
                .HasForeignKey(d => d.IdproductDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Imeis__IDProduct__52593CB8");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Idorder).HasName("PK__Orders__5CBBCADB43597EB5");

            entity.Property(e => e.Idorder)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDOrder");
            entity.Property(e => e.EstablishedDate).HasColumnType("datetime");
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");
            entity.Property(e => e.Idcustomer)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDCustomer");
            entity.Property(e => e.Idvoucher)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDVoucher");
            entity.Property(e => e.TotalAmount).HasColumnType("money");

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Idaccount)
                .HasConstraintName("FK__Orders__IDAccoun__59063A47");

            entity.HasOne(d => d.IdcustomerNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Idcustomer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Orders__IDCustom__59FA5E80");

            entity.HasOne(d => d.IdvoucherNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Idvoucher)
                .HasConstraintName("FK__Orders__IDVouche__5AEE82B9");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.Idorder, e.IdproductDetails }).HasName("PK__OrderDet__7B133CF7FBAEF255");

            entity.Property(e => e.Idorder)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDOrder");
            entity.Property(e => e.IdproductDetails)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IDProductDetails");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ReducedAmount).HasColumnType("money");

            entity.HasOne(d => d.IdorderNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.Idorder)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderDeta__IDOrd__5EBF139D");

            entity.HasOne(d => d.IdproductDetailsNavigation).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.IdproductDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderDeta__IDPro__5DCAEF64");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Idproduct).HasName("PK__Products__4290D179D32E809D");

            entity.Property(e => e.Idproduct)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDProduct");
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");
            entity.Property(e => e.Idcompany)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDCompany");
            entity.Property(e => e.Idcpu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IDCPU");
            entity.Property(e => e.ProductImage)
                .HasMaxLength(99)
                .IsUnicode(false);
            entity.Property(e => e.ProductName).HasMaxLength(30);
            entity.Property(e => e.Ram).HasColumnName("RAM");
            entity.Property(e => e.ScreenResolution)
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Idaccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Products__IDAcco__4222D4EF");

            entity.HasOne(d => d.IdcompanyNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Idcompany)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Products__IDComp__440B1D61");

            entity.HasOne(d => d.IdcpuNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Idcpu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Products__IDCPU__4316F928");
        });

        modelBuilder.Entity<ProductColor>(entity =>
        {
            entity.HasKey(e => e.Idcolor).HasName("PK__ProductC__E424D93679C97A38");

            entity.Property(e => e.Idcolor)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("IDColor");
            entity.Property(e => e.ColorName).HasMaxLength(20);
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.ProductColors)
                .HasForeignKey(d => d.Idaccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProductCo__IDAcc__398D8EEE");
        });

        modelBuilder.Entity<ProductCompany>(entity =>
        {
            entity.HasKey(e => e.Idcompany).HasName("PK__ProductC__9A030B76FB29E550");

            entity.Property(e => e.Idcompany)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDCompany");
            entity.Property(e => e.CompanyName).HasMaxLength(30);
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.ProductCompanies)
                .HasForeignKey(d => d.Idaccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProductCo__IDAcc__3F466844");
        });

        modelBuilder.Entity<ProductDetail>(entity =>
        {
            entity.HasKey(e => e.IdproductDetails).HasName("PK__ProductD__7A8F62C3E68C370B");

            entity.Property(e => e.IdproductDetails)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IDProductDetails");
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");
            entity.Property(e => e.Idcolor)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("IDColor");
            entity.Property(e => e.Idproduct)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDProduct");
            entity.Property(e => e.Idpromotion)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDPromotion");
            entity.Property(e => e.Inventory).HasColumnName("inventory");
            entity.Property(e => e.Price).HasColumnType("money");

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.ProductDetails)
                .HasForeignKey(d => d.Idaccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProductDe__IDAcc__4CA06362");

            entity.HasOne(d => d.IdcolorNavigation).WithMany(p => p.ProductDetails)
                .HasForeignKey(d => d.Idcolor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProductDe__IDCol__4F7CD00D");

            entity.HasOne(d => d.IdproductNavigation).WithMany(p => p.ProductDetails)
                .HasForeignKey(d => d.Idproduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProductDe__IDPro__4D94879B");

            entity.HasOne(d => d.IdpromotionNavigation).WithMany(p => p.ProductDetails)
                .HasForeignKey(d => d.Idpromotion)
                .HasConstraintName("FK__ProductDe__IDPro__4E88ABD4");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.Idpromotion).HasName("PK__Promotio__C76CC0D83A83F18A");

            entity.Property(e => e.Idpromotion)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDPromotion");
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");
            entity.Property(e => e.PromotionName).HasMaxLength(50);
            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.Promotions)
                .HasForeignKey(d => d.Idaccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Promotion__IDAcc__46E78A0C");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Idvoucher).HasName("PK__Vouchers__50249A27B8D75CBD");

            entity.Property(e => e.Idvoucher)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("IDVoucher");
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.Idaccount)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IDAccount");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.VoucherName).HasMaxLength(50);

            entity.HasOne(d => d.IdaccountNavigation).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.Idaccount)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vouchers__IDAcco__49C3F6B7");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
