using System;

namespace Anita_Dot_Net_Assignment.Models
{
    public class Student
    {
        // Marks StudentId as a required field and primary key
        public required int StudentId { get; set; }

        // Marks Name as a required field
        public required string Name { get; set; }

        // Marks Semester as a required field
        public required string Semester { get; set; }

        // Marks Faculty as a required field
        public required string Faculty { get; set; }

        // BookId as a foreign key reference to the Book entity
        public required int BookId { get; set; }
    }
}
