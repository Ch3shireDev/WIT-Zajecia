using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;

namespace LinqTest
{
    public partial class LinqTest : Form
    {
        private static string[] AllTest;
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public LinqTest()
        {
            InitializeComponent();
            var methods =
                typeof(LinqTest).GetMethods()
                .Where((method) => method.IsStatic)
                .Where((method) => method.ReturnType == typeof(void))
                .Where((method) => method.GetParameters().Count() == 1)
                .Where((method) => method.GetParameters().First().ParameterType == typeof(StringBuilder))
                .Where((method) => method.GetCustomAttributes(typeof(DescriptionAttribute)).Any())
                .Select((method) => method.Name)
                .OrderBy((name) => name)
            ;
            AllTest = methods.Where((name) => name != nameof(CallAllTest)).ToArray();
            CbTests.Items.AddRange(methods.ToArray());
            CbTests.SelectedIndex = 0;
            StringBuilder sb = new StringBuilder();
            methods.Aggregate(sb,(_sb, name) => _sb.AppendLine(name));
            TxtLog.Text = sb.ToString();
        }

        public static void CallByName(string name, StringBuilder sb)
        {
            MethodInfo method = typeof(LinqTest).GetMethod(name);
            string description = (method.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description;
            if(name != nameof(CallAllTest))
            {
                int len = description.Length - name.Length;
                sb.AppendLine($"={new string('=', len >> 1)} {name} {new string('=', len - (len >> 1))}=");
                sb.AppendLine($"= {description} =");
            }
            method.Invoke(null, new object[] { sb });
            sb.AppendLine();
        }

        [Description("Wszystkie metody")]
        public static void CallAllTest(StringBuilder sb)
        {
            foreach (string name in AllTest) CallByName(name, sb);
        }

        [Description("Posortowane slowa")]
        public static void Test_AB_01(StringBuilder sb)
        {
            digits.OrderBy((wordnum) => wordnum).Aggregate(sb, (_sb, wordnum) => _sb.Append(wordnum).Append(' '));
            sb.AppendLine();
        }

        [Description("Cyfry slownie")]
        public static void Test_AB_02(StringBuilder sb)
        {
            numbers.Select((num) => digits[num]).Aggregate(sb, (_sb, wordnum) => _sb.Append(wordnum).Append(' '));
            sb.AppendLine();
        }
        [Description("Dlugość mniejsza od wartości")]
        public static void Test_AB_03(StringBuilder sb)
        {
            digits.Where((num,index) => num.Length < index).Aggregate(sb, (_sb, wordnum) => _sb.Append(wordnum).Append(' '));
            sb.AppendLine();
        }
        [Description("Tabelka potęg")]
        public static void Test_AB_04(StringBuilder sb)
        {
            var table = from n in numbers orderby n select new { n, n2 = n * n, n3 = n * n * n };
            foreach (var s in table) sb.AppendFormat("{0}\t{1}\t{2}", s.n, s.n2, s.n3).AppendLine();
        }

        [Description("liczby parzyste")]
        public static void Test_CP_01(StringBuilder sb)
        {
            numbers.Where((num) => num % 2 == 0).OrderBy((num) => num).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.Append(Environment.NewLine);
        }

        [Description("Nieparzyste liczby")]
        public static void Test_JK_01(StringBuilder sb)
        {
            var query = from n in numbers orderby n where n % 2 != 0 select new { n };
            query.Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Uporzadkowane litery o długości większej od 3")]
        public static void Test_MH_01(StringBuilder sb)
        {
            digits.OrderBy((key) => key).Where((n) => n.Length > 3).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(" "));
            sb.AppendLine();
        }

        private static int[] numbersMultiple = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 5, 60, 5, 4, 3, 2, 1, 6, 8, 9, 2, 1, 2, 3, 4, 9, 6, 12, 60 };
        [Description("Unikalne wartości posortowane rosnąco")]
        public static void Test_ML_01(StringBuilder sb)
        {
            numbersMultiple.Distinct().OrderBy(wordnum => wordnum).Aggregate(sb, (_sb, wordnum) => sb.Append(wordnum).Append(' '));
            sb.AppendLine();
        }

        [Description("Unia 3 zbiorów")]
        public static void Test_RK_01(StringBuilder sb)
        {
            string[] add = { "eight", "nine", "ten", "eleven", "twelve" };
            var list = digits.Union(add).Union(new string[] { "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen" });
            foreach (var item in list) sb.Append(item.ToString()).Append(' ');
            sb.AppendLine();
        }

        [Description("Suma cyfr w number, gdzie każda jest pomnożona razy 10")]
        public static void Test_DD_01(StringBuilder sb)
        {
            sb.Append(numbers.Sum(x => x) * 10);
            sb.AppendLine();
        }

        [Description("wybranie oraz sortowanie liczb wiekszych od 1 i mniejszych od 4")]
        public static void Test_DM_01(StringBuilder sb)
        {
            var query = from num in numbers where 1 < num && num < 4 orderby num select digits[num];
            query.Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Wyrazy kończące się na e ")]
        public static void Test_MH_02(StringBuilder sb)
        {
            digits.Where((text, index) => text.EndsWith("e")).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Pomija elementy dla określonego warunku")]
        public static void Test_VM_01(StringBuilder sb)
        {
            digits.OrderBy((wordnum) => wordnum.Length).SkipWhile((wordnum) => wordnum.Length <= 3).Aggregate(sb, (_sb, wordnum) => _sb.Append(wordnum).Append(' '));
            sb.AppendLine();
        }

        [Description("Zaczynające się na literę t")]
        public static void Test_AS_01(StringBuilder sb)
        {
            digits.Where((name, index) => name.StartsWith("t")).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Wyswietlenie 3 ostatnich elementow")]
        public static void Test_DSZ_01(StringBuilder sb)
        {
            foreach (var item in digits.Skip(Math.Max(0, digits.Count() - 3))) sb.AppendLine(item);
        }

        [Description("Pierwsze słowo o długości < 4")]
        public static void Test_ML_02(StringBuilder sb)
        {
            sb.Append(digits.FirstOrDefault(digit => digit.Length < 4));
            sb.AppendLine();
        }

        [Description("Najwieksza parzysta liczba")]
        public static void Test_JK_02(StringBuilder sb)
        {
            //var query = numbers.Where(n=> n%2==0).Max();
            var query = numbers.Max(n => n % 2 == 0 ? n : 0);
            sb.AppendLine(query.ToString());
        }

        private class User
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Email { get; set; }
        }

        [Description("Szuka pierwszego wystąpienia osoby o nazwisku Testowy")]
        public static void Test_DD_02(StringBuilder sb)
        {
            var listOfUsers = new List<User>
            {
                new User
                {
                Firstname = "Patryk",
                Lastname = "Mikulski",
                Email = "test@mail.com"
                },
                new User
                {
                Firstname = "Maciek",
                Lastname = "Testowy",
                Email = "test@mail.com"
                },
                new User
                {
                Firstname = "Piotr",
                Email = "inny@mail.com",
                },
                null
            };
            var User=listOfUsers.Where(x => x != null).Where(x => x.Lastname == "Testowy").FirstOrDefault();
            sb.AppendLine($"{User.Firstname} {User.Lastname} { User.Email}");
        }

        [Description("Wyrazy o długości większej niż 4, oraz czy zawierają literę v ")]
        public static void Test_MH_03(StringBuilder sb)
        {
            (from str in digits orderby str where str.Length > 4 select new { str, cont = str.Contains("v"), }).Aggregate(sb, (_sb, key) => _sb.Append(string.Format("{0}\t{1}", key.str, key.cont)).Append(Environment.NewLine));
        }

        [Description("Przycina listę o 3 wyniki z początku i 3 z końca")]
        public static void Test_RK_02(StringBuilder sb)
        {
            var list = digits.Skip(3).Reverse().Skip(3).Reverse();
            foreach (var item in list) sb.Append(item).Append(' ');
            sb.AppendLine();
        }

        [Description("Slowa w odwrotnej kolejnosci i od tyłu")]
        public static void Test_DSZ_02(StringBuilder sb)
        {
            var resultstring = digits.Reverse().Select(c => new string(c.Reverse().ToArray())).ToArray();
            foreach (var item in resultstring) sb.AppendLine(item);
        }

        public class Student { public int StudentID; public string StudentName; public int Age; public int StandardID; }
        public class Standard { public int StandardID; public string StandardName; }
        List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
        };
        [Description("Students with odd age")]
        public void Test_MR_01(StringBuilder sb)
        {
            var elements = studentList.Where((stud) => stud.Age % 2 == 1).Aggregate(sb, (_sb, stud) => _sb.Append(stud.StudentName).Append(" "));
        }

        [Description("Wybiera elementy dla określonego warunku")]
        public static void Test_VM_02(StringBuilder sb)
        {
            numbers.OrderBy((num) => num).TakeWhile(num => num < 5).Aggregate(sb, (_sb, num) => _sb.Append(num).Append(' '));
            sb.AppendLine();
        }

        [Description("Wybór elementów tablicy określonego typu")]
        public static void Test_DS_01(StringBuilder sb)
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            var stringResult = from s in mixedList.OfType<string>() select s;
            var intResult = from s in mixedList.OfType<int>() select s;
            foreach (var str in stringResult) sb.AppendLine(str);
            foreach (var integer in intResult) sb.AppendLine(integer.ToString());
        }

        [Description("Powtórzenie liczby X razy")]
        public static void Test_JK_03(StringBuilder sb)
        {
            var intCollection = Enumerable.Repeat<int>(13, 3);
            intCollection.Aggregate(sb, (_sb, num) => _sb.Append(num).Append(' '));
            sb.AppendLine();
        }

        [Description("Dlugosci slow w tablicy")]
        public static void Test_DSZ_03(StringBuilder sb)
        {
            var table = from n in digits orderby n select new { n, nlenght = n.Length };
            foreach (var s in table) sb.Append($"Długość = { s.nlenght }\tElement = { s.n }").AppendLine();
        }

        private static string[] warmCountries = { "Turkey", "Italy", "Spain", "Saudi Arabia", "Etiobia" };
        private static string[] europeanCountries = { "Denmark", "Germany", "Italy", "Portugal", "Spain" };
        [Description("Połączone kraje, które są zarówno ciepłe, jak i europejskie (Inner Join)")]
        public static void Test_VM_03(StringBuilder sb)
        {
            warmCountries.Join(europeanCountries, warm => warm, european => european, (warm, european) => warm).Aggregate(sb, (_sb, warm) => _sb.Append(warm).Append(' '));
            sb.AppendLine();
        }

        [Description("sortowanie i używanie zip aby przyporzatkowac wartosci numbers to digits")]
        public static void Test_DM_02(StringBuilder sb)
        {
            // musi być ten sam rozmiar
            numbers.OrderBy((key) => key).Zip(digits, (first, second) => first + "->" + second).Aggregate(sb, (_sb, key) => _sb.Append(key).Append(' '));
            sb.AppendLine();
        }

        [Description("Ostatnie elementy")]
        public static void Test_AR_01(StringBuilder sb)
        {
            sb.AppendFormat("last Element numbers :{0}", numbers.Last()).AppendLine();
            sb.AppendFormat("last Element digits :{0}", digits.Last()).AppendLine();
            sb.AppendFormat("Last Even Element numbers in intList: {0}", numbers.Last(i => i % 2 == 0)).AppendLine();
            string last = digits.LastOrDefault(s => s.Contains("u"));
            sb.AppendFormat("Last Even Element in digits: {0}", String.IsNullOrEmpty(last) ? "<string is null or empty>" : last).AppendLine();
            string[] digits2 = { };
            string last2 = digits2.LastOrDefault(s => s.Contains("u"));
            sb.AppendFormat("Last Even Element in digits2: {0}", String.IsNullOrEmpty(last2) ? "<string is null or empty>" : last2).AppendLine();
        }

        [Description("Grupuje osoby po tych samych mailach. Wypisuje maila, a następnie wszystkie osoby posiadające tego maila")]
        public static void Test_DD_03(StringBuilder sb)
        {
            var listOfUsers = new List<User>
            {
                new User
                {
                    Firstname = "Patryk",
                    Lastname = "Mikulski",
                    Email = "test@mail.com"
                },
                new User
                {
                    Firstname = "Maciek",
                    Lastname = "Testowy",
                    Email = "test@mail.com"
                },
                new User
                {
                    Firstname = "Piotr",
                    Email = "inny@mail.com",
                },
                null
            };
            listOfUsers.Where(x => x != null).GroupBy(x => x.Email).ToList().ForEach(x =>
            {
                sb.AppendLine("Key: " + x.Key);
                sb.AppendLine("Members: ");
                x.ToList().ForEach(y =>
                {
                    sb.AppendLine("\t" + y.Firstname);
                });
            });
        }

        [Description("Czego nie ma w naszej liscie")]
        public static void Test_AR_02(StringBuilder sb)
        {
            int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10 };
            sb.AppendFormat("Do not exist in numbers: ");
            var result = numbers2.Except(numbers);
            foreach (int i in result) sb.AppendFormat("{0},", i);
            sb.Remove(sb.Length - 1, 1).AppendLine();
        }

        [Description("Tabliczka mnożenia")]
        public static void Test_CP_02(StringBuilder sb)
        {
            int[] myNumbers = numbers.Where(x => x != 0).OrderBy(x => x).ToArray();
            var mulTab = myNumbers.Join(myNumbers, x => myNumbers, y => myNumbers, (x, y) => x * y).ToList();
            for (int i = 0; i < mulTab.Count; ++i)
            {
                sb.AppendFormat("{0,3}", mulTab[i]);
                if (i != 0 && (i + 1) % myNumbers.Length == 0)
                {
                    sb.AppendLine();
                }
            }
        }
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            CallByName(CbTests.SelectedItem.ToString(), sb);
            TxtLog.Text = sb.ToString();
        }
    }
}
