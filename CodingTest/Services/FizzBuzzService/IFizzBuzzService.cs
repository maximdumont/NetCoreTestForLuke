using System.Collections.Generic;

namespace CodingTest.Services.FizzBuzzService
{
    public interface IFizzBuzzService
    {
        IEnumerable<string> ProcessFizzBuzz(int min, int max);
    }
}