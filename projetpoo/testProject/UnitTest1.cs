using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace testProject
{
    [TestClass]
    public class UnitTest1
    {
        Game _g;
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(_g.hasWinner());

        }

        [TestInitialize]
        public void init(){
            GameCreator g = new GameCreator();
            _g = g.buildGame(0); // 0 for a new Game (not a saved one)
            _g.addPlayer("Toto", 0);
            _g.addPlayer("Prateek", 0);
            _g.addPlayer("Lucifer", 666);
        }

        [TestCleanup]
        public void cleanup()
        {

        }
    }
}
