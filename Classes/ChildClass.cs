using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1Variant6.Classes
{
    public class ChildClass : BaseClass
    {
        public int p { get; set; }
        public ChildClass (string ProductName, double Productprice, int Productcount, int P) : base(ProductName, Productprice, Productcount)
        {
            this.p = P;
        }
        public virtual double QP(int P, double Productprice, int Productcount)
        {
            int T = DateTime.Now.Year; //текущее время и дата
            double q = base.Quality(productPrice,productCount);
            double qp = q + 0.5 * (T - P);
            return qp;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Q = {QP(p, productPrice, productCount)}");//метод для вывода информации
        }
    }
}
