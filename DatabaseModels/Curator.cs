using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels
{
    public class Curator
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
