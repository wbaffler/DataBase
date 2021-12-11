using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DatabaseModels
{
    public class Curator
    {
       /* Curator(int groupId, string name, string email)
        {
            GroupId = groupId;
            Name = name;
            Email = email;
        }*/
        [Required]
        public int Id { get; set; }
        [Required]
        public int GroupId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public Group Group { get; set; }
    }

}
