using System.Collections.Generic;
using System.Linq;
using WpfApplication.Model;
using System.IO;
using Newtonsoft.Json;
using System;

namespace WpfApplication.DataAccess
{
    public class FileDataService : IDataService
    {
        private const string StorageFile = "Examples.json";

        public Example GetExampleById(int exampleId)
        {
            var examples = ReadFromFile();
            return examples.Single(ex => ex.Id == exampleId);
        }

        private List<Example> ReadFromFile()
        {
            if (!File.Exists(StorageFile))
            {
                return new List<Example>()
                {
                    new Example
                    {
                        Id = 1,
                        Name = "HorizontalGridSplitterExample",
                        Title = "HorizontalGridSplitter Example"
                    },
                    new Example
                    {
                        Id = 2,
                        Name = "VerticalGridSplitterExample",
                        Title = "VerticalGridSplitter Example"
                    }
                };
            }
            string json = File.ReadAllText(StorageFile);
            return JsonConvert.DeserializeObject<List<Example>>(json);
        }

        private void SaveExamples(List<Example> exampleList)
        {
            string json = JsonConvert.SerializeObject(exampleList, Formatting.Indented);
            File.WriteAllText(StorageFile, json);
        }

        public IEnumerable<Example> GetAllExamples()
        {
            return ReadFromFile();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
