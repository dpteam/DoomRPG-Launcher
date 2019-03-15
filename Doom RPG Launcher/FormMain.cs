using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoomRPG.Properties;

namespace DoomRPG
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			this.InitializeComponent();
			this.Text = "Doom RPG Launcher v" + this.version;
			this.config.Load();
			this.PopulateComboBoxes();
			this.PopulatePatches();
			this.checkedListBoxMods.ItemCheck += this.CheckedListBoxMods_ItemCheck;
			this.PopulateMods();
			this.PopulateDMFlags();
			this.LoadControls();
			this.LoadCredits();
            _ = PopulateBranchesComboBox();
        }

		private void CheckedListBoxMods_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			string item = this.checkedListBoxMods.Items[e.Index].ToString();
			if (e.NewValue == CheckState.Unchecked)
			{
				this.config.mods.Remove(item);
				return;
			}
			if (!this.config.mods.Contains(item))
			{
				this.config.mods.Add(item);
			}
		}

		private void PopulateDMFlags()
		{
			string[] array = Resources.DMFlags.Split(new string[]
			{
				Environment.NewLine
			}, StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(new char[]
				{
					'\t'
				});
				if (array2[0] == "DMFlags")
				{
					this.DMFlags.Add(new DMFlag(int.Parse(array2[1]), array2[2], bool.Parse(array2[3]), array2[4]));
				}
				else
				{
					this.DMFlags2.Add(new DMFlag(int.Parse(array2[1]), array2[2], bool.Parse(array2[3]), array2[4]));
				}
			}
			this.listViewDMFlags.SelectedIndexChanged += this.SkipSelection;
			this.listViewDMFlags.ItemCheck += this.ListViewDMFlags_ItemCheck;
			for (int j = 0; j < this.DMFlags.Count; j++)
			{
				this.listViewDMFlags.Items.Add(this.DMFlags[j].Name);
				this.listViewDMFlags.Items[this.listViewDMFlags.Items.Count - 1].Checked = ((this.config.DMFlags & this.DMFlags[j].Key) == this.DMFlags[j].Key ^ this.DMFlags[j].DefaultState);
				this.listViewDMFlags.Items[this.listViewDMFlags.Items.Count - 1].ToolTipText = this.DMFlags[j].Description;
			}
			this.listViewDMFlags.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			this.listViewDMFlags2.SelectedIndexChanged += this.SkipSelection;
			for (int k = 0; k < this.DMFlags2.Count; k++)
			{
				this.listViewDMFlags2.Items.Add(this.DMFlags2[k].Name);
				this.listViewDMFlags2.Items[this.listViewDMFlags2.Items.Count - 1].Checked = ((this.config.DMFlags2 & this.DMFlags2[k].Key) == this.DMFlags2[k].Key ^ this.DMFlags2[k].DefaultState);
				this.listViewDMFlags2.Items[this.listViewDMFlags2.Items.Count - 1].ToolTipText = this.DMFlags2[k].Description;
			}
			this.listViewDMFlags2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private void ListViewDMFlags_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked)
			{
				if (e.Index == 4 || e.Index == 5)
				{
					this.listViewDMFlags.Items[3].Checked = false;
				}
				if (e.Index == 3 || e.Index == 5)
				{
					this.listViewDMFlags.Items[4].Checked = false;
				}
				if (e.Index == 3 || e.Index == 4)
				{
					this.listViewDMFlags.Items[5].Checked = false;
				}
			}
		}

		private void SkipSelection(object sender, EventArgs e)
		{
			((ListView)sender).SelectedIndices.Clear();
		}

		private void ProcessLoadOrder()
		{
		}

		private void LoadCredits()
		{
			string path = this.textBoxDRPGPath.Text + "\\CREDITS.txt";
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				this.richTextBoxCredits.Text = text;
				this.RichTextBoxCredits_TextChanged(null, null);
			}
		}

		private void PopulateComboBoxes()
		{
			for (int i = 0; i < Enum.GetNames(typeof(IWAD)).Length; i++)
			{
				this.comboBoxIWAD.Items.Add(Enum.GetName(typeof(IWAD), i));
			}
			this.comboBoxIWAD.SelectedIndex = (int)this.config.iwad;
			for (int j = 0; j < Enum.GetNames(typeof(Difficulty)).Length; j++)
			{
				this.comboBoxDifficulty.Items.Add(Enum.GetName(typeof(Difficulty), j));
			}
			this.comboBoxDifficulty.SelectedIndex = (int)this.config.difficulty;
			for (int k = 0; k < Enum.GetNames(typeof(DRLAClass)).Length; k++)
			{
				this.comboBoxClass.Items.Add(Enum.GetName(typeof(DRLAClass), k));
			}
			this.comboBoxClass.SelectedIndex = (int)this.config.rlClass;
			if (this.config.portPath != string.Empty)
			{
				foreach (string text in Directory.EnumerateFiles(Path.GetDirectoryName(this.config.portPath)).ToList<string>())
				{
					if (text.EndsWith(".zds"))
					{
						this.comboBoxSaveGame.Items.Add(Path.GetFileName(text));
					}
				}
			}
		}

		private async Task PopulateBranchesComboBox()
		{
			foreach (string item in await this.GetBranches())
			{
				this.comboBoxBranch.Items.Add(item);
			}
			this.comboBoxBranch.Text = "master";
			this.comboBoxBranch.Enabled = true;
		}

		private void PopulatePatches()
		{
			this.patches.Clear();
			this.checkedListBoxPatches.Items.Clear();
			if (this.config.DRPGPath != string.Empty && Directory.Exists(this.config.DRPGPath))
			{
				foreach (string text in Directory.EnumerateDirectories(this.config.DRPGPath).ToList<string>())
				{
					List<string> list = Directory.EnumerateFiles(text).ToList<string>();
					bool flag = false;
					using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current.Contains("DRPGINFO.txt"))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						PatchInfo item = PatchInfo.ReadPatch(text + "\\DRPGINFO.txt");
						this.patches.Add(item);
					}
				}
			}
			foreach (PatchInfo item2 in this.patches)
			{
				this.checkedListBoxPatches.Items.Add(item2);
			}
		}

		private void PopulateMods()
		{
			this.checkedListBoxMods.Items.Clear();
			if (this.config.modsPath != string.Empty && Directory.Exists(this.config.modsPath))
			{
				List<string> list = Directory.EnumerateDirectories(this.config.modsPath).ToList<string>();
				list.Add(this.config.modsPath);
				foreach (string path in list)
				{
					foreach (string text in Directory.EnumerateFiles(path).ToList<string>())
					{
						for (int i = 0; i < this.fileTypes.Length; i++)
						{
							if (text.ToLower().EndsWith("." + this.fileTypes[i]))
							{
								string text2 = Path.GetFullPath(text);
								text2 = text2.Substring(this.textBoxModsPath.Text.Length + 1);
								this.checkedListBoxMods.Items.Add(text2);
							}
						}
					}
				}
			}
		}

		private bool CheckForErrors()
		{
			if (this.config.portPath == string.Empty)
			{
				Utils.ShowError("Вы должны указать путь к порту!", "Ошибка");
				return false;
			}
			if (this.config.DRPGPath == string.Empty)
			{
				Utils.ShowError("Вы должны указать путь к Doom RPG!", "Ошибка");
				return false;
			}
			if (Path.GetDirectoryName(this.config.portPath) == this.config.DRPGPath)
			{
				Utils.ShowError("Пути к порту и Doom RPG не могут быть одинаковыми!", "Ошибка");
				return false;
			}
			if (this.config.DRPGPath == Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
			{
				Utils.ShowError("Вы не можете держать лаунчер в папке Doom RPG! Переместите его в другую папку.", "Ошибка");
				return false;
			}
			return true;
		}

		private bool CheckForMods()
		{
			if (this.textBoxDRPGPath.Text != string.Empty && Directory.Exists(this.textBoxDRPGPath.Text))
			{
				foreach (string text in Directory.EnumerateFiles(this.textBoxDRPGPath.Text).ToList<string>())
				{
					for (int i = 0; i < this.fileTypes.Length; i++)
					{
						if (text.ToLower().EndsWith(this.fileTypes[i]))
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}

		private void LoadControls()
		{
			this.textBoxPortPath.Text = this.config.portPath;
			this.textBoxDRPGPath.Text = this.config.DRPGPath;
			this.textBoxModsPath.Text = this.config.modsPath;
			this.numericUpDownMapNumber.Value = this.config.mapNumber;
			this.textBoxDemo.Text = this.config.demo;
			this.checkBoxEnableCheats.Checked = this.config.enableCheats;
			this.checkBoxLogging.Checked = this.config.enableLogging;
			for (int i = 0; i < this.patches.Count; i++)
			{
				foreach (string text in this.config.patches)
				{
					if (this.patches[i].Name.ToLower() == text.ToLower())
					{
						this.checkedListBoxPatches.SetItemChecked(i, true);
					}
				}
			}
			this.checkBoxMultiplayer.Checked = this.config.multiplayer;
			for (int j = 0; j < this.config.mods.Count; j++)
			{
				if (this.checkedListBoxMods.FindStringExact(this.config.mods[j]) != -1)
				{
					this.checkedListBoxMods.SetItemChecked(this.checkedListBoxMods.FindStringExact(this.config.mods[j]), true);
				}
			}
			if (this.config.multiplayerMode == MultiplayerMode.Hosting)
			{
				this.radioButtonHosting.Checked = true;
			}
			if (this.config.multiplayerMode == MultiplayerMode.Joining)
			{
				this.radioButtonJoining.Checked = true;
			}
			if (this.config.serverType == ServerType.PeerToPeer)
			{
				this.radioButtonPeerToPeer.Checked = true;
			}
			if (this.config.serverType == ServerType.PacketServer)
			{
				this.radioButtonPacketServer.Checked = true;
			}
			this.numericUpDownPlayers.Value = this.config.players;
			this.textBoxHostname.Text = this.config.hostname;
			this.checkBoxExtraTics.Checked = this.config.extraTics;
			this.numericUpDownDuplicate.Value = this.config.duplicate;
			this.textBoxCustomCommands.Text = this.config.customCommands;
			this.checkBoxDMFlags.Checked = this.config.EnableDMFlags;
			this.checkBoxDMFlags2.Checked = this.config.EnableDMFlags2;
		}

		private void SaveControls()
		{
			this.config.portPath = this.textBoxPortPath.Text;
			this.config.DRPGPath = this.textBoxDRPGPath.Text;
			this.config.modsPath = this.textBoxModsPath.Text;
			this.config.iwad = (IWAD)this.comboBoxIWAD.SelectedIndex;
			this.config.difficulty = (Difficulty)this.comboBoxDifficulty.SelectedIndex;
			this.config.rlClass = (DRLAClass)this.comboBoxClass.SelectedIndex;
			this.config.mapNumber = (int)this.numericUpDownMapNumber.Value;
			this.config.demo = this.textBoxDemo.Text;
			this.config.enableCheats = this.checkBoxEnableCheats.Checked;
			this.config.enableLogging = this.checkBoxLogging.Checked;
			this.config.patches.Clear();
			for (int i = 0; i < this.patches.Count; i++)
			{
				if (this.checkedListBoxPatches.GetItemChecked(i))
				{
					this.config.patches.Add(this.patches[i].Name);
				}
			}
			this.config.multiplayer = this.checkBoxMultiplayer.Checked;
			if (this.radioButtonHosting.Checked)
			{
				this.config.multiplayerMode = MultiplayerMode.Hosting;
			}
			if (this.radioButtonJoining.Checked)
			{
				this.config.multiplayerMode = MultiplayerMode.Joining;
			}
			if (this.radioButtonPeerToPeer.Checked)
			{
				this.config.serverType = ServerType.PeerToPeer;
			}
			if (this.radioButtonPacketServer.Checked)
			{
				this.config.serverType = ServerType.PacketServer;
			}
			this.config.players = (int)this.numericUpDownPlayers.Value;
			this.config.hostname = this.textBoxHostname.Text;
			this.config.extraTics = this.checkBoxExtraTics.Checked;
			this.config.duplicate = (int)this.numericUpDownDuplicate.Value;
			this.config.customCommands = this.textBoxCustomCommands.Text;
			this.config.EnableDMFlags = this.checkBoxDMFlags.Checked;
			this.config.EnableDMFlags2 = this.checkBoxDMFlags2.Checked;
		}

		private async Task<string> GetBranchSHA(string branchName)
		{
			Branch branch = (await Octokitten.GetAllBranches("Sumwunn", "DoomRPG")).Single((Branch b) => b.name == branchName);
			return (branch != null) ? branch.commit.sha : null;
		}

		private async Task<List<string>> GetBranches()
		{
			List<string> branchNames = new List<string>();
			foreach (Branch branch in ((IEnumerable<Branch>)(await Octokitten.GetAllBranches("Sumwunn", "DoomRPG"))))
			{
				branchNames.Add(branch.name);
			}
			return branchNames;
		}

		private async Task CheckForUpdates()
		{
			this.SaveControls();
			this.config.Save();
			DialogResult dialogResult;
			if (!this.config.wipeWarning)
			{
				dialogResult = MessageBox.Show("Этот процесс уничтожит все, что находится в папке Doom RPG. Вы уверены что хотите продолжить?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			}
			else
			{
				dialogResult = DialogResult.Yes;
			}
			if (this.CheckForMods())
			{
				if (MessageBox.Show("Папка Doom RPG содержит файлы других модов. Вы хотите создать подпапку для Doom RPG?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				{
					return;
				}
				TextBox textBox = this.textBoxDRPGPath;
				textBox.Text += "\\DoomRPG";
				Config config = this.config;
				config.DRPGPath += "\\DoomRPG";
			}
			if (dialogResult == DialogResult.Yes)
			{
				this.config.wipeWarning = true;
				this.toolStripStatusLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
				this.toolStripStatusLabel.Text = "Проверка обновлений...";
				this.toolStripProgressBar.Style = ProgressBarStyle.Marquee;
				try
				{
					string a = await this.GetBranchSHA(this.currentBranch);
					string path = this.config.DRPGPath + "\\SHA-1";
					if (Directory.Exists(this.config.DRPGPath + "\\.git"))
					{
						this.toolStripStatusLabel.Text = "Эта версия Doom RPG управляется системой git";
						this.toolStripProgressBar.Style = ProgressBarStyle.Continuous;
						this.buttonCheckUpdates.Enabled = true;
						this.buttonLaunch.Enabled = true;
						return;
					}
					if (!Directory.Exists(this.config.DRPGPath))
					{
						this.toolStripStatusLabel.ForeColor = Color.Red;
						this.toolStripStatusLabel.Text = "Не удалось найти папку Doom RPG, загрузка последней версии...";
					}
					else if (File.Exists(path))
					{
						if (!(a != File.ReadAllLines(path)[0]) && File.Exists(path))
						{
							this.toolStripStatusLabel.ForeColor = Color.Green;
							this.toolStripStatusLabel.Text = "Установлена самая свежая версия!";
							this.toolStripProgressBar.Style = ProgressBarStyle.Continuous;
							this.buttonCheckUpdates.Enabled = true;
							this.buttonLaunch.Enabled = true;
							return;
						}
						this.toolStripStatusLabel.ForeColor = Color.Red;
						this.toolStripStatusLabel.Text = "Версия устарела, загрузка последней версии...";
					}
					else
					{
						this.toolStripStatusLabel.ForeColor = Color.Red;
						this.toolStripStatusLabel.Text = "Не удаеться найти контрольную сумму SHA-1, загрузка последней версии...";
					}
					if (Directory.Exists(this.config.DRPGPath))
					{
						Directory.Delete(this.config.DRPGPath, true);
					}
					await Task.Delay(3000);
					this.toolStripProgressBar.Style = ProgressBarStyle.Continuous;
					this.DownloadDRPG();
					return;
				}
				catch (Exception e)
				{
					Utils.ShowError(e);
					return;
				}
			}
			this.buttonCheckUpdates.Enabled = true;
			this.buttonLaunch.Enabled = true;
		}

		private void DownloadDRPG()
		{
			Uri address = new Uri("https://github.com/Sumwunn/DoomRPG/archive/" + this.currentBranch + ".zip");
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string str = "\\DoomRPG.zip";
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFileAsync(address, directoryName + str);
				webClient.DownloadProgressChanged += this.Client_DownloadProgressChanged;
				webClient.DownloadFileCompleted += this.Client_DownloadFileCompleted;
			}
		}

		private void ExtractDRPG()
		{
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string zipPath = path + "\\DoomRPG.zip";

            try
			{
				this.toolStripStatusLabel.Text = "Извлечение DoomRPG.zip...";
				this.toolStripProgressBar.Style = ProgressBarStyle.Marquee;
				new Thread(new ThreadStart(this.ExtractZip)).Start();
			}
			catch (Exception e)
			{
				Utils.ShowError(e);
			}
		}

		private async void ExtractZip()
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string zipPath = directoryName + "\\DoomRPG.zip";
			ZipFile.ExtractToDirectory(zipPath, directoryName);
			Directory.Move(directoryName + "\\DoomRPG-" + this.currentBranch, this.config.DRPGPath);
			string path = this.config.DRPGPath + "\\SHA-1";
			string contents = await this.GetBranchSHA(this.currentBranch);
			File.WriteAllText(path, contents);
			path = null;
			File.Delete(zipPath);
			base.Invoke(new MethodInvoker(delegate()
			{
				this.toolStripStatusLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
				this.toolStripStatusLabel.Text = "Готово";
				this.toolStripProgressBar.Style = ProgressBarStyle.Continuous;
				this.buttonCheckUpdates.Enabled = true;
				this.buttonLaunch.Enabled = true;
			}));
		}

		private string BuildCommandLine()
		{
			string text = string.Empty;
			if (this.config.iwad == IWAD.Doom1)
			{
				text += " -iwad Doom";
			}
			else
			{
				text = text + " -iwad " + this.config.iwad.ToString();
			}
			if (this.config.mapNumber > 0)
			{
				text = text + " -skill " + (int)(this.config.difficulty + 1);
				text = text + " -warp " + this.config.mapNumber;
				if (this.IsDRLAActive())
				{
					text = text + " +playerclass " + this.config.rlClass.ToString();
				}
			}
			if (this.config.multiplayer)
			{
				if (this.config.multiplayerMode == MultiplayerMode.Hosting)
				{
					text = text + " -host " + this.config.players;
				}
				if (this.config.multiplayerMode == MultiplayerMode.Joining)
				{
					text = text + " -join " + this.config.hostname;
				}
				if (this.config.multiplayerMode == MultiplayerMode.Hosting)
				{
					if (this.config.serverType == ServerType.PeerToPeer)
					{
						text += " -netmode 0";
					}
					if (this.config.serverType == ServerType.PacketServer)
					{
						text += " -netmode 1";
					}
					if (this.config.extraTics)
					{
						text += " -extratic";
					}
					if (this.config.duplicate > 0)
					{
						text = text + " -dup " + this.config.duplicate;
					}
				}
			}
			if (this.checkBoxEnableCheats.Checked)
			{
				text += " +sv_cheats 1";
			}
			if (this.checkBoxLogging.Checked)
			{
				text += " +logfile \"Doom RPG.log\"";
			}
			if (this.comboBoxSaveGame.Text != "Никакой")
			{
				text = string.Concat(new string[]
				{
					text,
					" -loadgame ",
					Path.GetDirectoryName(this.textBoxPortPath.Text),
					"\\",
					this.comboBoxSaveGame.Text
				});
			}
			if (this.textBoxDemo.TextLength > 0)
			{
				text = text + " -record " + this.textBoxDemo.Text + ".lmp";
			}
			text += " -file";
			for (int i = 0; i < this.config.mods.Count; i++)
			{
				text = string.Concat(new string[]
				{
					text,
					" \"",
					this.config.modsPath,
					"\\",
					this.config.mods[i],
					"\""
				});
			}
			text = text + " \"" + this.config.DRPGPath + "\\DoomRPG\"";
			for (int j = 0; j < this.patches.Count; j++)
			{
				if (this.checkedListBoxPatches.GetItemChecked(j))
				{
					text = text + " \"" + this.patches[j].Path + "\"";
				}
			}
			if (this.config.EnableDMFlags)
			{
				text = text + " +set dmflags " + this.config.DMFlags.ToString();
			}
			if (this.config.EnableDMFlags2)
			{
				text = text + " +set dmflags2 " + this.config.DMFlags2.ToString();
			}
			if (this.config.customCommands != string.Empty)
			{
				text = text + " " + this.config.customCommands;
			}
			return text;
		}

		private bool IsDRLAActive()
		{
			for (int i = 0; i < this.patches.Count; i++)
			{
				if (this.patches[i].Name.ToLower().Contains("doomrl") && this.checkedListBoxPatches.GetItemChecked(i))
				{
					return true;
				}
			}
			return false;
		}

		private void ButtonBrowsePortPath_Click(object sender, EventArgs e)
		{
			FileDialog fileDialog = new OpenFileDialog
			{
				Title = "Указать путь к (G/L)ZDoom(32)..."
			};
			if (this.textBoxPortPath.Text == string.Empty)
			{
				fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
			}
			else
			{
				fileDialog.InitialDirectory = Path.GetDirectoryName(this.textBoxPortPath.Text);
			}
			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				this.textBoxPortPath.Text = fileDialog.FileName;
				this.config.portPath = fileDialog.FileName;
			}
		}

		private void ButtonBrowseDRPGPath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (this.textBoxDRPGPath.Text == string.Empty)
			{
				folderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();
			}
			else
			{
				folderBrowserDialog.SelectedPath = this.textBoxDRPGPath.Text;
			}
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.textBoxDRPGPath.Text = folderBrowserDialog.SelectedPath;
				this.config.DRPGPath = folderBrowserDialog.SelectedPath;
				this.LoadCredits();
				this.PopulatePatches();
			}
		}

		private void ButtonBrowseModsPath_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (this.textBoxModsPath.Text == string.Empty)
			{
				folderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();
			}
			else
			{
				folderBrowserDialog.SelectedPath = this.textBoxModsPath.Text;
			}
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.textBoxModsPath.Text = folderBrowserDialog.SelectedPath;
				this.config.modsPath = folderBrowserDialog.SelectedPath;
				this.PopulateMods();
			}
		}

		private void TextBoxModsPath_TextChanged(object sender, EventArgs e)
		{
			this.PopulateMods();
		}

		private async void ButtonCheckUpdates_Click(object sender, EventArgs e)
		{
			if (this.currentBranch == string.Empty)
			{
				Utils.ShowError("Git-ветвь не выбрана", "Ошибка");
			}
			else
			{
				this.SaveControls();
				this.config.Save();
				if (this.CheckForErrors())
				{
					this.buttonCheckUpdates.Enabled = false;
					this.buttonLaunch.Enabled = false;
					await this.CheckForUpdates();
				}
			}
		}

		private void ButtonLaunch_Click(object sender, EventArgs e)
		{
			try
			{
				if (PatchInfo.CheckForRequirements(this.patches))
				{
					if (PatchInfo.CheckForConflicts(this.patches))
					{
						this.SaveControls();
						this.CalculateDMFlags();
						this.config.Save();
						if (this.CheckForErrors())
						{
							Process.Start(this.config.portPath, this.BuildCommandLine());
						}
					}
				}
			}
			catch (Exception e2)
			{
				Utils.ShowError(e2);
			}
		}

		private void CalculateDMFlags()
		{
			int num = 0;
			int dmflags = 0;
			for (int i = 0; i < this.listViewDMFlags.Items.Count; i++)
			{
				if (this.listViewDMFlags.Items[i].Checked ^ this.DMFlags[i].DefaultState)
				{
					num |= this.DMFlags[i].Key;
				}
			}
			for (int j = 0; j < this.listViewDMFlags2.Items.Count; j++)
			{
				if (this.listViewDMFlags2.Items[j].Checked ^ this.DMFlags2[j].DefaultState)
				{
					num |= this.DMFlags2[j].Key;
				}
			}
			this.config.DMFlags = num;
			this.config.DMFlags2 = dmflags;
		}

		private void RichTextBoxCredits_TextChanged(object sender, EventArgs e)
		{
			this.richTextBoxCredits.Find("Testers");
			this.richTextBoxCredits.SelectionFont = new Font(FontFamily.GenericSansSerif, 12f, FontStyle.Bold);
			this.richTextBoxCredits.SelectionColor = Color.Green;
			this.richTextBoxCredits.Find("Contributors");
			this.richTextBoxCredits.SelectionFont = new Font(FontFamily.GenericSansSerif, 12f, FontStyle.Bold);
			this.richTextBoxCredits.SelectionColor = Color.Red;
			this.richTextBoxCredits.Find("Resources");
			this.richTextBoxCredits.SelectionFont = new Font(FontFamily.GenericSansSerif, 12f, FontStyle.Bold);
			this.richTextBoxCredits.SelectionColor = Color.Blue;
			this.richTextBoxCredits.Find("Libraries");
			this.richTextBoxCredits.SelectionFont = new Font(FontFamily.GenericSansSerif, 12f, FontStyle.Bold);
			this.richTextBoxCredits.SelectionColor = Color.Blue;
		}

		private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.toolStripStatusLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
			this.toolStripStatusLabel.Text = string.Concat(new object[]
			{
				"Загрузка... ",
				e.BytesReceived / 1024L,
				"КБ / ",
				e.TotalBytesToReceive / 1024L,
				"КБ (",
				e.ProgressPercentage,
				"%)"
			});
			this.toolStripProgressBar.Value = e.ProgressPercentage;
		}

		private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			try
			{
				this.ExtractDRPG();
			}
			catch (Exception e2)
			{
				Utils.ShowError(e2);
			}
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < this.patches.Count; i++)
			{
				this.patches[i].Enabled = this.checkedListBoxPatches.GetItemChecked(i);
			}
			if (this.numericUpDownMapNumber.Value == 0m)
			{
				this.comboBoxDifficulty.Enabled = false;
			}
			else
			{
				this.comboBoxDifficulty.Enabled = true;
			}
			if (this.numericUpDownMapNumber.Value > 0m && this.IsDRLAActive())
			{
				this.comboBoxClass.Enabled = true;
			}
			else
			{
				this.comboBoxClass.Enabled = false;
			}
			if (!this.checkBoxMultiplayer.Checked)
			{
				this.groupBoxMode.Enabled = false;
				this.groupBoxServerMode.Enabled = false;
				this.groupBoxServerOptions.Enabled = false;
				return;
			}
			this.groupBoxMode.Enabled = true;
			this.groupBoxServerMode.Enabled = true;
			if (this.radioButtonHosting.Checked)
			{
				this.numericUpDownPlayers.Enabled = true;
				this.radioButtonPeerToPeer.Enabled = true;
				this.radioButtonPacketServer.Enabled = true;
				this.groupBoxServerOptions.Enabled = true;
			}
			else
			{
				this.numericUpDownPlayers.Enabled = false;
				this.radioButtonPeerToPeer.Enabled = false;
				this.radioButtonPacketServer.Enabled = false;
				this.groupBoxServerOptions.Enabled = false;
			}
			if (this.radioButtonJoining.Checked)
			{
				this.textBoxHostname.Enabled = true;
				return;
			}
			this.textBoxHostname.Enabled = false;
		}

		private void TimerPulse_Tick(object sender, EventArgs e)
		{
			int red = 160 + (int)(Math.Sin((double)DateTime.Now.Millisecond / 256.0) * 64.0);
			this.buttonLaunch.ForeColor = Color.FromArgb(255, red, 0, 0);
		}

		private void ButtonShowCommandLine_Click(object sender, EventArgs e)
		{
			PatchInfo.CheckForRequirements(this.patches);
			PatchInfo.CheckForConflicts(this.patches);
			this.SaveControls();
			this.CalculateDMFlags();
			this.config.Save();
			new FormCommandLine("\"" + this.config.portPath + "\"" + this.BuildCommandLine()).ShowDialog();
		}

		private void ButtonRefresh_Click(object sender, EventArgs e)
		{
			this.PopulatePatches();
			this.PopulateMods();
			this.LoadControls();
		}

		private void TextBoxDRPGPath_TextChanged(object sender, EventArgs e)
		{
			this.LoadCredits();
		}

		private void ComboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.currentBranch = this.comboBoxBranch.Text;
		}

		private void ButtonLoadOrder_Click(object sender, EventArgs e)
		{
			FormLoadOrder formLoadOrder = new FormLoadOrder(this.config.mods);
			if (formLoadOrder.ShowDialog() == DialogResult.OK)
			{
				this.config.mods = formLoadOrder.LoadOrder;
			}
		}

		private Version version = Assembly.GetExecutingAssembly().GetName().Version;

		private Config config = new Config();

		private string currentBranch = string.Empty;

		private List<PatchInfo> patches = new List<PatchInfo>();

		private List<DMFlag> DMFlags = new List<DMFlag>();

		private List<DMFlag> DMFlags2 = new List<DMFlag>();

		private string[] fileTypes = new string[]
		{
			"пыж",
			"wad",
			"zip",
			"pk3",
			"pk7",
			"deh",
			"bex"
		};
	}
}
