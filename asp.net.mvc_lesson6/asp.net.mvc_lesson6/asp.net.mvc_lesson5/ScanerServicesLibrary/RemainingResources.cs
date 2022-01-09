using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Text.Json;


namespace asp.net.mvc_lesson6
{
    internal class RemainingResources
    {
        /// <summary>
        ///  преобразует значения в файле работы PseudoScaner на остаток от 100% ресурса
        /// </summary>
        /// <param name="file">адрес файла который нуджно преобразовать</param>
      void Remaining(string file) 
        {
          
            IList<FaceData> ListFaceDate = new List<FaceData>();
            FaceData face = new FaceData();
           
            string[] jsonString = File.ReadAllLines(file);

            for (int i = 0; i < jsonString.Length; i++)
            {
                FaceData FaceDataDeserialize = JsonSerializer.Deserialize<FaceData>(jsonString[i]);

                ListFaceDate.Add(FaceDataDeserialize);

            }

            string[] vs = new string[ListFaceDate.Count];
            for (int i = 0; i < ListFaceDate.Count; i++)
            {

                face.CPU_Usage = 100 - ListFaceDate[i].CPU_Usage;
                face.RAMLoading = 100 - ListFaceDate[i].RAMLoading;
                face.Time = ListFaceDate[i].Time;
                string SerealizeFaceData = JsonSerializer.Serialize(face);

                vs[i] = SerealizeFaceData;

            }


            File.WriteAllLines(file, vs);



        }



    }
}
