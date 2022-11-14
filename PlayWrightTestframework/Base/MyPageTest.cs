using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWrightTestframework.Base
{
    public class MyPageTest : PageTest, IMyPageTest
    {
        //Um Später Playwright auszutauschen, oder erweitern zu können.
        public MyPageTest(): base()
        {

        }

    }
}
