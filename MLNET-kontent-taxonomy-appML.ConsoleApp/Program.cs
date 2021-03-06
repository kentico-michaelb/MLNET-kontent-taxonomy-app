// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.IO;
using System.Linq;
using Microsoft.ML;
using MLNET_kontent_taxonomy_appML.Model;

namespace MLNET_kontent_taxonomy_appML.ConsoleApp
{
    class Program
    {
        //Dataset to use for predictions 
        private const string DATA_FILEPATH = @"C:\Users\MichaelB\source\repos\netflix_titles.csv\netflix_movies.csv";

        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = CreateSingleDataSample(DATA_FILEPATH);

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Listed_in with predicted Listed_in from sample data...\n\n");
            Console.WriteLine($"show_id: {sampleData.Show_id}");
            Console.WriteLine($"type: {sampleData.Type}");
            Console.WriteLine($"title: {sampleData.Title}");
            Console.WriteLine($"release_year: {sampleData.Release_year}");
            Console.WriteLine($"rating: {sampleData.Rating}");
            Console.WriteLine($"duration: {sampleData.Duration}");
            Console.WriteLine($"description : {sampleData.Description}");
            Console.WriteLine($"\n\nActual Listed_in: {sampleData.Listed_in} \nPredicted Listed_in value {predictionResult.Prediction} \nPredicted Listed_in scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }

        // Change this code to create your own sample data
        #region CreateSingleDataSample
        // Method to load single row of dataset to try a single prediction
        private static ModelInput CreateSingleDataSample(string dataFilePath)
        {
            // Create MLContext
            MLContext mlContext = new MLContext();

            // Load dataset
            IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                                            path: dataFilePath,
                                            hasHeader: true,
                                            separatorChar: ',',
                                            allowQuoting: true,
                                            allowSparse: false);

            // Use first line of dataset as model input
            // You can replace this with new test data (hardcoded or from end-user application)
            ModelInput sampleForPrediction = mlContext.Data.CreateEnumerable<ModelInput>(dataView, false)
                                                                        .First();
            return sampleForPrediction;
        }
        #endregion
    }
}
