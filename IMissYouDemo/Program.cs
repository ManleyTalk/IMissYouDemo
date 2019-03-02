using System;

namespace IMissYouDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string contest = "安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！李红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！安红，我想你！";

            Console.WriteLine(contest);

            Console.WriteLine(contest.Length);

            //替换前，检查
            Console.WriteLine(contest.Contains("李红"));

            contest = contest.Replace("李红", "安红");

            Console.WriteLine(contest);

            //替换后，检查
            Console.WriteLine(contest.Contains("李红"));

            Console.ReadKey();
        }
    }
}
