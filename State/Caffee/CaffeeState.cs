using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Caffee
{
	public abstract class CaffeeState
	{
		public virtual void Fill(Caffee caffee)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Can't fill, caffee is full");
			Console.ResetColor();
		}

		public virtual void Drink(Caffee caffee)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Can't drink, caffee is empty");
			Console.ResetColor();
		}
	}
}
