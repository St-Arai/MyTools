using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.type {
	public class Ice : IType {

		private const string TypeName = "こおり";

		public double Check(IType type) {
			throw new NotImplementedException();
		}

		public string Name {
			get { return TypeName; }
		}
	}
}
