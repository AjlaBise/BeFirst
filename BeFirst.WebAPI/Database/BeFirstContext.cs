using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BeFirst.WebAPI.Database
{
    public partial class BeFirstContext : DbContext
    {
        public BeFirstContext()
        {
        }

        public BeFirstContext(DbContextOptions<BeFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Internet> Internet { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Oprema> Oprema { get; set; }
        public virtual DbSet<OpremaUposlenikRadnoNalog> OpremaUposlenikRadnoNalog { get; set; }
        public virtual DbSet<Paket> Paket { get; set; }
        public virtual DbSet<PaketNamjena> PaketNamjena { get; set; }
        public virtual DbSet<Ponuda> Ponuda { get; set; }
        public virtual DbSet<Pozicije> Pozicije { get; set; }
        public virtual DbSet<RadniNalog> RadniNalog { get; set; }
        public virtual DbSet<Ugovor> Ugovor { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Uposlenik> Uposlenik { get; set; }
        public virtual DbSet<Zahtjev> Zahtjev { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BeFirst;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.KorisničkoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired();

                entity.Property(e => e.PasswordSalt)
                    .IsRequired();

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK__Account__UlogeId__267ABA7A");
            });

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Internet>(entity =>
            {
                entity.Property(e => e.Brzina)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.Ugovor)
                    .WithMany(p => p.Internet)
                    .HasForeignKey(d => d.UgovorId)
                    .HasConstraintName("FK__Internet__Ugovor__2D27B809");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.BrojTelefona)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Grad)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Komentar).IsRequired();

                entity.Property(e => e.PaketId).HasColumnName("PaketID");

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UgovorId).HasColumnName("UgovorID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Korisnik)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Korisnik__Accoun__3C69FB99");

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.Korisnik)
                    .HasForeignKey(d => d.PaketId)
                    .HasConstraintName("FK__Korisnik__Koment__3A81B327");

                entity.HasOne(d => d.Ugovor)
                    .WithMany(p => p.Korisnik)
                    .HasForeignKey(d => d.UgovorId)
                    .HasConstraintName("FK__Korisnik__Ugovor__3B75D760");
            });

          

            modelBuilder.Entity<Oprema>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<OpremaUposlenikRadnoNalog>(entity =>
            {
                entity.Property(e => e.OpremaId).HasColumnName("OpremaID");

                entity.Property(e => e.RadniNalogId).HasColumnName("RadniNalogID");

                entity.Property(e => e.UposlenikId).HasColumnName("UposlenikID");

                entity.HasOne(d => d.Oprema)
                    .WithMany(p => p.OpremaUposlenikRadnoNalog)
                    .HasForeignKey(d => d.OpremaId)
                    .HasConstraintName("FK__OpremaUpo__Oprem__4BAC3F29");

                entity.HasOne(d => d.RadniNalog)
                    .WithMany(p => p.OpremaUposlenikRadnoNalog)
                    .HasForeignKey(d => d.RadniNalogId)
                    .HasConstraintName("FK__OpremaUpo__Radni__4D94879B");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.OpremaUposlenikRadnoNalog)
                    .HasForeignKey(d => d.UposlenikId)
                    .HasConstraintName("FK__OpremaUpo__Uposl__4CA06362");
            });

            modelBuilder.Entity<Paket>(entity =>
            {
                entity.Property(e => e.CaTv).HasColumnName("CaTV");

                entity.HasOne(d => d.Internet)
                    .WithMany(p => p.Paket)
                    .HasForeignKey(d => d.InternetId)
                    .HasConstraintName("FK__Paket__InternetI__300424B4");

                entity.HasOne(d => d.Ugovor)
                    .WithMany(p => p.Paket)
                    .HasForeignKey(d => d.UgovorId)
                    .HasConstraintName("FK__Paket__UgovorId__30F848ED");
            });

            modelBuilder.Entity<Ponuda>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Opis).IsRequired();
            });

            modelBuilder.Entity<Pozicije>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).IsRequired();
            });

            modelBuilder.Entity<RadniNalog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.OpisIzvrsenogPosla).IsRequired();

                entity.Property(e => e.OpisPrijavljenogPosla).IsRequired();

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.RadniNalog)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__RadniNalo__Koris__48CFD27E");
            });

            modelBuilder.Entity<Ugovor>(entity =>
            {
                entity.Property(e => e.BrojUgovora)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Sadrzaj).IsRequired();
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Uposlenik>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.BrojTelefona)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Grad)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PozicijaId).HasColumnName("PozicijaID");

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UgovorId).HasColumnName("UgovorID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Uposlenik)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Uposlenik__Accou__35BCFE0A");

                entity.HasOne(d => d.Pozicija)
                    .WithMany(p => p.Uposlenik)
                    .HasForeignKey(d => d.PozicijaId)
                    .HasConstraintName("FK__Uposlenik__Pozic__37A5467C");

                entity.HasOne(d => d.Ugovor)
                    .WithMany(p => p.Uposlenik)
                    .HasForeignKey(d => d.UgovorId)
                    .HasConstraintName("FK__Uposlenik__Ugovo__36B12243");
            });

            modelBuilder.Entity<Zahtjev>(entity =>
            {
                entity.Property(e => e.Naslov)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Opis).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
