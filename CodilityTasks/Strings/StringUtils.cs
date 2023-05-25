using System.Runtime.InteropServices;
using System.Text;

namespace CodilityTasks.Strings;

public static class StringUtils
{
    public static int CountVowels(string text)
    {
        var vovels = "aeiou";
        var count = 0;
        foreach (var ch in text)
        {
            if (vovels.Contains(ch))
            {
                count++;
            }
        }

        return count;
    }

    public static string reverse(string test)
    {
        var reversedText = new StringBuilder();
        for (int i = test.Length -1; i >=0; i--)
        {
            reversedText.Append(test[i]);
        }

        return reversedText.ToString();
    }
    
    public static string reverseSentence(string test)
    {
        var words = test.Split(" ");
        var reversedText = new StringBuilder();
        for (int i = words.Length -1; i >=0; i--)
        {
            reversedText.Append(words[i] + " ");
        }

        return reversedText.ToString();
    }

    public static string duplicates(string str1)
    {
        var ouput = new StringBuilder();
        var seen = new HashSet<string>();

        foreach (char ch in str1)
        {
            if (!seen.Contains(ch.ToString()))
            {
                seen.Add(ch.ToString());
                ouput.Append(ch);
            }
        }

        return ouput.ToString();
    }

    public static char mostRepeated(string str1)
    {
        var frequencies = new Dictionary<char, int>();
        foreach (var ch in str1)
        {
            if (!frequencies.ContainsKey(ch))
            {
                frequencies.Add(ch,1);

            }
            else
            {
                frequencies[ch]++;
            }
        }
        char mostFrequentChar = frequencies.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        return mostFrequentChar;
    }

    public static string ToUpper(string sentence)
    {
        var words = sentence.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
           words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
        }

        return string.Join(" ", words);
    }

    public static bool Anagram(string word1, string word2)
    {
        var arra1 = word1.ToArray();
        var arra2 = word2.ToArray();

        Array.Sort(arra1);
        Array.Sort(arra2);
        return arra1.SequenceEqual(arra2);
    }
    
    public static bool Anagram2(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        var counter = new int[26];
        for (int i = 0; i < word1.Length; i++)
        {
            counter[char.ToLower(word1[i]) - 'a']++;
            counter[char.ToLower(word2[i]) - 'a']--;
        }

        foreach (int count in counter)
        {
            if (count != 0)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsPalindrome(string word)
    {
        word = word.ToLower();
        var left = 0;
        var right = word.Length - 1;

        while (left < right)
        {
            if (word[left++] != word[right--])
            {
                return false;
            }
        }

        return true;
    }


}