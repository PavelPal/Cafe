namespace Cafe.Domain.Migrations
{
    using System.Linq;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using Cafe.Domain.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<CafeContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CafeContext context)
        {
            if (!context.Sorts.Any())
            {
                List<Sort> sorts = new List<Sort>
                {
                    new Sort
                    {
                        Name = "Espresso"
                    },
                    new Sort
                    {
                        Name = "Cappuccino"
                    },
                    new Sort
                    {
                        Name = "Americano"
                    },
                    new Sort
                    {
                        Name = "Caffe Latte"
                    },
                    new Sort
                    {
                        Name = "Caf au Lait"
                    },
                    new Sort
                    {
                        Name = "Caf Mocha (Mochachino)"
                    },
                    new Sort
                    {
                        Name = "Caramel Macchiato"
                    },
                };

                sorts.AddRange(sorts);
            }

            context.SaveChanges();
        }
    }
}
