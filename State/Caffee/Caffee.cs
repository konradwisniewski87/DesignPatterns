using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Caffee
{
	public class Caffee
	{
		public CaffeeState caffeeState = new CaffeeStateFull();
		public void Drink() { caffeeState.Drink(this); }
		public void Fill() { caffeeState.Fill(this); }
	}
}
