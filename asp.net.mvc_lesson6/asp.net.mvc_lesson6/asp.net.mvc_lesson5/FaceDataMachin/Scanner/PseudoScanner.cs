using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace asp.net.mvc_lesson6
{
    internal class PseudoScanner
    {

        IList<FaceData> ListFaceDate = new List<FaceData>();
        /// <summary>
        /// метод имитации работы сканера
        /// </summary>
        /// <param name="file">адрес расположения файла с данными для сканера</param>
        /// <returns> возвращает десериализованные данные в формате FaceData </returns>
        internal IList<FaceData> ReadingPseudoScanner(string file= @"H:\homeworkcnn10\asp.net.mvc_lesson6")
        {
            string[] jsonString = File.ReadAllLines(file);


            for (int i = 0; i < jsonString.Length; i++)
            {
                FaceData FaceDataDeserialize = JsonSerializer.Deserialize<FaceData>(jsonString[i]);

                ListFaceDate.Add(FaceDataDeserialize);

            }

            return ListFaceDate;

        }

        internal void ReadingConsolPseudoScanner()
        {
            for (int i = 0; i < ListFaceDate.Count; i++)

                Console.WriteLine("Метрика CPU {0}, метрика RAM {1}, время {2}  ", ListFaceDate[i].CPU_Usage, ListFaceDate[i].RAMLoading, ListFaceDate[i].Time);


        }

    }
}
