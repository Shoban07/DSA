using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLQuestions
{
	class Program
	{
		public Dictionary<string, int> url = new Dictionary<string, int>();
		public Dictionary<int, string> revUrl = new Dictionary<int, string>();
		string BaseURL = "http://tinyurl.com/";
		int count = 0;
		public string encode(string longUrl)
		{
			int outputKey = 0;
			if (!url.ContainsKey(longUrl))
			{
				count++;
				url.Add(longUrl, count);
				revUrl.Add(count, longUrl);
				url.TryGetValue(longUrl, out outputKey);
			}
			return BaseURL+outputKey.ToString();
		}
		public string decode(string shrtUrl)
		{
			string resultFullUrl = string.Empty;
			if (!string.IsNullOrEmpty(shrtUrl)&&!string.IsNullOrWhiteSpace(shrtUrl))
			{
				int code = int.Parse(shrtUrl.Substring(shrtUrl.LastIndexOf('/') + 1));
				revUrl.TryGetValue(code, out resultFullUrl);
			}
			return resultFullUrl;
		}
		static void Main(string[] args)
		{
			Program pg = new Program();
			Console.WriteLine(pg.encode("https://leetcode.com/problems/design-tinyurl"));
			Console.WriteLine(pg.decode("http://tinyurl.com/1"));
			Console.ReadKey();
		}
	}
}
