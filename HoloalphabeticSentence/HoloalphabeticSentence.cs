using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
			string str = input.ToLower();
			Boolean flag = true;
			foreach (char c  in alphabets) {
				if ((str.IndexOf(c) == -1)) {
					flag = false;
					break;
				}
			}

            return flag;
        }
    }
}
