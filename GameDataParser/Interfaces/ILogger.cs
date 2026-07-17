using System;
using System.Collections.Generic;
using System.Text;

namespace GameDataParser.Interfaces
{
    internal interface ILogger
    {
        public void LogError(Exception error);

    }
}
