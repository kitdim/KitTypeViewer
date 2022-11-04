namespace KitTypeViewer
{
    static class MyReflication
    {
        public static void ListMethods(Type t)
        {
            Console.WriteLine(Messages.Methods);

            var methodNames = from n in t.GetMethods() select n.Name;
            foreach (var name in methodNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        public static void ListFields(Type t)
        {
            Console.WriteLine(Messages.Fields);

            var fieldNames = from f in t.GetFields() select f.Name;
            foreach (var name in fieldNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        public static void ListProp(Type t)
        {
            Console.WriteLine(Messages.Properties);

            var propNames = from p in t.GetProperties() select p.Name;
            foreach (var name in propNames)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        public static void ListInterfaces(Type t)
        {
            Console.WriteLine(Messages.Interfaces);

            var ifaces = from i in t.GetInterfaces() select i;
            foreach (var name in ifaces)
            {
                Console.WriteLine("->{0}", name);
            }
            Console.WriteLine();
        }

        public static void ListVariousStats(Type t)
        {
            Console.WriteLine(Messages.FullName);

            Console.WriteLine("Базовый класс: {0}", t.BaseType);
            Console.WriteLine("Указанный тип является абстактным? {0}", t.IsAbstract);
            Console.WriteLine("Указанный тип является запечатанным? {0}", t.IsSealed);
            Console.WriteLine("Указанный тип является обобщенным? {0}", t.IsGenericTypeDefinition);
            Console.WriteLine("Указанный тип является классом? {0}", t.IsClass);

            Console.WriteLine();
        }
    }
}
