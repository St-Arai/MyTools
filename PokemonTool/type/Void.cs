using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.type {
	public class Void : IType {

		private const string TypeName = "指定なし";

		public double Check(IType type) {
			throw new NotImplementedException();
		}

		public string Name {
			get { return TypeName; }
		}
	}
}
