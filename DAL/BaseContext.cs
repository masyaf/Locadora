using DAL.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseContext<T> : DbContext where T : class
    {

        public DbSet<T> DbSet
        {
            get;
            set;
        }

        public BaseContext()  : base("LocadoraContext")
        {
           
            
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
            Configuration.ValidateOnSaveEnabled = false;
            Database.SetInitializer<BaseContext<T>>(null);
        }
         
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new LoanMap());
            modelBuilder.Configurations.Add(new LoanMovieMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new RankingMap());
            modelBuilder.Configurations.Add(new GenderMap());
            modelBuilder.Configurations.Add(new RecorderMap());
            modelBuilder.Configurations.Add(new TypeMovieMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            Database.Log = (query) => Debug.Write(query);
        }
        public virtual void ChangeObjectState(object model, EntityState state)
        {
            ((IObjectContextAdapter)this)
                          .ObjectContext
                          .ObjectStateManager
                          .ChangeObjectState(model, state);
        }

        public virtual int Save(T model)
        {
            Database.Log = Console.WriteLine;
                this.DbSet.Add(model);
                return this.SaveChanges();
      
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }



        public virtual int Update(T model)
        {
            
            var entry = this.Entry(model);
            if (entry.State == EntityState.Detached)
                this.DbSet.Attach(model);

            this.ChangeObjectState(model, EntityState.Modified);
            return this.SaveChanges();
        }

        public virtual void Delete(int code)
        {
            this.SaveChanges();
        } 

        public virtual IEnumerable<T> GetAll()
        {
            return this.DbSet.ToList();
        }

        public virtual T GetByCode(int code)
        {
            return this.DbSet.Find(code);
        }

        public virtual IEnumerable<T> Where(Expression<Func<T, bool>> expression)
        {
            
            return this.DbSet.Where(expression);
        }

        public IEnumerable<T> OrderBy(Expression<Func<T, bool>> expression)
        {
            return this.DbSet.OrderBy(expression);
        }
    }
}