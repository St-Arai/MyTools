using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTool.pokemon {
	public class PokemonList {
		private readonly List<Pokemon> _pokemonList = new List<Pokemon>();

		public PokemonList() {
			_pokemonList.Add(new Pikachu());
			_pokemonList.Add(new Garchomp());
			_pokemonList.Add(new Lucario());
		}

		public IEnumerable<Pokemon> GetPokemonList() {
			return _pokemonList;
		}
	}
}
