using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.type {
	public class Ghost : IType {

		private const string TypeName = "ゴースト";

		public double Check(IType type) {
			throw new NotImplementedException();
		}

		public string Name {
			get { return TypeName; }
		}
	}
}
