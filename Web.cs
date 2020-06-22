using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

using DkpOverlay.Properties;
using HtmlAgilityPack;

namespace DkpOverlay
{
	public class Web
	{
		public string SessionID { get; set; }

		private Uri Domain = new Uri(Settings.Default.CookieDomain);

		public HtmlDocument GetHtmlDoc()
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Settings.Default.DkpUrl);
			request.CookieContainer = new CookieContainer();
			request.CookieContainer.Add(Domain,
				new Cookie(Settings.Default.CookieID, SessionID));

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			if(response.StatusCode == HttpStatusCode.OK)
			{
				using(StreamReader sr = new StreamReader(response.GetResponseStream()))
				{
					var doc = new HtmlDocument();
					doc.LoadHtml(sr.ReadToEnd());
					return doc;
				}
			}

			return null;
		}

		public string GetDkp(HtmlDocument doc)
		{
			// this code be made a lot easier with IDs set on these table cells.
			return doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/table[1]/tr[2]/td[2]/table[2]/tr[2]/td[1]/table[1]/tr[2]/td[4]").InnerText;
		}

		public string GetRA(HtmlDocument doc)
		{
			// this code be made a lot easier with IDs set on these table cells.
			return doc.DocumentNode.SelectSingleNode("/html[1]/body[1]/table[1]/tr[2]/td[2]/table[2]/tr[2]/td[1]/table[1]/tr[2]/td[7]").InnerText;
		}

		public string GetSessionId(string userName, string password)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Settings.Default.LoginUrl);
			request.Method = "POST";
			string postData = $"tUserName={userName}&tPassword={password}";
			byte[] byteArray = Encoding.UTF8.GetBytes(postData);
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = byteArray.Length;
			Stream dataStream = request.GetRequestStream();
			
			dataStream.Write(byteArray, 0, byteArray.Length);

			dataStream.Close();

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			if(response.StatusCode == HttpStatusCode.OK)
			{
				string setCookie = response.Headers["Set-Cookie"];
				string[] cookies = setCookie.Split(';');

				if(cookies.Length > 0)
				{
					for(int i = 0; i < cookies.Length; i++)
					{
						if(cookies[i].StartsWith(Settings.Default.CookieID))
						{
							return cookies[i].Split('=')[1];
						}
					}
				}
			}
			
			return string.Empty;
		}
	}
}
