using System;
using MyMLAppML.Model;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            do
            {
                var input = new ModelInput();
                text = Console.ReadLine();
                input.SentimentText = text;

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);
                Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
            }
            while (text != "q");
            
        }
    }
}
