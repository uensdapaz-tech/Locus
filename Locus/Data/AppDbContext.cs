using Microsoft.EntityFrameworkCore;
using Locus.Models;

namespace Locus.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Setor> Setores { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<TipoServico> TiposServico { get; set; }
        public DbSet<Chamado> Chamados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Setores
            modelBuilder.Entity<Setor>().HasData(
                new Setor { Id = 1, Nome = "Secretaria" },
                new Setor { Id = 2, Nome = "Financeiro" },
                new Setor { Id = 3, Nome = "Biblioteca" }
            );

            // Seed TiposServico
            modelBuilder.Entity<TipoServico>().HasData(
                new TipoServico { Id = 1, Nome = "Instalação SO" },
                new TipoServico { Id = 2, Nome = "Instalação Office" },
                new TipoServico { Id = 3, Nome = "Montagem" },
                new TipoServico { Id = 4, Nome = "Instalação Driver" },
                new TipoServico { Id = 5, Nome = "Instalação Toner" },
                new TipoServico { Id = 6, Nome = "Ativação Windows" }
            );

            // Seed Equipamentos (Tipo agora é string)
            modelBuilder.Entity<Equipamento>().HasData(
                new Equipamento { Id = 1, Tipo = "Desktop", SetorId = 1, Modelo = "Montagem i3" },
                new Equipamento { Id = 2, Tipo = "Notebook", SetorId = 1, Modelo = "Acer Aspire 3" },
                new Equipamento { Id = 3, Tipo = "Notebook", SetorId = 1, Modelo = "Notebook G1" },
                new Equipamento { Id = 4, Tipo = "Desktop", SetorId = 1, Modelo = "Desktop S1" },
                new Equipamento { Id = 5, Tipo = "Desktop", SetorId = 1, Modelo = "Desktop S2" },
                new Equipamento { Id = 6, Tipo = "Desktop", SetorId = 3, Modelo = "Desktop B1" },
                new Equipamento { Id = 7, Tipo = "Impressora", SetorId = 3, Modelo = "HP LaserJet" },
                new Equipamento { Id = 8, Tipo = "Desktop", SetorId = 2, Modelo = "Desktop F1" },
                new Equipamento { Id = 9, Tipo = "Desktop", SetorId = 2, Modelo = "Desktop F2" },
                new Equipamento { Id = 10, Tipo = "Desktop", SetorId = 2, Modelo = "Desktop F3" },
                new Equipamento { Id = 11, Tipo = "Notebook", SetorId = 1, Modelo = "Notebook S3" }
            );

            // Seed Chamados - Dates converted to UTC
            modelBuilder.Entity<Chamado>().HasData(
                new Chamado { Id = 1, DataAbertura = new DateTime(2025, 3, 13, 0, 0, 0, DateTimeKind.Utc), Descricao = "Montagem de computador i3 segunda geração", SetorId = 1, EquipamentoId = 1, TipoServicoId = 3, Status = StatusChamado.Concluido },
                new Chamado { Id = 2, DataAbertura = new DateTime(2025, 3, 13, 0, 0, 0, DateTimeKind.Utc), Descricao = "Instalação do Windows 10 — Notebook Acer Aspire 3, configurar boot", SetorId = 1, EquipamentoId = 2, TipoServicoId = 1, Status = StatusChamado.Concluido },
                new Chamado { Id = 3, DataAbertura = new DateTime(2025, 3, 13, 0, 0, 0, DateTimeKind.Utc), Descricao = "Instalação Office 365 — Notebook", SetorId = 1, EquipamentoId = 3, TipoServicoId = 2, Status = StatusChamado.Concluido },
                new Chamado { Id = 4, DataAbertura = new DateTime(2025, 3, 13, 0, 0, 0, DateTimeKind.Utc), Descricao = "Computador travando, impressora não abre", SetorId = 1, EquipamentoId = 4, TipoServicoId = 3, Status = StatusChamado.Concluido },
                new Chamado { Id = 5, DataAbertura = new DateTime(2025, 3, 13, 0, 0, 0, DateTimeKind.Utc), Descricao = "Ativar Windows", SetorId = 1, EquipamentoId = 5, TipoServicoId = 6, Status = StatusChamado.Concluido },
                new Chamado { Id = 6, DataAbertura = new DateTime(2025, 3, 13, 0, 0, 0, DateTimeKind.Utc), Descricao = "Instalação Office 365 — Desktop", SetorId = 3, EquipamentoId = 6, TipoServicoId = 2, Status = StatusChamado.Concluido },
                new Chamado { Id = 7, DataAbertura = new DateTime(2025, 3, 13, 0, 0, 0, DateTimeKind.Utc), Descricao = "Instalação de Toner", SetorId = 3, EquipamentoId = 7, TipoServicoId = 5, Status = StatusChamado.Concluido },
                new Chamado { Id = 8, DataAbertura = new DateTime(2025, 3, 20, 0, 0, 0, DateTimeKind.Utc), Descricao = "Instalação de SSD — Desktop", SetorId = 2, EquipamentoId = 8, TipoServicoId = 3, Status = StatusChamado.Concluido },
                new Chamado { Id = 9, DataAbertura = new DateTime(2025, 3, 20, 0, 0, 0, DateTimeKind.Utc), Descricao = "Instalação do Windows 10 — Desktop", SetorId = 2, EquipamentoId = 9, TipoServicoId = 1, Status = StatusChamado.Concluido },
                new Chamado { Id = 10, DataAbertura = new DateTime(2025, 3, 20, 0, 0, 0, DateTimeKind.Utc), Descricao = "Instalação de driver de impressora — Desktop", SetorId = 2, EquipamentoId = 10, TipoServicoId = 4, Status = StatusChamado.Concluido },
                new Chamado { Id = 11, DataAbertura = new DateTime(2025, 3, 28, 0, 0, 0, DateTimeKind.Utc), Descricao = "Instalação de driver de impressora — Notebook", SetorId = 1, EquipamentoId = 11, TipoServicoId = 4, Status = StatusChamado.Concluido }
            );
        }
    }
}
