using TestCore.Models;

namespace TestController.Services
{
    public static class FileService
    {
        public static async void Export(string str)
        {
            string path = "result.txt";

            using (StreamWriter sw = new(path, false))
            {
                await sw.WriteLineAsync(str);
            }
        }
    }
}