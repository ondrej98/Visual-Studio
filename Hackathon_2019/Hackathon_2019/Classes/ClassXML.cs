using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Hackathon_2019.Classes
{
	public static class ClassXML
	{
		private const char DefaultDivider = '>';
		private const char DefaultFinder = '?';
		private const string DefaultXMLElementName = "_Name";

		/*For inspiration how to use default parameters
		 * private static readonly string[] DefaultTaskHeaderFull = new string[]
		{            
            //RegistrationInfo 
            "RegistrationInfo>Author",
			"RegistrationInfo>Date",
            //Principals
            "Principals>Principal>RunLevel",
			"Principals>Principal>UserId",
            //Triggers
            //My items
            "Triggers>?Trigger>_Name",
			"Triggers>?Trigger>?Schedule>_Name",
			"Triggers>?Trigger>?Schedule>?Interval",
            //Triggers
            "Triggers>?Trigger>Enabled",
			"Triggers>?Trigger>StartBoundary",
			"Triggers>?Trigger>EndBoundary",
			"Triggers>?Trigger>ExecutionTimeLimit",
			"Triggers>?Trigger>Repetition>Interval",
			"Triggers>?Trigger>Repetition>Duration",
			"Triggers>?Trigger>Repetition>StopAtDurationEnd",
            //Actions
            "Actions>Exec>Command",
			"Actions>Exec>Arguments",
			"Actions>Exec>WorkingDirectory",
            //Settings 
            "Settings>Enabled",
			"Settings>RunOnlyIfIdle",
			"Settings>IdleSettings>Duration",
			"Settings>IdleSettings>WaitTimeout",
			"Settings>IdleSettings>StopOnIdleEnd",
			"Settings>IdleSettings>RestartOnIdle",
			"Settings>AllowStartOnDemand",
			"Settings>RestartOnFailure",
			"Settings>MultipleInstancesPolicy",
			"Settings>DisallowStartIfOnBatteries",
			"Settings>StopIfGoingOnBatteries",
			"Settings>AllowHardTerminate",
			"Settings>StartWhenAvailable",
			"Settings>RunOnlyIfNetworkAvailable",
			"Settings>WakeToRun",
			"Settings>Hidden",
			"Settings>DeleteExpiredTaskAfter",
			"Settings>ExecutionTimeLimit",
			"Settings>Priority",
			"Settings>NetworkSettings",
			"Settings>UseUnifiedSchedulingEngine",
			"Settings>DisallowStartOnRemoteAppSession"
		};*/

		private static XElement ReturnChildElement(XElement parent, string elementName)
		{
			XElement child = null;

			if (parent != null && parent.Elements().Count() > 0)
			{
				foreach (XElement children in parent.Elements())
				{
					if (children.Name.LocalName == elementName)
					{
						child = children;
						break;
					}
				}
			}
			return child;
		}

		private static XElement ReturnElement(XElement parent, string elementName)
		{
			XElement child = null;

			if (parent != null && parent.Elements().Count() > 0)
			{
				XNamespace ns = parent.Name.NamespaceName;
				child = parent.Element(ns + elementName);
			}
			return child;
		}

		private static XElement ReturnElement(XElement parent, string partialElementName, bool find)
		{
			XElement child = null;

			if (parent != null && parent.Elements().Count() > 0)
			{
				foreach (XElement element in parent.Elements())
				{
					if (element.Name.LocalName.Contains(partialElementName) && find)
					{
						child = element;
						break;
					}
				}
			}
			return child;
		}

		private static string[] GetDataFromXElement(XElement element, string[] filterElementNames)
		{
			string[] result = new string[filterElementNames.Length];
			int index = 0;
			foreach (string filter in filterElementNames)
			{
				string[] filterData = filter.Split(DefaultDivider);
				if (filterData[0] == element.Name.LocalName)
				{
					string[] finderData = null;
					XElement child = null;
					XElement grandChild = null;
					XElement praGrandChild = null;
					switch (filterData.Length)
					{
						default:

							break;

						case 2:
							//child = ReturnChildElement(element, cycleData[1]);
							finderData = filterData[1].Split(DefaultFinder);
							if (finderData.Length > 1)
							{
								child = ReturnElement(element, finderData[1], true);
							}
							else
							{
								child = ReturnElement(element, filterData[1]);
							}
							if (child != null)
							{
								result[index] = child.Value.ToString();
							}
							if (element != null && (finderData.Length > 1 && finderData[1] == DefaultXMLElementName || finderData[0] == DefaultXMLElementName))
								result[index] = element.Name.LocalName;
							break;

						case 3:
							//child = ReturnElement(element, filterData[1]);
							finderData = filterData[1].Split(DefaultFinder);
							if (finderData.Length > 1)
							{
								child = ReturnElement(element, finderData[1], true);
							}
							else
							{
								child = ReturnElement(element, filterData[1]);
							}
							//grandChild = ReturnElement(child, filterData[2]);
							finderData = filterData[2].Split(DefaultFinder);
							if (finderData.Length > 1)
							{
								grandChild = ReturnElement(child, finderData[1], true);
							}
							else
							{
								grandChild = ReturnElement(child, filterData[2]);
							}
							if (grandChild != null)
							{
								result[index] = grandChild.Value.ToString();
							}
							if (child != null && (finderData.Length > 1 && finderData[1] == DefaultXMLElementName || finderData[0] == DefaultXMLElementName))
								result[index] = child.Name.LocalName;
							break;

						case 4:
							//child = ReturnElement(element, filterData[1]);
							finderData = filterData[1].Split(DefaultFinder);
							if (finderData.Length > 1)
							{
								child = ReturnElement(element, finderData[1], true);
							}
							else
							{
								child = ReturnElement(element, filterData[1]);
							}
							//grandChild = ReturnElement(child, filterData[2]);
							finderData = filterData[2].Split(DefaultFinder);
							if (finderData.Length > 1)
							{
								grandChild = ReturnElement(child, finderData[1], true);
							}
							else
							{
								grandChild = ReturnElement(child, filterData[2]);
							}
							//praGrandChild = ReturnElement(grandChild, filterData[3]);
							finderData = filterData[3].Split(DefaultFinder);
							if (finderData.Length > 1)
							{
								praGrandChild = ReturnElement(grandChild, finderData[1], true);
							}
							else
							{
								praGrandChild = ReturnElement(grandChild, filterData[3]);
							}
							if (praGrandChild != null)
							{
								result[index] = praGrandChild.Value.ToString();
							}
							if (grandChild != null && (finderData.Length > 1 && finderData[1] == DefaultXMLElementName || finderData[0] == DefaultXMLElementName))
								result[index] = grandChild.Name.LocalName;
							break;
					}
				}
				index++;
			}
			return result;
		}
	}

	/*Something for backup
	public class XmlSave
	{
		public static void SaveData(object IClass, string filename)
		{
			StreamWriter writer = null;
			try
			{
				XmlSerializer xmlSerializable = new XmlSerializer((IClass.GetType()));
				writer = new StreamWriter(filename);
				xmlSerializable.Serialize(writer, IClass);
			}
			finally
			{
				if (writer != null)
					writer.Close();
				writer = null;
			}
		}
	}

	public class XmlLoad<T>
	{
		public static Type type;

		public XmlLoad()
		{
			type = typeof(T);
		}

		public T LoadData(string filename)
		{
			T result;
			XmlSerializer xmlSerializer = new XmlSerializer(type);
			FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
			result = (T)xmlSerializer.Deserialize(fs);
			fs.Close();
			return result;
		}
	}

	public class Datafile
	{
		private string key;
		private string salt;
		private string text;
		private string other;
		public string Key
		{
			get { return key; }
			set { key = value; }
		}

		public string Salt
		{
			get { return salt; }
			set { salt = value; }
		}

		public string Text
		{
			get { return text; }
			set { text = value; }
		}

		public string Other
		{
			get { return other; }
			set { other = value; }
		}
	}

	//Load xml file
	{
			Datafile datafile = new Datafile();
			XmlLoad<Datafile> xmlLoad = new XmlLoad<Datafile>();
			datafile = xmlLoad.LoadData(openFileDialog1.FileName);
	}

	//Save xml file
	{
			Datafile datafile = new Datafile();
			datafile.Key = richTextBoxKey.Text;
			datafile.Salt = richTextBoxSalt.Text;
			datafile.Text = richTextBoxText.Text;
			datafile.Other = encrypt.ToString();
			XmlSave.SaveData(datafile, saveFileDialog1.FileName);
	}

	*/
}
