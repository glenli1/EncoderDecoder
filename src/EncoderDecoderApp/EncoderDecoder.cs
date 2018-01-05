using EncoderDecoder.Properties;

namespace EncoderDecoder
{
	using System;
	using System.Windows.Forms;

	public partial class EncoderDecoder : Form
	{
		public EncoderDecoder()
		{
			InitializeComponent();

			// Auto-select type
			if (this.comboBoxType.Items.Count > 0)
			{
				this.comboBoxType.SelectedIndex = 0;
			}
		}

		#region UI Events

		private void buttonSwap_Click(object sender, EventArgs e)
		{
			//this.ToggleControls(false);
			using (new DisableControls(this))
			{
				var temp = this.textBoxInput.Text;
				this.textBoxInput.Text = this.textBoxOutput.Text;
				this.textBoxOutput.Text = temp;
			}
			//this.ToggleControls(true);
		}

		private void buttonEncode_Click(object sender, EventArgs e)
		{
			using (new DisableControls(this))
			{
				switch (this.comboBoxType.SelectedItem?.ToString())
				{
					case "Base64":
						this.textBoxOutput.Text = Base64Encode(this.textBoxInput.Text);
						break;
					default:
						MessageBox.Show(Resources.Message_PleaseSelectEncodeType);
						break;
				}
			}
		}

		private void buttonDecode_Click(object sender, EventArgs e)
		{
			using (new DisableControls(this))
			{
				switch (this.comboBoxType.SelectedItem?.ToString())
				{
					case "Base64":
						this.textBoxOutput.Text = Base64Decode(this.textBoxInput.Text);
						break;
					default:
						MessageBox.Show(Resources.Message_PleaseSelectDecodeType);
						break;
				}
			}
		}

		private void EncoderDecoder_Resize(object sender, EventArgs e)
		{
			var availableHeight = this.Height - 80;
			var extra = availableHeight%2;
			var boxHeight = availableHeight/2;
			this.groupBoxInput.Height = boxHeight + extra;
			this.groupBoxOutput.Height = boxHeight;
		}

		private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
		{
			// Ctrl+A for select-all doesn't work for multiline textboxes, workaround.
			if (e.Control && e.KeyCode == Keys.A)
			{
				(sender as TextBox)?.SelectAll();
			}
		}

		private void textBoxOutput_KeyDown(object sender, KeyEventArgs e)
		{
			// Ctrl+A for select-all doesn't work for multiline textboxes, workaround.
			if (e.Control && e.KeyCode == Keys.A)
			{
				(sender as TextBox)?.SelectAll();
			}
		}
		
		private void textBoxInput_TextChanged(object sender, EventArgs e)
		{
			this.groupBoxInput.Text = $"Input ({this.textBoxInput.Text.Length:n0} characters)";
		}

		private void textBoxOutput_TextChanged(object sender, EventArgs e)
		{
			this.groupBoxOutput.Text = $"Output ({this.textBoxOutput.Text.Length:n0} characters)";
		}

		private void ToggleControls(bool enabled)
		{
			this.comboBoxType.Enabled = enabled;
			this.buttonEncode.Enabled = enabled;
			this.buttonDecode.Enabled = enabled;
			this.buttonSwap.Enabled = enabled;
			this.textBoxInput.ReadOnly = !enabled;
			this.textBoxOutput.ReadOnly = !enabled;
		}

		#endregion

		private string Base64Encode(string input)
		{
			var bytes = System.Text.Encoding.UTF8.GetBytes(input);
			return System.Convert.ToBase64String(bytes);
		}

		private string Base64Decode(string input)
		{
			while (true)
			{
				try
				{
					var bytes = System.Convert.FromBase64String(input);
					return System.Text.Encoding.UTF8.GetString(bytes);
				}
				catch (System.FormatException fe)
				{
					// If the input is the wrong size then add padding.
					if (fe.Message == "Invalid length for a Base-64 char array or string.")
					{
						input += "=";
					}
				}
			}
		}

		public class DisableControls : IDisposable
		{
			private EncoderDecoder Form;

			public DisableControls(EncoderDecoder form)
			{
				this.Form = form;
				this.Form.ToggleControls(false);
			}

			public void Dispose()
			{
				this.Form.ToggleControls(true);
			}
		}
	}
}