using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace service_lanche.Models
{
    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public virtual DbSet<adicional> adicional { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<combos> combos { get; set; }
        public virtual DbSet<pedidos> pedidos { get; set; }
        public virtual DbSet<produtos> produtos { get; set; }
        public virtual DbSet<registroVendas> registroVendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<adicional>()
                .Property(e => e.adicionais)
                .IsUnicode(false);

            modelBuilder.Entity<adicional>()
                .Property(e => e.precoAdicionais)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.referencia)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.cel)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<combos>()
                .Property(e => e.combo)
                .IsUnicode(false);

            modelBuilder.Entity<combos>()
                .Property(e => e.imgCombo)
                .IsUnicode(false);

            modelBuilder.Entity<combos>()
                .Property(e => e.precoCombo)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.referencia)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.cel)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.pedido)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.adicional)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.obsLanche)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.dataPedido)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.horaPdido)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.totalPedido)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.tipoPagamento)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.obsPagamento)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.recebido)
                .IsUnicode(false);

            modelBuilder.Entity<pedidos>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<produtos>()
                .Property(e => e.produto)
                .IsUnicode(false);

            modelBuilder.Entity<produtos>()
                .Property(e => e.imgProduto)
                .IsUnicode(false);

            modelBuilder.Entity<produtos>()
                .Property(e => e.precoProduto)
                .IsUnicode(false);

            modelBuilder.Entity<produtos>()
                .Property(e => e.descricaoProduto)
                .IsUnicode(false);

            modelBuilder.Entity<produtos>()
                .Property(e => e.extra)
                .IsUnicode(false);

            modelBuilder.Entity<registroVendas>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<registroVendas>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<registroVendas>()
                .Property(e => e.cel)
                .IsUnicode(false);

            modelBuilder.Entity<registroVendas>()
                .Property(e => e.pedido)
                .IsUnicode(false);

            modelBuilder.Entity<registroVendas>()
                .Property(e => e.data)
                .IsUnicode(false);

            modelBuilder.Entity<registroVendas>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<registroVendas>()
                .Property(e => e.total)
                .IsUnicode(false);
        }
    }
}
