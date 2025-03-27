namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Samsung", "Galaxy A", 1500, 700, 14);
            product.GetInfo();
            product.Sale(3);

        }
    }
}
