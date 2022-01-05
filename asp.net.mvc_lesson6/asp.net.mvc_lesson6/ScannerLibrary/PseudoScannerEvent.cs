using System;
using System.IO;
using Microsoft.Extensions.Logging;


namespace ScannerLibrary
{
    public class PseudoScannerEvent
    {

        FileSystemWatcher _FileDystemWatcher { get; set; }
        ILogger logger { get; set; }


        /// <summary>
        /// В конструкторе событие о изменении в дериктории PseudoScanera пишется в лог и выводится сообщение в консоль
        /// </summary>
        /// <param name="file"> адрес дериктории куда пишет PseudoScanner</param>
        /// <param name="logger"> логер</param>
        PseudoScannerEvent(string file, ILogger<PseudoScannerEvent> logger) 
        {
            _FileDystemWatcher = new FileSystemWatcher(file);
            logger = logger;
            _FileDystemWatcher.Changed += EventFile;


        }

        void  EventFile(object sender, FileSystemEventArgs e) 
        {
            logger.LogInformation($"Выполнена запись нового файла {e.Name.ToString()}");
            Console.WriteLine("Выполнена запись нового файла {0}", e.Name.ToString());
            Console.ReadLine();



        }





    }
}