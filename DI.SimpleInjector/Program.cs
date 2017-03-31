using DI.Common;
using SimpleInjector;
using System;

namespace DI.SimpleInjector
{
    class Program
    {
        static void Main(string[] args)
        {
            App.Init();

            var myVM = App.Container.GetInstance<MyViewModel>();
            myVM.MyName = "Jakub";
            var html = myVM.HTML;

            Console.WriteLine(html);
        }
    }
    static class App
    {
        public static Container Container { get; set; }

        public static void Init()
        {
            Container = new Container();

            Container.Register<IHttpClient, MyHttpClient>();
            Container.Register<MyViewModel>();
        }
    }
}