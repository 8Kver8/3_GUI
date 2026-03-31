using _3_GUI_3;

namespace _3_GUI.Tests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void VerboseAndToTest()
        {
            var area = new Area(1, Area.AreaUnit.hectare);

            Assert.AreEqual("1 гектар", area.Verbose());
            Assert.AreEqual("100 сотка", area.To(Area.AreaUnit.sotka).Verbose());
            Assert.AreEqual("10000 м²", area.To(Area.AreaUnit.m2).Verbose());
        }

        [TestMethod]
        public void MultiplyByNumberTest()
        {
            var area = new Area(3, Area.AreaUnit.sotka);
            var result = area * 4;

            Assert.AreEqual(new Area(12, Area.AreaUnit.sotka), result);
        }

        [TestMethod]
        public void AddSubtractTwoAreasTest()
        {
            var a = new Area(100, Area.AreaUnit.m2);
            var b = new Area(1, Area.AreaUnit.sotka);

            Assert.AreEqual(new Area(200, Area.AreaUnit.m2), a + b);
            Assert.AreEqual(new Area(2, Area.AreaUnit.sotka), b + a);
            Assert.AreEqual(new Area(0, Area.AreaUnit.m2), a - b);
            Assert.AreEqual(new Area(0, Area.AreaUnit.sotka), b - a);
        }

        [TestMethod]
        public void AddSubtractDifferentUnitsTest()
        {
            var hectare = new Area(1, Area.AreaUnit.hectare);
            var sotka = new Area(50, Area.AreaUnit.sotka);

            Assert.AreEqual(new Area(1.5, Area.AreaUnit.hectare), hectare + sotka);
            Assert.AreEqual(new Area(-50, Area.AreaUnit.sotka), sotka - hectare);
        }

        [TestMethod]
        public void CompareToTest()
        {
            var a = new Area(1, Area.AreaUnit.hectare);
            var b = new Area(90, Area.AreaUnit.sotka);
            var c = new Area(100, Area.AreaUnit.sotka);

            Assert.AreEqual(1, a.CompareTo(b));
            Assert.AreEqual(-1, b.CompareTo(a));
            Assert.AreEqual(0, a.CompareTo(c));
        }

        [TestMethod]
        public void ConvertToForGUITest()
        {
            var area = new Area(1, Area.AreaUnit.hectare);

            Assert.AreEqual(100, area.ConvertTo("сотка"));
            Assert.AreEqual(10000, area.ConvertTo("м²"));
            Assert.AreEqual(1, area.ConvertTo("гектар"));
        }
    }
}