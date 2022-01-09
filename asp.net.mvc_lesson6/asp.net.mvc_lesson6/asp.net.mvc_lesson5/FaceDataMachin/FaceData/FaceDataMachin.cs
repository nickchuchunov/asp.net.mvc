
global using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System;

namespace asp.net.mvc_lesson6
{
    internal class FaceDataMachin
    {
        FaceData face = new FaceData();

        /// <summary>
        /// метод создания файла с рандомными данными сканера
        /// </summary>
        /// <param name="FileLocation"> адрес файла для записи фейковых данных</param>
        /// <param name="count"> количество замеров</param>
        internal void FaceDataMachinGenerator(string FileLocation = @"H:\homeworkcnn10\asp.net.mvc_lesson6", int count=100)
        {
            Random random = new Random();

            string[] vs = new string[count];


            for (int i = 0; i < count; i++)
            {
                face.RAMLoading = random.Next(0, 100);
                face.CPU_Usage = random.Next(0, 100);
                face.Time = DateTime.Now;

                string SerealizeFaceData = JsonSerializer.Serialize(face);

                vs[i] = SerealizeFaceData;

            }


            File.WriteAllLines(FileLocation, vs);

        }

    }
}
