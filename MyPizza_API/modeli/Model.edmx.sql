
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/06/2017 14:08:58
-- Generated from EDMX file: C:\Users\gabel\OneDrive\Documents\GitHub\My_Pizza\MyPizza_API\Models\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPizza];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DodatniSastojci_NarudzbePizze]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DodatniSastojci] DROP CONSTRAINT [FK_DodatniSastojci_NarudzbePizze];
GO
IF OBJECT_ID(N'[dbo].[FK_DodatniSastojci_Sastojci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DodatniSastojci] DROP CONSTRAINT [FK_DodatniSastojci_Sastojci];
GO
IF OBJECT_ID(N'[dbo].[FK_Korisnici_Gradovi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Korisnici] DROP CONSTRAINT [FK_Korisnici_Gradovi];
GO
IF OBJECT_ID(N'[dbo].[FK_Korisnici_StatusiKorisnika]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Korisnici] DROP CONSTRAINT [FK_Korisnici_StatusiKorisnika];
GO
IF OBJECT_ID(N'[dbo].[FK_KorisnickeUloge_Korisnici]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KorisnickeUloge] DROP CONSTRAINT [FK_KorisnickeUloge_Korisnici];
GO
IF OBJECT_ID(N'[dbo].[FK_KorisnickeUloge_UlogeKorisnika]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KorisnickeUloge] DROP CONSTRAINT [FK_KorisnickeUloge_UlogeKorisnika];
GO
IF OBJECT_ID(N'[dbo].[FK_Narudzbe_Korisnici]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Narudzbe] DROP CONSTRAINT [FK_Narudzbe_Korisnici];
GO
IF OBJECT_ID(N'[dbo].[FK_Narudzbe_StatusiNarudzbi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Narudzbe] DROP CONSTRAINT [FK_Narudzbe_StatusiNarudzbi];
GO
IF OBJECT_ID(N'[dbo].[FK_NarudzbePizze_Narudzbe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NarudzbePizze] DROP CONSTRAINT [FK_NarudzbePizze_Narudzbe];
GO
IF OBJECT_ID(N'[dbo].[FK_NarudzbePizze_Pizze]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NarudzbePizze] DROP CONSTRAINT [FK_NarudzbePizze_Pizze];
GO
IF OBJECT_ID(N'[dbo].[FK_Ocjene_Korisnici]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ocjene] DROP CONSTRAINT [FK_Ocjene_Korisnici];
GO
IF OBJECT_ID(N'[dbo].[FK_Ocjene_Pizze]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ocjene] DROP CONSTRAINT [FK_Ocjene_Pizze];
GO
IF OBJECT_ID(N'[dbo].[FK_Pizze_CijenePizza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pizze] DROP CONSTRAINT [FK_Pizze_CijenePizza];
GO
IF OBJECT_ID(N'[dbo].[FK_Pizze_StatusiPizza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pizze] DROP CONSTRAINT [FK_Pizze_StatusiPizza];
GO
IF OBJECT_ID(N'[dbo].[FK_Pizze_VelicinePizza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pizze] DROP CONSTRAINT [FK_Pizze_VelicinePizza];
GO
IF OBJECT_ID(N'[dbo].[FK_Pizze_VrstePizza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pizze] DROP CONSTRAINT [FK_Pizze_VrstePizza];
GO
IF OBJECT_ID(N'[dbo].[FK_Racuni_Korisnici]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Racuni] DROP CONSTRAINT [FK_Racuni_Korisnici];
GO
IF OBJECT_ID(N'[dbo].[FK_Racuni_Narudzbe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Racuni] DROP CONSTRAINT [FK_Racuni_Narudzbe];
GO
IF OBJECT_ID(N'[dbo].[FK_VrsteSastojci_Sastojci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VrsteSastojci] DROP CONSTRAINT [FK_VrsteSastojci_Sastojci];
GO
IF OBJECT_ID(N'[dbo].[FK_VrsteSastojci_VrstePizza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VrsteSastojci] DROP CONSTRAINT [FK_VrsteSastojci_VrstePizza];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CijenePizza]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CijenePizza];
GO
IF OBJECT_ID(N'[dbo].[DodatniSastojci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DodatniSastojci];
GO
IF OBJECT_ID(N'[dbo].[Gradovi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gradovi];
GO
IF OBJECT_ID(N'[dbo].[Korisnici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Korisnici];
GO
IF OBJECT_ID(N'[dbo].[KorisnickeUloge]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KorisnickeUloge];
GO
IF OBJECT_ID(N'[dbo].[Narudzbe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Narudzbe];
GO
IF OBJECT_ID(N'[dbo].[NarudzbePizze]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NarudzbePizze];
GO
IF OBJECT_ID(N'[dbo].[Ocjene]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ocjene];
GO
IF OBJECT_ID(N'[dbo].[Pizze]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pizze];
GO
IF OBJECT_ID(N'[dbo].[Racuni]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Racuni];
GO
IF OBJECT_ID(N'[dbo].[Sastojci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sastojci];
GO
IF OBJECT_ID(N'[dbo].[StatusiKorisnika]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StatusiKorisnika];
GO
IF OBJECT_ID(N'[dbo].[StatusiNarudzbi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StatusiNarudzbi];
GO
IF OBJECT_ID(N'[dbo].[StatusiPizza]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StatusiPizza];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[UlogeKorisnika]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UlogeKorisnika];
GO
IF OBJECT_ID(N'[dbo].[VelicinePizza]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VelicinePizza];
GO
IF OBJECT_ID(N'[dbo].[VrstePizza]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VrstePizza];
GO
IF OBJECT_ID(N'[dbo].[VrsteSastojci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VrsteSastojci];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CijenePizza'
CREATE TABLE [dbo].[CijenePizza] (
    [CijenaPizzeId] int IDENTITY(1,1) NOT NULL,
    [Cijena] float  NOT NULL,
    [Opis] nvarchar(500)  NULL,
    [DatumIzmjene] datetime  NULL
);
GO

-- Creating table 'DodatniSastojci'
CREATE TABLE [dbo].[DodatniSastojci] (
    [DodatniSastojakId] int IDENTITY(1,1) NOT NULL,
    [NarudzbaPizzaId] int  NOT NULL,
    [SastojakId] int  NOT NULL
);
GO

-- Creating table 'Gradovi'
CREATE TABLE [dbo].[Gradovi] (
    [GradId] int IDENTITY(1,1) NOT NULL,
    [Grad] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Korisnici'
CREATE TABLE [dbo].[Korisnici] (
    [KorisnikId] int IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(50)  NOT NULL,
    [Prezime] nvarchar(50)  NOT NULL,
    [KorisnickoIme] nvarchar(50)  NOT NULL,
    [LozinkaHash] nvarchar(500)  NOT NULL,
    [LozinkaSalt] nvarchar(500)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [BrojTelefona] nvarchar(50)  NOT NULL,
    [DatumRegistracije] datetime  NOT NULL,
    [StatusKorisnikaId] int  NOT NULL,
    [GradId] int  NOT NULL
);
GO

-- Creating table 'KorisnickeUloge'
CREATE TABLE [dbo].[KorisnickeUloge] (
    [KorisnickaUlogaId] int IDENTITY(1,1) NOT NULL,
    [KorisnikId] int  NOT NULL,
    [UlogaKorisnikaId] int  NOT NULL,
    [DatumIzmjene] datetime  NOT NULL
);
GO

-- Creating table 'Narudzbe'
CREATE TABLE [dbo].[Narudzbe] (
    [NarudzbaId] int IDENTITY(1,1) NOT NULL,
    [KorisnikId] int  NOT NULL,
    [StatusNarudzbeId] int  NOT NULL,
    [DatumNarudzbe] datetime  NOT NULL,
    [OtkazanaNarudzba] bit  NULL
);
GO

-- Creating table 'NarudzbePizze'
CREATE TABLE [dbo].[NarudzbePizze] (
    [NarudzbaPizzaId] int IDENTITY(1,1) NOT NULL,
    [NarudzbaId] int  NOT NULL,
    [PizzaId] int  NOT NULL,
    [Kolicina] int  NOT NULL,
    [Cijena] float  NULL
);
GO

-- Creating table 'Ocjene'
CREATE TABLE [dbo].[Ocjene] (
    [OcjenaId] int IDENTITY(1,1) NOT NULL,
    [PizzaId] int  NOT NULL,
    [KorisnikId] int  NOT NULL,
    [DatumOcjene] datetime  NOT NULL,
    [Ocjena] float  NOT NULL,
    [Komentar] nvarchar(500)  NULL
);
GO

-- Creating table 'Pizze'
CREATE TABLE [dbo].[Pizze] (
    [PizzaId] int IDENTITY(1,1) NOT NULL,
    [VrstaId] int  NOT NULL,
    [VelicinaId] int  NOT NULL,
    [StatusPizzeId] int  NOT NULL,
    [CijenaId] int  NOT NULL,
    [Cijena] float  NULL
);
GO

-- Creating table 'Racuni'
CREATE TABLE [dbo].[Racuni] (
    [RacunId] int IDENTITY(1,1) NOT NULL,
    [Datum] datetime  NOT NULL,
    [NarudzbaId] int  NOT NULL,
    [KorisnikId] int  NOT NULL,
    [CijenaSaPDV] float  NOT NULL,
    [CijenaBezPDV] float  NOT NULL
);
GO

-- Creating table 'Sastojci'
CREATE TABLE [dbo].[Sastojci] (
    [SastojakId] int IDENTITY(1,1) NOT NULL,
    [Sastojak] nvarchar(50)  NOT NULL,
    [BaznaCijena] float  NOT NULL,
    [DodatnaCijena] float  NOT NULL
);
GO

-- Creating table 'StatusiKorisnika'
CREATE TABLE [dbo].[StatusiKorisnika] (
    [StatusKorisnikaId] int IDENTITY(1,1) NOT NULL,
    [Status] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'StatusiNarudzbi'
CREATE TABLE [dbo].[StatusiNarudzbi] (
    [StatusNarudzbeId] int IDENTITY(1,1) NOT NULL,
    [StatusNarudzbe] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'StatusiPizza'
CREATE TABLE [dbo].[StatusiPizza] (
    [StatusPizzeId] int IDENTITY(1,1) NOT NULL,
    [StatusPizze] nvarchar(50)  NOT NULL,
    [Opis] nvarchar(500)  NULL,
    [DatumIzmjene] datetime  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'UlogeKorisnika'
CREATE TABLE [dbo].[UlogeKorisnika] (
    [UlogaKorisnikaId] int IDENTITY(1,1) NOT NULL,
    [Uloga] nvarchar(50)  NOT NULL,
    [Opis] nvarchar(500)  NULL
);
GO

-- Creating table 'VelicinePizza'
CREATE TABLE [dbo].[VelicinePizza] (
    [VelicinaPizzeId] int IDENTITY(1,1) NOT NULL,
    [Velicina] nvarchar(50)  NOT NULL,
    [DatumIzmjene] datetime  NULL,
    [Promjer] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'VrstePizza'
CREATE TABLE [dbo].[VrstePizza] (
    [VrstaPizzeId] int IDENTITY(1,1) NOT NULL,
    [Vrsta] nvarchar(50)  NOT NULL,
    [Opis] nvarchar(700)  NULL,
    [DatumDodavanja] datetime  NOT NULL,
    [DatumIzmjene] datetime  NULL,
    [Slika] varbinary(max)  NULL,
    [SlikaThumb] varbinary(max)  NULL
);
GO

-- Creating table 'VrsteSastojci'
CREATE TABLE [dbo].[VrsteSastojci] (
    [VrsteSastojciId] int IDENTITY(1,1) NOT NULL,
    [VrstaId] int  NOT NULL,
    [SastojakId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CijenaPizzeId] in table 'CijenePizza'
ALTER TABLE [dbo].[CijenePizza]
ADD CONSTRAINT [PK_CijenePizza]
    PRIMARY KEY CLUSTERED ([CijenaPizzeId] ASC);
GO

-- Creating primary key on [DodatniSastojakId] in table 'DodatniSastojci'
ALTER TABLE [dbo].[DodatniSastojci]
ADD CONSTRAINT [PK_DodatniSastojci]
    PRIMARY KEY CLUSTERED ([DodatniSastojakId] ASC);
GO

-- Creating primary key on [GradId] in table 'Gradovi'
ALTER TABLE [dbo].[Gradovi]
ADD CONSTRAINT [PK_Gradovi]
    PRIMARY KEY CLUSTERED ([GradId] ASC);
GO

-- Creating primary key on [KorisnikId] in table 'Korisnici'
ALTER TABLE [dbo].[Korisnici]
ADD CONSTRAINT [PK_Korisnici]
    PRIMARY KEY CLUSTERED ([KorisnikId] ASC);
GO

-- Creating primary key on [KorisnickaUlogaId] in table 'KorisnickeUloge'
ALTER TABLE [dbo].[KorisnickeUloge]
ADD CONSTRAINT [PK_KorisnickeUloge]
    PRIMARY KEY CLUSTERED ([KorisnickaUlogaId] ASC);
GO

-- Creating primary key on [NarudzbaId] in table 'Narudzbe'
ALTER TABLE [dbo].[Narudzbe]
ADD CONSTRAINT [PK_Narudzbe]
    PRIMARY KEY CLUSTERED ([NarudzbaId] ASC);
GO

-- Creating primary key on [NarudzbaPizzaId] in table 'NarudzbePizze'
ALTER TABLE [dbo].[NarudzbePizze]
ADD CONSTRAINT [PK_NarudzbePizze]
    PRIMARY KEY CLUSTERED ([NarudzbaPizzaId] ASC);
GO

-- Creating primary key on [OcjenaId] in table 'Ocjene'
ALTER TABLE [dbo].[Ocjene]
ADD CONSTRAINT [PK_Ocjene]
    PRIMARY KEY CLUSTERED ([OcjenaId] ASC);
GO

-- Creating primary key on [PizzaId] in table 'Pizze'
ALTER TABLE [dbo].[Pizze]
ADD CONSTRAINT [PK_Pizze]
    PRIMARY KEY CLUSTERED ([PizzaId] ASC);
GO

-- Creating primary key on [RacunId] in table 'Racuni'
ALTER TABLE [dbo].[Racuni]
ADD CONSTRAINT [PK_Racuni]
    PRIMARY KEY CLUSTERED ([RacunId] ASC);
GO

-- Creating primary key on [SastojakId] in table 'Sastojci'
ALTER TABLE [dbo].[Sastojci]
ADD CONSTRAINT [PK_Sastojci]
    PRIMARY KEY CLUSTERED ([SastojakId] ASC);
GO

-- Creating primary key on [StatusKorisnikaId] in table 'StatusiKorisnika'
ALTER TABLE [dbo].[StatusiKorisnika]
ADD CONSTRAINT [PK_StatusiKorisnika]
    PRIMARY KEY CLUSTERED ([StatusKorisnikaId] ASC);
GO

-- Creating primary key on [StatusNarudzbeId] in table 'StatusiNarudzbi'
ALTER TABLE [dbo].[StatusiNarudzbi]
ADD CONSTRAINT [PK_StatusiNarudzbi]
    PRIMARY KEY CLUSTERED ([StatusNarudzbeId] ASC);
GO

-- Creating primary key on [StatusPizzeId] in table 'StatusiPizza'
ALTER TABLE [dbo].[StatusiPizza]
ADD CONSTRAINT [PK_StatusiPizza]
    PRIMARY KEY CLUSTERED ([StatusPizzeId] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [UlogaKorisnikaId] in table 'UlogeKorisnika'
ALTER TABLE [dbo].[UlogeKorisnika]
ADD CONSTRAINT [PK_UlogeKorisnika]
    PRIMARY KEY CLUSTERED ([UlogaKorisnikaId] ASC);
GO

-- Creating primary key on [VelicinaPizzeId] in table 'VelicinePizza'
ALTER TABLE [dbo].[VelicinePizza]
ADD CONSTRAINT [PK_VelicinePizza]
    PRIMARY KEY CLUSTERED ([VelicinaPizzeId] ASC);
GO

-- Creating primary key on [VrstaPizzeId] in table 'VrstePizza'
ALTER TABLE [dbo].[VrstePizza]
ADD CONSTRAINT [PK_VrstePizza]
    PRIMARY KEY CLUSTERED ([VrstaPizzeId] ASC);
GO

-- Creating primary key on [VrsteSastojciId] in table 'VrsteSastojci'
ALTER TABLE [dbo].[VrsteSastojci]
ADD CONSTRAINT [PK_VrsteSastojci]
    PRIMARY KEY CLUSTERED ([VrsteSastojciId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CijenaId] in table 'Pizze'
ALTER TABLE [dbo].[Pizze]
ADD CONSTRAINT [FK_Pizze_CijenePizza]
    FOREIGN KEY ([CijenaId])
    REFERENCES [dbo].[CijenePizza]
        ([CijenaPizzeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pizze_CijenePizza'
CREATE INDEX [IX_FK_Pizze_CijenePizza]
ON [dbo].[Pizze]
    ([CijenaId]);
GO

-- Creating foreign key on [NarudzbaPizzaId] in table 'DodatniSastojci'
ALTER TABLE [dbo].[DodatniSastojci]
ADD CONSTRAINT [FK_DodatniSastojci_NarudzbePizze]
    FOREIGN KEY ([NarudzbaPizzaId])
    REFERENCES [dbo].[NarudzbePizze]
        ([NarudzbaPizzaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DodatniSastojci_NarudzbePizze'
CREATE INDEX [IX_FK_DodatniSastojci_NarudzbePizze]
ON [dbo].[DodatniSastojci]
    ([NarudzbaPizzaId]);
GO

-- Creating foreign key on [SastojakId] in table 'DodatniSastojci'
ALTER TABLE [dbo].[DodatniSastojci]
ADD CONSTRAINT [FK_DodatniSastojci_Sastojci]
    FOREIGN KEY ([SastojakId])
    REFERENCES [dbo].[Sastojci]
        ([SastojakId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DodatniSastojci_Sastojci'
CREATE INDEX [IX_FK_DodatniSastojci_Sastojci]
ON [dbo].[DodatniSastojci]
    ([SastojakId]);
GO

-- Creating foreign key on [GradId] in table 'Korisnici'
ALTER TABLE [dbo].[Korisnici]
ADD CONSTRAINT [FK_Korisnici_Gradovi]
    FOREIGN KEY ([GradId])
    REFERENCES [dbo].[Gradovi]
        ([GradId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Korisnici_Gradovi'
CREATE INDEX [IX_FK_Korisnici_Gradovi]
ON [dbo].[Korisnici]
    ([GradId]);
GO

-- Creating foreign key on [StatusKorisnikaId] in table 'Korisnici'
ALTER TABLE [dbo].[Korisnici]
ADD CONSTRAINT [FK_Korisnici_StatusiKorisnika]
    FOREIGN KEY ([StatusKorisnikaId])
    REFERENCES [dbo].[StatusiKorisnika]
        ([StatusKorisnikaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Korisnici_StatusiKorisnika'
CREATE INDEX [IX_FK_Korisnici_StatusiKorisnika]
ON [dbo].[Korisnici]
    ([StatusKorisnikaId]);
GO

-- Creating foreign key on [KorisnikId] in table 'KorisnickeUloge'
ALTER TABLE [dbo].[KorisnickeUloge]
ADD CONSTRAINT [FK_KorisnickeUloge_Korisnici]
    FOREIGN KEY ([KorisnikId])
    REFERENCES [dbo].[Korisnici]
        ([KorisnikId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KorisnickeUloge_Korisnici'
CREATE INDEX [IX_FK_KorisnickeUloge_Korisnici]
ON [dbo].[KorisnickeUloge]
    ([KorisnikId]);
GO

-- Creating foreign key on [KorisnikId] in table 'Narudzbe'
ALTER TABLE [dbo].[Narudzbe]
ADD CONSTRAINT [FK_Narudzbe_Korisnici]
    FOREIGN KEY ([KorisnikId])
    REFERENCES [dbo].[Korisnici]
        ([KorisnikId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Narudzbe_Korisnici'
CREATE INDEX [IX_FK_Narudzbe_Korisnici]
ON [dbo].[Narudzbe]
    ([KorisnikId]);
GO

-- Creating foreign key on [KorisnikId] in table 'Ocjene'
ALTER TABLE [dbo].[Ocjene]
ADD CONSTRAINT [FK_Ocjene_Korisnici]
    FOREIGN KEY ([KorisnikId])
    REFERENCES [dbo].[Korisnici]
        ([KorisnikId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ocjene_Korisnici'
CREATE INDEX [IX_FK_Ocjene_Korisnici]
ON [dbo].[Ocjene]
    ([KorisnikId]);
GO

-- Creating foreign key on [KorisnikId] in table 'Racuni'
ALTER TABLE [dbo].[Racuni]
ADD CONSTRAINT [FK_Racuni_Korisnici]
    FOREIGN KEY ([KorisnikId])
    REFERENCES [dbo].[Korisnici]
        ([KorisnikId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Racuni_Korisnici'
CREATE INDEX [IX_FK_Racuni_Korisnici]
ON [dbo].[Racuni]
    ([KorisnikId]);
GO

-- Creating foreign key on [UlogaKorisnikaId] in table 'KorisnickeUloge'
ALTER TABLE [dbo].[KorisnickeUloge]
ADD CONSTRAINT [FK_KorisnickeUloge_UlogeKorisnika]
    FOREIGN KEY ([UlogaKorisnikaId])
    REFERENCES [dbo].[UlogeKorisnika]
        ([UlogaKorisnikaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KorisnickeUloge_UlogeKorisnika'
CREATE INDEX [IX_FK_KorisnickeUloge_UlogeKorisnika]
ON [dbo].[KorisnickeUloge]
    ([UlogaKorisnikaId]);
GO

-- Creating foreign key on [StatusNarudzbeId] in table 'Narudzbe'
ALTER TABLE [dbo].[Narudzbe]
ADD CONSTRAINT [FK_Narudzbe_StatusiNarudzbi]
    FOREIGN KEY ([StatusNarudzbeId])
    REFERENCES [dbo].[StatusiNarudzbi]
        ([StatusNarudzbeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Narudzbe_StatusiNarudzbi'
CREATE INDEX [IX_FK_Narudzbe_StatusiNarudzbi]
ON [dbo].[Narudzbe]
    ([StatusNarudzbeId]);
GO

-- Creating foreign key on [NarudzbaId] in table 'NarudzbePizze'
ALTER TABLE [dbo].[NarudzbePizze]
ADD CONSTRAINT [FK_NarudzbePizze_Narudzbe]
    FOREIGN KEY ([NarudzbaId])
    REFERENCES [dbo].[Narudzbe]
        ([NarudzbaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NarudzbePizze_Narudzbe'
CREATE INDEX [IX_FK_NarudzbePizze_Narudzbe]
ON [dbo].[NarudzbePizze]
    ([NarudzbaId]);
GO

-- Creating foreign key on [NarudzbaId] in table 'Racuni'
ALTER TABLE [dbo].[Racuni]
ADD CONSTRAINT [FK_Racuni_Narudzbe]
    FOREIGN KEY ([NarudzbaId])
    REFERENCES [dbo].[Narudzbe]
        ([NarudzbaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Racuni_Narudzbe'
CREATE INDEX [IX_FK_Racuni_Narudzbe]
ON [dbo].[Racuni]
    ([NarudzbaId]);
GO

-- Creating foreign key on [PizzaId] in table 'NarudzbePizze'
ALTER TABLE [dbo].[NarudzbePizze]
ADD CONSTRAINT [FK_NarudzbePizze_Pizze]
    FOREIGN KEY ([PizzaId])
    REFERENCES [dbo].[Pizze]
        ([PizzaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NarudzbePizze_Pizze'
CREATE INDEX [IX_FK_NarudzbePizze_Pizze]
ON [dbo].[NarudzbePizze]
    ([PizzaId]);
GO

-- Creating foreign key on [PizzaId] in table 'Ocjene'
ALTER TABLE [dbo].[Ocjene]
ADD CONSTRAINT [FK_Ocjene_Pizze]
    FOREIGN KEY ([PizzaId])
    REFERENCES [dbo].[Pizze]
        ([PizzaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ocjene_Pizze'
CREATE INDEX [IX_FK_Ocjene_Pizze]
ON [dbo].[Ocjene]
    ([PizzaId]);
GO

-- Creating foreign key on [StatusPizzeId] in table 'Pizze'
ALTER TABLE [dbo].[Pizze]
ADD CONSTRAINT [FK_Pizze_StatusiPizza]
    FOREIGN KEY ([StatusPizzeId])
    REFERENCES [dbo].[StatusiPizza]
        ([StatusPizzeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pizze_StatusiPizza'
CREATE INDEX [IX_FK_Pizze_StatusiPizza]
ON [dbo].[Pizze]
    ([StatusPizzeId]);
GO

-- Creating foreign key on [VelicinaId] in table 'Pizze'
ALTER TABLE [dbo].[Pizze]
ADD CONSTRAINT [FK_Pizze_VelicinePizza]
    FOREIGN KEY ([VelicinaId])
    REFERENCES [dbo].[VelicinePizza]
        ([VelicinaPizzeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pizze_VelicinePizza'
CREATE INDEX [IX_FK_Pizze_VelicinePizza]
ON [dbo].[Pizze]
    ([VelicinaId]);
GO

-- Creating foreign key on [VrstaId] in table 'Pizze'
ALTER TABLE [dbo].[Pizze]
ADD CONSTRAINT [FK_Pizze_VrstePizza]
    FOREIGN KEY ([VrstaId])
    REFERENCES [dbo].[VrstePizza]
        ([VrstaPizzeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pizze_VrstePizza'
CREATE INDEX [IX_FK_Pizze_VrstePizza]
ON [dbo].[Pizze]
    ([VrstaId]);
GO

-- Creating foreign key on [SastojakId] in table 'VrsteSastojci'
ALTER TABLE [dbo].[VrsteSastojci]
ADD CONSTRAINT [FK_VrsteSastojci_Sastojci]
    FOREIGN KEY ([SastojakId])
    REFERENCES [dbo].[Sastojci]
        ([SastojakId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VrsteSastojci_Sastojci'
CREATE INDEX [IX_FK_VrsteSastojci_Sastojci]
ON [dbo].[VrsteSastojci]
    ([SastojakId]);
GO

-- Creating foreign key on [VrstaId] in table 'VrsteSastojci'
ALTER TABLE [dbo].[VrsteSastojci]
ADD CONSTRAINT [FK_VrsteSastojci_VrstePizza]
    FOREIGN KEY ([VrstaId])
    REFERENCES [dbo].[VrstePizza]
        ([VrstaPizzeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VrsteSastojci_VrstePizza'
CREATE INDEX [IX_FK_VrsteSastojci_VrstePizza]
ON [dbo].[VrsteSastojci]
    ([VrstaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------