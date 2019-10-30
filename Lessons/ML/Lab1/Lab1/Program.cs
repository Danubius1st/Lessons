using System.Collections.Generic;
using Microsoft.ML;

namespace Lab1
{
    class FeedBackTrainingData
    {
        public string FeedBackText { get; set; }
        public bool IsGood { get; set; }
    }

    class Program
    {
        static List<FeedBackTrainingData> trainingdata = new List<FeedBackTrainingData>();
        static void LoadTrainingData()
        {
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is good",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is horrible",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is average",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is average and ok",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "bad and hell",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "this is nice but better can be done",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "bad bad",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "till now it looks nice",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "god horrible",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "average and ok",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "sweet and nice",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "nice and good",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "very good",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "quiet average",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "soooo nice",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "it very average",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "bad horrible",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "well ok ok",
                IsGood = true
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "shitty terrible",
                IsGood = false
            });
            trainingdata.Add(new FeedBackTrainingData()
            {
                FeedBackText = "cool nice",
                IsGood = true
            });
        }

        static void Main(string[] args)
        {
            LoadTrainingData();
            MLContext mlContext = new MLContext();
            //IDataView dataView = mlContext.CreateStreamingDataView<FeedBackTrainingData>(trainingdata);
            IDataView dataView = mlContext.Data.LoadFromEnumerable<FeedBackTrainingData>(trainingdata);
            //var pipeline = mlContext.Transforms.Text.FeaturizeText("FeedBackText", "Features")
            //    .Append(mlContext.BinaryClassification.Trainers.);
        }
    }
}
