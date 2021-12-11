using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseModels
{
    public class Group
    {
        /*public Group(string name, DateTime dt)
        {
            Name = name;
            CreationDate = dt;
        }*/
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }

    }
}
