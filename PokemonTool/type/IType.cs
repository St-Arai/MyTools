using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.type {
	public interface IType {

		double Check(IType type);

		string Name { get; }
	}
}
