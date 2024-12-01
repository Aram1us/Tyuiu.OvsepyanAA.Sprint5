using Microsoft.VisualBasic;
using Tyuiu.OvsepyanAA.Sprint5.Task7.V20.Lib;
namespace Tyuiu.OvsepyanAA.Sprint5.Task7.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string result;

            Console.Title = "Task:5.7.v20| Овсепян А.А , СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Овсепян А.А |  СМАРТб-24-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:          *\n");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.Write("* File = " + Path.Combine("D:", "DataSprint5", "InPutDataFileTask7V20.txt"));
            string input = Console.ReadLine();

            Console.WriteLine("***************************************************************************");

            { //code
                result = ds.LoadDataAndSave(Path.Combine("D:", "DataSprint5", "InPutDataFileTask7V20.txt"));
            }
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Result in {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}