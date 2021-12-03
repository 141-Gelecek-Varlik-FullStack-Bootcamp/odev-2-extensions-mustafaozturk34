using System;

namespace Homework2_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Extensions.Extensions.RemoveNonAlphanumeric("Gelecek Varlık */-.@ Bootcamp - 2021");
            Console.WriteLine(Extensions.Extensions.RemoveNonAlphanumeric("Gelecek Varlik */-.@ Bootcamp - 2021"));
        }
    }
}
