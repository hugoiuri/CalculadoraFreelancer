using CalculadoraFreelancer.Domain.Interfaces;
using CalculadoraFreelancer.iOS.Database;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseFile))]
namespace CalculadoraFreelancer.iOS.Database
{
    public class DatabaseFile : IDatabaseFile
    {
        public string GetFilePath(string file)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = System.IO.Path.Combine(docFolder, "..", "Library");
            return Path.Combine(libFolder, file);
        }
    }
}