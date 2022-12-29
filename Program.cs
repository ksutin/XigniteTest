using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XigniteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new getQuotes();
            c.GetGCTQuotes();
            c.GetGCTDelayedQuotes();
        }
    }

    public class getQuotes
    {
        xHist.XigniteGlobalHistorical api = new xHist.XigniteGlobalHistorical();
        xGlobalDelayed.XigniteGlobalQuotes xService = new xGlobalDelayed.XigniteGlobalQuotes();

        public void GetGCTQuotes()
        {

            xHist.GlobalHistoricalQuote[] call = api.GetGlobalHistoricalQuotes("GCT", "Symbol", null, "None", "12/27/2022");

            for (int i = 0; i < call.Count(); i++)
            {
                var Outcome = call[i].Outcome + call[i].Message;
            }
            
        }

        public void GetGCTDelayedQuotes()
        {

            xGlobalDelayed.GlobalQuote[] call = xService.GetGlobalDelayedQuotes("GCT", xGlobalDelayed.IdentifierTypes.Symbol);

            for (int i = 0; i < call.Count(); i++)
            {
                var Outcome = call[i].Outcome + call[i].Message;
            }

        }

    }

}
