using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.item {
	public class LightBall : Item {
		protected new double SetPowerUp() {
			return 2.0;
		}
	}
}
