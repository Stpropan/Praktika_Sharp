using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;

namespace ClassLibrary
{
    public class Quant_Uniq
    {
        private Regex reg_exp = new Regex("[\u002D\u0022\\.?!—,;:()\u000A]|('[^A-Za-z0-9]|[^A-Za-z0-9]')");

        [UniqContent]
        private void UniqContent(ReadTextFile txt)
        {
            txt = reg_exp.Replace(txt, " ");
            txt = txt.ToLower();
            string[] str_words = txt.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            Quant_Uniq Aizek = new Quant_Uniq();
            Aizek.all_words = words;
            Aizek.uniq_words_count = new Dictionary<string, int>();
            foreach (string element in obj.all_words)
            {
                if (obj.uniq_words_count.ContainsKey(element))
                {
                    obj.uniq_words_count[element]++;
                }
                else
                {
                    obj.uniq_words_count.Add(element, 1);
                }
            }
        }
    }
}
