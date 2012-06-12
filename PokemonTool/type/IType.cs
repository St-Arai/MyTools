using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.type {
	public interface IType {

		/// <summary>
		/// タイプの相性をチェックします。
		/// </summary>
		/// <param name="type"></param>
		/// <returns>相性によるダメージ補正値</returns>
		double Check(IType type);

		/// <summary>
		/// タイプの名前を取得します。
		/// </summary>
		string Name { get; }
	}
}
