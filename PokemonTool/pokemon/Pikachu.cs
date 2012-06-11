using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonTool.type;

namespace PokemonTool.pokemon {
	public class Pikachu : Pokemon {

		private const string PokeName = "ピカチュウ";
		private readonly int[] _baseArray = new[] { 35, 55, 30, 50, 40, 90 };
		
		public override IType Type1 {
			get { return new Electric(); }
		}

		public override IType Type2 {
			get { return null; }
		}

		public override IEnumerable<int> BaseStatus {
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
