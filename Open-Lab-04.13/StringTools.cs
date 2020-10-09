using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            //First must be longer than second
            if (str2.Length > str1.Length)
            {
                string str1copy = str1;
                str1 = str2;
                str2 = str1copy;  
            }
               
            string longest = "";
            for (int y = 0; y < str1.Length; y++)
            {
                string temp = "";
                int index = 0;
                for (int x = 0; x < str2.Length; x++)
                {
                    
                    if (y+index < str1.Length && str1[y+index] == str2[x])
                    {
                        temp += str2[x];
                        index++;
                    }
                    else
                    {
                        if (longest.Length < temp.Length)
                            longest = temp;
                        index = 0;
                        temp = "";
                    }
                   
                }
                if (longest.Length < temp.Length)
                    longest = temp;
            }
            return longest;
        }
    }
}
