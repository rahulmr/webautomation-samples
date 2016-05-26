using NUnit.Framework;
using WebAutomation.Core.Logger;

namespace HowTo.XML
{
    public class NUnit3Logger : ILogger
    {
        public void Debug(string message, params object[] parameters)
        {
            TestContext.Write(message, parameters);
        }

        public void Error(string message, params object[] parameters)
        {
            TestContext.Write(message, parameters);
        }

        public void Info(string message, params object[] parameters)
        {
            TestContext.Write(message, parameters);
        }

        public void SetClassName(string className)
        {
        }

        public void Warn(string message, params object[] parameters)
        {
            TestContext.Write(message, parameters);
        }
    }
}
