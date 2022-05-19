using Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.ModelMap {
    public class PessoaMap : IEntityTypeConfiguration<Pessoa> {
        public void Configure(EntityTypeBuilder<Pessoa> builder) {

            builder.ToTable("pessoa");

            builder.HasKey(x => x.codigo);

            builder.Property(x => x.nome).HasMaxLength(50);

        }
    }
}
