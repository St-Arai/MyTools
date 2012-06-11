using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PokemonTool.pokemon;

namespace PokemonTool {
	class GuiForm : Form {
		private readonly Label _label;
		private readonly ComboBox _box;
		private int _count = 0;

		private readonly IEnumerable<Pokemon> _list;

		public GuiForm() {
			Width = 300;
			Height = 400;
			Text = "ポケモンツール（仮）";

			_label = new Label {
				Location = new Point(100, 200),
				AutoSize = true
			};

			_box = new ComboBox {
				Location = new Point(100, 100),
				DropDownStyle = ComboBoxStyle.DropDownList,
			};

			_list = new PokemonList().GetPokemonList();
			foreach (var pokemon in _list) {
				_box.Items.Add(pokemon.Name);
			}

			_box.SelectedIndexChanged += BoxSelectedIndexChanged;

			Controls.Add(_label);
			Controls.Add(_box);
		}

		void BoxSelectedIndexChanged(object sender, EventArgs e) {
			_label.Text = null;
			foreach (var pokemon in _list) {
				if (_box.SelectedItem.ToString().Equals(pokemon.Name)) {
					foreach (var status in pokemon.BaseStatus) {
						_label.Text += status.ToString(CultureInfo.InvariantCulture) + "\n";
					}
					_label.Text += pokemon.Type1.Name + "\n";
					if (pokemon.Type2 != null) {
						_label.Text += pokemon.Type2.Name + "\n";
					}
					break;
				}
			}
		}
	}
}
