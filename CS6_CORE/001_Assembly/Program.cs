using System;
using System.Reflection;

namespace TestAssembly
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Assembly a = Assembly.GetEntryAssembly();
            Console.WriteLine($"    {a.FullName}");
            Console.WriteLine($"    {a.CodeBase}");

            // Display the set of assemblies our assemblies reference.
            Console.WriteLine("Referenced assemblies:");
            foreach (AssemblyName an in a.GetReferencedAssemblies())
                Console.WriteLine("    Name={0}, Version={1}, Culture={2}, PublicKey token={3}", an.Name, an.Version, an.CultureName, (BitConverter.ToString (an.GetPublicKeyToken())));

            // Instantiate an Assembly class to the assembly housing the Integer type.
            Assembly systemAssembly = typeof(String).GetTypeInfo().Assembly;
            Console.WriteLine("FullName = {0}", systemAssembly.FullName);
            Console.WriteLine("CodeBase = {0}", systemAssembly.CodeBase);
            systemAssembly = typeof(Int32).GetTypeInfo().Assembly;
            Console.WriteLine("FullName = {0}", systemAssembly.FullName);
            Console.WriteLine("CodeBase = {0}", systemAssembly.CodeBase);

            Console.Write("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
