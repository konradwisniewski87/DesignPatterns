using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Caffee
{
	public class CaffeeStateFull : CaffeeState
	{
        public CaffeeStateFull()
        {
			Console.WriteLine("Caffee is full");
        }

		public override void Drink(Caffee caffee)
		{
			Console.WriteLine("Caffee is drinking");
			caffee.caffeeState = new CaffeeStateEmpty();
		}
	}
}
