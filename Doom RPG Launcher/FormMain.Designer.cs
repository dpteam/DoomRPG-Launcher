namespace DoomRPG
{
	public partial class FormMain : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::DoomRPG.FormMain));
			this.tabControlMain = new global::System.Windows.Forms.TabControl();
			this.tabPageBasic = new global::System.Windows.Forms.TabPage();
			this.comboBoxBranch = new global::System.Windows.Forms.ComboBox();
			this.labelBranch = new global::System.Windows.Forms.Label();
			this.buttonShowCommandLine = new global::System.Windows.Forms.Button();
			this.textBoxDemo = new global::System.Windows.Forms.TextBox();
			this.labelRecordDemo = new global::System.Windows.Forms.Label();
			this.checkBoxLogging = new global::System.Windows.Forms.CheckBox();
			this.checkBoxEnableCheats = new global::System.Windows.Forms.CheckBox();
			this.comboBoxSaveGame = new global::System.Windows.Forms.ComboBox();
			this.labelSavegame = new global::System.Windows.Forms.Label();
			this.comboBoxClass = new global::System.Windows.Forms.ComboBox();
			this.labelPlayerClass = new global::System.Windows.Forms.Label();
			this.comboBoxIWAD = new global::System.Windows.Forms.ComboBox();
			this.labelIWAD = new global::System.Windows.Forms.Label();
			this.buttonBrowseModsPath = new global::System.Windows.Forms.Button();
			this.textBoxModsPath = new global::System.Windows.Forms.TextBox();
			this.labelModsLocation = new global::System.Windows.Forms.Label();
			this.numericUpDownMapNumber = new global::System.Windows.Forms.NumericUpDown();
			this.labelMapNumber = new global::System.Windows.Forms.Label();
			this.comboBoxDifficulty = new global::System.Windows.Forms.ComboBox();
			this.labelDifficulty = new global::System.Windows.Forms.Label();
			this.buttonBrowseDRPGPath = new global::System.Windows.Forms.Button();
			this.textBoxDRPGPath = new global::System.Windows.Forms.TextBox();
			this.labelDoomRPGFolderLocation = new global::System.Windows.Forms.Label();
			this.buttonBrowsePortPath = new global::System.Windows.Forms.Button();
			this.textBoxPortPath = new global::System.Windows.Forms.TextBox();
			this.labelPortLocation = new global::System.Windows.Forms.Label();
			this.tabPageMultiplayer = new global::System.Windows.Forms.TabPage();
			this.groupBoxServerOptions = new global::System.Windows.Forms.GroupBox();
			this.labelDuplicate = new global::System.Windows.Forms.Label();
			this.numericUpDownDuplicate = new global::System.Windows.Forms.NumericUpDown();
			this.checkBoxExtraTics = new global::System.Windows.Forms.CheckBox();
			this.groupBoxServerMode = new global::System.Windows.Forms.GroupBox();
			this.radioButtonPacketServer = new global::System.Windows.Forms.RadioButton();
			this.radioButtonPeerToPeer = new global::System.Windows.Forms.RadioButton();
			this.groupBoxMode = new global::System.Windows.Forms.GroupBox();
			this.numericUpDownPlayers = new global::System.Windows.Forms.NumericUpDown();
			this.labelPlayers = new global::System.Windows.Forms.Label();
			this.textBoxHostname = new global::System.Windows.Forms.TextBox();
			this.radioButtonHosting = new global::System.Windows.Forms.RadioButton();
			this.radioButtonJoining = new global::System.Windows.Forms.RadioButton();
			this.checkBoxMultiplayer = new global::System.Windows.Forms.CheckBox();
			this.tabPageModsPatches = new global::System.Windows.Forms.TabPage();
			this.buttonLoadOrder = new global::System.Windows.Forms.Button();
			this.buttonRefresh = new global::System.Windows.Forms.Button();
			this.checkedListBoxMods = new global::System.Windows.Forms.CheckedListBox();
			this.labelMods = new global::System.Windows.Forms.Label();
			this.checkedListBoxPatches = new global::System.Windows.Forms.CheckedListBox();
			this.labelPatches = new global::System.Windows.Forms.Label();
			this.tabPageDMFlags = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.listViewDMFlags2 = new global::System.Windows.Forms.ListView();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.checkBoxDMFlags2 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxDMFlags = new global::System.Windows.Forms.CheckBox();
			this.listViewDMFlags = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.tabPageCredits = new global::System.Windows.Forms.TabPage();
			this.richTextBoxCredits = new global::System.Windows.Forms.RichTextBox();
			this.buttonLaunch = new global::System.Windows.Forms.Button();
			this.labelCustomCommands = new global::System.Windows.Forms.Label();
			this.textBoxCustomCommands = new global::System.Windows.Forms.TextBox();
			this.statusStrip = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar = new global::System.Windows.Forms.ToolStripProgressBar();
			this.buttonCheckUpdates = new global::System.Windows.Forms.Button();
			this.timer = new global::System.Windows.Forms.Timer(this.components);
			this.timerPulse = new global::System.Windows.Forms.Timer(this.components);
			this.toolTipMain = new global::System.Windows.Forms.ToolTip(this.components);
			this.tabControlMain.SuspendLayout();
			this.tabPageBasic.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownMapNumber).BeginInit();
			this.tabPageMultiplayer.SuspendLayout();
			this.groupBoxServerOptions.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownDuplicate).BeginInit();
			this.groupBoxServerMode.SuspendLayout();
			this.groupBoxMode.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownPlayers).BeginInit();
			this.tabPageModsPatches.SuspendLayout();
			this.tabPageDMFlags.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPageCredits.SuspendLayout();
			this.statusStrip.SuspendLayout();
			base.SuspendLayout();
			this.tabControlMain.Controls.Add(this.tabPageBasic);
			this.tabControlMain.Controls.Add(this.tabPageMultiplayer);
			this.tabControlMain.Controls.Add(this.tabPageModsPatches);
			this.tabControlMain.Controls.Add(this.tabPageDMFlags);
			this.tabControlMain.Controls.Add(this.tabPageCredits);
			this.tabControlMain.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.tabControlMain.Location = new global::System.Drawing.Point(0, 0);
			this.tabControlMain.Margin = new global::System.Windows.Forms.Padding(6);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new global::System.Drawing.Size(856, 623);
			this.tabControlMain.TabIndex = 0;
			this.tabPageBasic.Controls.Add(this.comboBoxBranch);
			this.tabPageBasic.Controls.Add(this.labelBranch);
			this.tabPageBasic.Controls.Add(this.buttonShowCommandLine);
			this.tabPageBasic.Controls.Add(this.textBoxDemo);
			this.tabPageBasic.Controls.Add(this.labelRecordDemo);
			this.tabPageBasic.Controls.Add(this.checkBoxLogging);
			this.tabPageBasic.Controls.Add(this.checkBoxEnableCheats);
			this.tabPageBasic.Controls.Add(this.comboBoxSaveGame);
			this.tabPageBasic.Controls.Add(this.labelSavegame);
			this.tabPageBasic.Controls.Add(this.comboBoxClass);
			this.tabPageBasic.Controls.Add(this.labelPlayerClass);
			this.tabPageBasic.Controls.Add(this.comboBoxIWAD);
			this.tabPageBasic.Controls.Add(this.labelIWAD);
			this.tabPageBasic.Controls.Add(this.buttonBrowseModsPath);
			this.tabPageBasic.Controls.Add(this.textBoxModsPath);
			this.tabPageBasic.Controls.Add(this.labelModsLocation);
			this.tabPageBasic.Controls.Add(this.numericUpDownMapNumber);
			this.tabPageBasic.Controls.Add(this.labelMapNumber);
			this.tabPageBasic.Controls.Add(this.comboBoxDifficulty);
			this.tabPageBasic.Controls.Add(this.labelDifficulty);
			this.tabPageBasic.Controls.Add(this.buttonBrowseDRPGPath);
			this.tabPageBasic.Controls.Add(this.textBoxDRPGPath);
			this.tabPageBasic.Controls.Add(this.labelDoomRPGFolderLocation);
			this.tabPageBasic.Controls.Add(this.buttonBrowsePortPath);
			this.tabPageBasic.Controls.Add(this.textBoxPortPath);
			this.tabPageBasic.Controls.Add(this.labelPortLocation);
			this.tabPageBasic.Location = new global::System.Drawing.Point(8, 39);
			this.tabPageBasic.Margin = new global::System.Windows.Forms.Padding(6);
			this.tabPageBasic.Name = "tabPageBasic";
			this.tabPageBasic.Padding = new global::System.Windows.Forms.Padding(6);
			this.tabPageBasic.Size = new global::System.Drawing.Size(840, 576);
			this.tabPageBasic.TabIndex = 0;
			this.tabPageBasic.Text = "Basic";
			this.tabPageBasic.UseVisualStyleBackColor = true;
			this.comboBoxBranch.Enabled = false;
			this.comboBoxBranch.FormattingEnabled = true;
			this.comboBoxBranch.Location = new global::System.Drawing.Point(588, 415);
			this.comboBoxBranch.Margin = new global::System.Windows.Forms.Padding(6);
			this.comboBoxBranch.Name = "comboBoxBranch";
			this.comboBoxBranch.Size = new global::System.Drawing.Size(232, 33);
			this.comboBoxBranch.TabIndex = 27;
			this.comboBoxBranch.Text = "Checking...";
			this.comboBoxBranch.SelectedIndexChanged += new global::System.EventHandler(this.ComboBoxBranch_SelectedIndexChanged);
			this.labelBranch.AutoSize = true;
			this.labelBranch.Location = new global::System.Drawing.Point(582, 385);
			this.labelBranch.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelBranch.Name = "labelBranch";
			this.labelBranch.Size = new global::System.Drawing.Size(80, 25);
			this.labelBranch.TabIndex = 26;
			this.labelBranch.Text = "Branch";
			this.buttonShowCommandLine.Location = new global::System.Drawing.Point(592, 495);
			this.buttonShowCommandLine.Margin = new global::System.Windows.Forms.Padding(6);
			this.buttonShowCommandLine.Name = "buttonShowCommandLine";
			this.buttonShowCommandLine.Size = new global::System.Drawing.Size(236, 69);
			this.buttonShowCommandLine.TabIndex = 25;
			this.buttonShowCommandLine.Text = "Show Entire Command-Line";
			this.buttonShowCommandLine.UseVisualStyleBackColor = true;
			this.buttonShowCommandLine.Click += new global::System.EventHandler(this.ButtonShowCommandLine_Click);
			this.textBoxDemo.Location = new global::System.Drawing.Point(588, 340);
			this.textBoxDemo.Margin = new global::System.Windows.Forms.Padding(6);
			this.textBoxDemo.Name = "textBoxDemo";
			this.textBoxDemo.Size = new global::System.Drawing.Size(232, 31);
			this.textBoxDemo.TabIndex = 24;
			this.labelRecordDemo.AutoSize = true;
			this.labelRecordDemo.Location = new global::System.Drawing.Point(582, 310);
			this.labelRecordDemo.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelRecordDemo.Name = "labelRecordDemo";
			this.labelRecordDemo.Size = new global::System.Drawing.Size(143, 25);
			this.labelRecordDemo.TabIndex = 23;
			this.labelRecordDemo.Text = "Record Demo";
			this.checkBoxLogging.AutoSize = true;
			this.checkBoxLogging.Location = new global::System.Drawing.Point(24, 458);
			this.checkBoxLogging.Margin = new global::System.Windows.Forms.Padding(6);
			this.checkBoxLogging.Name = "checkBoxLogging";
			this.checkBoxLogging.Size = new global::System.Drawing.Size(259, 29);
			this.checkBoxLogging.TabIndex = 22;
			this.checkBoxLogging.Text = "Enable Logging to File";
			this.checkBoxLogging.UseVisualStyleBackColor = true;
			this.checkBoxEnableCheats.AutoSize = true;
			this.checkBoxEnableCheats.Location = new global::System.Drawing.Point(24, 413);
			this.checkBoxEnableCheats.Margin = new global::System.Windows.Forms.Padding(6);
			this.checkBoxEnableCheats.Name = "checkBoxEnableCheats";
			this.checkBoxEnableCheats.Size = new global::System.Drawing.Size(185, 29);
			this.checkBoxEnableCheats.TabIndex = 21;
			this.checkBoxEnableCheats.Text = "Enable Cheats";
			this.checkBoxEnableCheats.UseVisualStyleBackColor = true;
			this.comboBoxSaveGame.FormattingEnabled = true;
			this.comboBoxSaveGame.Items.AddRange(new object[]
			{
				"None"
			});
			this.comboBoxSaveGame.Location = new global::System.Drawing.Point(304, 340);
			this.comboBoxSaveGame.Margin = new global::System.Windows.Forms.Padding(6);
			this.comboBoxSaveGame.Name = "comboBoxSaveGame";
			this.comboBoxSaveGame.Size = new global::System.Drawing.Size(238, 33);
			this.comboBoxSaveGame.TabIndex = 20;
			this.comboBoxSaveGame.Text = "None";
			this.labelSavegame.AutoSize = true;
			this.labelSavegame.Location = new global::System.Drawing.Point(298, 310);
			this.labelSavegame.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelSavegame.Name = "labelSavegame";
			this.labelSavegame.Size = new global::System.Drawing.Size(114, 25);
			this.labelSavegame.TabIndex = 19;
			this.labelSavegame.Text = "Savegame";
			this.comboBoxClass.Enabled = false;
			this.comboBoxClass.FormattingEnabled = true;
			this.comboBoxClass.Location = new global::System.Drawing.Point(22, 340);
			this.comboBoxClass.Margin = new global::System.Windows.Forms.Padding(6);
			this.comboBoxClass.Name = "comboBoxClass";
			this.comboBoxClass.Size = new global::System.Drawing.Size(238, 33);
			this.comboBoxClass.TabIndex = 18;
			this.labelPlayerClass.AutoSize = true;
			this.labelPlayerClass.Location = new global::System.Drawing.Point(16, 310);
			this.labelPlayerClass.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelPlayerClass.Name = "labelPlayerClass";
			this.labelPlayerClass.Size = new global::System.Drawing.Size(133, 25);
			this.labelPlayerClass.TabIndex = 17;
			this.labelPlayerClass.Text = "Player Class";
			this.comboBoxIWAD.FormattingEnabled = true;
			this.comboBoxIWAD.Location = new global::System.Drawing.Point(24, 262);
			this.comboBoxIWAD.Margin = new global::System.Windows.Forms.Padding(6);
			this.comboBoxIWAD.Name = "comboBoxIWAD";
			this.comboBoxIWAD.Size = new global::System.Drawing.Size(238, 33);
			this.comboBoxIWAD.TabIndex = 16;
			this.labelIWAD.AutoSize = true;
			this.labelIWAD.Location = new global::System.Drawing.Point(18, 231);
			this.labelIWAD.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelIWAD.Name = "labelIWAD";
			this.labelIWAD.Size = new global::System.Drawing.Size(128, 25);
			this.labelIWAD.TabIndex = 15;
			this.labelIWAD.Text = "Doom IWAD";
			this.buttonBrowseModsPath.Location = new global::System.Drawing.Point(694, 187);
			this.buttonBrowseModsPath.Margin = new global::System.Windows.Forms.Padding(6);
			this.buttonBrowseModsPath.Name = "buttonBrowseModsPath";
			this.buttonBrowseModsPath.Size = new global::System.Drawing.Size(132, 38);
			this.buttonBrowseModsPath.TabIndex = 14;
			this.buttonBrowseModsPath.Text = "Browse...";
			this.buttonBrowseModsPath.UseVisualStyleBackColor = true;
			this.buttonBrowseModsPath.Click += new global::System.EventHandler(this.ButtonBrowseModsPath_Click);
			this.textBoxModsPath.Location = new global::System.Drawing.Point(24, 187);
			this.textBoxModsPath.Margin = new global::System.Windows.Forms.Padding(6);
			this.textBoxModsPath.Name = "textBoxModsPath";
			this.textBoxModsPath.Size = new global::System.Drawing.Size(654, 31);
			this.textBoxModsPath.TabIndex = 13;
			this.textBoxModsPath.TextChanged += new global::System.EventHandler(this.TextBoxModsPath_TextChanged);
			this.labelModsLocation.AutoSize = true;
			this.labelModsLocation.Location = new global::System.Drawing.Point(18, 156);
			this.labelModsLocation.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelModsLocation.Name = "labelModsLocation";
			this.labelModsLocation.Size = new global::System.Drawing.Size(273, 25);
			this.labelModsLocation.TabIndex = 12;
			this.labelModsLocation.Text = "WAD/PK3s Folder Location";
			this.labelModsLocation.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.numericUpDownMapNumber.Location = new global::System.Drawing.Point(588, 262);
			this.numericUpDownMapNumber.Margin = new global::System.Windows.Forms.Padding(6);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDownMapNumber;
			int[] array = new int[4];
			array[0] = 1000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDownMapNumber.Name = "numericUpDownMapNumber";
			this.numericUpDownMapNumber.Size = new global::System.Drawing.Size(148, 31);
			this.numericUpDownMapNumber.TabIndex = 9;
			this.labelMapNumber.AutoSize = true;
			this.labelMapNumber.Location = new global::System.Drawing.Point(582, 231);
			this.labelMapNumber.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelMapNumber.Name = "labelMapNumber";
			this.labelMapNumber.Size = new global::System.Drawing.Size(135, 25);
			this.labelMapNumber.TabIndex = 8;
			this.labelMapNumber.Text = "Map Number";
			this.comboBoxDifficulty.FormattingEnabled = true;
			this.comboBoxDifficulty.Location = new global::System.Drawing.Point(304, 262);
			this.comboBoxDifficulty.Margin = new global::System.Windows.Forms.Padding(6);
			this.comboBoxDifficulty.Name = "comboBoxDifficulty";
			this.comboBoxDifficulty.Size = new global::System.Drawing.Size(238, 33);
			this.comboBoxDifficulty.TabIndex = 7;
			this.labelDifficulty.AutoSize = true;
			this.labelDifficulty.Location = new global::System.Drawing.Point(298, 231);
			this.labelDifficulty.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelDifficulty.Name = "labelDifficulty";
			this.labelDifficulty.Size = new global::System.Drawing.Size(94, 25);
			this.labelDifficulty.TabIndex = 6;
			this.labelDifficulty.Text = "Difficulty";
			this.buttonBrowseDRPGPath.Location = new global::System.Drawing.Point(692, 112);
			this.buttonBrowseDRPGPath.Margin = new global::System.Windows.Forms.Padding(6);
			this.buttonBrowseDRPGPath.Name = "buttonBrowseDRPGPath";
			this.buttonBrowseDRPGPath.Size = new global::System.Drawing.Size(132, 38);
			this.buttonBrowseDRPGPath.TabIndex = 5;
			this.buttonBrowseDRPGPath.Text = "Browse...";
			this.buttonBrowseDRPGPath.UseVisualStyleBackColor = true;
			this.buttonBrowseDRPGPath.Click += new global::System.EventHandler(this.ButtonBrowseDRPGPath_Click);
			this.textBoxDRPGPath.Location = new global::System.Drawing.Point(22, 112);
			this.textBoxDRPGPath.Margin = new global::System.Windows.Forms.Padding(6);
			this.textBoxDRPGPath.Name = "textBoxDRPGPath";
			this.textBoxDRPGPath.Size = new global::System.Drawing.Size(654, 31);
			this.textBoxDRPGPath.TabIndex = 4;
			this.textBoxDRPGPath.TextChanged += new global::System.EventHandler(this.TextBoxDRPGPath_TextChanged);
			this.labelDoomRPGFolderLocation.AutoSize = true;
			this.labelDoomRPGFolderLocation.Location = new global::System.Drawing.Point(16, 81);
			this.labelDoomRPGFolderLocation.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelDoomRPGFolderLocation.Name = "labelDoomRPGFolderLocation";
			this.labelDoomRPGFolderLocation.Size = new global::System.Drawing.Size(274, 25);
			this.labelDoomRPGFolderLocation.TabIndex = 3;
			this.labelDoomRPGFolderLocation.Text = "Doom RPG Folder Location";
			this.labelDoomRPGFolderLocation.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.buttonBrowsePortPath.Location = new global::System.Drawing.Point(692, 37);
			this.buttonBrowsePortPath.Margin = new global::System.Windows.Forms.Padding(6);
			this.buttonBrowsePortPath.Name = "buttonBrowsePortPath";
			this.buttonBrowsePortPath.Size = new global::System.Drawing.Size(132, 38);
			this.buttonBrowsePortPath.TabIndex = 2;
			this.buttonBrowsePortPath.Text = "Browse...";
			this.buttonBrowsePortPath.UseVisualStyleBackColor = true;
			this.buttonBrowsePortPath.Click += new global::System.EventHandler(this.ButtonBrowsePortPath_Click);
			this.textBoxPortPath.Location = new global::System.Drawing.Point(22, 37);
			this.textBoxPortPath.Margin = new global::System.Windows.Forms.Padding(6);
			this.textBoxPortPath.Name = "textBoxPortPath";
			this.textBoxPortPath.Size = new global::System.Drawing.Size(654, 31);
			this.textBoxPortPath.TabIndex = 1;
			this.labelPortLocation.AutoSize = true;
			this.labelPortLocation.Location = new global::System.Drawing.Point(16, 6);
			this.labelPortLocation.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelPortLocation.Name = "labelPortLocation";
			this.labelPortLocation.Size = new global::System.Drawing.Size(185, 25);
			this.labelPortLocation.TabIndex = 0;
			this.labelPortLocation.Text = "GZDoom Location";
			this.labelPortLocation.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.tabPageMultiplayer.Controls.Add(this.groupBoxServerOptions);
			this.tabPageMultiplayer.Controls.Add(this.groupBoxServerMode);
			this.tabPageMultiplayer.Controls.Add(this.groupBoxMode);
			this.tabPageMultiplayer.Controls.Add(this.checkBoxMultiplayer);
			this.tabPageMultiplayer.Location = new global::System.Drawing.Point(8, 39);
			this.tabPageMultiplayer.Margin = new global::System.Windows.Forms.Padding(6);
			this.tabPageMultiplayer.Name = "tabPageMultiplayer";
			this.tabPageMultiplayer.Padding = new global::System.Windows.Forms.Padding(6);
			this.tabPageMultiplayer.Size = new global::System.Drawing.Size(840, 576);
			this.tabPageMultiplayer.TabIndex = 1;
			this.tabPageMultiplayer.Text = "Multiplayer";
			this.tabPageMultiplayer.UseVisualStyleBackColor = true;
			this.groupBoxServerOptions.Controls.Add(this.labelDuplicate);
			this.groupBoxServerOptions.Controls.Add(this.numericUpDownDuplicate);
			this.groupBoxServerOptions.Controls.Add(this.checkBoxExtraTics);
			this.groupBoxServerOptions.Location = new global::System.Drawing.Point(350, 56);
			this.groupBoxServerOptions.Margin = new global::System.Windows.Forms.Padding(6);
			this.groupBoxServerOptions.Name = "groupBoxServerOptions";
			this.groupBoxServerOptions.Padding = new global::System.Windows.Forms.Padding(6);
			this.groupBoxServerOptions.Size = new global::System.Drawing.Size(474, 506);
			this.groupBoxServerOptions.TabIndex = 5;
			this.groupBoxServerOptions.TabStop = false;
			this.groupBoxServerOptions.Text = "Server Options";
			this.labelDuplicate.Location = new global::System.Drawing.Point(12, 79);
			this.labelDuplicate.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelDuplicate.Name = "labelDuplicate";
			this.labelDuplicate.Size = new global::System.Drawing.Size(278, 38);
			this.labelDuplicate.TabIndex = 6;
			this.labelDuplicate.Text = "Server-side tic duplication";
			this.labelDuplicate.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTipMain.SetToolTip(this.labelDuplicate, "Causes GZDoom to transmit fewer player movement commands across the network.\r\nFor example, -dup 2 would cause GZDoom to send half as many movements as normal.");
			this.numericUpDownDuplicate.Location = new global::System.Drawing.Point(302, 84);
			this.numericUpDownDuplicate.Margin = new global::System.Windows.Forms.Padding(6);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDownDuplicate;
			int[] array2 = new int[4];
			array2[0] = 9;
			numericUpDown2.Maximum = new decimal(array2);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDownDuplicate;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Minimum = new decimal(array3);
			this.numericUpDownDuplicate.Name = "numericUpDownDuplicate";
			this.numericUpDownDuplicate.Size = new global::System.Drawing.Size(160, 31);
			this.numericUpDownDuplicate.TabIndex = 6;
			this.toolTipMain.SetToolTip(this.numericUpDownDuplicate, "Causes GZDoom to transmit fewer player movement commands across the network.");
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDownDuplicate;
			int[] array4 = new int[4];
			array4[0] = 1;
			numericUpDown4.Value = new decimal(array4);
			this.checkBoxExtraTics.AutoSize = true;
			this.checkBoxExtraTics.Location = new global::System.Drawing.Point(12, 38);
			this.checkBoxExtraTics.Margin = new global::System.Windows.Forms.Padding(6);
			this.checkBoxExtraTics.Name = "checkBoxExtraTics";
			this.checkBoxExtraTics.Size = new global::System.Drawing.Size(129, 29);
			this.checkBoxExtraTics.TabIndex = 0;
			this.checkBoxExtraTics.Text = "Extra Tic";
			this.toolTipMain.SetToolTip(this.checkBoxExtraTics, "Causes GZDoom to send a backup copy of every movement command across the network.");
			this.checkBoxExtraTics.UseVisualStyleBackColor = true;
			this.groupBoxServerMode.Controls.Add(this.radioButtonPacketServer);
			this.groupBoxServerMode.Controls.Add(this.radioButtonPeerToPeer);
			this.groupBoxServerMode.Location = new global::System.Drawing.Point(16, 298);
			this.groupBoxServerMode.Margin = new global::System.Windows.Forms.Padding(6);
			this.groupBoxServerMode.Name = "groupBoxServerMode";
			this.groupBoxServerMode.Padding = new global::System.Windows.Forms.Padding(6);
			this.groupBoxServerMode.Size = new global::System.Drawing.Size(322, 131);
			this.groupBoxServerMode.TabIndex = 4;
			this.groupBoxServerMode.TabStop = false;
			this.groupBoxServerMode.Text = "Server Mode";
			this.radioButtonPacketServer.AutoSize = true;
			this.radioButtonPacketServer.Location = new global::System.Drawing.Point(12, 81);
			this.radioButtonPacketServer.Margin = new global::System.Windows.Forms.Padding(6);
			this.radioButtonPacketServer.Name = "radioButtonPacketServer";
			this.radioButtonPacketServer.Size = new global::System.Drawing.Size(178, 29);
			this.radioButtonPacketServer.TabIndex = 1;
			this.radioButtonPacketServer.TabStop = true;
			this.radioButtonPacketServer.Text = "Packet Server";
			this.radioButtonPacketServer.UseVisualStyleBackColor = true;
			this.radioButtonPeerToPeer.AutoSize = true;
			this.radioButtonPeerToPeer.Location = new global::System.Drawing.Point(12, 37);
			this.radioButtonPeerToPeer.Margin = new global::System.Windows.Forms.Padding(6);
			this.radioButtonPeerToPeer.Name = "radioButtonPeerToPeer";
			this.radioButtonPeerToPeer.Size = new global::System.Drawing.Size(165, 29);
			this.radioButtonPeerToPeer.TabIndex = 0;
			this.radioButtonPeerToPeer.TabStop = true;
			this.radioButtonPeerToPeer.Text = "Peer-to-Peer";
			this.radioButtonPeerToPeer.UseVisualStyleBackColor = true;
			this.groupBoxMode.Controls.Add(this.numericUpDownPlayers);
			this.groupBoxMode.Controls.Add(this.labelPlayers);
			this.groupBoxMode.Controls.Add(this.textBoxHostname);
			this.groupBoxMode.Controls.Add(this.radioButtonHosting);
			this.groupBoxMode.Controls.Add(this.radioButtonJoining);
			this.groupBoxMode.Location = new global::System.Drawing.Point(16, 56);
			this.groupBoxMode.Margin = new global::System.Windows.Forms.Padding(6);
			this.groupBoxMode.Name = "groupBoxMode";
			this.groupBoxMode.Padding = new global::System.Windows.Forms.Padding(6);
			this.groupBoxMode.Size = new global::System.Drawing.Size(322, 231);
			this.groupBoxMode.TabIndex = 3;
			this.groupBoxMode.TabStop = false;
			this.groupBoxMode.Text = "Mode";
			this.numericUpDownPlayers.Location = new global::System.Drawing.Point(170, 84);
			this.numericUpDownPlayers.Margin = new global::System.Windows.Forms.Padding(6);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericUpDownPlayers;
			int[] array5 = new int[4];
			array5[0] = 8;
			numericUpDown5.Maximum = new decimal(array5);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numericUpDownPlayers;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Minimum = new decimal(array6);
			this.numericUpDownPlayers.Name = "numericUpDownPlayers";
			this.numericUpDownPlayers.Size = new global::System.Drawing.Size(140, 31);
			this.numericUpDownPlayers.TabIndex = 8;
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numericUpDownPlayers;
			int[] array7 = new int[4];
			array7[0] = 2;
			numericUpDown7.Value = new decimal(array7);
			this.labelPlayers.Location = new global::System.Drawing.Point(12, 79);
			this.labelPlayers.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelPlayers.Name = "labelPlayers";
			this.labelPlayers.Size = new global::System.Drawing.Size(146, 38);
			this.labelPlayers.TabIndex = 7;
			this.labelPlayers.Text = "Players";
			this.labelPlayers.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.textBoxHostname.Location = new global::System.Drawing.Point(14, 181);
			this.textBoxHostname.Margin = new global::System.Windows.Forms.Padding(6);
			this.textBoxHostname.Name = "textBoxHostname";
			this.textBoxHostname.Size = new global::System.Drawing.Size(292, 31);
			this.textBoxHostname.TabIndex = 6;
			this.radioButtonHosting.AutoSize = true;
			this.radioButtonHosting.Location = new global::System.Drawing.Point(12, 37);
			this.radioButtonHosting.Margin = new global::System.Windows.Forms.Padding(6);
			this.radioButtonHosting.Name = "radioButtonHosting";
			this.radioButtonHosting.Size = new global::System.Drawing.Size(116, 29);
			this.radioButtonHosting.TabIndex = 1;
			this.radioButtonHosting.TabStop = true;
			this.radioButtonHosting.Text = "Hosting";
			this.radioButtonHosting.UseVisualStyleBackColor = true;
			this.radioButtonJoining.AutoSize = true;
			this.radioButtonJoining.Location = new global::System.Drawing.Point(12, 137);
			this.radioButtonJoining.Margin = new global::System.Windows.Forms.Padding(6);
			this.radioButtonJoining.Name = "radioButtonJoining";
			this.radioButtonJoining.Size = new global::System.Drawing.Size(112, 29);
			this.radioButtonJoining.TabIndex = 2;
			this.radioButtonJoining.TabStop = true;
			this.radioButtonJoining.Text = "Joining";
			this.radioButtonJoining.UseVisualStyleBackColor = true;
			this.checkBoxMultiplayer.AutoSize = true;
			this.checkBoxMultiplayer.Location = new global::System.Drawing.Point(16, 12);
			this.checkBoxMultiplayer.Margin = new global::System.Windows.Forms.Padding(6);
			this.checkBoxMultiplayer.Name = "checkBoxMultiplayer";
			this.checkBoxMultiplayer.Size = new global::System.Drawing.Size(212, 29);
			this.checkBoxMultiplayer.TabIndex = 0;
			this.checkBoxMultiplayer.Text = "Multiplayer Game";
			this.checkBoxMultiplayer.UseVisualStyleBackColor = true;
			this.tabPageModsPatches.Controls.Add(this.buttonLoadOrder);
			this.tabPageModsPatches.Controls.Add(this.buttonRefresh);
			this.tabPageModsPatches.Controls.Add(this.checkedListBoxMods);
			this.tabPageModsPatches.Controls.Add(this.labelMods);
			this.tabPageModsPatches.Controls.Add(this.checkedListBoxPatches);
			this.tabPageModsPatches.Controls.Add(this.labelPatches);
			this.tabPageModsPatches.Location = new global::System.Drawing.Point(8, 39);
			this.tabPageModsPatches.Margin = new global::System.Windows.Forms.Padding(6);
			this.tabPageModsPatches.Name = "tabPageModsPatches";
			this.tabPageModsPatches.Size = new global::System.Drawing.Size(840, 576);
			this.tabPageModsPatches.TabIndex = 3;
			this.tabPageModsPatches.Text = "Mods/Patches";
			this.tabPageModsPatches.UseVisualStyleBackColor = true;
			this.buttonLoadOrder.Location = new global::System.Drawing.Point(582, 512);
			this.buttonLoadOrder.Margin = new global::System.Windows.Forms.Padding(6);
			this.buttonLoadOrder.Name = "buttonLoadOrder";
			this.buttonLoadOrder.Size = new global::System.Drawing.Size(236, 56);
			this.buttonLoadOrder.TabIndex = 29;
			this.buttonLoadOrder.Text = "Edit Load Order";
			this.buttonLoadOrder.UseVisualStyleBackColor = true;
			this.buttonLoadOrder.Click += new global::System.EventHandler(this.ButtonLoadOrder_Click);
			this.buttonRefresh.Location = new global::System.Drawing.Point(22, 512);
			this.buttonRefresh.Margin = new global::System.Windows.Forms.Padding(6);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new global::System.Drawing.Size(548, 56);
			this.buttonRefresh.TabIndex = 21;
			this.buttonRefresh.Text = "Reload Patches and Mods";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new global::System.EventHandler(this.ButtonRefresh_Click);
			this.checkedListBoxMods.FormattingEnabled = true;
			this.checkedListBoxMods.Location = new global::System.Drawing.Point(402, 31);
			this.checkedListBoxMods.Margin = new global::System.Windows.Forms.Padding(6);
			this.checkedListBoxMods.Name = "checkedListBoxMods";
			this.checkedListBoxMods.Size = new global::System.Drawing.Size(416, 446);
			this.checkedListBoxMods.TabIndex = 20;
			this.labelMods.AutoSize = true;
			this.labelMods.Location = new global::System.Drawing.Point(396, 0);
			this.labelMods.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelMods.Name = "labelMods";
			this.labelMods.Size = new global::System.Drawing.Size(159, 25);
			this.labelMods.TabIndex = 19;
			this.labelMods.Text = "WAD/PK3 Files";
			this.checkedListBoxPatches.FormattingEnabled = true;
			this.checkedListBoxPatches.Location = new global::System.Drawing.Point(20, 31);
			this.checkedListBoxPatches.Margin = new global::System.Windows.Forms.Padding(6);
			this.checkedListBoxPatches.Name = "checkedListBoxPatches";
			this.checkedListBoxPatches.Size = new global::System.Drawing.Size(366, 446);
			this.checkedListBoxPatches.TabIndex = 18;
			this.labelPatches.AutoSize = true;
			this.labelPatches.Location = new global::System.Drawing.Point(16, 0);
			this.labelPatches.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelPatches.Name = "labelPatches";
			this.labelPatches.Size = new global::System.Drawing.Size(203, 25);
			this.labelPatches.TabIndex = 17;
			this.labelPatches.Text = "Doom RPG Patches";
			this.tabPageDMFlags.Controls.Add(this.tableLayoutPanel1);
			this.tabPageDMFlags.Location = new global::System.Drawing.Point(8, 39);
			this.tabPageDMFlags.Margin = new global::System.Windows.Forms.Padding(6);
			this.tabPageDMFlags.Name = "tabPageDMFlags";
			this.tabPageDMFlags.Size = new global::System.Drawing.Size(840, 576);
			this.tabPageDMFlags.TabIndex = 4;
			this.tabPageDMFlags.Text = "Gameplay options";
			this.tabPageDMFlags.UseVisualStyleBackColor = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.listViewDMFlags2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBoxDMFlags2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.checkBoxDMFlags, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.listViewDMFlags, 0, 1);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(840, 576);
			this.tableLayoutPanel1.TabIndex = 0;
			this.listViewDMFlags2.CheckBoxes = true;
			this.listViewDMFlags2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader2
			});
			this.listViewDMFlags2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewDMFlags2.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewDMFlags2.Location = new global::System.Drawing.Point(423, 44);
			this.listViewDMFlags2.Name = "listViewDMFlags2";
			this.listViewDMFlags2.ShowItemToolTips = true;
			this.listViewDMFlags2.Size = new global::System.Drawing.Size(414, 529);
			this.listViewDMFlags2.TabIndex = 25;
			this.listViewDMFlags2.UseCompatibleStateImageBehavior = false;
			this.listViewDMFlags2.View = global::System.Windows.Forms.View.Details;
			this.checkBoxDMFlags2.AutoSize = true;
			this.checkBoxDMFlags2.Location = new global::System.Drawing.Point(426, 6);
			this.checkBoxDMFlags2.Margin = new global::System.Windows.Forms.Padding(6);
			this.checkBoxDMFlags2.Name = "checkBoxDMFlags2";
			this.checkBoxDMFlags2.Size = new global::System.Drawing.Size(215, 29);
			this.checkBoxDMFlags2.TabIndex = 23;
			this.checkBoxDMFlags2.Text = "Enable DMFlags2";
			this.checkBoxDMFlags2.UseVisualStyleBackColor = true;
			this.checkBoxDMFlags.AutoSize = true;
			this.checkBoxDMFlags.Location = new global::System.Drawing.Point(6, 6);
			this.checkBoxDMFlags.Margin = new global::System.Windows.Forms.Padding(6);
			this.checkBoxDMFlags.Name = "checkBoxDMFlags";
			this.checkBoxDMFlags.Size = new global::System.Drawing.Size(203, 29);
			this.checkBoxDMFlags.TabIndex = 22;
			this.checkBoxDMFlags.Text = "Enable DMFlags";
			this.checkBoxDMFlags.UseVisualStyleBackColor = true;
			this.listViewDMFlags.CheckBoxes = true;
			this.listViewDMFlags.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1
			});
			this.listViewDMFlags.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewDMFlags.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewDMFlags.LabelWrap = false;
			this.listViewDMFlags.Location = new global::System.Drawing.Point(3, 44);
			this.listViewDMFlags.Name = "listViewDMFlags";
			this.listViewDMFlags.ShowItemToolTips = true;
			this.listViewDMFlags.Size = new global::System.Drawing.Size(414, 529);
			this.listViewDMFlags.TabIndex = 24;
			this.listViewDMFlags.UseCompatibleStateImageBehavior = false;
			this.listViewDMFlags.View = global::System.Windows.Forms.View.Details;
			this.tabPageCredits.Controls.Add(this.richTextBoxCredits);
			this.tabPageCredits.Location = new global::System.Drawing.Point(8, 39);
			this.tabPageCredits.Margin = new global::System.Windows.Forms.Padding(6);
			this.tabPageCredits.Name = "tabPageCredits";
			this.tabPageCredits.Size = new global::System.Drawing.Size(840, 576);
			this.tabPageCredits.TabIndex = 2;
			this.tabPageCredits.Text = "Credits";
			this.tabPageCredits.UseVisualStyleBackColor = true;
			this.richTextBoxCredits.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBoxCredits.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxCredits.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBoxCredits.Location = new global::System.Drawing.Point(0, 0);
			this.richTextBoxCredits.Margin = new global::System.Windows.Forms.Padding(6);
			this.richTextBoxCredits.Name = "richTextBoxCredits";
			this.richTextBoxCredits.ReadOnly = true;
			this.richTextBoxCredits.Size = new global::System.Drawing.Size(840, 576);
			this.richTextBoxCredits.TabIndex = 0;
			this.richTextBoxCredits.Text = "";
			this.richTextBoxCredits.TextChanged += new global::System.EventHandler(this.RichTextBoxCredits_TextChanged);
			this.buttonLaunch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonLaunch.Location = new global::System.Drawing.Point(412, 712);
			this.buttonLaunch.Margin = new global::System.Windows.Forms.Padding(6);
			this.buttonLaunch.Name = "buttonLaunch";
			this.buttonLaunch.Size = new global::System.Drawing.Size(444, 67);
			this.buttonLaunch.TabIndex = 6;
			this.buttonLaunch.Text = "Launch Doom RPG";
			this.buttonLaunch.UseVisualStyleBackColor = true;
			this.buttonLaunch.Click += new global::System.EventHandler(this.ButtonLaunch_Click);
			this.labelCustomCommands.Location = new global::System.Drawing.Point(10, 629);
			this.labelCustomCommands.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
			this.labelCustomCommands.Name = "labelCustomCommands";
			this.labelCustomCommands.Size = new global::System.Drawing.Size(838, 27);
			this.labelCustomCommands.TabIndex = 7;
			this.labelCustomCommands.Text = "Custom Commands";
			this.labelCustomCommands.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.textBoxCustomCommands.Location = new global::System.Drawing.Point(8, 662);
			this.textBoxCustomCommands.Margin = new global::System.Windows.Forms.Padding(6);
			this.textBoxCustomCommands.Name = "textBoxCustomCommands";
			this.textBoxCustomCommands.Size = new global::System.Drawing.Size(836, 31);
			this.textBoxCustomCommands.TabIndex = 8;
			this.statusStrip.ImageScalingSize = new global::System.Drawing.Size(32, 32);
			this.statusStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel,
				this.toolStripProgressBar
			});
			this.statusStrip.Location = new global::System.Drawing.Point(0, 791);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new global::System.Windows.Forms.Padding(2, 0, 28, 0);
			this.statusStrip.Size = new global::System.Drawing.Size(856, 42);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 9;
			this.toolStripStatusLabel.AutoSize = false;
			this.toolStripStatusLabel.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new global::System.Drawing.Size(625, 37);
			this.toolStripStatusLabel.Spring = true;
			this.toolStripStatusLabel.Text = "Ready";
			this.toolStripStatusLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolStripProgressBar.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripProgressBar.Margin = new global::System.Windows.Forms.Padding(1, 3, 0, 3);
			this.toolStripProgressBar.Name = "toolStripProgressBar";
			this.toolStripProgressBar.Size = new global::System.Drawing.Size(200, 36);
			this.toolStripProgressBar.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
			this.buttonCheckUpdates.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonCheckUpdates.Location = new global::System.Drawing.Point(8, 712);
			this.buttonCheckUpdates.Margin = new global::System.Windows.Forms.Padding(6);
			this.buttonCheckUpdates.Name = "buttonCheckUpdates";
			this.buttonCheckUpdates.Size = new global::System.Drawing.Size(392, 67);
			this.buttonCheckUpdates.TabIndex = 10;
			this.buttonCheckUpdates.Text = "Check for Updates";
			this.buttonCheckUpdates.UseVisualStyleBackColor = true;
			this.buttonCheckUpdates.Click += new global::System.EventHandler(this.ButtonCheckUpdates_Click);
			this.timer.Enabled = true;
			this.timer.Tick += new global::System.EventHandler(this.Timer_Tick);
			this.timerPulse.Enabled = true;
			this.timerPulse.Interval = 10;
			this.timerPulse.Tick += new global::System.EventHandler(this.TimerPulse_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			base.ClientSize = new global::System.Drawing.Size(856, 833);
			base.Controls.Add(this.buttonCheckUpdates);
			base.Controls.Add(this.statusStrip);
			base.Controls.Add(this.textBoxCustomCommands);
			base.Controls.Add(this.labelCustomCommands);
			base.Controls.Add(this.buttonLaunch);
			base.Controls.Add(this.tabControlMain);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(6);
			base.MaximizeBox = false;
			base.Name = "FormMain";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doom RPG Launcher";
			this.tabControlMain.ResumeLayout(false);
			this.tabPageBasic.ResumeLayout(false);
			this.tabPageBasic.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownMapNumber).EndInit();
			this.tabPageMultiplayer.ResumeLayout(false);
			this.tabPageMultiplayer.PerformLayout();
			this.groupBoxServerOptions.ResumeLayout(false);
			this.groupBoxServerOptions.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownDuplicate).EndInit();
			this.groupBoxServerMode.ResumeLayout(false);
			this.groupBoxServerMode.PerformLayout();
			this.groupBoxMode.ResumeLayout(false);
			this.groupBoxMode.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDownPlayers).EndInit();
			this.tabPageModsPatches.ResumeLayout(false);
			this.tabPageModsPatches.PerformLayout();
			this.tabPageDMFlags.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabPageCredits.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.TabControl tabControlMain;

		private global::System.Windows.Forms.TabPage tabPageBasic;

		private global::System.Windows.Forms.TabPage tabPageMultiplayer;

		private global::System.Windows.Forms.Label labelPortLocation;

		private global::System.Windows.Forms.Button buttonBrowsePortPath;

		private global::System.Windows.Forms.TextBox textBoxPortPath;

		private global::System.Windows.Forms.Button buttonBrowseDRPGPath;

		private global::System.Windows.Forms.TextBox textBoxDRPGPath;

		private global::System.Windows.Forms.Label labelDoomRPGFolderLocation;

		private global::System.Windows.Forms.Button buttonLaunch;

		private global::System.Windows.Forms.ComboBox comboBoxDifficulty;

		private global::System.Windows.Forms.Label labelDifficulty;

		private global::System.Windows.Forms.NumericUpDown numericUpDownMapNumber;

		private global::System.Windows.Forms.Label labelMapNumber;

		private global::System.Windows.Forms.CheckBox checkBoxMultiplayer;

		private global::System.Windows.Forms.RadioButton radioButtonJoining;

		private global::System.Windows.Forms.RadioButton radioButtonHosting;

		private global::System.Windows.Forms.GroupBox groupBoxServerMode;

		private global::System.Windows.Forms.RadioButton radioButtonPacketServer;

		private global::System.Windows.Forms.RadioButton radioButtonPeerToPeer;

		private global::System.Windows.Forms.GroupBox groupBoxMode;

		private global::System.Windows.Forms.GroupBox groupBoxServerOptions;

		private global::System.Windows.Forms.Label labelDuplicate;

		private global::System.Windows.Forms.NumericUpDown numericUpDownDuplicate;

		private global::System.Windows.Forms.CheckBox checkBoxExtraTics;

		private global::System.Windows.Forms.TextBox textBoxHostname;

		private global::System.Windows.Forms.NumericUpDown numericUpDownPlayers;

		private global::System.Windows.Forms.Label labelPlayers;

		private global::System.Windows.Forms.Button buttonBrowseModsPath;

		private global::System.Windows.Forms.TextBox textBoxModsPath;

		private global::System.Windows.Forms.Label labelModsLocation;

		private global::System.Windows.Forms.Label labelCustomCommands;

		private global::System.Windows.Forms.TextBox textBoxCustomCommands;

		private global::System.Windows.Forms.StatusStrip statusStrip;

		private global::System.Windows.Forms.TabPage tabPageCredits;

		private global::System.Windows.Forms.RichTextBox richTextBoxCredits;

		private global::System.Windows.Forms.Button buttonCheckUpdates;

		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

		private global::System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;

		private global::System.Windows.Forms.TabPage tabPageModsPatches;

		private global::System.Windows.Forms.CheckedListBox checkedListBoxMods;

		private global::System.Windows.Forms.Label labelMods;

		private global::System.Windows.Forms.CheckedListBox checkedListBoxPatches;

		private global::System.Windows.Forms.Label labelPatches;

		private global::System.Windows.Forms.ComboBox comboBoxIWAD;

		private global::System.Windows.Forms.Label labelIWAD;

		private global::System.Windows.Forms.ComboBox comboBoxClass;

		private global::System.Windows.Forms.Label labelPlayerClass;

		private global::System.Windows.Forms.Timer timer;

		private global::System.Windows.Forms.ComboBox comboBoxSaveGame;

		private global::System.Windows.Forms.Label labelSavegame;

		private global::System.Windows.Forms.CheckBox checkBoxLogging;

		private global::System.Windows.Forms.CheckBox checkBoxEnableCheats;

		private global::System.Windows.Forms.TextBox textBoxDemo;

		private global::System.Windows.Forms.Label labelRecordDemo;

		private global::System.Windows.Forms.Button buttonShowCommandLine;

		private global::System.Windows.Forms.ComboBox comboBoxBranch;

		private global::System.Windows.Forms.Label labelBranch;

		private global::System.Windows.Forms.Button buttonRefresh;

		private global::System.Windows.Forms.Timer timerPulse;

		private global::System.Windows.Forms.ToolTip toolTipMain;

		private global::System.Windows.Forms.TabPage tabPageDMFlags;

		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		private global::System.Windows.Forms.ListView listViewDMFlags2;

		private global::System.Windows.Forms.CheckBox checkBoxDMFlags2;

		private global::System.Windows.Forms.CheckBox checkBoxDMFlags;

		private global::System.Windows.Forms.ListView listViewDMFlags;

		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		private global::System.Windows.Forms.Button buttonLoadOrder;
	}
}
