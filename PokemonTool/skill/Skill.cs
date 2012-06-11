using PokemonTool.type;

namespace PokemonTool.skill {
	public abstract class Skill {
		public abstract int Power { get; }

		public abstract IType Type { get; }

		public abstract string Name { get; }
	}
}