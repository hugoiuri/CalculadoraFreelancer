using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraFreelancer.Domain.Interfaces
{
    public interface IDatabaseFile
    {
        string GetFilePath(string file);
    }
}
