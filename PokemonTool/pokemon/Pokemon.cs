using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonTool.type;

namespace PokemonTool.pokemon {
	public abstract class Pokemon {

		/// <summary>
		/// ポケモンのタイプ１を取得します。
		/// </summary>
		public abstract IType Type1 { get; }

		/// <summary>
		/// ポケモンのタイプ２を取得します。
		/// </summary>
		public abstract IType Type2 { get; }

		/// <summary>
		/// ポケモンの種族値を取得します。
		/// </summary>
		public abstract IList<int> BaseStatus { get; }

		/// <summary>
		/// ポケモンのすばやさ種族値を取得します。
		/// </summary>
		public abstract int Speed { get; }

		/// <summary>
		/// ポケモンの名前を取得します。
		/// </summary>
		public abstract string Name { get; }
	}
}
