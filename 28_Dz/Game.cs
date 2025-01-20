using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Dz
{
    internal class Game
    {
        Dictionary<string, List<string>> AllKarts = new Dictionary<string, List<string>>()
        {
            ["піка"] = new List<string> { "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" },
            ["трефа"] = new List<string> { "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" },
            ["бубна"] = new List<string> { "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" },
            ["чирва"] = new List<string> { "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" }
        };
    }
}
