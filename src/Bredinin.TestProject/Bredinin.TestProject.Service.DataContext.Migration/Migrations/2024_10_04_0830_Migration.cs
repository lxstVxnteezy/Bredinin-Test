﻿using FluentMigrator;

namespace Bredinin.TestProject.Service.DataContext.Migration.Migrations
{
    [Migration(2024_10_04_0830)]
    public class Migration_2024_10_04_0830 : ForwardOnlyMigration
    {
        public override void Up()
        {
            Execute.Sql(
                "CREATE TABLE public.product_categories" +
                "(id uuid NOT NULL," +
                "name varchar NOT NULL,"+
                "description varchar NULL"+
                ");"
                );  
        }
    }
}
