using st10210396IceTask1PROG6212;

namespace WizardTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWizardProperties()
        {
            // Arrange
            Wizard harry = new Wizard("Harry Potter", "Gryffindor", "Holly, Phoenix Feather, 11 inches", 17, 100);

            // Act
            string name = (string)harry["name"];
            string house = (string)harry["house"];
            string wand = (string)harry["wand"];
            int age = (int)harry["age"];
            double magicPower = (double)harry["magicPower"];

            // Assert
            Assert.AreEqual("Harry Potter", name);
            Assert.AreEqual("Gryffindor", house);
            Assert.AreEqual("Holly, Phoenix Feather, 11 inches", wand);
            Assert.AreEqual(17, age);
            Assert.AreEqual(100, magicPower);
        }
       

        [TestMethod]
        public void TestWizardIndexer()
        {
            // Arrange
            Wizard harry = new Wizard("Harry Potter", "Gryffindor", "Holly, Phoenix Feather, 11 inches", 17, 100);

            // Act
            string name = (string)harry[0];
            string house = (string)harry[1];
            string wand = (string)harry[2];
            int age = (int)harry[3];
            double magicPower = (double)harry[4];

            // Assert
            Assert.AreEqual("Harry Potter", name);
            Assert.AreEqual("Gryffindor", house);
            Assert.AreEqual("Holly, Phoenix Feather, 11 inches", wand);
            Assert.AreEqual(17, age);
            Assert.AreEqual(100, magicPower);
        }

       

        [TestMethod]
        public void TestWizardStringIndexer()
        {
            // Arrange
            Wizard harry = new Wizard("Harry Potter", "Gryffindor", "Holly, Phoenix Feather, 11 inches", 17, 100);

            // Act
            string name = (string)harry["name"];
            string house = (string)harry["house"];
            string wand = (string)harry["wand"];
            int age = (int)harry["age"];
            double magicPower = (double)harry["magicPower"];

            // Assert
            Assert.AreEqual("Harry Potter", name);
            Assert.AreEqual("Gryffindor", house);
            Assert.AreEqual("Holly, Phoenix Feather, 11 inches", wand);
            Assert.AreEqual(17, age);
            Assert.AreEqual(100, magicPower);
        }
        [TestMethod]
        public void TestWizardCreation()
        {
            Wizard hermione = new Wizard("Hermione Granger", "Gryffindor", "Vine, Dragon Heartstring, 10 3/4 inches", 17, 110);
           
            string name = (string)hermione["name"];
            string house = (string)hermione["house"];
            string wand = (string)hermione["wand"];
            int age = (int)hermione["age"];
            double magicPower = (double)hermione["magicPower"];




            // Assert wizard properties
            // Assert
            Assert.AreEqual("Hermione Granger", name);
            Assert.AreEqual("Gryffindor", house);
            Assert.AreEqual("Vine, Dragon Heartstring, 10 3/4 inches", wand);
            Assert.AreEqual(17, age);
            Assert.AreEqual(110.0, magicPower, 0.01);



        }
        [TestMethod]
        public void TestWizardCreation2()
        {

            Wizard dumbledore = new Wizard("Albus Dumbledore", "Gryffindor", "Elder, Thestral Hair, 15 inches", 115, 150);

            string name = (string)dumbledore["name"];
            string house = (string)dumbledore["house"];
            string wand = (string)dumbledore["wand"];
            int age = (int)dumbledore["age"];
            double magicPower = (double)dumbledore["magicPower"];

            Assert.AreEqual("Albus Dumbledore", dumbledore[0]);
            Assert.AreEqual("Gryffindor", dumbledore[1]);
            Assert.AreEqual("Elder, Thestral Hair, 15 inches", dumbledore[2]);
            Assert.AreEqual(115, dumbledore[3]);
            

        }


    }
}