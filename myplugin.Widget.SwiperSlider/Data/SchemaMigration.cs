using FluentMigrator;
using myplugin.Widget.SwiperSlider.Data.Domain;
using Nop.Data.Migrations;

namespace myplugin.Widget.SwiperSlider.Data
{
    [NopMigration("2020/03/03 19:40:17:6455422", "swiper slider base schema")]
    public class SchemaMigration : AutoReversingMigration
    {
        protected IMigrationManager _migrationManager;
        public SchemaMigration(IMigrationManager migrationManager)
        {
            _migrationManager = migrationManager;
        }

        public override void Up()
        {
            _migrationManager.BuildTable<Slider>(Create);
            _migrationManager.BuildTable<SliderItem>(Create);
        }
    }
}
