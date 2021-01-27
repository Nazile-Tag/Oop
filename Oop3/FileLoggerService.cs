using System;

namespace Oop3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}


