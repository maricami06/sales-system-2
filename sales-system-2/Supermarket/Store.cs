using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system_2.Supermarket
{
    class Store
    {
        SalesMan[] SalesMan = new SalesMan[50];
        int salesmanCount = 0;

        Product[] Product = new Product[200];
        int productCount = 0;

        Sale[] Sale = new Sale[500];
        int saleCount = 0;

        public void AddSalesman(SalesMan newSalesman)
        {
            SalesMan[salesmanCount] = newSalesman;
            salesmanCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Product[productCount] = newProduct;
            productCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sale[saleCount] = newSale;
            saleCount++;
        }

        public int QuantityProductsSold()
        {
            int count = 0;
            for (int i = 0; i < productCount; i++)
            {
                count++;
            }
            return count;
        }

        public float SalesTotal()
        {
            float countSaleTotal = 0;
            for (int i = 0; i < saleCount; i++)
            {
                countSaleTotal = countSaleTotal + Sale[i].Product.price;
            }
            return countSaleTotal;
        }

        public float AverageProductPrice()
        {
            float average = 0;
            float saleTotal = 0;
            for (int i = 0; i < saleCount; i++)
            {
                saleTotal = saleTotal + Sale[i].Product.price;
                average = saleTotal / QuantityProductsSold();
            }
            return average;
        }

        public string MostExpensiveProduct()
        {
            float mostExpensive = 0;
            string product = "";
            for (int i = 0; i < saleCount; i++)
            {
                if (Sale[i].Product.price > mostExpensive)
                {
                    mostExpensive = Sale[i].Product.price;
                    product = Sale[i].Product.name;
                }
            }
            return product;
        }

        public string CheaperProduct()
        {
           
            string product = "";
            int it = 0;
            float mostCheaper = Sale[it].Product.price;
            for (int i = 1 ; i < saleCount; i++)
            {
                if (Sale[i].Product.price < mostCheaper)
                {
                    mostCheaper = Sale[i].Product.price;
                    product = Sale[i].SalesMan.name;
                }
                else
                {
                    mostCheaper = Sale[it].Product.price;
                    product = Sale[it].SalesMan.name;
                }
            }
            return product;
        }


    }
}
