using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructure.UnitTest
{
    [TestClass]
    public class FirstRepeatedCharacterTests
    {
        [TestMethod]
        public void Happy_Path_One_Repeated_Char()
        {
            FirstRepeatedCharacter character= new FirstRepeatedCharacter();
            char expected = 'a';
            char actual = character.GetFirstRepeatedCharacter("ajay");
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Happy_Path_Zero_Repeated_Char()
        {
            FirstRepeatedCharacter character = new FirstRepeatedCharacter();
            char expected = '\n';
            char actual = character.GetFirstRepeatedCharacter("Vijay");
            Assert.AreEqual(expected, actual);
        }
    }
}
