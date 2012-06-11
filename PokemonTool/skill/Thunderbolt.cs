using PokemonTool.type;

namespace PokemonTool.skill {
	public class Thunderbolt : Skill {

		private const int SkillPower = 95;
		private const string SkillName = "10まんボルト";

		public override int Power {
			get { return SkillPower; }
		}

		public override IType Type {
			get { return new Electric(); }
		}

		public override string Name {
			get { return SkillName; }
		}
	}
}