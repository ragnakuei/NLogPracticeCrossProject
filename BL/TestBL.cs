using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TestBL
    {
        private readonly Logger _logger;

        public TestBL()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public void Test()
        {
            _logger.Debug(MethodBase.GetCurrentMethod());
        }
    }
}
