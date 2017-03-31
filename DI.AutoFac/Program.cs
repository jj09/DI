using Autofac;
using DI.Common;
using System;

namespace DI.AutoFac
{
    class Program
    {
        static void Main(string[] args)
        {
            App.Init();

            var myVM = App.Container.Resolve<MyViewModel>();
            myVM.MyName = "Jakub";
            var html = myVM.HTML;

            Console.WriteLine(html);
        }
    }


    static class App
    {
        public static IContainer Container { get; set; }

        public static void Init()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MyHttpClient>().As<IHttpClient>();
            builder.RegisterType<MyViewModel>();


            Container = builder.Build();
        }
    }
}