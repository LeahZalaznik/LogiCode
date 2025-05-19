using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAO
{
    public  class StudentCourse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public DateTime PurchaseDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string? Status { get; set; }
        public double? FinalGrade { get; set; }

    }
}
