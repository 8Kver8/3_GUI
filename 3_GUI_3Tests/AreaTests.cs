namespace _3_GUI.Tests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void Constructor_AllUnitsConvertToSquareMeters()
        {
            Assert.AreEqual(1, new Area(1, "м²").ValueInSquareMeters);
            Assert.AreEqual(100, new Area(1, "сотка").ValueInSquareMeters);
            Assert.AreEqual(10000, new Area(1, "гектар").ValueInSquareMeters);
            Assert.AreEqual(10925, new Area(1, "десятина").ValueInSquareMeters);
        }

        [TestMethod]
        public void Add_DifferentAndSameUnits()
        {
            var a1 = new Area(1, "гектар");
            var a2 = new Area(5, "сотка");
            Assert.AreEqual(10500, a1.Add(a2).ValueInSquareMeters);

            var a3 = new Area(3, "сотка");
            var a4 = new Area(2, "сотка");
            Assert.AreEqual(500, a3.Add(a4).ValueInSquareMeters);
        }

        [TestMethod]
        public void Subtract_PositiveAndNegativeResults()
        {
            var a1 = new Area(2, "гектар");
            var a2 = new Area(5, "сотка");
            Assert.AreEqual(19500, a1.Subtract(a2).ValueInSquareMeters);

            var a3 = new Area(1, "сотка");
            var a4 = new Area(1, "гектар");
            Assert.AreEqual(-9900, a3.Subtract(a4).ValueInSquareMeters);
        }

        [TestMethod]
        public void Multiply_NormalZeroAndFraction()
        {
            var a1 = new Area(3, "сотка");
            Assert.AreEqual(1200, a1.Multiply(4).ValueInSquareMeters);

            var a2 = new Area(5, "гектар");
            Assert.AreEqual(0, a2.Multiply(0).ValueInSquareMeters);

            var a3 = new Area(100, "сотка");
            Assert.AreEqual(5000, a3.Multiply(0.5).ValueInSquareMeters);
        }

        [TestMethod]
        public void CompareTo_LessEqualGreater()
        {
            Assert.AreEqual(-1, new Area(1, "гектар").CompareTo(new Area(2, "гектар")));

            Assert.AreEqual(0, new Area(100, "сотка").CompareTo(new Area(1, "гектар")));

            Assert.AreEqual(1, new Area(2, "гектар").CompareTo(new Area(1, "гектар")));
        }

        [TestMethod]
        public void ConvertTo_AllDirections()
        {
            var m2 = new Area(10000, "м²");
            Assert.AreEqual(100, m2.ConvertTo("сотка"));
            Assert.AreEqual(1, m2.ConvertTo("гектар"));

            var ha = new Area(2, "гектар");
            Assert.AreEqual(200, ha.ConvertTo("сотка"));
            Assert.AreEqual(20000, ha.ConvertTo("м²"));

            var sotka = new Area(109, "сотка");
            Assert.AreEqual(0.997, sotka.ConvertTo("десятина"), 0.001);
        }

        [TestMethod]
        public void AddThenConvert()
        {
            var a1 = new Area(1, "гектар");
            var a2 = new Area(100, "сотка");
            var sum = a1.Add(a2);

            Assert.AreEqual(2, sum.ConvertTo("гектар"));
            Assert.AreEqual(200, sum.ConvertTo("сотка"));
            Assert.AreEqual(1.83, sum.ConvertTo("десятина"), 0.01);
        }
    }
}