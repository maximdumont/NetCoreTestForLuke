using System.Collections.Generic;
using System.Text;

namespace CodingTest.Services.FizzBuzzService
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private const string Fizz = nameof(Fizz);
        private const string Buzz = nameof(Buzz);
        
        private readonly StringBuilder _fizzBuzzBuilder = new StringBuilder();
        
        public IEnumerable<string> ProcessFizzBuzz(int min, int max)
        {
            for (int i = min; i < max; i++)
            {
                _fizzBuzzBuilder.Clear();

                if (i % 3 == 0 && i % 5 == 0)
                {
                    _fizzBuzzBuilder.Append("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    _fizzBuzzBuilder.Append("Fizz");
                }
                else if (i % 5 == 0)
                {
                    _fizzBuzzBuilder.Append("Buzz");
                }
                else
                {
                    _fizzBuzzBuilder.Append(i);
                }

                yield return _fizzBuzzBuilder.ToString();
            }
        }
    }
}