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
			return alphabets.All(c => str.Contains(c));
		}
    }
}
