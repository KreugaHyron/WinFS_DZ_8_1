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

				ToolStripButton btnUpdate = new ToolStripButton("�������");
				btnUpdate.Click += (s, ev) => MessageBox.Show("��� ��������!");
				btnUpdate.Image = SystemIcons.Information.ToBitmap();
				btnUpdate.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;

				ToolStripComboBox comboColors = new ToolStripComboBox();
				comboColors.Items.AddRange(new string[] { "��������", "�������", "����" });
				comboColors.SelectedIndexChanged += (s, ev) =>
				{
					switch (comboColors.SelectedItem.ToString())
					{
						case "��������":
							this.BackColor = Color.Red;
							break;
						case "�������":
							this.BackColor = Color.Green;
							break;
						case "����":
							this.BackColor = Color.Blue;
							break;
					}
				};
				ToolStripTextBox txtInput = new ToolStripTextBox();
				txtInput.KeyDown += (s, ev) =>
				{
					if (ev.KeyCode == Keys.Enter)
					{
						MessageBox.Show($"�������: {txtInput.Text}");
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
