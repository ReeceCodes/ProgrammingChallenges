using System;
using System.Collections.Generic;

namespace Challenge395
{
    public class Challenge395Class
    {
        //input is array of binary values (0,1), count sequences of 1 and reset when given 0, return array of counts of sequences
        public Array nonogram(Array input)
        {
            int counter = 0;
            List<int> retValue = new List<int>(); //this is easier than using a new array if I don't know the length of output??, can return .ToArray()

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length == 0)
                {
                    return retValue.ToArray();
                }

                if (input.GetValue(i).ToString() == "1")
                {
                    counter++;
                }
                else if (input.GetValue(i).ToString() == "0" && counter > 0)
                {
                    retValue.Add(counter);

                    counter = 0;
                }

            //if the final number is a 1 this is needed. 
            //example: all 1, or multiple things ending with a 1. need something to add that final count to the list, check against the end of the input list
                if (input.Length-1 == i && counter > 0)
                {
                    retValue.Add(counter);
                }
            }

            return retValue.ToArray();
        }
         
        //first function that just let tests be set up, did pass for the first two inputs
        public Array nonogram1(Array input)
        {            
            return new int[] { };
        }
    }
}
