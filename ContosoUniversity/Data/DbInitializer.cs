using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            if (context.Students.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student{FirstMidName="Abhi",LastName="Sethu",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstMidName="Anu",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                          new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
  };
            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                 new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
  new Course{CourseID=1045,Title="Calculus",Credits=4},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4},
                new Course{CourseID=2021,Title="Composition",Credits=3},
                new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();


            var enrollments = new Enrollment[]

            {  new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                 new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
        };
            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();





        }
    }

}
