using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Fallout4_QA
{
	class RunQA
	{
		#region CSS for HTML
		static string cssHTML = @"
        .right {
            text-align: right;
            font-size:10px;
            font-family:Verdana;
        }

        table p {
            padding: 0px 4px 0px 4px;
        }

        .category p {
            padding: 15px 15px 15px 15px;
            font-size: 16px;
            color: #888888;
        }

        table {
            position:relative;
            font-family: Verdana;
            font-size:11px;
            background-color: #CCCCCC;
            width: 95%;
            margin: 0px auto 25px auto;
            font-weight: normal;
        }

        .container {
            margin: 0 10px 0 10px;
        }

        .category {
            margin: 5px;
            background: #FAFAFA;
            font-family: Verdana;
            font-size: 12px;
            font-weight: bold;
        }

        .tables {
            margin: 0 auto 0 auto;
        }

        .info {
            font-size:11px;
            background-color: #EEFFEE;
        }

        .idcol {
            font-size:10px;
            width:130px;
        }

        .textcol {
            font-size:10px;
            width:300px;
        }

        .info2 {
            font-size: 11px;
            background-color: #FFFFFF;
            margin: 0 10px 0 0;
            padding: 0 10px 0 0;
        }

        .source {
            background-color: #CCFFCC;
        }

        .sourceWords {
            background-color: #F0E6F0;
        }

        .target {
            background-color: #FFFFAA;
        }

        .header {
            font-family: Verdana;
            font-size:13px;
        }

        .heading {
            font-family: Verdana;
            font-size:13px;
            color:#487976;
            font-wight:bold;
            text-align:center;
        }

        .high{
            color: #FA2823;
            background-color:yellow;
        }

        .high2{
            background-color:#F8FC83;
        }

        .error{
            background-color: #FFC05C;
            color: #FA2823;
        }

        .consistencyError{
            color:#CC0000
        }

        .tag{
            background-color: #42b6ff;
            color: #FFFFFF
        }";
		#endregion

		public static void Process(string inputFolderPath, string glossaryFilePath, string outputFolderPath, MainForm form)
		{
			List<string> source_checks = new List<string>();
			List<string> target_checks = new List<string>();

			using (var reader = new StreamReader(glossaryFilePath))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var values = line.Split('\t');

					source_checks.Add(values[0]);
					target_checks.Add(values[1]);
				}
			}

			if (source_checks.Count == target_checks.Count)
			{
				
				DirectoryInfo d = new DirectoryInfo(inputFolderPath);
				
				foreach (var file in d.GetFiles("*.xml"))
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(file.FullName);
					XmlNode XmlContent = doc.DocumentElement.SelectSingleNode("/SSTXMLRessources/Content");
					XmlNodeList strings = XmlContent.SelectNodes("//String");
					int stringCount = XmlContent.SelectNodes("//String").Count;

					StringWriter stringWriter = new StringWriter();

					using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter))
					{
						writer.RenderBeginTag("!DOCTYPE html");
						writer.Indent--;

						writer.RenderBeginTag(HtmlTextWriterTag.Html);

						#region Head
						writer.RenderBeginTag(HtmlTextWriterTag.Head);

						#region Meta
						writer.AddAttribute("charset", "utf-8");
						writer.RenderBeginTag(HtmlTextWriterTag.Meta);
						writer.RenderEndTag();
						#endregion

						#region Title
						writer.WriteLine();
						writer.RenderBeginTag(HtmlTextWriterTag.Title);
						writer.Write(file.Name);
						writer.RenderEndTag();
						#endregion

						#region CSS
						writer.WriteLine();
						writer.RenderBeginTag(HtmlTextWriterTag.Style);
						writer.Write(cssHTML);
						writer.RenderEndTag();
						#endregion

						writer.RenderEndTag();
						#endregion

						writer.WriteLine();

						#region Body
						writer.RenderBeginTag(HtmlTextWriterTag.Body);

						writer.AddAttribute(HtmlTextWriterAttribute.Class, "container");
						writer.RenderBeginTag(HtmlTextWriterTag.Div);

						writer.AddAttribute(HtmlTextWriterAttribute.Class, "tables");
						writer.RenderBeginTag(HtmlTextWriterTag.Div);

						form.setMaxValueProgressBar(source_checks.Count);
						for (int i = 0; i < source_checks.Count; i++)
						{
							form.setValueProgressBar(i + 1);
							int stringIdInCheck = 0;
							int checkIssues = 0;

							foreach (XmlNode sString in strings)
							{
								string sID = sString.SelectSingleNode("@sID").Value;
								string EDID = sString.SelectSingleNode("EDID").InnerText;
								string REC = sString.SelectSingleNode("REC").InnerText;
								string source = sString.SelectSingleNode("Source").InnerText;
								string target = sString.SelectSingleNode("Dest").InnerText;
								if (Regex.IsMatch(source, source_checks[i]) && !Regex.IsMatch(target, target_checks[i]))
								{
									if (checkIssues < 1)
									{
										writer.WriteBeginTag("div");
										writer.WriteAttribute("class", "category");
										writer.Write(HtmlTextWriter.TagRightChar);

										writer.WriteLine();
										writer.RenderBeginTag(HtmlTextWriterTag.P);
										writer.Write((i + 1).ToString() + ". " + source_checks[i] + " – " + target_checks[i]);
										writer.RenderEndTag();

										writer.WriteLine();
										writer.WriteBeginTag("table");
										writer.Write(HtmlTextWriter.TagRightChar);

										#region Header
										writer.WriteLine();
										writer.AddAttribute(HtmlTextWriterAttribute.Class, "info");
										writer.RenderBeginTag(HtmlTextWriterTag.Tr);

										writer.AddAttribute(HtmlTextWriterAttribute.Class, "idcol");
										writer.RenderBeginTag(HtmlTextWriterTag.Th);
										writer.Write("sID");
										writer.RenderEndTag();

										writer.WriteLine();
										writer.RenderBeginTag(HtmlTextWriterTag.Th);
										writer.Write("EDID");
										writer.RenderEndTag();

										writer.WriteLine();
										writer.RenderBeginTag(HtmlTextWriterTag.Th);
										writer.Write("REC");
										writer.RenderEndTag();

										writer.WriteLine();
										writer.RenderBeginTag(HtmlTextWriterTag.Th);
										writer.Write("Source");
										writer.RenderEndTag();

										writer.WriteLine();
										writer.RenderBeginTag(HtmlTextWriterTag.Th);
										writer.Write("Target");
										writer.RenderEndTag();

										writer.RenderEndTag();
										#endregion
									}

									writer.WriteLine();
									writer.AddAttribute(HtmlTextWriterAttribute.Class, "info2");
									writer.RenderBeginTag(HtmlTextWriterTag.Tr);

									writer.AddAttribute(HtmlTextWriterAttribute.Class, "idcol");
									writer.RenderBeginTag(HtmlTextWriterTag.Td);
									writer.Write(sID);
									writer.RenderEndTag();

									writer.WriteLine();
									writer.RenderBeginTag(HtmlTextWriterTag.Td);
									writer.Write(EDID);
									writer.RenderEndTag();

									writer.WriteLine();
									writer.RenderBeginTag(HtmlTextWriterTag.Td);
									writer.Write(REC);
									writer.RenderEndTag();

									writer.WriteLine();
									writer.AddAttribute(HtmlTextWriterAttribute.Class, "source");
									writer.RenderBeginTag(HtmlTextWriterTag.Td);
									writer.Write(source);
									writer.RenderEndTag();

									writer.WriteLine();
									writer.AddAttribute(HtmlTextWriterAttribute.Class, "target");
									writer.RenderBeginTag(HtmlTextWriterTag.Td);
									writer.Write(target);
									writer.RenderEndTag();

									writer.RenderEndTag();

									checkIssues++;
								}

								stringIdInCheck++;
								if ((checkIssues > 0) && (stringIdInCheck == stringCount))
								{
									writer.WriteLine();
									writer.WriteEndTag("table");

									writer.WriteLine();
									writer.WriteEndTag("div");
								}

							}
						}

						writer.RenderEndTag();

						writer.RenderEndTag();

						writer.RenderEndTag();
						#endregion

						writer.RenderEndTag();
					}

					stringWriter.Close();
					string outputFilePath = string.Format("{0}{1}{2}{3}", outputFolderPath, @"\",  file.Name, ".F4_QA_report.html");
					File.WriteAllText(outputFilePath, stringWriter.ToString());
				}

				int numberOfProcessedFiles = d.GetFiles("*.xml").Length;
				MessageBox.Show(string.Format("{0} {1} {2}!", "Successfully run through", numberOfProcessedFiles, (numberOfProcessedFiles == 1) ? "file" : "files"));
				form.setValueProgressBar(0);
			}
		}
	}
}
