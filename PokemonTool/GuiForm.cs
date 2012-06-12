using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PokemonTool.calculation;
using PokemonTool.pokemon;

namespace PokemonTool {
	class GuiForm : Form {
		private readonly Label _label;
		private readonly ComboBox _box;
		private readonly NumericUpDown[] _upDown = new NumericUpDown[6];
		private int _count = 0;

		private readonly IEnumerable<Pokemon> _list = new PokemonList().GetPokemonList();
		
		public GuiForm() {
			Width = 800;
			Height = 600;
			Text = "ポケモンツール（仮）";

			_label = new Label {
				Location = new Point(100, 200),
				AutoSize = true
			};

			_box = new ComboBox {
				Location = new Point(100, 100),
				DropDownStyle = ComboBoxStyle.DropDownList
			};

			var y = 0;
			for (var i = 0; i < _upDown.Count(); i++) {
				_upDown[i] = new NumericUpDown {
					Location = new Point(400, 400 + y),
					Width = 100,
					Maximum = 252,
					Minimum = 0
				};
				y += 20;
			}

			foreach (var pokemon in _list) {
				_box.Items.Add(pokemon.Name);
			}

			_box.SelectedIndexChanged += BoxSelectedIndexChanged;

			Controls.Add(_label);
			Controls.Add(_box);
			Controls.AddRange(_upDown);
		}

		void BoxSelectedIndexChanged(object sender, EventArgs e) {
			_label.Text = null;
			_upDown[0].Text = null;
			foreach (var pokemon in _list) {
				if (_box.SelectedItem.ToString().Equals(pokemon.Name)) {
					foreach (var basestatus in pokemon.BaseStatus) {
						_label.Text += basestatus.ToString(CultureInfo.InvariantCulture) + "\n";
					}
					_label.Text += pokemon.Type1.Name + "\n";
					if (pokemon.Type2 != null) {
						_label.Text += pokemon.Type2.Name + "\n";
					}
					var status = new StatusCalculator(pokemon.BaseStatus).GetStatus();
					for (var i = 0; i < pokemon.BaseStatus.Count(); i++) {
						_upDown[i].Text = status.ElementAt(i).ToString(CultureInfo.InvariantCulture);
					}
					break;
				}
			}
		}
	}
}
