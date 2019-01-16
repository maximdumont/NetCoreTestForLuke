using System.Collections.Generic;
using System.Linq;
using CodingTest.Models;

namespace CodingTest.Services.GradesService
{
    public interface IGradesService
    {
        IEnumerable<StudentGrade> GetGrades();
        string GetAverage();
        IEnumerable<StudentGrouping> GetGroupingsByLetterGrade();
        IOrderedEnumerable<StudentGrade> GetStudentsListGroupedByGrade();
    }
}