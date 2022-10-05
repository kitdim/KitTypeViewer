namespace KitTypeViewer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Messages.Hello);
            var typeName = "";

            do
            {
                Console.WriteLine("\n" + Messages.EnterNameType);
                Console.Write(Messages.OrEnterOnQForExit);

                typeName = Console.ReadLine();
                if (typeName.Equals("Q", StringComparison.OrdinalIgnoreCase)) break;

                try
                {
                    var type = Type.GetType(typeName);
                    type = type == null && typeName.Equals("System.Console", StringComparison.OrdinalIgnoreCase) ?  typeof(System.Console) : type;

                    Console.WriteLine();
                    MyReflication.ListVariousStats(type);
                    MyReflication.ListFields(type);
                    MyReflication.ListProp(type);
                    MyReflication.ListMethods(type);
                    MyReflication.ListInterfaces(type);
                }
                catch
                {
                    Console.WriteLine(Messages.TypeNotFound);
                }
            } while (true);
        }
    }
}

//TODO добавить локализацию

