namespace CariBilanganTest
{
    using TPMOD12;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form1 = new Form1();
            Assert.AreEqual("Bilangan Positif", form1.CariTandaBilangan(1) );
            Assert.AreEqual("Bilangan Negatif", form1.CariTandaBilangan(-1));
            Assert.AreEqual("Bilangan Nol", form1.CariTandaBilangan(0));


        }
    }
}