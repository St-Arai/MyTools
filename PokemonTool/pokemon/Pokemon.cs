using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonTool.type;

namespace PokemonTool.pokemon {
	public abstract class Pokemon {
		
		public abstract IType Type1 { get; }

		public abstract IType Type2 { get; }

		public abstract IEnumerable<int> BaseStatus { get; }

		public abstract int Speed { get; }

		public abstract string Name { get; }
	}
}
