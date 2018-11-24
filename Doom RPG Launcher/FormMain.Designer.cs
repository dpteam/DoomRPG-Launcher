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
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageBasic = new System.Windows.Forms.TabPage();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.labelBranch = new System.Windows.Forms.Label();
            this.buttonCopyCommandClipboard = new System.Windows.Forms.Button();
            this.textBoxDemo = new System.Windows.Forms.TextBox();
            this.labelRecordDemo = new System.Windows.Forms.Label();
            this.checkBoxLogging = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableCheats = new System.Windows.Forms.CheckBox();
            this.comboBoxSaveGame = new System.Windows.Forms.ComboBox();
            this.labelSavegame = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelPlayerClass = new System.Windows.Forms.Label();
            this.comboBoxIWAD = new System.Windows.Forms.ComboBox();
            this.labelIWAD = new System.Windows.Forms.Label();
            this.buttonBrowseModsPath = new System.Windows.Forms.Button();
            this.textBoxModsPath = new System.Windows.Forms.TextBox();
            this.labelModsLocation = new System.Windows.Forms.Label();
            this.numericUpDownMapNumber = new System.Windows.Forms.NumericUpDown();
            this.labelMapNumber = new System.Windows.Forms.Label();
            this.comboBoxDifficulty = new System.Windows.Forms.ComboBox();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.buttonBrowseDRPGPath = new System.Windows.Forms.Button();
            this.textBoxDRPGPath = new System.Windows.Forms.TextBox();
            this.labelDoomRPGFolderLocation = new System.Windows.Forms.Label();
            this.buttonBrowsePortPath = new System.Windows.Forms.Button();
            this.textBoxPortPath = new System.Windows.Forms.TextBox();
            this.labelPortLocation = new System.Windows.Forms.Label();
            this.tabPageMultiplayer = new System.Windows.Forms.TabPage();
            this.groupBoxServerOptions = new System.Windows.Forms.GroupBox();
            this.labelDuplicate = new System.Windows.Forms.Label();
            this.numericUpDownDuplicate = new System.Windows.Forms.NumericUpDown();
            this.checkBoxExtraTics = new System.Windows.Forms.CheckBox();
            this.groupBoxServerMode = new System.Windows.Forms.GroupBox();
            this.radioButtonPacketServer = new System.Windows.Forms.RadioButton();
            this.radioButtonPeerToPeer = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.numericUpDownPlayers = new System.Windows.Forms.NumericUpDown();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.radioButtonHosting = new System.Windows.Forms.RadioButton();
            this.radioButtonJoining = new System.Windows.Forms.RadioButton();
            this.checkBoxMultiplayer = new System.Windows.Forms.CheckBox();
            this.tabPageModsPatches = new System.Windows.Forms.TabPage();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.checkedListBoxMods = new System.Windows.Forms.CheckedListBox();
            this.labelMods = new System.Windows.Forms.Label();
            this.checkedListBoxPatches = new System.Windows.Forms.CheckedListBox();
            this.labelPatches = new System.Windows.Forms.Label();
            this.tabPageCredits = new System.Windows.Forms.TabPage();
            this.richTextBoxCredits = new System.Windows.Forms.RichTextBox();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.labelCustomCommands = new System.Windows.Forms.Label();
            this.textBoxCustomCommands = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.buttonCheckUpdates = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerPulse = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapNumber)).BeginInit();
            this.tabPageMultiplayer.SuspendLayout();
            this.groupBoxServerOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuplicate)).BeginInit();
            this.groupBoxServerMode.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).BeginInit();
            this.tabPageModsPatches.SuspendLayout();
            this.tabPageCredits.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageBasic);
            this.tabControlMain.Controls.Add(this.tabPageMultiplayer);
            this.tabControlMain.Controls.Add(this.tabPageModsPatches);
            this.tabControlMain.Controls.Add(this.tabPageCredits);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(570, 324);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageBasic
            // 
            this.tabPageBasic.Controls.Add(this.comboBoxBranch);
            this.tabPageBasic.Controls.Add(this.labelBranch);
            this.tabPageBasic.Controls.Add(this.buttonCopyCommandClipboard);
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
            this.tabPageBasic.Location = new System.Drawing.Point(4, 22);
            this.tabPageBasic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageBasic.Name = "tabPageBasic";
            this.tabPageBasic.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageBasic.Size = new System.Drawing.Size(562, 298);
            this.tabPageBasic.TabIndex = 0;
            this.tabPageBasic.Text = "Основное";
            this.tabPageBasic.UseVisualStyleBackColor = true;
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.Enabled = false;
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(392, 216);
            this.comboBoxBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(156, 21);
            this.comboBoxBranch.TabIndex = 27;
            this.comboBoxBranch.Text = "Проверка...";
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.Location = new System.Drawing.Point(387, 200);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(69, 13);
            this.labelBranch.TabIndex = 26;
            this.labelBranch.Text = "Git-Ветка";
            // 
            // buttonCopyCommandClipboard
            // 
            this.buttonCopyCommandClipboard.Location = new System.Drawing.Point(13, 263);
            this.buttonCopyCommandClipboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCopyCommandClipboard.Name = "buttonCopyCommandClipboard";
            this.buttonCopyCommandClipboard.Size = new System.Drawing.Size(537, 28);
            this.buttonCopyCommandClipboard.TabIndex = 25;
            this.buttonCopyCommandClipboard.Text = "Скопировать данные запуска в буфер обмена";
            this.buttonCopyCommandClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyCommandClipboard.Click += new System.EventHandler(this.buttonCopyCommandClipboard_Click);
            // 
            // textBoxDemo
            // 
            this.textBoxDemo.Location = new System.Drawing.Point(392, 177);
            this.textBoxDemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDemo.Name = "textBoxDemo";
            this.textBoxDemo.Size = new System.Drawing.Size(156, 21);
            this.textBoxDemo.TabIndex = 24;
            // 
            // labelRecordDemo
            // 
            this.labelRecordDemo.AutoSize = true;
            this.labelRecordDemo.Location = new System.Drawing.Point(387, 161);
            this.labelRecordDemo.Name = "labelRecordDemo";
            this.labelRecordDemo.Size = new System.Drawing.Size(105, 13);
            this.labelRecordDemo.TabIndex = 23;
            this.labelRecordDemo.Text = "Записать демо";
            // 
            // checkBoxLogging
            // 
            this.checkBoxLogging.AutoSize = true;
            this.checkBoxLogging.Location = new System.Drawing.Point(16, 238);
            this.checkBoxLogging.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxLogging.Name = "checkBoxLogging";
            this.checkBoxLogging.Size = new System.Drawing.Size(230, 17);
            this.checkBoxLogging.TabIndex = 22;
            this.checkBoxLogging.Text = "Включить запись логов в файл";
            this.checkBoxLogging.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableCheats
            // 
            this.checkBoxEnableCheats.AutoSize = true;
            this.checkBoxEnableCheats.Location = new System.Drawing.Point(16, 215);
            this.checkBoxEnableCheats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxEnableCheats.Name = "checkBoxEnableCheats";
            this.checkBoxEnableCheats.Size = new System.Drawing.Size(126, 17);
            this.checkBoxEnableCheats.TabIndex = 21;
            this.checkBoxEnableCheats.Text = "Включить читы";
            this.checkBoxEnableCheats.UseVisualStyleBackColor = true;
            // 
            // comboBoxSaveGame
            // 
            this.comboBoxSaveGame.FormattingEnabled = true;
            this.comboBoxSaveGame.Items.AddRange(new object[] {
            "Никакой"});
            this.comboBoxSaveGame.Location = new System.Drawing.Point(202, 177);
            this.comboBoxSaveGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSaveGame.Name = "comboBoxSaveGame";
            this.comboBoxSaveGame.Size = new System.Drawing.Size(159, 21);
            this.comboBoxSaveGame.TabIndex = 20;
            this.comboBoxSaveGame.Text = "Никакой";
            // 
            // labelSavegame
            // 
            this.labelSavegame.AutoSize = true;
            this.labelSavegame.Location = new System.Drawing.Point(199, 161);
            this.labelSavegame.Name = "labelSavegame";
            this.labelSavegame.Size = new System.Drawing.Size(122, 13);
            this.labelSavegame.TabIndex = 19;
            this.labelSavegame.Text = "Файл сохранения";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Enabled = false;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(15, 177);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(159, 21);
            this.comboBoxClass.TabIndex = 18;
            // 
            // labelPlayerClass
            // 
            this.labelPlayerClass.AutoSize = true;
            this.labelPlayerClass.Location = new System.Drawing.Point(10, 161);
            this.labelPlayerClass.Name = "labelPlayerClass";
            this.labelPlayerClass.Size = new System.Drawing.Size(94, 13);
            this.labelPlayerClass.TabIndex = 17;
            this.labelPlayerClass.Text = "Класс игрока";
            // 
            // comboBoxIWAD
            // 
            this.comboBoxIWAD.FormattingEnabled = true;
            this.comboBoxIWAD.Location = new System.Drawing.Point(16, 136);
            this.comboBoxIWAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxIWAD.Name = "comboBoxIWAD";
            this.comboBoxIWAD.Size = new System.Drawing.Size(159, 21);
            this.comboBoxIWAD.TabIndex = 16;
            // 
            // labelIWAD
            // 
            this.labelIWAD.AutoSize = true;
            this.labelIWAD.Location = new System.Drawing.Point(11, 121);
            this.labelIWAD.Name = "labelIWAD";
            this.labelIWAD.Size = new System.Drawing.Size(101, 13);
            this.labelIWAD.TabIndex = 15;
            this.labelIWAD.Text = "Игровой IWAD";
            // 
            // buttonBrowseModsPath
            // 
            this.buttonBrowseModsPath.Location = new System.Drawing.Point(463, 97);
            this.buttonBrowseModsPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBrowseModsPath.Name = "buttonBrowseModsPath";
            this.buttonBrowseModsPath.Size = new System.Drawing.Size(88, 20);
            this.buttonBrowseModsPath.TabIndex = 14;
            this.buttonBrowseModsPath.Text = "Обзор...";
            this.buttonBrowseModsPath.UseVisualStyleBackColor = true;
            this.buttonBrowseModsPath.Click += new System.EventHandler(this.buttonBrowseModsPath_Click);
            // 
            // textBoxModsPath
            // 
            this.textBoxModsPath.Location = new System.Drawing.Point(16, 97);
            this.textBoxModsPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxModsPath.Name = "textBoxModsPath";
            this.textBoxModsPath.Size = new System.Drawing.Size(437, 21);
            this.textBoxModsPath.TabIndex = 13;
            this.textBoxModsPath.TextChanged += new System.EventHandler(this.textBoxModsPath_TextChanged);
            // 
            // labelModsLocation
            // 
            this.labelModsLocation.AutoSize = true;
            this.labelModsLocation.Location = new System.Drawing.Point(11, 82);
            this.labelModsLocation.Name = "labelModsLocation";
            this.labelModsLocation.Size = new System.Drawing.Size(249, 13);
            this.labelModsLocation.TabIndex = 12;
            this.labelModsLocation.Text = "Местонахождение WAD/PK3 файлов";
            this.labelModsLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMapNumber
            // 
            this.numericUpDownMapNumber.Location = new System.Drawing.Point(392, 136);
            this.numericUpDownMapNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownMapNumber.Name = "numericUpDownMapNumber";
            this.numericUpDownMapNumber.Size = new System.Drawing.Size(98, 21);
            this.numericUpDownMapNumber.TabIndex = 9;
            // 
            // labelMapNumber
            // 
            this.labelMapNumber.AutoSize = true;
            this.labelMapNumber.Location = new System.Drawing.Point(387, 121);
            this.labelMapNumber.Name = "labelMapNumber";
            this.labelMapNumber.Size = new System.Drawing.Size(94, 13);
            this.labelMapNumber.TabIndex = 8;
            this.labelMapNumber.Text = "Номер карты";
            // 
            // comboBoxDifficulty
            // 
            this.comboBoxDifficulty.FormattingEnabled = true;
            this.comboBoxDifficulty.Location = new System.Drawing.Point(202, 136);
            this.comboBoxDifficulty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDifficulty.Name = "comboBoxDifficulty";
            this.comboBoxDifficulty.Size = new System.Drawing.Size(159, 21);
            this.comboBoxDifficulty.TabIndex = 7;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Location = new System.Drawing.Point(199, 121);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(80, 13);
            this.labelDifficulty.TabIndex = 6;
            this.labelDifficulty.Text = "Сложность";
            // 
            // buttonBrowseDRPGPath
            // 
            this.buttonBrowseDRPGPath.Location = new System.Drawing.Point(462, 58);
            this.buttonBrowseDRPGPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBrowseDRPGPath.Name = "buttonBrowseDRPGPath";
            this.buttonBrowseDRPGPath.Size = new System.Drawing.Size(88, 20);
            this.buttonBrowseDRPGPath.TabIndex = 5;
            this.buttonBrowseDRPGPath.Text = "Обзор...";
            this.buttonBrowseDRPGPath.UseVisualStyleBackColor = true;
            this.buttonBrowseDRPGPath.Click += new System.EventHandler(this.buttonBrowseDRPGPath_Click);
            // 
            // textBoxDRPGPath
            // 
            this.textBoxDRPGPath.Location = new System.Drawing.Point(15, 58);
            this.textBoxDRPGPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDRPGPath.Name = "textBoxDRPGPath";
            this.textBoxDRPGPath.Size = new System.Drawing.Size(437, 21);
            this.textBoxDRPGPath.TabIndex = 4;
            this.textBoxDRPGPath.TextChanged += new System.EventHandler(this.textBoxDRPGPath_TextChanged);
            // 
            // labelDoomRPGFolderLocation
            // 
            this.labelDoomRPGFolderLocation.AutoSize = true;
            this.labelDoomRPGFolderLocation.Location = new System.Drawing.Point(10, 43);
            this.labelDoomRPGFolderLocation.Name = "labelDoomRPGFolderLocation";
            this.labelDoomRPGFolderLocation.Size = new System.Drawing.Size(264, 13);
            this.labelDoomRPGFolderLocation.TabIndex = 3;
            this.labelDoomRPGFolderLocation.Text = "Местонахождение каталога Doom RPG";
            this.labelDoomRPGFolderLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBrowsePortPath
            // 
            this.buttonBrowsePortPath.Location = new System.Drawing.Point(462, 19);
            this.buttonBrowsePortPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBrowsePortPath.Name = "buttonBrowsePortPath";
            this.buttonBrowsePortPath.Size = new System.Drawing.Size(88, 20);
            this.buttonBrowsePortPath.TabIndex = 2;
            this.buttonBrowsePortPath.Text = "Обзор...";
            this.buttonBrowsePortPath.UseVisualStyleBackColor = true;
            this.buttonBrowsePortPath.Click += new System.EventHandler(this.buttonBrowsePortPath_Click);
            // 
            // textBoxPortPath
            // 
            this.textBoxPortPath.Location = new System.Drawing.Point(15, 19);
            this.textBoxPortPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPortPath.Name = "textBoxPortPath";
            this.textBoxPortPath.Size = new System.Drawing.Size(437, 21);
            this.textBoxPortPath.TabIndex = 1;
            // 
            // labelPortLocation
            // 
            this.labelPortLocation.AutoSize = true;
            this.labelPortLocation.Location = new System.Drawing.Point(10, 4);
            this.labelPortLocation.Name = "labelPortLocation";
            this.labelPortLocation.Size = new System.Drawing.Size(186, 13);
            this.labelPortLocation.TabIndex = 0;
            this.labelPortLocation.Text = "Местонахождение LZDoom";
            this.labelPortLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageMultiplayer
            // 
            this.tabPageMultiplayer.Controls.Add(this.groupBoxServerOptions);
            this.tabPageMultiplayer.Controls.Add(this.groupBoxServerMode);
            this.tabPageMultiplayer.Controls.Add(this.groupBoxMode);
            this.tabPageMultiplayer.Controls.Add(this.checkBoxMultiplayer);
            this.tabPageMultiplayer.Location = new System.Drawing.Point(4, 22);
            this.tabPageMultiplayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMultiplayer.Name = "tabPageMultiplayer";
            this.tabPageMultiplayer.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMultiplayer.Size = new System.Drawing.Size(562, 298);
            this.tabPageMultiplayer.TabIndex = 1;
            this.tabPageMultiplayer.Text = "Мультиплеер";
            this.tabPageMultiplayer.UseVisualStyleBackColor = true;
            // 
            // groupBoxServerOptions
            // 
            this.groupBoxServerOptions.Controls.Add(this.labelDuplicate);
            this.groupBoxServerOptions.Controls.Add(this.numericUpDownDuplicate);
            this.groupBoxServerOptions.Controls.Add(this.checkBoxExtraTics);
            this.groupBoxServerOptions.Location = new System.Drawing.Point(233, 30);
            this.groupBoxServerOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxServerOptions.Name = "groupBoxServerOptions";
            this.groupBoxServerOptions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxServerOptions.Size = new System.Drawing.Size(315, 264);
            this.groupBoxServerOptions.TabIndex = 5;
            this.groupBoxServerOptions.TabStop = false;
            this.groupBoxServerOptions.Text = "Настройки сервера";
            // 
            // labelDuplicate
            // 
            this.labelDuplicate.Location = new System.Drawing.Point(8, 39);
            this.labelDuplicate.Name = "labelDuplicate";
            this.labelDuplicate.Size = new System.Drawing.Size(125, 24);
            this.labelDuplicate.TabIndex = 6;
            this.labelDuplicate.Text = "Дублирование";
            this.labelDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownDuplicate
            // 
            this.numericUpDownDuplicate.Location = new System.Drawing.Point(139, 42);
            this.numericUpDownDuplicate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownDuplicate.Name = "numericUpDownDuplicate";
            this.numericUpDownDuplicate.Size = new System.Drawing.Size(170, 21);
            this.numericUpDownDuplicate.TabIndex = 6;
            // 
            // checkBoxExtraTics
            // 
            this.checkBoxExtraTics.AutoSize = true;
            this.checkBoxExtraTics.Location = new System.Drawing.Point(8, 20);
            this.checkBoxExtraTics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxExtraTics.Name = "checkBoxExtraTics";
            this.checkBoxExtraTics.Size = new System.Drawing.Size(125, 17);
            this.checkBoxExtraTics.TabIndex = 0;
            this.checkBoxExtraTics.Text = "Режим Extratic";
            this.checkBoxExtraTics.UseVisualStyleBackColor = true;
            // 
            // groupBoxServerMode
            // 
            this.groupBoxServerMode.Controls.Add(this.radioButtonPacketServer);
            this.groupBoxServerMode.Controls.Add(this.radioButtonPeerToPeer);
            this.groupBoxServerMode.Location = new System.Drawing.Point(10, 221);
            this.groupBoxServerMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxServerMode.Name = "groupBoxServerMode";
            this.groupBoxServerMode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxServerMode.Size = new System.Drawing.Size(215, 69);
            this.groupBoxServerMode.TabIndex = 4;
            this.groupBoxServerMode.TabStop = false;
            this.groupBoxServerMode.Text = "Режим сервера";
            // 
            // radioButtonPacketServer
            // 
            this.radioButtonPacketServer.AutoSize = true;
            this.radioButtonPacketServer.Location = new System.Drawing.Point(8, 43);
            this.radioButtonPacketServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPacketServer.Name = "radioButtonPacketServer";
            this.radioButtonPacketServer.Size = new System.Drawing.Size(123, 17);
            this.radioButtonPacketServer.TabIndex = 1;
            this.radioButtonPacketServer.TabStop = true;
            this.radioButtonPacketServer.Text = "Клиент-сервер";
            this.radioButtonPacketServer.UseVisualStyleBackColor = true;
            // 
            // radioButtonPeerToPeer
            // 
            this.radioButtonPeerToPeer.AutoSize = true;
            this.radioButtonPeerToPeer.Location = new System.Drawing.Point(8, 19);
            this.radioButtonPeerToPeer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonPeerToPeer.Name = "radioButtonPeerToPeer";
            this.radioButtonPeerToPeer.Size = new System.Drawing.Size(49, 17);
            this.radioButtonPeerToPeer.TabIndex = 0;
            this.radioButtonPeerToPeer.TabStop = true;
            this.radioButtonPeerToPeer.Text = "P2P";
            this.radioButtonPeerToPeer.UseVisualStyleBackColor = true;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.numericUpDownPlayers);
            this.groupBoxMode.Controls.Add(this.labelPlayers);
            this.groupBoxMode.Controls.Add(this.textBoxHostname);
            this.groupBoxMode.Controls.Add(this.radioButtonHosting);
            this.groupBoxMode.Controls.Add(this.radioButtonJoining);
            this.groupBoxMode.Location = new System.Drawing.Point(10, 30);
            this.groupBoxMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMode.Size = new System.Drawing.Size(215, 183);
            this.groupBoxMode.TabIndex = 3;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Режим";
            // 
            // numericUpDownPlayers
            // 
            this.numericUpDownPlayers.Location = new System.Drawing.Point(125, 42);
            this.numericUpDownPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownPlayers.Name = "numericUpDownPlayers";
            this.numericUpDownPlayers.Size = new System.Drawing.Size(79, 21);
            this.numericUpDownPlayers.TabIndex = 8;
            // 
            // labelPlayers
            // 
            this.labelPlayers.Location = new System.Drawing.Point(6, 40);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(113, 23);
            this.labelPlayers.TabIndex = 7;
            this.labelPlayers.Text = "Кол-во игроков";
            this.labelPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(6, 154);
            this.textBoxHostname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(196, 21);
            this.textBoxHostname.TabIndex = 6;
            this.textBoxHostname.Text = "Введите IP-адрес";
            // 
            // radioButtonHosting
            // 
            this.radioButtonHosting.AutoSize = true;
            this.radioButtonHosting.Location = new System.Drawing.Point(8, 19);
            this.radioButtonHosting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonHosting.Name = "radioButtonHosting";
            this.radioButtonHosting.Size = new System.Drawing.Size(54, 17);
            this.radioButtonHosting.TabIndex = 1;
            this.radioButtonHosting.TabStop = true;
            this.radioButtonHosting.Text = "Хост";
            this.radioButtonHosting.UseVisualStyleBackColor = true;
            // 
            // radioButtonJoining
            // 
            this.radioButtonJoining.AutoSize = true;
            this.radioButtonJoining.Location = new System.Drawing.Point(6, 129);
            this.radioButtonJoining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonJoining.Name = "radioButtonJoining";
            this.radioButtonJoining.Size = new System.Drawing.Size(132, 17);
            this.radioButtonJoining.TabIndex = 2;
            this.radioButtonJoining.TabStop = true;
            this.radioButtonJoining.Text = "Присоединиться";
            this.radioButtonJoining.UseVisualStyleBackColor = true;
            // 
            // checkBoxMultiplayer
            // 
            this.checkBoxMultiplayer.AutoSize = true;
            this.checkBoxMultiplayer.Location = new System.Drawing.Point(10, 6);
            this.checkBoxMultiplayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMultiplayer.Name = "checkBoxMultiplayer";
            this.checkBoxMultiplayer.Size = new System.Drawing.Size(109, 17);
            this.checkBoxMultiplayer.TabIndex = 0;
            this.checkBoxMultiplayer.Text = "Игра по сети";
            this.checkBoxMultiplayer.UseVisualStyleBackColor = true;
            // 
            // tabPageModsPatches
            // 
            this.tabPageModsPatches.Controls.Add(this.buttonRefresh);
            this.tabPageModsPatches.Controls.Add(this.checkedListBoxMods);
            this.tabPageModsPatches.Controls.Add(this.labelMods);
            this.tabPageModsPatches.Controls.Add(this.checkedListBoxPatches);
            this.tabPageModsPatches.Controls.Add(this.labelPatches);
            this.tabPageModsPatches.Location = new System.Drawing.Point(4, 22);
            this.tabPageModsPatches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageModsPatches.Name = "tabPageModsPatches";
            this.tabPageModsPatches.Size = new System.Drawing.Size(562, 298);
            this.tabPageModsPatches.TabIndex = 3;
            this.tabPageModsPatches.Text = "Моды/Патчи";
            this.tabPageModsPatches.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(15, 266);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(534, 30);
            this.buttonRefresh.TabIndex = 21;
            this.buttonRefresh.Text = "Перезагрузить список Модов и Патчей";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // checkedListBoxMods
            // 
            this.checkedListBoxMods.FormattingEnabled = true;
            this.checkedListBoxMods.Location = new System.Drawing.Point(267, 17);
            this.checkedListBoxMods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxMods.Name = "checkedListBoxMods";
            this.checkedListBoxMods.Size = new System.Drawing.Size(278, 244);
            this.checkedListBoxMods.TabIndex = 20;
            // 
            // labelMods
            // 
            this.labelMods.AutoSize = true;
            this.labelMods.Location = new System.Drawing.Point(264, 0);
            this.labelMods.Name = "labelMods";
            this.labelMods.Size = new System.Drawing.Size(117, 13);
            this.labelMods.TabIndex = 19;
            this.labelMods.Text = "WAD/PK3 Файлы";
            // 
            // checkedListBoxPatches
            // 
            this.checkedListBoxPatches.FormattingEnabled = true;
            this.checkedListBoxPatches.Location = new System.Drawing.Point(14, 17);
            this.checkedListBoxPatches.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxPatches.Name = "checkedListBoxPatches";
            this.checkedListBoxPatches.Size = new System.Drawing.Size(245, 244);
            this.checkedListBoxPatches.TabIndex = 18;
            // 
            // labelPatches
            // 
            this.labelPatches.AutoSize = true;
            this.labelPatches.Location = new System.Drawing.Point(10, 0);
            this.labelPatches.Name = "labelPatches";
            this.labelPatches.Size = new System.Drawing.Size(115, 13);
            this.labelPatches.TabIndex = 17;
            this.labelPatches.Text = "Патчи Doom RPG";
            // 
            // tabPageCredits
            // 
            this.tabPageCredits.Controls.Add(this.richTextBoxCredits);
            this.tabPageCredits.Location = new System.Drawing.Point(4, 22);
            this.tabPageCredits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageCredits.Name = "tabPageCredits";
            this.tabPageCredits.Size = new System.Drawing.Size(562, 298);
            this.tabPageCredits.TabIndex = 2;
            this.tabPageCredits.Text = "Авторы";
            this.tabPageCredits.UseVisualStyleBackColor = true;
            // 
            // richTextBoxCredits
            // 
            this.richTextBoxCredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCredits.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCredits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxCredits.Name = "richTextBoxCredits";
            this.richTextBoxCredits.ReadOnly = true;
            this.richTextBoxCredits.Size = new System.Drawing.Size(562, 298);
            this.richTextBoxCredits.TabIndex = 0;
            this.richTextBoxCredits.Text = "";
            this.richTextBoxCredits.TextChanged += new System.EventHandler(this.richTextBoxCredits_TextChanged);
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaunch.Location = new System.Drawing.Point(274, 370);
            this.buttonLaunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(296, 35);
            this.buttonLaunch.TabIndex = 6;
            this.buttonLaunch.Text = "Запустить Doom RPG";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // labelCustomCommands
            // 
            this.labelCustomCommands.Location = new System.Drawing.Point(7, 327);
            this.labelCustomCommands.Name = "labelCustomCommands";
            this.labelCustomCommands.Size = new System.Drawing.Size(559, 14);
            this.labelCustomCommands.TabIndex = 7;
            this.labelCustomCommands.Text = "Доп. команды";
            this.labelCustomCommands.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCustomCommands
            // 
            this.textBoxCustomCommands.Location = new System.Drawing.Point(6, 344);
            this.textBoxCustomCommands.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCustomCommands.Name = "textBoxCustomCommands";
            this.textBoxCustomCommands.Size = new System.Drawing.Size(558, 21);
            this.textBoxCustomCommands.TabIndex = 8;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 407);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(570, 26);
            this.statusStrip.TabIndex = 9;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AutoSize = false;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(415, 21);
            this.toolStripStatusLabel.Spring = true;
            this.toolStripStatusLabel.Text = "Готово";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(134, 20);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // buttonCheckUpdates
            // 
            this.buttonCheckUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckUpdates.Location = new System.Drawing.Point(6, 370);
            this.buttonCheckUpdates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCheckUpdates.Name = "buttonCheckUpdates";
            this.buttonCheckUpdates.Size = new System.Drawing.Size(262, 35);
            this.buttonCheckUpdates.TabIndex = 10;
            this.buttonCheckUpdates.Text = "Проверить обновления";
            this.buttonCheckUpdates.UseVisualStyleBackColor = true;
            this.buttonCheckUpdates.Click += new System.EventHandler(this.buttonCheckUpdates_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerPulse
            // 
            this.timerPulse.Enabled = true;
            this.timerPulse.Interval = 10;
            this.timerPulse.Tick += new System.EventHandler(this.timerPulse_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 433);
            this.Controls.Add(this.buttonCheckUpdates);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBoxCustomCommands);
            this.Controls.Add(this.labelCustomCommands);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doom RPG Launcher";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageBasic.ResumeLayout(false);
            this.tabPageBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapNumber)).EndInit();
            this.tabPageMultiplayer.ResumeLayout(false);
            this.tabPageMultiplayer.PerformLayout();
            this.groupBoxServerOptions.ResumeLayout(false);
            this.groupBoxServerOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuplicate)).EndInit();
            this.groupBoxServerMode.ResumeLayout(false);
            this.groupBoxServerMode.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlayers)).EndInit();
            this.tabPageModsPatches.ResumeLayout(false);
            this.tabPageModsPatches.PerformLayout();
            this.tabPageCredits.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

		private global::System.Windows.Forms.Button buttonCopyCommandClipboard;

		private global::System.Windows.Forms.ComboBox comboBoxBranch;

		private global::System.Windows.Forms.Label labelBranch;

		private global::System.Windows.Forms.Button buttonRefresh;

		private global::System.Windows.Forms.Timer timerPulse;
	}
}
