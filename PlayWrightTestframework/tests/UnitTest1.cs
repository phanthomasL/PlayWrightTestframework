using SeleniumWebtestFramework.Base.Area;
using SeleniumWebtestFramework.Base;
using SeleniumWebtestFramework.Func.perform;

namespace PlayWrightTestframework.tests
{
    [TestClass]
    public class UnitTest1 : BaseFunctions
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region Variablen
            IArea buttonBar1 = new ButtonBarArea("ButtonBar bier");
            #endregion

            Click(Button, "plus bier", buttonBar1);

        }
    }
    
}