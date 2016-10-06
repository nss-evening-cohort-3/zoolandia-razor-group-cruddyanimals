using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZoolandiaRazor.Models
{
    public class Habitat
    {
        public int HabitatId { get; set; }
        public string HabitatName { get; set; }
        public string HabitatType { get; set; }
        public List<Animal> AnimalList { get; set; }
        public List<Employee> EmployeeList { get; set; }
    }
}