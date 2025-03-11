

namespace MyMvcApp.Models
{
    
       public class Person 
    {
        
        internal string? id;
        internal string? email;

        public required String PersonID { get; set;}
        public required String FullName { get;set;}
        public required String Address { get; set;}
        public string? Gender { get; internal set; }
    }
}