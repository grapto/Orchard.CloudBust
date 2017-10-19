using Orchard.Data.Migration;
using Orchard.Environment.Extensions;

namespace CloudBust.Common {
    public class FaviconMigrations : DataMigrationImpl {

        public int Create() {
            SchemaBuilder.CreateTable(
                "FaviconSettingsPartRecord",
                table => table
                             .ContentPartRecord()
                             .Column<string>("FaviconUrl")
                );
            return 1;
        }
    }
}