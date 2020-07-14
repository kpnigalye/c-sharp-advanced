using System;
using System.Collections.Generic;

namespace c_sharp_linq
{
    /// <summary>
    /// Class to populate temp Student data
    /// </summary>
    public static class StudentData
    {
        public static IList<Student> GetStudentData()
        {
            return new List<Student>() {
                new Student() { Id = 1, Name = "John", Age = 18, Skills = new List<string> { "C++", "Java" } } ,
                new Student() { Id = 2, Name = "Steve",  Age = 21, Skills = new List<string>{ "Python", "C++", "Java" } } ,
                new Student() { Id = 3, Name = "Bill",  Age = 18 , Skills = new List<string>{ "Python", "C#", "Java" } } ,
                new Student() { Id = 4, Name = "Ram" , Age = 20 , Skills = new List<string>{ "Angular", "Python" } } ,
                new Student() { Id = 5, Name = "Abram" , Age = 21 , Skills =new List<string> { "C#" } }
            };
        }
    }
}
