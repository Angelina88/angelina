using AutoMapper;
using EFCore.DBA;
using EFCore.Mapping;
using EFCore.Presenter;
using EFCore.Services;
using Microsoft.EntityFrameworkCore;
using Ninject;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace EFCore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var kernel = new StandardKernel();
            RegisterServices(kernel);
            var presenter = kernel.Get<MainPresenter>();

            InitializeMapper();

            presenter.Run();
        }

        private static void InitializeMapper()
        {
            var assembly = Assembly.GetAssembly(typeof(EntityProfile));
            Mapper.Initialize(cfg => cfg.AddProfiles(assembly));
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<DbContext>().To<PlaceDBContext>().InSingletonScope();

            //Регистрация интерфейсов
            RegisterServices<IView>(kernel);

            //Регистрация поставщиков данных
            RegisterServicesInSingleScope<IDataProvider>(kernel);

            //Регистрация сервисов
            RegisterServices<IService>(kernel);
        }

        /// <summary>
        /// Регистрация сервисов типа T
        /// </summary>
        /// <typeparam name="T">тип сервисов</typeparam>
        /// <param name="kernel"></param>
        private static void RegisterServices<T>(IKernel kernel) 
        {
            var assembly = Assembly.GetAssembly(typeof(T));

            var interfaces = assembly.GetTypes()
                .Where(t => t.IsInterface && t.GetInterfaces().Any(i => i == typeof(T))).ToList();
            var classes = assembly.GetTypes()
                .Where(t => t.IsClass && t.GetInterfaces().Any(i => i == typeof(T))).ToList();
            foreach (var inter in interfaces)
            {
                var type = classes.FirstOrDefault(t => t.GetInterfaces().Any(i => i == inter));
                if (type != null)
                    kernel.Bind(inter).To(type);
            }
        }

        private static void RegisterServicesInSingleScope<T>(IKernel kernel)
        {
            var assembly = Assembly.GetAssembly(typeof(T));

            var interfaces = assembly.GetTypes()
                .Where(t => t.IsInterface && t == typeof(T)).ToList();
            var classes = assembly.GetTypes()
                .Where(t => t.IsClass && t.GetInterfaces().Any(i => i == typeof(T))).ToList();
            foreach (var inter in interfaces)
            {
                var type = classes.FirstOrDefault(t => t.GetInterfaces().Any(i => i == inter));
                if (type != null)
                    kernel.Bind(inter).To(type).InSingletonScope();
            }
        }
    }
}
