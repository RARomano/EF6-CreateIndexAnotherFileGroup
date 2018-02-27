using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class ExtendedSqlServerMigrationsSqlGenerator : SqlServerMigrationSqlGenerator
    {
        /// <summary>
        /// Generates SQL for a <see cref="T:System.Data.Entity.Migrations.Model.CreateIndexOperation" />.
        /// Generated SQL should be added using the Statement method.
        /// </summary>
        /// <param name="createIndexOperation">The operation to produce SQL for.</param>
        protected override void Generate(CreateIndexOperation createIndexOperation)
        {
            using (var writer = Writer())
            {
                #region original code
                writer.Write("CREATE ");

                if (createIndexOperation.IsUnique)
                {
                    writer.Write("UNIQUE ");
                }
                if (createIndexOperation.IsClustered)
                {
                    writer.Write("CLUSTERED ");
                }
                writer.Write("INDEX ");
                writer.Write(Quote(createIndexOperation.Name));
                writer.Write(" ON ");
                writer.Write(Name(createIndexOperation.Table));
                writer.Write("(");
                writer.Write(string.Join(",", createIndexOperation.Columns.Select(c => Quote(c))));
                writer.Write(")");
                #endregion

                // Change the filegroup for non-clustered indexes
                if (!createIndexOperation.IsClustered)
                {
                    // The name of the filegroup is fixed, but that won't change.
                    // TODO: read it from a parameter?                              
                    writer.Write(" ON " + Quote("GRINDEX"));
                }

                Statement(writer);
            }
        }
    }
}
