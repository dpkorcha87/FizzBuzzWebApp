namespace Utilities
{
    public static class Utility
    {
        public static List<ProcessedResponse> Process(List<string> values)
        {
            // Declare a list of strings to store the results 
            List<ProcessedResponse> result = new List<ProcessedResponse>();

            // Loop from 1 to n (inclusive) 
            foreach (var i in values)
            {
                int number;
                int.TryParse(i, out number);
                if (string.IsNullOrEmpty(i) || number == 0)
                {
                    result.Add(new ProcessedResponse() { Number = i, Response = new List<string>() { "Invalid Item" } });
                }
                else
                {

                    // Check if i is divisible by both 3 and 5 
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        // Add "FizzBuzz" to the result list 
                        result.Add(new ProcessedResponse() { Number = number.ToString(), Response = new List<string>() { "FizzBuzz" } });
                    }
                    // Check if i is divisible by 3 
                    else if (number % 3 == 0)
                    {
                        // Add "Fizz" to the result list 
                        result.Add(new ProcessedResponse() { Number = number.ToString(), Response = new List<string>() { "Fizz" } });
                    }
                    // Check if i is divisible by 5 
                    else if (number % 5 == 0)
                    {
                        // Add "Buzz" to the result list 
                        result.Add(new ProcessedResponse() { Number = number.ToString(), Response = new List<string>() { "Buzz" } });
                    }
                    else
                    {
                        // Add the current number as a string to the 
                        // result list 
                        result.Add(new ProcessedResponse()
                        {
                            Number = number.ToString(),
                            Response = new List<string>() {
                        "Divided " + i.ToString() + " by 3",
                        "Divided " + i.ToString() + " by 5"},
                        });
                    }

                }
            }

            // Return the result list 
            return result;
        }

    }

    public class ProcessedResponse
    {
        public string Number { get; set; }

        public List<string> Response { get; set; }
    }
}