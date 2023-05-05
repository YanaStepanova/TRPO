using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TRPO
{
    /*!
	\brief Класс - связь с БД
	

	Класс для взаимодействия с базой данных 
*/

    public class ApplicationContext : DbContext
    {
        public DbSet<product> products => Set<product>();
        public DbSet<param> param => Set<param>();
        public ApplicationContext()
        {
            //    Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=kkprod.db");
        }
    }
}
