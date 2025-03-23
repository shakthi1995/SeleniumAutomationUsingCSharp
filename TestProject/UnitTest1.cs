using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            string input = "a b c a b c d";
            RemoveDuplicates obj = new RemoveDuplicates();
            string output = obj.RemoveDuplicateCharacters(input);
            Console.WriteLine(output);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            string input = "Hello World!";
            ReverseString obj = new ReverseString();
            string output = obj.ReverseAString(input);
            Console.WriteLine(output);
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            string input = "This is tree";
            ReverseString obj = new ReverseString();
            string output = obj.ReverseAStringLogic(input);
            Console.WriteLine(output);
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {
            string input = "reversed it";
            ReverseString obj = new ReverseString();
            string output = obj.ReverseAStringWithoutLoop(input);
            Console.WriteLine(output);
            Assert.Pass();
        }

        [Test]
        public void Test5()
        {
            string input = "reversed is it";
            ReverseString obj = new ReverseString();
            string output = obj.ReverseASentence(input);
            Console.WriteLine(output);
            Assert.Pass();
        }

        [Test]
        public void Test6()
        {
            string input = "reversed is it ";
            ReverseString obj = new ReverseString();
            string output = obj.ReverseASentenceWithLoop(input);
            Console.WriteLine(output);
            Assert.Pass();
        }

        [Test]
        public void Test7()
        {
            int input = 10;
            RandomString obj = new RandomString();
            string output = obj.GenerateRandomString(input);
            Console.WriteLine(output);
            Assert.Pass();
        }

        [Test]
        public void Test8()
        {
            string path = "C:\\Users\\s0r0d91\\Documents\\Work\\file.txt";
            EmptyFile obj = new EmptyFile();
            obj.CreateEmptyFile(path);
            Assert.Pass();
        }

        [Test]
        public void Test9()
        {
            int[] input = { 354, 500, 101, 8, 9 };
            FindingNumbers obj = new FindingNumbers();
            (int min, int max) = obj.FindingLargestAndSmallestNumber(input);
            Console.WriteLine($"Smallest Number:{min} and Largest Number:{max}");
            Assert.Pass();
        }

        [Test]
        public void Test10()
        {
            int[] input = { 354, 500, 101, 8, 9 };
            FindingNumbers obj = new FindingNumbers();
            (int secondMin, int secondMax) = obj.FindingSecondLargestAndSecondSmallestNumber(input);
            Console.WriteLine($"Second Smallest Number:{secondMin} and Second Largest Number:{secondMax}");
            Assert.Pass();
        }

        [Test]
        public void Test11()
        {
            int[] input = { 354, 500, 101, 8, 9 };
            FindingNumbers obj = new FindingNumbers();
            (int thirdMin, int thirdMax) = obj.FindingThirdLargestAndThirdSmallestNumber(input);
            Console.WriteLine($"Third Smallest Number:{thirdMin} and Third Largest Number:{thirdMax}");
            Assert.Pass();
        }

        [Test]
        public void Test12()
        {
            string[] input ={"apple","banana","grapes", "apple", "banana"};
            RemoveDuplicates obj = new RemoveDuplicates();
            string[] output = obj.RemoveDuplicatesInAnArray(input);
            Console.WriteLine(string.Join("\n", output));
            Assert.Pass();
        }

        [Test]
        public void Test13()
        {
            string[] input = { "apple", "banana", "grapes", "apple", "banana" };
            RemoveDuplicates obj = new RemoveDuplicates();
            string[] output = obj.RemoveDuplicatesInAnArrayLogic(input);
            Console.WriteLine(string.Join("\n", output));
            Assert.Pass();
        }

        [Test]
        public void Test14()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement loginButton = wait.Until(drv => drv.FindElement(By.Name("login-button")));

            HighlightWebElement obj = new HighlightWebElement();
            obj.HighlightWebElementInRed(driver, loginButton);
            Thread.Sleep(500);

            driver.Quit();
            Assert.Pass();
        }

        [Test]
        public void Test15()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement table = wait.Until(drv => drv.FindElement(By.Id("htmlTableId")));

            PrintHtmlTable obj = new PrintHtmlTable();
            obj.PrintWebTables(driver, table);

            Thread.Sleep(500);

            driver.Quit();
            Assert.Pass();
        }

        [Test]
        public void Test16()
        {
            int levels = 5;
            PyramidProgram obj = new PyramidProgram();
            obj.PrintPyramid(levels);
            Assert.Pass();
        }

        [Test]
        public void Test17()
        {
            string input = "Missisippi";
            Dictionary<Char, int> characterOccurance = new Dictionary<char, int>();
            CharacterCount obj = new CharacterCount();
            characterOccurance = obj.CharacterOccurenceCount(input);
            foreach(var item in characterOccurance)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Assert.Pass();
        }

        [Test]
        public void Test18()
        {
            string fileName = "C:\\Users\\s0r0d91\\Documents\\learning materials\\EmployeeDetails.xlsx";
            string sheetName = "Sheet1";
            ReadTheExcelFile obj = new ReadTheExcelFile();
            List<Dictionary<string, object>> excelData = obj.ReadExcel(fileName, sheetName);
            
            foreach (var Row in excelData)
            {
                string name = Row["Name"].ToString();
                int age = Convert.ToInt32(Row["Age"]);
                double salary = Convert.ToDouble(Row["Salary"]);

                Console.WriteLine($"Employee Details: Name={name}, Age={age}, Salary={salary}");
            }
            Assert.Pass();
        }

        [Test]
        public void Test19()
        {
            int num = 153;
            ArmstrongNumber obj = new ArmstrongNumber();
            obj.FindArmstrongNumber(num);
            Assert.Pass();
        }

        [Test]
        public void Test20()
        {
            int input = 11;
            Fibonacci obj = new Fibonacci();
            obj.GenerateFibonacciSeries(input);
            Assert.Pass();
        }

        [Test]
        public void Test21()
        {
            int input = 12345;
            IntPalindrome obj = new IntPalindrome();
            obj.CheckPalindromeNumber(input);
            Assert.Pass();
        }

        [Test]
        public void Test22()
        {
            int input = 5;
            Factorial obj = new Factorial();
            int output = obj.FactorialNumber(input);
            Console.Write($"Fcatorial of the {input} is {output}");
            Assert.Pass();
        }

        [Test]
        public void Test23()
        {
            int input = 1;
            PrimeNumber obj = new PrimeNumber();
            bool output = obj.FindPrimeNumber(input);
            if (output)
            {
                Console.Write($"{input} is prime number");
            }
            else 
            {
                Console.Write($"{input} is not prime number");
            }

            Assert.Pass();
        }

        [Test]
        public void Test24()
        {
            int input = 1;
            SumOfDigits obj = new SumOfDigits();
            int output = obj.FindSumOfDigits(input);
            Console.Write($"Sum of digits is {output}");
            Assert.Pass();
        }

        [Test]
        public void Test25()
        {
            int input = 3456;
            CountInteger obj = new CountInteger();
            int output = obj.FindTheIntegerDigitCount(input);
            Console.Write($"Integer length is {output}");
            Assert.Pass();
        }

        [Test]
        public void Test26()
        {
            int input = 35475859;
            CountInteger obj = new CountInteger();
            int output = obj.FindTheIntegerDigitCountWithoutLoop(input);
            Console.Write($"Integer length is {output}");
            Assert.Pass();
        }

        [Test]
        public void Test27()
        {
            string[] input = {"listen", "Enlist", "silent", "Hello", "Word"};
             Anagram obj = new Anagram();
            var output = obj.FindAnagrams(input);
            foreach(var group in output) 
            {
                Console.Write($"[ " + string.Join(",", group) + " ]");
            }
            Assert.Pass();
        }

        [Test]
        public void Test28()
        {
            string input = "This is a omelette";
            ReverseString obj = new ();
            var output = obj.ReverseEachWordLogic(input);
            
            Console.Write($"{output}");

            Assert.Pass();
        }

        [Test]
        public void Test29()
        {
            string input = "This14363 is$%& a%6%7*9) omelette13263$%&*";
            ExtractString obj = new();
            obj.SegregateStringDigits(input);
            Assert.Pass();
        }

        [Test]
        public void Test30()
        {
            int start = 50, end = 100;
            PrimeNumber obj = new();
            obj.GetPrimeNumberInRange(start, end);
            Assert.Pass();
        }

        [Test]
        public void Test31()
        {
            int[] input = { 56, 87, 2, 3748, 67, 8 };
            FindingNumbers obj = new();
            obj.SortArrayAsc(input);
            Console.Write(string.Join(",",input));
            Assert.Pass();
        }

        [Test]
        public void Test32()
        {
            int[] input = { 56, 87, 2, 3748, 67, 8 };
            FindingNumbers obj = new();
            obj.SortArrayDesc(input);
            Console.Write(string.Join(",", input));
            Assert.Pass();
        }

        [Test]
        public void Test33()
        {
            int[] input = { 56, 57, 59, 60, 61};
            FindingNumbers obj = new();
            obj.MissingNumber(input);
            Assert.Pass();
        }

        [Test]
        public void Test34()
        {
            int[] input = { 56, 57, 59, 60, 61 };
            FindingNumbers obj = new();
            obj.MissingNumber(input);
            Assert.Pass();
        }





    }
}