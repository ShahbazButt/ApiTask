namespace apitask.Shared
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

      
        IList<Course> Courses { get; set; }
       
        

    }
}
