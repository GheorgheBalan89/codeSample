using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemo
{
    public class CharTest
    {
        public  List<int> balancedOrNot(List<string> expressions, List<int> maxReplacements)
        {

            List<int> response = new List<int>();
            if (!maxReplacements.Any())
            {
                return response;
            }

            for (int i = 0; i < maxReplacements.Count; i++)
            {

                var expression = expressions[i];
                if (maxReplacements[i] > Math.Pow(10, 2))
                {
                    response.Add(0);
                    continue;
                }
                if (expression.EndsWith("<"))
                {
                    response.Add(0);
                    continue;
                }

                if ( expression.Length > Math.Pow(10, 5) || expression.Length < 1)
                {
                    response.Add(0);
                    continue;
                }

                if (maxReplacements[i] > Math.Pow(10, 5) || maxReplacements[i] < 0)
                {
                    response.Add(0);
                    continue;
                } 

                int greaterThanCount = expression.Count(x => x == '>');
                int lesserThanCount = expression.Count(x => x == '<');


                if (greaterThanCount == lesserThanCount)
                {
                    response.Add(1);
                }
                else
                {
                    if (lesserThanCount > greaterThanCount)
                    {
                        response.Add(0);
                    }
                   
                    else
                    {

                        var diff = greaterThanCount - lesserThanCount;
                        if (diff < 0)
                        {
                            response.Add(0);
                        }
                        else
                        {
                            response.Add(maxReplacements[i] >= diff ? 1 : 0);
                        }

                    }

                }


            }

            return response;
        }
    }
}
