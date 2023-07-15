namespace LeetCode
{
    internal class Program
    {
        public int MethodCalledCount { get; set; }
        public int ForIterationTotalCount { get; set; }
        static void Main(string[] args)
        {
            //string s = "[[[]]]";
            //bool isValid = IsValid(s);
            //Console.WriteLine(isValid);
            Test(6);
            //Console.WriteLine("Test2");
            
            //Test2(4,0);
            Console.ReadLine();
        }
        public static bool IsValid(string s)
        {
            var sArr = s.ToArray();
            if (sArr.Length < 2 || sArr.Length % 2 == 1)
                return false;
            if (sArr[0] == ')' || sArr[0] == ']' || sArr[0] == '}' || sArr[sArr.Length - 1] == '(' || sArr[sArr.Length - 1] == '[' || sArr[sArr.Length - 1] == '{')
                return false;
            char[] stack = new char[sArr.Length];
            int lint = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (sArr[i] == '(' || sArr[i] == '[' || sArr[i] == '{')
                {
                    stack[i] = sArr[i];
                    lint = i;
                }
                else if (sArr[i] == ')' || sArr[i] == ']' || sArr[i] == '}')
                {
                    if (!isMatchingPair(stack[lint], sArr[i]))
                        return false;
                    else
                        Array.Clear(stack, lint, 1);
                    lint--;
                }
            }
            return stack[0] != sArr[0] && stack[stack.Length - 1] != sArr[sArr.Length - 1];

            static Boolean isMatchingPair(char character1,
                                 char character2)
            {
                if (character1 == '(' && character2 == ')')
                    return true;
                else if (character1 == '{' && character2 == '}')
                    return true;
                else if (character1 == '[' && character2 == ']')
                    return true;
                else
                    return false;
            }
        }

        public static void Test(int n)
        {
            if (n > 0)
            {
                for (int i = 1; i < n; i=i*2)
                {
                    Console.WriteLine("value Of n: {0}", n);
                }
                Test(n - 1);

            }
        }
        public static void Test2(int n, int times)
        {
            Console.WriteLine("times executed so far:{0}",times);
            times++;
            //Console.WriteLine("entering loop: {0}", n);
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("calling test for : {0}", n);
                Test2(n - 1, times);
            }
            //Console.WriteLine("exit loop: {0}", n);
        }
    }
}