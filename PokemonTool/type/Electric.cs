using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.type {
	public class Electric : IType {

		private const string TypeName = "でんき";

		public double Check(IType type) {
			if (type as Ground != null) {
				return 2.0;
			}
			if (type as Electric != null || type as Flying != null) {
				return 0.5;
			}
			return 1.0;
		}

		public string Name {
			get { return TypeName; }
		}
	}
}
