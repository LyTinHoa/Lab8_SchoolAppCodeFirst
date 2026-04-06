using Microsoft.EntityFrameworkCore;

namespace SchoolAppCoreRazor.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [Precision(3, 2)]
        public decimal Grade { get; set; }
        public Course? Course { get; set; }
        public Student? Student { get; set; }
    }
}