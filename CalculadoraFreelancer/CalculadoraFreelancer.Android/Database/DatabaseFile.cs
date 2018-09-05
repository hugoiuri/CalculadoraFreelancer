using CalculadoraFreelancer.Domain.Interfaces;
using CalculadoraFreelancer.Droid.Database;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseFile))]
namespace CalculadoraFreelancer.Droid.Database
{
    public class DatabaseFile : IDatabaseFile
        {
            public string GetFilePath(string filename)
            {
                string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                return Path.Combine(path, filename);
            }
        }
}