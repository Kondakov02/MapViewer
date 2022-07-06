// Класс для сохранения и загрузки данных из файлов.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using MapViewer.Misc;

namespace MapViewer.Helpers
{
    internal class DataFileManagement
    {
        public void SaveData(string path, List<MarkerInfo> objects)
        {
            if (objects is null) throw new ArgumentNullException("Список объектов не может быть null.");
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            File.WriteAllText(path, JsonSerializer.Serialize(objects, options));
        }

        public List<MarkerInfo> LoadMarkerData(string path)
        {
            return JsonSerializer.Deserialize<List<MarkerInfo>>(File.ReadAllText(path));
        }
    }
}
