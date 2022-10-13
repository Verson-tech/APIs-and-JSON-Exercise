using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        public static void KanyeWords()
        {
            //1-st API:
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            object kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Kanye: {kanyeQuote}");
            Console.WriteLine("\n-------------");
        }
        public static void RonWords()
        {
            //2-d API:
            var client1 = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client1.GetStringAsync(ronURL).Result;
            object ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine($"Ron: {ronQuote}");
            Console.WriteLine("\n-------------");
        }
        public static void RonKaneyConverstaion()
        {
            Console.WriteLine("How many Kanye vs. Ron qoutes would you like to see?");
            var conversation = true;
            var conversationlength = Int32.Parse(Console.ReadLine());
            while (conversation)
            {
                Console.WriteLine("\nKanye and Ron are speaking:");
                for (int i = 0; i < conversationlength; i++)
                {
                    Console.WriteLine($"\n{i + 1}:");
                    QuoteGenerator.KanyeWords();
                    QuoteGenerator.RonWords();
                }
                break;
            }
        }
        
    }
}

