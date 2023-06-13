using NUnit.Framework;
using Block1Variant6.Classes;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {
        }

        [Test]
        public void TestQuality ()//проверка метода главного класса
        {
            string name = "Apple";
            double price = 10;
            int count = 5;
            BaseClass p1 = new BaseClass("Apple", 10, 5);
            Assert.AreEqual(name, p1.productName);
            Assert.AreEqual(price, p1.productPrice);
            Assert.AreEqual(count, p1.productCount);

        }
        [Test]
        public void TestQualityChild()//Проверка метода потомка
        {
            string name = "Xiaomi";
            double price = 15;
            int count = 3;
            int year = 2018;
            ChildClass p2 = new ChildClass("Xiaomi",15,3,2018);
            Assert.AreEqual(name, p2.productName);
            Assert.AreEqual(price, p2.productPrice);
            Assert.AreEqual(count, p2.productCount);
            Assert.AreEqual(year, p2.p);

        }
        public void CheckQ()//проверка Q
        {
            string name = "Iphone2";
            double price = 10;
            int count = 5;
            BaseClass baseclass = new BaseClass(name, price, count);
            double Q = baseclass.Quality(price, count);
            Assert.AreEqual(Q, baseclass.Quality(price, count));
        }
        public void CheckQp ()//проверка Qp
        {
            string name = "Iphone2";
            double price = 10;
            int count = 5;
            int p = 0;
            ChildClass baseclass = new ChildClass(name, price, count, p);
            double QP = baseclass.QP(count, price, p);
            Assert.AreEqual(QP, baseclass.Quality(price, count));
        }
    }
}