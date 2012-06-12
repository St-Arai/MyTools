using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonTool.type;

namespace PokemonTool.pokemon {
	public class Lucario : Pokemon {

		private const string PokeName = "ルカリオ";
		private readonly int[] _baseArray = new[] { 70, 110, 70, 115, 70, 90};

		public override IType Type1 {
			get { return new Fighting(); }
		}

		public override IType Type2 {
			get { return new Steel(); }
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
