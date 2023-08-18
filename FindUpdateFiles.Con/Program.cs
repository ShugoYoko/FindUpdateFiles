
namespace FindUpdateFiles.Con
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ユーザー入力
            Console.Write("Research folder path:");
            var targetFolder = Console.ReadLine();
            Console.Write("Start date(yyyy/MM/dd):");
            var startDate = Console.ReadLine();
            Console.Write("End date(yyyy/MM/dd):");
            var endDate = Console.ReadLine();

            var search = new SearchPaths(targetFolder, startDate, endDate);
            foreach (var path in search.GetAllFiles())
            {
                Console.WriteLine(path);
            }

            //終了待機
            Console.WriteLine("-------------------");
            Console.ReadLine();

        }
    }
}

