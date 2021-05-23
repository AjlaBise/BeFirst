using BeFirst.WebAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeFirst.WebAPI.Database
{
    public partial class BeFirstContext
    {
        // Database seeding
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Salt.Add(PasswordHelper.GenerateSalt());
            }

            #region Dodavanje korisnickih uloga
            modelBuilder.Entity<Uloge>().HasData(
                new Uloge()
                {
                    Id = 1,
                    Naziv = "Administrator"
                },
                new Uloge()
                {
                    Id = 2,
                    Naziv = "Korisnik"
                },
                new Uloge()
                {
                    Id = 3,
                    Naziv = "Uposlenik"
                },
                 new Uloge()
                 {
                     Id = 4,
                     Naziv = "Serviser"
                 });
            #endregion

            #region Dodavanje korisnickih naloga
            modelBuilder.Entity<Account>().HasData(
                new Account()
                {
                    Id = 1,
                    KorisničkoIme = "Admin",
                    UlogaId = 1, // Administratorska uloga
                    PasswordSalt = Salt[0],
                    PasswordHash = PasswordHelper.GenerateHash(Salt[0], "admin123")
                },
                new Account()
                {
                    Id = 2,
                    KorisničkoIme = "BeFirstKorisnik",
                    UlogaId = 2, // Korisnicka uloga
                    PasswordSalt = Salt[1],
                    PasswordHash = PasswordHelper.GenerateHash(Salt[1], "korisnik123")
                },
                new Account()
                {
                    Id = 3,
                    KorisničkoIme = "Hazim",
                    UlogaId = 2, // Korisnicka uloga
                    PasswordSalt = Salt[2],
                    PasswordHash = PasswordHelper.GenerateHash(Salt[2], "hazim123")
                },
                new Account()
                {
                    Id = 4,
                    KorisničkoIme = "BeFirstUposlenik",
                    UlogaId = 3, // Uposlenik uloga
                    PasswordSalt = Salt[3],
                    PasswordHash = PasswordHelper.GenerateHash(Salt[3], "uposlenik123")
                },
                 new Account()
                 {
                     Id = 5,
                     KorisničkoIme = "BeFirstServiser",
                     UlogaId = 4, // Serviser uloga
                     PasswordSalt = Salt[4],
                     PasswordHash = PasswordHelper.GenerateHash(Salt[4], "serviser123")
                 },
                  new Account()
                  {
                      Id = 6,
                      KorisničkoIme = "AjlaBise",
                      UlogaId = 2, // Korisnicka uloga
                      PasswordSalt = Salt[2],
                      PasswordHash = PasswordHelper.GenerateHash(Salt[2], "ajla123")
                  },
                    new Account()
                    {
                        Id = 7,
                        KorisničkoIme = "ArmanBise",
                        UlogaId = 2, // Korisnicka uloga
                        PasswordSalt = Salt[2],
                        PasswordHash = PasswordHelper.GenerateHash(Salt[2], "arman123")
                    },
                      new Account()
                      {
                          Id = 8,
                          KorisničkoIme = "MahirSkula",
                          UlogaId = 2, // Korisnicka uloga
                          PasswordSalt = Salt[2],
                          PasswordHash = PasswordHelper.GenerateHash(Salt[2], "mahir123")
                      },
                        new Account()
                        {
                            Id = 9,
                            KorisničkoIme = "DzanisBrkan",
                            UlogaId = 2, // Korisnicka uloga
                            PasswordSalt = Salt[2],
                            PasswordHash = PasswordHelper.GenerateHash(Salt[2], "dzanis123")
                        },
                          new Account()
                          {
                              Id = 10,
                              KorisničkoIme = "AhmedHazimovic",
                              UlogaId = 2, // Korisnicka uloga
                              PasswordSalt = Salt[2],
                              PasswordHash = PasswordHelper.GenerateHash(Salt[2], "ahmed123")
                          },
                          new Account()
                          {
                              Id = 11,
                              KorisničkoIme = "NedimSendro",
                              UlogaId = 3, // Uposlenik uloga
                              PasswordSalt = Salt[3],
                              PasswordHash = PasswordHelper.GenerateHash(Salt[3], "nedim123")
                          },
                            new Account()
                            {
                                Id = 12,
                                KorisničkoIme = "LejlaBise",
                                UlogaId = 3, // Uposlenik uloga
                                PasswordSalt = Salt[3],
                                PasswordHash = PasswordHelper.GenerateHash(Salt[3], "lejla123")
                            },
                              new Account()
                              {
                                  Id = 13,
                                  KorisničkoIme = "NikolaLeung",
                                  UlogaId = 3, // Uposlenik uloga
                                  PasswordSalt = Salt[3],
                                  PasswordHash = PasswordHelper.GenerateHash(Salt[3], "nikola123")
                              }


                );
            #endregion

            #region Dodavanje administratora
            modelBuilder.Entity<Administrator>().HasData(
                    new Administrator()
                    {
                        Id = 1,
                        AccountId = 1,
                        Adresa = "Admin Adresa 1",
                        Ime = "Ajla",
                        Prezime = "Bise"
                    }
                );
            #endregion

            #region Dodavanje ugovora
            modelBuilder.Entity<Ugovor>().HasData(
                    new Ugovor()
                    {
                        Id = 1,
                        Sadrzaj = "Sadrzaj ugovora o radu",
                        BrojUgovora = "44BGFHJJ",
                        Naziv = "Ugovor o radu"
                    },
                     new Ugovor()
                     {
                         Id = 2,
                         Sadrzaj = "Sadrzaj ugovora paket CaTv",
                         BrojUgovora = "11BG45JJ4",
                         Naziv = "Ugovor paket CaTv"
                     },
                      new Ugovor()
                      {
                          Id = 3,
                          Sadrzaj = "Sadrzaj ugovora paket Internet",
                          BrojUgovora = "8854BGFHJJ",
                          Naziv = "Ugovor paket Internet"
                      },
                       new Ugovor()
                       {
                           Id = 4,
                           Sadrzaj = "Sadrzaj ugovora studentski paket",
                           BrojUgovora = "33RRRHJJ",
                           Naziv = "Ugovor studentski paket"
                       }
                );
            #endregion

            #region Dodavanje interneta
            modelBuilder.Entity<Internet>().HasData(
                    new Internet()
                    {
                        Id = 1,
                        Brzina = "150mbps",
                        Cijena = 75.99f,
                        Naziv = "Internet 1",
                        Opis = "Brz internet haos",
                        UgovorId = 1
                    },
                     new Internet()
                     {
                         Id = 2,
                         Brzina = "50mbps",
                         Cijena = 75.99f,
                         Naziv = "Internet 2",
                         Opis = "Brz internet haos",
                         UgovorId = 1
                     },
                      new Internet()
                      {
                          Id = 3,
                          Brzina = "150mbps",
                          Cijena = 75.99f,
                          Naziv = "Internet 3",
                          Opis = "Brz internet haos",
                          UgovorId = 1
                      },
                       new Internet()
                       {
                           Id = 4,
                           Brzina = "100mbps",
                           Cijena = 75.99f,
                           Naziv = "Internet 4",
                           Opis = "Brz internet haos",
                           UgovorId = 1
                       },
                        new Internet()
                        {
                            Id = 5,
                            Brzina = "150mbps",
                            Cijena = 75.99f,
                            Naziv = "Internet 5",
                            Opis = "Brz internet haos",
                            UgovorId = 1
                        }
                );
            #endregion

            #region Dodavanje namjena paketa

            modelBuilder.Entity<PaketNamjena>().HasData(new PaketNamjena() { 
                Id = 1, Naziv = "Studentski paket"
            }, new PaketNamjena() { Id = 2, Naziv = "Penzionerski paket"},
            new PaketNamjena() { Id = 3, Naziv = "Obicni paket" },
            new PaketNamjena() { Id = 4, Naziv = "Paket za RVI korisnike"});

            #endregion

            #region Dodavanje paketa
            modelBuilder.Entity<Paket>().HasData(
                    new Paket()
                    {
                        Id = 1,
                        CaTv = true,
                        UgovorId = 1,
                        InternetId = 1,
                        Snizen = true,
                        PaketNamjenaId = 1
                    },
                    new Paket()
                    {
                        Id = 2,
                        CaTv = true,
                        UgovorId = 2,
                        InternetId = 1,
                        Snizen = false,
                        PaketNamjenaId = 2
                    },
                      new Paket()
                      {
                          Id = 3,
                          CaTv = false,
                          UgovorId = 4,
                          InternetId = 3,
                          Snizen = true,
                          PaketNamjenaId = 3
                      },
                        new Paket()
                        {
                            Id = 4,
                            CaTv = true,
                            UgovorId = 2,
                            InternetId = 4,
                            Snizen = false,
                            PaketNamjenaId = 4
                        },
                          new Paket()
                          {
                              Id = 5,
                              CaTv = true,
                              UgovorId = 3,
                              InternetId = 2,
                              Snizen = true,
                              PaketNamjenaId = 1
                          },
                           new Paket()
                           {
                               Id = 6,
                               CaTv = true,
                               UgovorId = 3,
                               InternetId = 5,
                               Snizen = false,
                               PaketNamjenaId = 2
                           }
                );
            #endregion

            #region Dodavanje korisnika
            modelBuilder.Entity<Korisnik>().HasData(
                    new Korisnik()
                    {
                        Id = 1,
                        AccountId = 2,
                        Adresa = "Korisnik Adresa 1",
                        BrojTelefona = "061222555",
                        DatumRodjenja = DateTime.Now.AddYears(-24),
                        Email = "korisnik1@befirst.com",
                        Grad = "Mostar",
                        Ime = "KorisnikIme",
                        Prezime = "KorisnikPrezime",
                        Komentar = "Bez rijeci",
                        PaketId = 1,
                        UgovorId = 1,
                        VrstaKorisnika = VrstaKorisnika.RVI,
                    },
                    new Korisnik()
                    {
                        Id = 2,
                        AccountId = 3,
                        Adresa = "Korisnik Adresa 2",
                        BrojTelefona = "061777999",
                        DatumRodjenja = DateTime.Now.AddYears(-36),
                        Email = "korisnik2@befirst.com",
                        Grad = "Sarajevo",
                        Ime = "Hazim",
                        Prezime = "Hazimovic",
                        Komentar = "Ostao bez teksta",
                        PaketId = 1,
                        UgovorId = 1,
                        VrstaKorisnika = VrstaKorisnika.RVI,
                    },
                     new Korisnik()
                     {
                         Id = 3,
                         AccountId = 6,
                         Adresa = "Korisnik Adresa 3",
                         BrojTelefona = "061777999",
                         DatumRodjenja = DateTime.Now.AddYears(-36),
                         Email = "korisnik2@befirst.com",
                         Grad = "Sarajevo",
                         Ime = "Ajla",
                         Prezime = "Bise",
                         Komentar = "Ostao bez teksta",
                         PaketId = 3,
                         UgovorId = 3,
                         VrstaKorisnika = VrstaKorisnika.Student
                     },
                      new Korisnik()
                      {
                          Id = 4,
                          AccountId = 7,
                          Adresa = "Korisnik Adresa 2",
                          BrojTelefona = "061777999",
                          DatumRodjenja = DateTime.Now.AddYears(-36),
                          Email = "korisnik2@befirst.com",
                          Grad = "Sarajevo",
                          Ime = "Arman",
                          Prezime = "Bise",
                          Komentar = "Ostao bez teksta",
                          PaketId = 3,
                          UgovorId = 4,
                          VrstaKorisnika = VrstaKorisnika.Student
                      },
                       new Korisnik()
                       {
                           Id = 5,
                           AccountId = 8,
                           Adresa = "Korisnik Adresa 2",
                           BrojTelefona = "061777999",
                           DatumRodjenja = DateTime.Now.AddYears(-36),
                           Email = "korisnik2@befirst.com",
                           Grad = "Sarajevo",
                           Ime = "Mahir",
                           Prezime = "Skula",
                           Komentar = "Ostao bez teksta",
                           PaketId = 4,
                           UgovorId = 3,
                           VrstaKorisnika = VrstaKorisnika.Student
                       },
                        new Korisnik()
                        {
                            Id = 6,
                            AccountId = 9,
                            Adresa = "Korisnik Adresa 2",
                            BrojTelefona = "061777999",
                            DatumRodjenja = DateTime.Now.AddYears(-36),
                            Email = "korisnik2@befirst.com",
                            Grad = "Sarajevo",
                            Ime = "Dzanis",
                            Prezime = "Brkan",
                            Komentar = "Ostao bez teksta",
                            PaketId = 3,
                            UgovorId = 3,
                            VrstaKorisnika = VrstaKorisnika.Obicni
                        },
                         new Korisnik()
                         {
                             Id = 7,
                             AccountId = 10,
                             Adresa = "Korisnik Adresa 2",
                             BrojTelefona = "061777999",
                             DatumRodjenja = DateTime.Now.AddYears(-36),
                             Email = "korisnik2@befirst.com",
                             Grad = "Sarajevo",
                             Ime = "Ahmed",
                             Prezime = "Hazimovic",
                             Komentar = "Ostao bez teksta",
                             PaketId = 1,
                             UgovorId = 2,
                             VrstaKorisnika = VrstaKorisnika.Obicni
                         }
                );
            #endregion

            #region Dodavanje pozicija
            modelBuilder.Entity<Pozicije>().HasData(
                    new Pozicije()
                    {
                        Id = 1,
                        Naziv = "Software developer",
                        Opis = "Full stack software dev"
                    },
                      new Pozicije()
                      {
                          Id = 2,
                          Naziv = "Serviser",
                          Opis = "Opis posla za servisera"
                      },
                       new Pozicije()
                       {
                           Id = 3,
                           Naziv = "Frontend developer",
                           Opis = "Opis posla za frontend dev"
                       },
                        new Pozicije()
                        {
                            Id = 4,
                            Naziv = "User support",
                            Opis = "Opis posla za User support"
                        },
                         new Pozicije()
                         {
                             Id = 5,
                             Naziv = "Sef terena",
                             Opis = "Opis posla za sef terena"
                         }
                );
            #endregion

            #region Dodavanje uposlenika
            modelBuilder.Entity<Uposlenik>().HasData(
                    new Uposlenik()
                    {
                        Id = 1,
                        AccountId = 4,
                        Adresa = "Uposlenik Adresa 1",
                        Aktivan = true,
                        BrojTelefona = "063000111",
                        Email = "uposlenik@befirst.com",
                        Grad = "Tuzla",
                        Ime = "UposlenikIme",
                        Prezime = "UposlenikPrezime",
                        Plata = 1495.00d,
                        UgovorId = 1,
                        PozicijaId = 1
                    },
                     new Uposlenik()
                     {
                         Id = 2,
                         AccountId = 5,
                         Adresa = "Uposlenik Adresa 2",
                         Aktivan = true,
                         BrojTelefona = "063000111",
                         Email = "serviser@befirst.com",
                         Grad = "Tuzla",
                         Ime = "ServiserIme",
                         Prezime = "ServiserPrezime",
                         Plata = 1495.00,
                         UgovorId = 1,
                         PozicijaId = 2
                     },
                       new Uposlenik()
                       {
                           Id = 3,
                           AccountId = 11,
                           Adresa = "Uposlenik Adresa 2",
                           Aktivan = true,
                           BrojTelefona = "063000111",
                           Email = "serviser@befirst.com",
                           Grad = "Tuzla",
                           Ime = "Nedim",
                           Prezime = "Sendro",
                           Plata = 1495.00,
                           UgovorId = 1,
                           PozicijaId = 3
                       },
                         new Uposlenik()
                         {
                             Id = 4,
                             AccountId = 12,
                             Adresa = "Uposlenik Adresa 2",
                             Aktivan = true,
                             BrojTelefona = "063000111",
                             Email = "serviser@befirst.com",
                             Grad = "Tuzla",
                             Ime = "Lejla",
                             Prezime = "Bise",
                             Plata = 1495.00,
                             UgovorId = 1,
                             PozicijaId = 3
                         },
                           new Uposlenik()
                           {
                               Id = 5,
                               AccountId = 13,
                               Adresa = "Uposlenik Adresa 2",
                               Aktivan = true,
                               BrojTelefona = "063000111",
                               Email = "serviser@befirst.com",
                               Grad = "Tuzla",
                               Ime = "Nikola",
                               Prezime = "Leung",
                               Plata = 1495.00,
                               UgovorId = 1,
                               PozicijaId = 1
                           }
                );
            #endregion

            #region Dodavanje zahtjeva
            modelBuilder.Entity<Zahtjev>().HasData(
                new Zahtjev()
                {
                    Id = 1,
                    Naslov = "Prekid programa",
                    Opis = "Jutros od 10:00h prekinuti su svi programi. Molim Vas kad možete doći da popravite?",
                    Odgovor = "",
                    KorisnikId = 1,
                    KorisnikIme = "Hazim",
                    Odgovoreno = false,
                    Pogledno = false
                },
                new Zahtjev()
                {
                    Id = 2,
                    Naslov = "Istice ugovor",
                    Opis = "Poštovanje, ističe mi uskoro ugovor za paket 88TGHTE, koje papire treba da donesem u prostorije Kablovske da bi produžil isti ugovor?",
                    Odgovor = "",
                    KorisnikId = 5,
                    KorisnikIme = "Arman",
                    Odgovoreno = false,
                    Pogledno = false
                },
                new Zahtjev()
                {
                    Id = 3,
                    Naslov = "Prekid programa",
                    Opis = "Jutros od 11:00h prekinuti su svi programi. Molim Vas kad možete doći da popravite?",
                    Odgovor = "",
                    KorisnikId = 4,
                    KorisnikIme = "Mahir",
                    Odgovoreno = false,
                    Pogledno = false
                },
                new Zahtjev()
                {
                    Id = 4,
                    Naslov = "Slab signal",
                    Opis = "Zadnjih par dana signal je jako los. Da li bi neko mogao doci da pogleda? Lp",
                    Odgovor = "Kolege serviseri će doći do vas danas u terminu 14:00h. Lp",
                    KorisnikId = 3,
                    KorisnikIme = "Ajla",
                    Odgovoreno = false,
                    Pogledno = false
                }
                );
            #endregion

            #region Dodavanje ponuda
            modelBuilder.Entity<Ponuda>().HasData(
                new Ponuda
                {
                    Id = 1,
                    Naziv = "Studentski paket",
                    Opis = "Opis",

                },
                  new Ponuda
                  {
                      Id = 2,
                      Naziv = "Studentski paket",
                      Opis = "Opis",

                  },
                    new Ponuda
                    {
                        Id = 3,
                        Naziv = "Studentski paket",
                        Opis = "Opis",

                    },
                      new Ponuda
                      {
                          Id = 4,
                          Naziv = "Studentski paket",
                          Opis = "Opis",

                      },
                        new Ponuda
                        {
                            Id = 5,
                            Naziv = "Studentski paket",
                            Opis = "Opis",

                        },
                          new Ponuda
                          {
                              Id = 6,
                              Naziv = "Studentski paket",
                              Opis = "Opis",

                          },
                           new Ponuda
                           {
                               Id = 7,
                               Naziv = "Studentski paket",
                               Opis = "Opis",

                           },
                            new Ponuda
                            {
                                Id = 8,
                                Naziv = "Studentski paket",
                                Opis = "Opis",

                            },
                            new Ponuda
                            {
                                Id = 9,
                                Naziv = "Studentski paket",
                                Opis = "Opis",

                            },
                            new Ponuda
                            {
                                Id = 10,
                                Naziv = "Studentski paket",
                                Opis = "Opis",

                            });
            #endregion

            #region Dodavenje Opreme

            modelBuilder.Entity<Oprema>().HasData(
                new Oprema
                {
                    Id = 1,
                    Naziv = "Ruter",
                    BrojKomada = 20,
                    NaStanju = true,
                    Cijena = 35
                },
                 new Oprema
                 {
                     Id = 2,
                     Naziv = "Reciever",
                     BrojKomada = 40,
                     NaStanju = true,
                     Cijena = 45
                 },
                  new Oprema
                  {
                      Id = 3,
                      Naziv = "Konekcijski",
                      BrojKomada = 20,
                      NaStanju = true,
                      Cijena = 15
                  },
                   new Oprema
                   {
                       Id = 4,
                       Naziv = "Modem",
                       BrojKomada = 20,
                       NaStanju = true,
                       Cijena = 35
                   });

            #endregion

            #region Dodavanje RadnogNaloga

            modelBuilder.Entity<RadniNalog>().HasData(
                new RadniNalog
                {
                    Id = 1,
                    Datum = DateTime.Now,
                    Adresa = "a",
                    OpisPrijavljenogPosla = "Nestanak programa",
                    OpisIzvrsenogPosla = "Zamijenjen resiver",
                    KorisnikId = 3,
                    KorisnikIme = "Ajla",
                    KorisnikPrezime = "Bise"
                },
                 new RadniNalog
                 {
                     Id = 2,
                     Datum = DateTime.Now,
                     Adresa = "a",
                     OpisPrijavljenogPosla = "Priključivanje CaTv",
                     OpisIzvrsenogPosla = "Priključivanje CaTv",
                     KorisnikId = 5,
                     KorisnikIme = "Mahir",
                     KorisnikPrezime = "Skula"
                 },
                  new RadniNalog
                  {
                      Id = 3,
                      Datum = DateTime.Now,
                      Adresa = "a",
                      OpisPrijavljenogPosla = "Loš signal",
                      OpisIzvrsenogPosla = "Zamijenjen resiver",
                      KorisnikId = 7,
                      KorisnikIme = "Ahmed",
                      KorisnikPrezime = "Hazimovic"
                  }

           );

            #endregion

            #region Dodavanje OpremaUposlenikRadnoNalog

            modelBuilder.Entity<OpremaUposlenikRadnoNalog>().HasData(
                new OpremaUposlenikRadnoNalog
                {
                    Id = 1,
                    RadniNalogId = 1,
                    OpremaId = 2,
                    UposlenikId = 1
                },
                new OpremaUposlenikRadnoNalog
                {
                    Id = 2,
                    RadniNalogId = 3,
                    OpremaId = 2,
                    UposlenikId = 1
                },
                new OpremaUposlenikRadnoNalog
                {
                    Id = 3,
                    RadniNalogId = 2,
                    OpremaId = 3,
                    UposlenikId = 2
                }


           );

            #endregion
        }
    }
}