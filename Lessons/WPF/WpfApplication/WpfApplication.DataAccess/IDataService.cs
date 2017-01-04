using System;
using System.Collections.Generic;
using WpfApplication.Model;

namespace WpfApplication.DataAccess
{
    public interface IDataService : IDisposable
    {
        Example GetExampleById(int exampleId);
        IEnumerable<Example> GetAllExamples();
    }
}