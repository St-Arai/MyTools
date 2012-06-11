using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.type {
	public class Bug : IType {

		private const string TypeName = "むし";

		public double Check(IType type) {
			throw new NotImplementedException();
		}

		public string Name {
			get { return TypeName; }
		}
	}
}
