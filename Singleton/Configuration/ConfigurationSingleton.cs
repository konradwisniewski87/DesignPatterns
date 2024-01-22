using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Configuration
{
	public class ConfigurationSingleton
	{
        private static ConfigurationSingleton instance = null;
		private static object objToLock = new object();

        public string StringProperty { get; set; }
		public int IntProperty { get; set; }

        private ConfigurationSingleton() { }
		public static ConfigurationSingleton GetInstance()
		{
			lock(objToLock) //multithreading protection
			{
				if(instance == null)
				{
					instance = new ConfigurationSingleton();
				}
			}
			return instance;
		}
    }
}
