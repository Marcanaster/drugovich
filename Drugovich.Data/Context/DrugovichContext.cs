using Drugovich.Data.Mapping;
using Drugovich.Domain.Entities;
using Drugovich.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Drugovich.Data.Context
{
    public class DrugovichContext : DbContext
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<GerenteEntity> Gerentes { get; set; }
        public DbSet<GrupoEntity> Grupos { get; set; }
        public DbSet<UsuarioEntity> Usuarios { get; set; }


        public DrugovichContext(DbContextOptions<DrugovichContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<ClienteEntity>(new ClienteMap().Configure);
            modelbuilder.Entity<GerenteEntity>(new GerenteMap().Configure);
            modelbuilder.Entity<GrupoEntity>(new GrupoMap().Configure);
            modelbuilder.Entity<UsuarioEntity>(new UsuarioMap().Configure);

            modelbuilder.Entity<GerenteEntity>()
                .HasOne(a => a.Usuario)
                .WithOne(b => b.Gerente)
                .HasForeignKey<UsuarioEntity>(b => b.GerenteRef);

            modelbuilder.Entity<GrupoEntity>()
            .HasMany<ClienteEntity>(g => g.Clientes)
            .WithOne(s => s.Grupo)
            .HasForeignKey(s => s.GrupoRef);

            modelbuilder.Entity<GerenteEntity>().HasData(new GerenteEntity { Id = 1, Codigo = "GR0001", Nome = "Gerente nivel Um", Email = "gerentenivel1@drugovich.com", Nivel = NivelGerenteEnum.nivelum, CreatAt = DateTime.Now });
            modelbuilder.Entity<GerenteEntity>().HasData(new GerenteEntity { Id = 2, Codigo = "GR0002", Nome = "Gerente nivel Dois", Email = "gerentenivel2@drugovich.com", Nivel = NivelGerenteEnum.niveldois, CreatAt = DateTime.Now });
            modelbuilder.Entity<GrupoEntity>().HasData(new GrupoEntity { Id = 1, Codigo = "Grupo000A", Nome = "Grupo A", CreatAt = DateTime.Now }); ;
            modelbuilder.Entity<GrupoEntity>().HasData(new GrupoEntity { Id = 2, Codigo = "Grupo000B", Nome = "Grupo B", CreatAt = DateTime.Now });
            modelbuilder.Entity<GrupoEntity>().HasData(new GrupoEntity { Id = 3, Codigo = "Grupo000C", Nome = "Grupo C", CreatAt = DateTime.Now });
            modelbuilder.Entity<ClienteEntity>().HasData(new ClienteEntity { Id = 1, Codigo = "CLiente0001", Nome = "Cliente 1", GrupoRef = 1, CNPJ = "95195019000147", CreatAt = DateTime.Now });
            modelbuilder.Entity<ClienteEntity>().HasData(new ClienteEntity { Id = 2, Codigo = "CLiente0002", Nome = "Cliente 2", GrupoRef = 2, CNPJ = "43514821000159", CreatAt = DateTime.Now });
            modelbuilder.Entity<ClienteEntity>().HasData(new ClienteEntity { Id = 3, Codigo = "CLiente0003", Nome = "Cliente 3", GrupoRef = 3, CNPJ = "15693178000132", CreatAt = DateTime.Now });
            modelbuilder.Entity<UsuarioEntity>().HasData(new UsuarioEntity { Id = 1, Login = "user1", Senha = "0a84e19c7d8defe8", GerenteRef = 1, Ativo = true, CreatAt = DateTime.Now });
            modelbuilder.Entity<UsuarioEntity>().HasData(new UsuarioEntity { Id = 2, Login = "user2", Senha = "0a84e19c7d8defe8", GerenteRef = 2, Ativo = true, CreatAt = DateTime.Now });
        }
    }
}
