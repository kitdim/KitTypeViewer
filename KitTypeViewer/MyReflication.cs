using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitTypeViewer
{
    static class MyReflication
    {
        public static void ListMethods(Type t)
        {
            Console.WriteLine("***** Методы *****");

            var methodNames = from n in t.GetMethods() select n.Name;
            foreach (var name in methodNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        public static void ListFields(Type t)
        {
            Console.WriteLine("***** Поля *****");

            var fieldNames = from f in t.GetFields() select f.Name;
            foreach (var name in fieldNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        public static void ListProp(Type t)
        {
            Console.WriteLine("***** Свойства *****");

            var propNames = from p in t.GetProperties() select p.Name;
            foreach (var name in propNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        public static void ListInterfaces(Type t)
        {
            Console.WriteLine("***** Интерфейсы *****");

            var ifaces = from i in t.GetInterfaces() select i;
            foreach (var name in ifaces)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        public static void ListVariousStats(Type t)
        {
            Console.WriteLine("***** Различная статистика *****");

            Console.WriteLine("Базовый класс: {0}", t.BaseType);
            Console.WriteLine("Указанный тип является абстактным? {0}", t.IsAbstract);
            Console.WriteLine("Указанный тип является запечатанным? {0}", t.IsSealed);
            Console.WriteLine("Указанный тип является обобщенным? {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Указанный тип является классом? {0}", t.IsClass);

            Console.WriteLine();
        }
    }
}
