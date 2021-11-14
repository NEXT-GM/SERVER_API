using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 namespace ApiServer.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Title { get; set; }
        public bool isBoy { get; set; }
    }
}
