using ECommerceApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Infrastructre.EntityTypeConfiguration
{
    public class MallConfig : BaseEntityConfig<Mall>

    {
        public override void Configure(EntityTypeBuilder<Mall> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired(true);  //Guid değil int yaparsam yazmalıyım ? /*HasAnnotation("SqlServer:Identity", "1000,");  */

            base.Configure(builder);
        }
    }
}
