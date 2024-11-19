namespace WinFS_DZ_8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
				ToolStrip toolStrip = new ToolStrip();

				ToolStripButton btnUpdate = new ToolStripButton("Оновити");
				btnUpdate.Click += (s, ev) => MessageBox.Show("Дані оновлено!");
				btnUpdate.Image = SystemIcons.Information.ToBitmap();
				btnUpdate.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;

				ToolStripComboBox comboColors = new ToolStripComboBox();
				comboColors.Items.AddRange(new string[] { "Червоний", "Зелений", "Синій" });
				comboColors.SelectedIndexChanged += (s, ev) =>
				{
					switch (comboColors.SelectedItem.ToString())
					{
						case "Червоний":
							this.BackColor = Color.Red;
							break;
						case "Зелений":
							this.BackColor = Color.Green;
							break;
						case "Синій":
							this.BackColor = Color.Blue;
							break;
					}
				};
				ToolStripTextBox txtInput = new ToolStripTextBox();
				txtInput.KeyDown += (s, ev) =>
				{
					if (ev.KeyCode == Keys.Enter)
					{
						MessageBox.Show($"Введено: {txtInput.Text}");
					}
				};

				ToolStripSeparator separator = new ToolStripSeparator();

				toolStrip.Items.Add(btnUpdate);
				toolStrip.Items.Add(separator);
				toolStrip.Items.Add(comboColors);
				toolStrip.Items.Add(txtInput);

				this.Controls.Add(toolStrip);
			}
		}
    }
