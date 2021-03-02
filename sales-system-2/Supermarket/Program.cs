using System;

namespace sales_system_2.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            SalesMan v1 = new SalesMan();
            v1.name = "Luis";
            v1.age = 35;
            store.AddSalesman(v1);

            SalesMan v2 = new SalesMan();
            v2.name = "Carlos";
            v2.age = 24;
            store.AddSalesman(v2);

            SalesMan v3 = new SalesMan();
            v3.name = "Natalia";
            v3.age = 19;
            store.AddSalesman(v3);

            Product p1 = new Product();
            p1.name = "chip";
            p1.price = 2000;
            store.AddProduct(p1);

            Product p2 = new Product();
            p2.name = "Soda";
            p2.price = 2500;
            store.AddProduct(p2);

            Product p3 = new Product();
            p3.name = "biscuits";
            p3.price = 500;
            store.AddProduct(p3);

           Product p4 = new Product();
            p4.name = "tomato";
            p4.price = 300;
            store.AddProduct(p4);

            Sale sale1 = new Sale();
            sale1.SalesMan = v1;
            sale1.Product = p1;
            sale1.commensts = "sale made";
            store.AddSale(sale1);

            Sale sale2 = new Sale();
            sale2.SalesMan = v2;
            sale2.Product = p2;
            sale2.commensts = "sale made";
            store.AddSale(sale2);

            Sale sale3 = new Sale();
            sale3.SalesMan = v3;
            sale3.Product = p3;
            sale3.commensts = "sale made";
            store.AddSale(sale3);

            Sale sale4 = new Sale();
            sale4.SalesMan = v3;
            sale4.Product = p4;
            sale4.commensts = "sale made";
            store.AddSale(sale4);

            float salesTotalNewMethod = store.SalesTotal();
            System.Console.WriteLine("Total sales: " + salesTotalNewMethod);

            int countProductsNewMethod = store.QuantityProductsSold();
            System.Console.WriteLine("quantity of products sold: " + countProductsNewMethod);

            float averageProductNewMethod = store.AverageProductPrice() ;
            System.Console.WriteLine("average price of products: " + averageProductNewMethod);

            string nameProductNewMethod = store.MostExpensiveProduct();
            System.Console.WriteLine("most expensive product: " + nameProductNewMethod);

            string nameSalemanLowerSaleNewMethod = store.CheaperProduct();
            System.Console.WriteLine("seller who sold the cheapest product: " + nameSalemanLowerSaleNewMethod);
        }
    }
}
