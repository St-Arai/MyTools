using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokemonTool.pokemon;

namespace PokemonTool.calculation {
	public class StatusCalculator {

		private const int Level = 50;
		private readonly int _hp;
		private readonly int _attack;
		private readonly int _defense;
		private readonly int _spAttack;
		private readonly int _spDefense;
		private readonly int _speed;

		public StatusCalculator(IList<int> list) {
			_hp = list[0];
			_attack = list[1];
			_defense = list[2];
			_spAttack = list[3];
			_spDefense = list[4];
			_speed = list[5];
		}

		public IEnumerable<int> GetStatus() {

			var list = new List<int>();
			var hp = ((_hp*2 + 31 + 252/4)*Level/100) + 10 + Level;
			var attack = Math.Floor((((_attack * 2 + 31 + 252 / 4) * Level / 100) + 5) * 1.0);
			var defense = Math.Floor((((_defense * 2 + 31 + 252 / 4) * Level / 100) + 5) * 1.0);
			var spAttack = Math.Floor((((_spAttack * 2 + 31 + 252 / 4) * Level / 100) + 5) * 1.0);
			var spDefense = Math.Floor((((_spDefense * 2 + 31 + 252 / 4) * Level / 100) + 5) * 1.0);
			var speed = Math.Floor((((_speed * 2 + 31 + 252 / 4) * Level / 100) + 5) * 1.1);

			list.Add(hp);
			list.Add((int)attack);
			list.Add((int)defense);
			list.Add((int)spAttack);
			list.Add((int)spDefense);
			list.Add((int)speed);

			return list;
		}
	}
}
