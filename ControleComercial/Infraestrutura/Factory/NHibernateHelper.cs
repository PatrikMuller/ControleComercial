//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using System.Reflection;

using NHibernate.Driver;
using NHibernate.Bytecode;
using NHibernate.Dialect;
using NHibernate.Connection;
using System.Collections;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
//using System.Collections;

namespace Infraestrutura.Factory
{
    public class NHibernateHelper
    {

        private static ISessionFactory factory = CriaSessionFactory();
                
        public static ISessionFactory CriaSessionFactory()
        {

            //IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString("Server=localhost;Port=5432;Database=money_sic;User Id=postgres;Password=123456;");
            IPersistenceConfigurer configDB = MsSqlConfiguration.MsSql2012.ConnectionString("Server=(local); Database=teste; User Id=user_teste; Password=Bili@35;");
            var configMap = Fluently.Configure().Database(configDB).
                //Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapping.PessoaFisicaMapping>());
                Mappings(x => { x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()); }).
                //ExposeConfiguration( y => new SchemaExport(y).Create(true, false));
                ExposeConfiguration(y => new SchemaUpdate(y).Execute(true, true));



            factory = configMap.BuildSessionFactory();


            //ISessionFactory sessionFactory = Fluently.Configure()
            //    .Database(MsSqlConfiguration.MsSql2012
            //      .ConnectionString(@"Data Source=(localDB)\v11.0;Initial Catalog=Cadastro;Integrated Security=True")
            //                  .ShowSql()
            //    )
            //   .Mappings(m =>
            //              m.FluentMappings
            //                  .AddFromAssemblyOf<Aluno>())
            //    .ExposeConfiguration(cfg => new SchemaExport(cfg)
            //                                    .Create(false, false))
            //    .BuildSessionFactory();



            //ISessionFactory factory = Fluently.Configure(cfg).
            //Mappings(x => { x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()); }).BuildSessionFactory();

            //Configuration cfg = new Configuration();

            //cfg.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
            //cfg.SetProperty("dialect", "NHibernate.Dialect.PostgreSQLDialect");
            //cfg.SetProperty("connection.driver_class", "NHibernate.Driver.NpgsqlDriver");
            //cfg.SetProperty("connection.connection_string", "Server=localhost;Port=5432;Database=money_sic;User Id=postgres;Password=123456;");
            //cfg.SetProperty("hbm2ddl.auto", "update");

            //cfg.Configure();

            //Environment.

            //     < property name = "connection.provider" > NHibernate.Connection.DriverConnectionProvider </ property >

            //< property name = "dialect" > NHibernate.Dialect.PostgreSQLDialect </ property >

            // < property name = "connection.driver_class" > NHibernate.Driver.NpgsqlDriver </ property >

            //  < property name = "connection.connection_string_name" > money_sic </ property >

            //   < property name = "hbm2ddl.auto" > update </ property >


            //cfg.Configure();

            //string connectionString = "";


            //cfg = new Configuration()
            //                .AddProperties(new Dictionary<string, string> {
            //        {Environment.ConnectionDriver, typeof (SQLite20Driver).FullName},
            //        {Environment.ProxyFactoryFactoryClass, typeof (IProxyFactoryFactory).AssemblyQualifiedName},
            //        {Environment.Dialect, typeof (SQLiteDialect).FullName},
            //        {Environment.ConnectionProvider, typeof (DriverConnectionProvider).FullName},
            //        {Environment.ConnectionString, connectionString},
            //                })
            //                .AddAssembly(Assembly.GetExecutingAssembly());


            //dBconnectionString = connectionString;
            //Configuration cfg = new Configuration();
            //IDictionary props = new Hashtable();
            //Hashtable props = new Hashtable();

            //props.Add("hibernate.dialect", "NHibernate.Dialect.MsSql2000Dialect");

            //props.Add("hibernate.connection.provider", "NHibernate.Connection.DriverConnectionProvider");

            //props.Add("hibernate.connection.connection_string", connectionString);

            //cfg.SetProperties(props);
            //cfg.AddProperties(props);

            //cfg.Properties.Add();

            //cfg.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
            //cfg.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver");
            //cfg.SetProperty("connection.connection_string", connectionString);
            //cfg.SetProperty("dialect", "NHibernate.Dialect.MsSql2005Dialect");
            //cfg.SetProperty("default_schema", "bus");

            //cfg.AddAssembly(domainAssembly);

            //sessionFactory = cfg.BuildSessionFactory();


            //public ISessionFactory BuildSessionFactory(string connectionString)
            //{
            //    var cfg = new Configuration()
            //                .AddProperties(new Dictionary<string, string> {
            //        {Environment.ConnectionDriver, typeof (SQLite20Driver).FullName},
            //        {Environment.ProxyFactoryFactoryClass, typeof (ProxyFactoryFactory).AssemblyQualifiedName},
            //        {Environment.Dialect, typeof (SQLiteDialect).FullName},
            //        {Environment.ConnectionProvider, typeof (DriverConnectionProvider).FullName},
            //        {Environment.ConnectionString, connectionString},
            //                })
            //                .AddAssembly(Assembly.GetExecutingAssembly());
            //    return cfg.BuildSessionFactory();
            //}


            //ISessionFactory sessionFactory = Fluently.Configure()
            //    .Database(MsSqlConfiguration.MsSql2012
            //      .ConnectionString(@"Data Source=(localDB)\v11.0;Initial Catalog=Cadastro;Integrated Security=True")
            //                  .ShowSql()
            //    )
            //   .Mappings(m =>
            //              m.FluentMappings
            //                  .AddFromAssemblyOf<Aluno>())
            //    .ExposeConfiguration(cfg => new SchemaExport(cfg)
            //                                    .Create(false, false))
            //    .BuildSessionFactory();


            //ISessionFactory factory = Fluently.Configure(cfg).Mappings
            //    (x => { x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()); }).BuildSessionFactory();
            //(m => m.AutoMappings.Add(AutoMap.AssemblyOf<Machine>)).BuildSessionFactory();

            //string conexão = System.Configuration.ConfigurationManager.ConnectionStrings["Nome da Conexão"].ConnectionString;

            return factory;
                                    
        }

        public static ISession AbreSessao()
        {
            return CriaSessionFactory().OpenSession();
        }

    }
}
