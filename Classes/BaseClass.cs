using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1Variant6.Classes
{
    public class BaseClass
    {
        public string productName { get; set; } //имя товара
        public double productPrice { get; set; }//цена товара
        public int productCount { get; set; } //название товара
        public BaseClass (string ProductName, double Productprice, int Productcount)
        {
            this.productName = ProductName;//переменная для имени товара
            this.productPrice = Productprice;//переменная для цены товара
            this.productCount = Productcount;//переменная для количества товара
        }
        public virtual double Quality (double Productprice, int Productcount)
        {
            var Q = Productprice / Productcount; //расчет переменной
            return Q;
        }
        public void PrintInfo ()
        {
            Console.WriteLine($"Q = {Quality(productPrice, productCount)}");//метод для вывода информации
        }
    }
}
