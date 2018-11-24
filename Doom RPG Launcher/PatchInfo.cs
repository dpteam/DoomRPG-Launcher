using System;
using System.Collections.Generic;
using System.IO;

namespace DoomRPG
{
	public class PatchInfo
	{
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		public List<string> Conflicts
		{
			get
			{
				return this.conflicts;
			}
		}

		public List<string> Requires
		{
			get
			{
				return this.requires;
			}
		}

		public string Path
		{
			get
			{
				return this.path;
			}
		}

		public bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				this.enabled = value;
			}
		}

		public static PatchInfo ReadPatch(string path)
		{
			PatchInfo patchInfo = new PatchInfo();
			patchInfo.path = System.IO.Path.GetDirectoryName(path);
			if (File.Exists(path))
			{
				string[] array = File.ReadAllLines(path);
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(new char[]
					{
						'='
					});
					if (array2.Length == 2)
					{
						if (array2[0].ToLower() == "name")
						{
							patchInfo.name = array2[1];
						}
						if (array2[0].ToLower() == "conflicts")
						{
							patchInfo.conflicts.Add(array2[1]);
						}
						if (array2[0].ToLower() == "requires")
						{
							patchInfo.requires.Add(array2[1]);
						}
					}
				}
				return patchInfo;
			}
			Utils.ShowError("Недопустимый путь патча\n\n" + path, "Ошибка");
			return null;
		}

		public static bool CheckForRequirements(List<PatchInfo> patches)
		{
			string text = string.Empty;
			bool flag = false;
			for (int i = 0; i < patches.Count; i++)
			{
				if (patches[i].Enabled)
				{
					for (int j = 0; j < patches.Count; j++)
					{
						for (int k = 0; k < patches[i].Requires.Count; k++)
						{
							if (patches[i].Requires[k].ToLower() == patches[j].Name.ToLower() && !patches[j].Enabled)
							{
								text = string.Concat(new string[]
								{
									text,
									"Патч ",
									patches[i].name,
									" требует патч ",
									patches[j].name,
									"\n"
								});
								flag = true;
							}
						}
					}
				}
			}
			if (flag)
			{
				Utils.ShowError(text.TrimEnd(new char[]
				{
					'\n'
				}), "Конфликт патчей");
				return false;
			}
			return true;
		}

		public static bool CheckForConflicts(List<PatchInfo> patches)
		{
			string text = string.Empty;
			bool flag = false;
			for (int i = 0; i < patches.Count; i++)
			{
				if (patches[i].Enabled)
				{
					for (int j = 0; j < patches.Count; j++)
					{
						if (patches[j].Enabled)
						{
							for (int k = 0; k < patches[j].Conflicts.Count; k++)
							{
								if (patches[j].Conflicts[k].ToLower() == patches[i].Name.ToLower())
								{
									text = string.Concat(new string[]
									{
										text,
										"Патч ",
										patches[i].name,
										" конфликтует с патчем ",
										patches[j].name,
										"\n"
									});
									flag = true;
								}
							}
						}
					}
				}
			}
			if (flag)
			{
				Utils.ShowError(text.TrimEnd(new char[]
				{
					'\n'
				}), "Конфликт патчей");
				return false;
			}
			return true;
		}

		public override string ToString()
		{
			return this.name;
		}

		public PatchInfo()
		{
		}

		private string name;

		private List<string> conflicts = new List<string>();

		private List<string> requires = new List<string>();

		private string path;

		private bool enabled;
	}
}
