using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log4NetTest
{
	class Program
	{
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		static void Main(string[] args)
		{
			log4net.Config.XmlConfigurator.Configure();
			log.Debug("log Debug");
			log.Info("log Info");
			log.Warn("log Warn");
			log.Error("log Error");
			log.Fatal("log Fatal"); 
		}
	}
}
