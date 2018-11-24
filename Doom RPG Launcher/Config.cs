using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DoomRPG
{
	public class Config
	{
		public void Save()
		{
			List<string> list = new List<string>();
			try
			{
				foreach (FieldInfo fieldInfo in base.GetType().GetFields())
				{
					if (fieldInfo.GetValue(this).GetType() == typeof(bool[]))
					{
						bool[] array = (bool[])fieldInfo.GetValue(this);
						string text = fieldInfo.Name + "=";
						for (int j = 0; j < array.Length; j++)
						{
							text = text + array[j].ToString() + ",";
						}
						list.Add(text.Substring(0, text.Length - 1));
					}
					else if (fieldInfo.GetValue(this).GetType() == typeof(List<string>))
					{
						List<string> list2 = (List<string>)fieldInfo.GetValue(this);
						string text2 = fieldInfo.Name + "=";
						foreach (string str in list2)
						{
							text2 = text2 + "{" + str + "};";
						}
						if (text2[text2.Length - 1] == ';')
						{
							text2 = text2.Remove(text2.Length - 1);
						}
						list.Add(text2);
					}
					else
					{
						list.Add(fieldInfo.Name + "=" + fieldInfo.GetValue(this));
					}
				}
				File.WriteAllLines(this.path, list);
			}
			catch (Exception e)
			{
				Utils.ShowError(e);
			}
		}

		public void Load()
		{
			try
			{
				if (File.Exists(this.path))
				{
					FieldInfo[] fields = base.GetType().GetFields();
					string[] array = File.ReadAllLines(this.path);
					for (int i = 0; i < array.Length; i++)
					{
						string text = array[i];
						string[] s = text.Split(new char[]
						{
							'='
						});
						if (s.Length == 2)
						{
							FieldInfo fieldInfo = fields.FirstOrDefault((FieldInfo o) => o.Name == s[0]);
							if (fieldInfo != null)
							{
								if (fieldInfo.GetValue(this).GetType() == typeof(bool))
								{
									fieldInfo.SetValue(this, bool.Parse(s[1]));
								}
								if (fieldInfo.GetValue(this).GetType() == typeof(int))
								{
									fieldInfo.SetValue(this, int.Parse(s[1]));
								}
								if (fieldInfo.GetValue(this).GetType() == typeof(float))
								{
									fieldInfo.SetValue(this, float.Parse(s[1]));
								}
								if (fieldInfo.GetValue(this).GetType() == typeof(string))
								{
									fieldInfo.SetValue(this, s[1]);
								}
								if (fieldInfo.GetValue(this).GetType() == typeof(List<string>))
								{
									List<string> list = new List<string>();
									string[] array2 = s[1].Split(new char[]
									{
										';'
									});
									if (array2.Length != 0 && array2[0] != string.Empty)
									{
										foreach (string text2 in array2)
										{
											list.Add(text2.Trim(new char[]
											{
												'{',
												'}'
											}));
										}
									}
									fieldInfo.SetValue(this, list);
								}
								if (fieldInfo.GetValue(this).GetType() == typeof(IWAD))
								{
									for (int k = 0; k < Enum.GetNames(typeof(IWAD)).Length; k++)
									{
										if (Enum.GetNames(typeof(IWAD))[k].Contains(s[1]))
										{
											fieldInfo.SetValue(this, Enum.ToObject(typeof(IWAD), k));
										}
									}
								}
								if (fieldInfo.GetValue(this).GetType() == typeof(Difficulty))
								{
									for (int l = 0; l < Enum.GetNames(typeof(Difficulty)).Length; l++)
									{
										if (Enum.GetNames(typeof(Difficulty))[l].Contains(s[1]))
										{
											fieldInfo.SetValue(this, Enum.ToObject(typeof(Difficulty), l));
										}
									}
								}
								if (fieldInfo.GetValue(this).GetType() == typeof(DRLAClass))
								{
									for (int m = 0; m < Enum.GetNames(typeof(DRLAClass)).Length; m++)
									{
										if (Enum.GetNames(typeof(DRLAClass))[m].Contains(s[1]))
										{
											fieldInfo.SetValue(this, Enum.ToObject(typeof(DRLAClass), m));
										}
									}
								}
								if (fieldInfo.GetValue(this).GetType() == typeof(MultiplayerMode))
								{
									for (int n = 0; n < Enum.GetNames(typeof(MultiplayerMode)).Length; n++)
									{
										if (Enum.GetNames(typeof(MultiplayerMode))[n].Contains(s[1]))
										{
											fieldInfo.SetValue(this, Enum.ToObject(typeof(MultiplayerMode), n));
										}
									}
								}
								if (fieldInfo.GetValue(this).GetType() == typeof(ServerType))
								{
									for (int num = 0; num < Enum.GetNames(typeof(ServerType)).Length; num++)
									{
										if (Enum.GetNames(typeof(ServerType))[num].Contains(s[1]))
										{
											fieldInfo.SetValue(this, Enum.ToObject(typeof(ServerType), num));
										}
									}
								}
							}
						}
					}
				}
				else
				{
					this.Save();
				}
			}
			catch (Exception e)
			{
				Utils.ShowError(e);
			}
		}

		public Config()
		{
		}

		private string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + Assembly.GetEntryAssembly().GetName().Name + ".cfg";

		public string portPath = string.Empty;

		public string DRPGPath = string.Empty;

		public string modsPath = string.Empty;

		public IWAD iwad = IWAD.Doom2;

		public Difficulty difficulty = Difficulty.Normal;

		public DRLAClass rlClass;

		public int mapNumber = 1;

		public string demo = string.Empty;

		public bool enableCheats;

		public bool enableLogging;

		public List<string> patches = new List<string>();

		public List<string> mods = new List<string>();

		public string customCommands = string.Empty;

		public bool multiplayer;

		public MultiplayerMode multiplayerMode;

		public ServerType serverType;

		public int players = 2;

		public string hostname = string.Empty;

		public bool extraTics;

		public int duplicate = 1;

		public bool wipeWarning;
	}
}
