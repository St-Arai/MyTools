using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonTool.type;

namespace PokemonTool.pokemon {
	public class Garchomp : Pokemon {

		private const string PokeName = "ガブリアス";
		private readonly int[] _baseArray = new[] { 108, 130, 95, 80, 85, 102 };

		public override IType Type1 {
			get { return new Dragon(); }
		}

		public override IType Type2 {
			get { return new Ground(); }
		}

		public override IList<int> BaseStatus {
			get { return _baseArray; }
		}

		public override int Speed {
			get { return _baseArray[5]; }
		}

		public override string Name {
			get { return PokeName; }
		}
	}
}
