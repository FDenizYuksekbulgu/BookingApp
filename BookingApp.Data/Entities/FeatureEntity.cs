using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;

namespace BookingApp.Data.Entities
{
    public class FeatureEntity : BaseEntity
    {
        public string Title { get; set; }

        // Relational Properties
        public ICollection<HotelFeatureEntity> HotelFeatures{ get; set; }
    }

    public class FeatureConfiguration : BaseConfiguration<FeatureEntity>
    {
        public override void Configure(EntityTypeBuilder<FeatureEntity> builder)
        {
            base.Configure(builder);
        }
    }
}