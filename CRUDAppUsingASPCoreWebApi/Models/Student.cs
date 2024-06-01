namespace CRUDAppUsingASPCoreWebApi.Models
{
    public class Student
    {
        public int id { get; set; }
        public string studentName { get; set; }
        public string studentGender { get; set; }
        private int age { get; set; }
        private int standard { get; set; }
        public string fatherName { get; set; }

    }
}
