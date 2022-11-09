﻿namespace SerializeStudentGroup
{
    [Serializable]
    public class Student
    {
        public decimal StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
    }
}