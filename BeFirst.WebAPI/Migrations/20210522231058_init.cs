using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeFirst.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oprema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 15, nullable: false),
                    BrojKomada = table.Column<int>(nullable: false),
                    NaStanju = table.Column<bool>(nullable: false),
                    Cijena = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oprema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaketNamjena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaketNamjena", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ponuda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 100, nullable: false),
                    Opis = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponuda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pozicije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pozicije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ugovor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 25, nullable: false),
                    BrojUgovora = table.Column<string>(maxLength: 25, nullable: false),
                    Sadrzaj = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ugovor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Internet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 25, nullable: false),
                    Brzina = table.Column<string>(maxLength: 25, nullable: false),
                    Cijena = table.Column<float>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    UgovorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Internet", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Internet__Ugovor__2D27B809",
                        column: x => x.UgovorId,
                        principalTable: "Ugovor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisničkoIme = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    PasswordSalt = table.Column<string>(nullable: false),
                    UlogaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Account__UlogeId__267ABA7A",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaTV = table.Column<bool>(nullable: false),
                    InternetId = table.Column<int>(nullable: true),
                    UgovorId = table.Column<int>(nullable: true),
                    Snizen = table.Column<bool>(nullable: true),
                    PaketNamjenaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paket", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Paket__InternetI__300424B4",
                        column: x => x.InternetId,
                        principalTable: "Internet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paket_PaketNamjena_PaketNamjenaId",
                        column: x => x.PaketNamjenaId,
                        principalTable: "PaketNamjena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Paket__UgovorId__30F848ED",
                        column: x => x.UgovorId,
                        principalTable: "Ugovor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Adresa = table.Column<string>(maxLength: 25, nullable: false),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administrator_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Adresa = table.Column<string>(maxLength: 25, nullable: false),
                    BrojTelefona = table.Column<string>(maxLength: 20, nullable: false),
                    Grad = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Plata = table.Column<double>(nullable: false),
                    Aktivan = table.Column<bool>(nullable: false),
                    PozicijaID = table.Column<int>(nullable: false),
                    UgovorID = table.Column<int>(nullable: false),
                    AccountID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Uposlenik__Accou__35BCFE0A",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Uposlenik__Pozic__37A5467C",
                        column: x => x.PozicijaID,
                        principalTable: "Pozicije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Uposlenik__Ugovo__36B12243",
                        column: x => x.UgovorID,
                        principalTable: "Ugovor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Adresa = table.Column<string>(maxLength: 25, nullable: false),
                    Grad = table.Column<string>(maxLength: 25, nullable: false),
                    BrojTelefona = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: false),
                    AccountID = table.Column<int>(nullable: false),
                    UgovorID = table.Column<int>(nullable: false),
                    PaketID = table.Column<int>(nullable: true),
                    Komentar = table.Column<string>(nullable: false),
                    VrstaKorisnika = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Korisnik__Accoun__3C69FB99",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Korisnik__Koment__3A81B327",
                        column: x => x.PaketID,
                        principalTable: "Paket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Korisnik__Ugovor__3B75D760",
                        column: x => x.UgovorID,
                        principalTable: "Ugovor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RadniNalog",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    Adresa = table.Column<string>(maxLength: 100, nullable: false),
                    OpisPrijavljenogPosla = table.Column<string>(nullable: false),
                    OpisIzvrsenogPosla = table.Column<string>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    KorisnikIme = table.Column<string>(nullable: true),
                    KorisnikPrezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadniNalog", x => x.ID);
                    table.ForeignKey(
                        name: "FK__RadniNalo__Koris__48CFD27E",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(maxLength: 25, nullable: false),
                    Opis = table.Column<string>(nullable: false),
                    Odgovor = table.Column<string>(nullable: true),
                    KorisnikId = table.Column<int>(nullable: false),
                    KorisnikIme = table.Column<string>(nullable: true),
                    Odgovoreno = table.Column<bool>(nullable: true),
                    Pogledno = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpremaUposlenikRadnoNalog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RadniNalogID = table.Column<int>(nullable: false),
                    OpremaID = table.Column<int>(nullable: false),
                    UposlenikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpremaUposlenikRadnoNalog", x => x.Id);
                    table.ForeignKey(
                        name: "FK__OpremaUpo__Oprem__4BAC3F29",
                        column: x => x.OpremaID,
                        principalTable: "Oprema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__OpremaUpo__Radni__4D94879B",
                        column: x => x.RadniNalogID,
                        principalTable: "RadniNalog",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__OpremaUpo__Uposl__4CA06362",
                        column: x => x.UposlenikID,
                        principalTable: "Uposlenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Oprema",
                columns: new[] { "Id", "BrojKomada", "Cijena", "NaStanju", "Naziv" },
                values: new object[,]
                {
                    { 1, 20, 35.0, true, "Ruter" },
                    { 2, 40, 45.0, true, "Reciever" },
                    { 3, 20, 15.0, true, "Konekcijski" },
                    { 4, 20, 35.0, true, "Modem" }
                });

            migrationBuilder.InsertData(
                table: "PaketNamjena",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "Studentski paket" },
                    { 2, "Penzionerski paket" },
                    { 3, "Obicni paket" },
                    { 4, "Paket za RVI korisnike" }
                });

            migrationBuilder.InsertData(
                table: "Ponuda",
                columns: new[] { "Id", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 10, "Studentski paket", "Opis" },
                    { 9, "Studentski paket", "Opis" },
                    { 7, "Studentski paket", "Opis" },
                    { 6, "Studentski paket", "Opis" },
                    { 8, "Studentski paket", "Opis" },
                    { 4, "Studentski paket", "Opis" },
                    { 3, "Studentski paket", "Opis" },
                    { 2, "Studentski paket", "Opis" },
                    { 1, "Studentski paket", "Opis" },
                    { 5, "Studentski paket", "Opis" }
                });

            migrationBuilder.InsertData(
                table: "Pozicije",
                columns: new[] { "Id", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 5, "Sef terena", "Opis posla za sef terena" },
                    { 3, "Frontend developer", "Opis posla za frontend dev" },
                    { 4, "User support", "Opis posla za User support" },
                    { 1, "Software developer", "Full stack software dev" },
                    { 2, "Serviser", "Opis posla za servisera" }
                });

            migrationBuilder.InsertData(
                table: "Ugovor",
                columns: new[] { "Id", "BrojUgovora", "Naziv", "Sadrzaj" },
                values: new object[,]
                {
                    { 1, "44BGFHJJ", "Ugovor o radu", "Sadrzaj ugovora o radu" },
                    { 2, "11BG45JJ4", "Ugovor paket CaTv", "Sadrzaj ugovora paket CaTv" },
                    { 3, "8854BGFHJJ", "Ugovor paket Internet", "Sadrzaj ugovora paket Internet" },
                    { 4, "33RRRHJJ", "Ugovor studentski paket", "Sadrzaj ugovora studentski paket" }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 3, "Uposlenik" },
                    { 1, "Administrator" },
                    { 2, "Korisnik" },
                    { 4, "Serviser" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "KorisničkoIme", "PasswordHash", "PasswordSalt", "UlogaId" },
                values: new object[,]
                {
                    { 6, "AjlaBise", "AB3LuS0MYU/1zWNgWjJE0rExjeU=", "+98TCK7Prn74upr2wFnSRA==", 2 },
                    { 12, "LejlaBise", "4ihCLLBdn4pJUzNSbHgG5GjycqQ=", "i7dJDt4f375NU0HgYbE46w==", 3 },
                    { 11, "NedimSendro", "759xdgzWKH/Rub13mn1WkrelDlo=", "i7dJDt4f375NU0HgYbE46w==", 3 },
                    { 4, "BeFirstUposlenik", "txoZ27+iGZVFyqi8dj4tpXL3yTk=", "i7dJDt4f375NU0HgYbE46w==", 3 },
                    { 10, "AhmedHazimovic", "okDfATqJgsrBnAlvuSowfME5oww=", "+98TCK7Prn74upr2wFnSRA==", 2 },
                    { 9, "DzanisBrkan", "1lehabhntsH2RF/Kd0ZhReNzwao=", "+98TCK7Prn74upr2wFnSRA==", 2 },
                    { 8, "MahirSkula", "bKIQzimofw5cMPiGHClHU4mRYH0=", "+98TCK7Prn74upr2wFnSRA==", 2 },
                    { 7, "ArmanBise", "DsTh0j1/E4esSNjRCn+jtSjx1AI=", "+98TCK7Prn74upr2wFnSRA==", 2 },
                    { 5, "BeFirstServiser", "iZaqi/tQukIrLUXGT3s3gGGUJP0=", "SrY3Tqxi65mhzoZW8PdPiA==", 4 },
                    { 3, "Hazim", "HuiOKkk2juGXgaR155oZLYuhrco=", "+98TCK7Prn74upr2wFnSRA==", 2 },
                    { 2, "BeFirstKorisnik", "GfOIoJsRZ3acjo73luCKvqfwH34=", "tKv10dENHhM7HEA8AptZWA==", 2 },
                    { 1, "Admin", "FtJdX+0+S7XwnwHgLkPxTUygj08=", "zQizqXl1hfbL3Yg/g3OteA==", 1 },
                    { 13, "NikolaLeung", "NHScnIQQKvDI8Mi7XabO9u+uTy0=", "i7dJDt4f375NU0HgYbE46w==", 3 }
                });

            migrationBuilder.InsertData(
                table: "Internet",
                columns: new[] { "Id", "Brzina", "Cijena", "Naziv", "Opis", "UgovorId" },
                values: new object[,]
                {
                    { 5, "150mbps", 75.99f, "Internet 5", "Brz internet haos", 1 },
                    { 4, "100mbps", 75.99f, "Internet 4", "Brz internet haos", 1 },
                    { 3, "150mbps", 75.99f, "Internet 3", "Brz internet haos", 1 },
                    { 2, "50mbps", 75.99f, "Internet 2", "Brz internet haos", 1 },
                    { 1, "150mbps", 75.99f, "Internet 1", "Brz internet haos", 1 }
                });

            migrationBuilder.InsertData(
                table: "Administrator",
                columns: new[] { "Id", "AccountId", "Adresa", "Ime", "Prezime" },
                values: new object[] { 1, 1, "Admin Adresa 1", "Ajla", "Bise" });

            migrationBuilder.InsertData(
                table: "Paket",
                columns: new[] { "Id", "CaTV", "InternetId", "PaketNamjenaId", "Snizen", "UgovorId" },
                values: new object[,]
                {
                    { 1, true, 1, 1, true, 1 },
                    { 2, true, 1, 2, false, 2 },
                    { 5, true, 2, 1, true, 3 },
                    { 3, false, 3, 3, true, 4 },
                    { 4, true, 4, 4, false, 2 },
                    { 6, true, 5, 2, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Uposlenik",
                columns: new[] { "Id", "AccountID", "Adresa", "Aktivan", "BrojTelefona", "Email", "Grad", "Ime", "Plata", "PozicijaID", "Prezime", "UgovorID" },
                values: new object[,]
                {
                    { 1, 4, "Uposlenik Adresa 1", true, "063000111", "uposlenik@befirst.com", "Tuzla", "UposlenikIme", 1495.0, 1, "UposlenikPrezime", 1 },
                    { 3, 11, "Uposlenik Adresa 2", true, "063000111", "serviser@befirst.com", "Tuzla", "Nedim", 1495.0, 3, "Sendro", 1 },
                    { 4, 12, "Uposlenik Adresa 2", true, "063000111", "serviser@befirst.com", "Tuzla", "Lejla", 1495.0, 3, "Bise", 1 },
                    { 5, 13, "Uposlenik Adresa 2", true, "063000111", "serviser@befirst.com", "Tuzla", "Nikola", 1495.0, 1, "Leung", 1 },
                    { 2, 5, "Uposlenik Adresa 2", true, "063000111", "serviser@befirst.com", "Tuzla", "ServiserIme", 1495.0, 2, "ServiserPrezime", 1 }
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "Id", "AccountID", "Adresa", "BrojTelefona", "DatumRodjenja", "Email", "Grad", "Ime", "Komentar", "PaketID", "Prezime", "UgovorID", "VrstaKorisnika" },
                values: new object[,]
                {
                    { 1, 2, "Korisnik Adresa 1", "061222555", new DateTime(1997, 5, 23, 1, 10, 58, 93, DateTimeKind.Local).AddTicks(4066), "korisnik1@befirst.com", "Mostar", "KorisnikIme", "Bez rijeci", 1, "KorisnikPrezime", 1, 4 },
                    { 2, 3, "Korisnik Adresa 2", "061777999", new DateTime(1985, 5, 23, 1, 10, 58, 95, DateTimeKind.Local).AddTicks(9686), "korisnik2@befirst.com", "Sarajevo", "Hazim", "Ostao bez teksta", 1, "Hazimovic", 1, 4 },
                    { 7, 10, "Korisnik Adresa 2", "061777999", new DateTime(1985, 5, 23, 1, 10, 58, 95, DateTimeKind.Local).AddTicks(9791), "korisnik2@befirst.com", "Sarajevo", "Ahmed", "Ostao bez teksta", 1, "Hazimovic", 2, 1 },
                    { 3, 6, "Korisnik Adresa 3", "061777999", new DateTime(1985, 5, 23, 1, 10, 58, 95, DateTimeKind.Local).AddTicks(9768), "korisnik2@befirst.com", "Sarajevo", "Ajla", "Ostao bez teksta", 3, "Bise", 3, 2 },
                    { 4, 7, "Korisnik Adresa 2", "061777999", new DateTime(1985, 5, 23, 1, 10, 58, 95, DateTimeKind.Local).AddTicks(9775), "korisnik2@befirst.com", "Sarajevo", "Arman", "Ostao bez teksta", 3, "Bise", 4, 2 },
                    { 6, 9, "Korisnik Adresa 2", "061777999", new DateTime(1985, 5, 23, 1, 10, 58, 95, DateTimeKind.Local).AddTicks(9786), "korisnik2@befirst.com", "Sarajevo", "Dzanis", "Ostao bez teksta", 3, "Brkan", 3, 1 },
                    { 5, 8, "Korisnik Adresa 2", "061777999", new DateTime(1985, 5, 23, 1, 10, 58, 95, DateTimeKind.Local).AddTicks(9781), "korisnik2@befirst.com", "Sarajevo", "Mahir", "Ostao bez teksta", 4, "Skula", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "RadniNalog",
                columns: new[] { "ID", "Adresa", "Datum", "KorisnikID", "KorisnikIme", "KorisnikPrezime", "OpisIzvrsenogPosla", "OpisPrijavljenogPosla" },
                values: new object[,]
                {
                    { 3, "a", new DateTime(2021, 5, 23, 1, 10, 58, 98, DateTimeKind.Local).AddTicks(2102), 7, "Ahmed", "Hazimovic", "Zamijenjen resiver", "Loš signal" },
                    { 1, "a", new DateTime(2021, 5, 23, 1, 10, 58, 97, DateTimeKind.Local).AddTicks(9352), 3, "Ajla", "Bise", "Zamijenjen resiver", "Nestanak programa" },
                    { 2, "a", new DateTime(2021, 5, 23, 1, 10, 58, 98, DateTimeKind.Local).AddTicks(2051), 5, "Mahir", "Skula", "Priključivanje CaTv", "Priključivanje CaTv" }
                });

            migrationBuilder.InsertData(
                table: "Zahtjev",
                columns: new[] { "Id", "KorisnikId", "KorisnikIme", "Naslov", "Odgovor", "Odgovoreno", "Opis", "Pogledno" },
                values: new object[,]
                {
                    { 1, 1, "Hazim", "Prekid programa", "", false, "Jutros od 10:00h prekinuti su svi programi. Molim Vas kad možete doći da popravite?", false },
                    { 4, 3, "Ajla", "Slab signal", "Kolege serviseri će doći do vas danas u terminu 14:00h. Lp", false, "Zadnjih par dana signal je jako los. Da li bi neko mogao doci da pogleda? Lp", false },
                    { 3, 4, "Mahir", "Prekid programa", "", false, "Jutros od 11:00h prekinuti su svi programi. Molim Vas kad možete doći da popravite?", false },
                    { 2, 5, "Arman", "Istice ugovor", "", false, "Poštovanje, ističe mi uskoro ugovor za paket 88TGHTE, koje papire treba da donesem u prostorije Kablovske da bi produžil isti ugovor?", false }
                });

            migrationBuilder.InsertData(
                table: "OpremaUposlenikRadnoNalog",
                columns: new[] { "Id", "OpremaID", "RadniNalogID", "UposlenikID" },
                values: new object[] { 2, 2, 3, 1 });

            migrationBuilder.InsertData(
                table: "OpremaUposlenikRadnoNalog",
                columns: new[] { "Id", "OpremaID", "RadniNalogID", "UposlenikID" },
                values: new object[] { 1, 2, 1, 1 });

            migrationBuilder.InsertData(
                table: "OpremaUposlenikRadnoNalog",
                columns: new[] { "Id", "OpremaID", "RadniNalogID", "UposlenikID" },
                values: new object[] { 3, 3, 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Account_UlogaId",
                table: "Account",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_AccountId",
                table: "Administrator",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Internet_UgovorId",
                table: "Internet",
                column: "UgovorId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_AccountID",
                table: "Korisnik",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_PaketID",
                table: "Korisnik",
                column: "PaketID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_UgovorID",
                table: "Korisnik",
                column: "UgovorID");

            migrationBuilder.CreateIndex(
                name: "IX_OpremaUposlenikRadnoNalog_OpremaID",
                table: "OpremaUposlenikRadnoNalog",
                column: "OpremaID");

            migrationBuilder.CreateIndex(
                name: "IX_OpremaUposlenikRadnoNalog_RadniNalogID",
                table: "OpremaUposlenikRadnoNalog",
                column: "RadniNalogID");

            migrationBuilder.CreateIndex(
                name: "IX_OpremaUposlenikRadnoNalog_UposlenikID",
                table: "OpremaUposlenikRadnoNalog",
                column: "UposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_Paket_InternetId",
                table: "Paket",
                column: "InternetId");

            migrationBuilder.CreateIndex(
                name: "IX_Paket_PaketNamjenaId",
                table: "Paket",
                column: "PaketNamjenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Paket_UgovorId",
                table: "Paket",
                column: "UgovorId");

            migrationBuilder.CreateIndex(
                name: "IX_RadniNalog_KorisnikID",
                table: "RadniNalog",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_AccountID",
                table: "Uposlenik",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_PozicijaID",
                table: "Uposlenik",
                column: "PozicijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_UgovorID",
                table: "Uposlenik",
                column: "UgovorID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_KorisnikId",
                table: "Zahtjev",
                column: "KorisnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "OpremaUposlenikRadnoNalog");

            migrationBuilder.DropTable(
                name: "Ponuda");

            migrationBuilder.DropTable(
                name: "Zahtjev");

            migrationBuilder.DropTable(
                name: "Oprema");

            migrationBuilder.DropTable(
                name: "RadniNalog");

            migrationBuilder.DropTable(
                name: "Uposlenik");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Pozicije");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Paket");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Internet");

            migrationBuilder.DropTable(
                name: "PaketNamjena");

            migrationBuilder.DropTable(
                name: "Ugovor");
        }
    }
}
