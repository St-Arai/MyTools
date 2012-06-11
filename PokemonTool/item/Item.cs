using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.item {
	public class Item {
		protected virtual double SetPowerUp() {
			throw new NotImplementedException();
		}
	}
}
