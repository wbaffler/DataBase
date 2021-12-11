using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseModels
{
    public class Student
    {
       /* public Student (int groupId, string name, int age)
        {
            GroupId = groupId;
            Name = name;
            Age = age;
        }*/
        [Required]
        public int Id { get; set; }
        [Required]
        public int GroupId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public Group Group { get; set; }

    }
}
