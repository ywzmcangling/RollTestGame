using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    /// <summary>
    /// BowlingGameTest 的摘要说明
    /// </summary>
    
    [TestClass]
    public class BowlingGameTest
    {
        Game g = new Game();
        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.roll(pins);

            }

        }//rollMany

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion



        [TestMethod]
        public void testGutterGame()
        {

            rollMany(20, 0);
            Assert.AreEqual(0, g.score());
        }//testGutterGame




       [TestMethod]
        public void TestAllOnes()
        {
            //
            // TODO: 在此处添加测试逻辑
            //

            Game g = new Game();
            for (int i = 0; i < 20; i++)
                g.roll(1);
            Assert.AreEqual(20, g.score());
        }//testAllOnes



       [TestMethod]

        public void testOnesSpare()
        {
            rollStrike();
            g.roll(3);
            g.roll(4);
            rollMany(17, 0);
            Assert.AreEqual(24,g.score());
        }

       private void rollStrike()
       {
           g.roll(10);//strike
       }

       private void rollSpare()
       {
           g.roll(5);
           g.roll(5); //spare
       } //void testOneSpare 


       [TestMethod]
       public void testPerfectGame()
       {
           rollMany(20,10);
           Assert.AreEqual(300, g.score());
       }



       [TestMethod]
       public void TestSampleGame()
       {
           g.roll(1);
           g.roll(4);
           g.roll(4);
           g.roll(5);
           g.roll(6);
           g.roll(4);
           g.roll(5);
           g.roll(5);
           g.roll(10);
           g.roll(0);
           g.roll(1);
           g.roll(7);
           g.roll(3);
           g.roll(6);
           g.roll(4);
           g.roll(10);
           g.roll(2);
           g.roll(8);
           g.roll(6);
         
           Assert.AreEqual(133,g.score());
       }

    }//BowlingGametest
}
