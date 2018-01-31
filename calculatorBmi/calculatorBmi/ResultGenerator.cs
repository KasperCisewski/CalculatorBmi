using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculatorBmi.pages;

namespace calculatorBmi
{
    public class ResultGenerator
    {

        public static async Task<List<Result>> CreateResults(Person per)
        {
            List<Result> results = new List<Result>();
            for (int i = 0; i < per.ResultList.Count; i++)
            {
                DateTime date = per.ResultList[i].DateTime;
                double result = per.ResultList[i].result;
                Result resultObject = new Result();
                resultObject.DateTime = date;
                resultObject.result = result;
                results.Add(resultObject);

            }
            return results;
        }
    }

  
}
