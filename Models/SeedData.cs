using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakultetMVC.Models
{
    public class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using (var context = new FakultetMVCContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<FakultetMVCContext>>()))
            {
                if (context.Course.Any() || context.Student.Any() || context.Teacher.Any())
                {
                    return;
                }
                context.Student.AddRange(
                    new Student
                    {
                        StudentId = "123/2020",
                        FirstName = "Име_Студент1",
                        LastName = "Презиме_Студент1",
                        EnrollmentDate = DateTime.Parse("2020-9-1"),
                        AcquiredCredits = 12,
                        CurrentSemestar = 2,
                        EducationLevel = "Доипломски студии"
                    },
                    new Student
                    {
                        StudentId = "456/2017",
                        FirstName = "Име_Студент2",
                        LastName = "Презиме_Студент2",
                        EnrollmentDate = DateTime.Parse("2017-9-1"),
                        AcquiredCredits = 200,
                        CurrentSemestar = 8,
                        EducationLevel = "Додипломски студии"
                    },
                    new Student
                    {
                        StudentId = "789/2019",
                        FirstName = "Име_Студент3",
                        LastName = "Презиме_Студент3",
                        EnrollmentDate = DateTime.Parse("2019-9-1"),
                        AcquiredCredits = 36,
                        CurrentSemestar = 4,
                        EducationLevel = "Додипломски студии"
                    },
                    new Student
                    {
                        StudentId = "9/2015",
                        FirstName = "Име_Студент4",
                        LastName = "Презиме_Студент4",
                        EnrollmentDate = DateTime.Parse("2015-9-1"),
                        AcquiredCredits = 63,
                        CurrentSemestar = 5,
                        EducationLevel = "Додипломски студии"
                    },
                    new Student
                    {
                        StudentId = "20/2018",
                        FirstName = "Име_Студент5",
                        LastName = "Презиме_Студент5",
                        EnrollmentDate = DateTime.Parse("2018-9-1"),
                        AcquiredCredits = 58,
                        CurrentSemestar = 6,
                        EducationLevel = "Додипломски студии"
                    },
                    new Student
                    {
                        StudentId = "12/2003",
                        FirstName = "Име_Студент6",
                        LastName = "Презиме_Студент6",
                        EnrollmentDate = DateTime.Parse("2003-9-1"),
                        AcquiredCredits = 210,
                        CurrentSemestar = 8,
                        EducationLevel = "Додипломски студии"
                    },
                    new Student
                    {
                        StudentId = "268/2020",
                        FirstName = "Име_Студент6",
                        LastName = "Презиме_Студент6",
                        EnrollmentDate = DateTime.Parse("2020-9-1"),
                        AcquiredCredits = 30,
                        CurrentSemestar = 2,
                        EducationLevel = "Додипломски студии"
                    },
                    new Student
                    {
                        StudentId = "16/2014",
                        FirstName = "Име_Студент6",
                        LastName = "Презиме_Студент6",
                        EnrollmentDate = DateTime.Parse("2014-9-1"),
                        AcquiredCredits = 152,
                        CurrentSemestar = 6,
                        EducationLevel = "Додипломски студии"
                    }
                    );
            context.SaveChanges();

                context.Teacher.AddRange(
                    new Teacher
                    {
                        FirstName="Име_Професор1",
                        LastName="Презиме_Професор1",
                        Degree="Магистер",
                        AcademicRank="Вонреден професор",
                        OfficeNumber="123А",
                        HireDate=DateTime.Parse("2010-5-23")
                    },
                    new Teacher
                    {
                        FirstName = "Име_Професор2",
                        LastName = "Презиме_Професор2",
                        Degree = "Доктор",
                        AcademicRank = "Редовен професор",
                        OfficeNumber = "456Б",
                        HireDate = DateTime.Parse("1999-1-1")
                    },
                    new Teacher
                    {
                        FirstName = "Име_Професор3",
                        LastName = "Презиме_Професор3",
                        Degree = "Апсолвент",
                        AcademicRank = "Асистент",
                        OfficeNumber = "123А",
                        HireDate = DateTime.Parse("2019-8-10")
                    },
                    new Teacher
                    {
                        FirstName = "Име_Професор4",
                        LastName = "Презиме_Професор4",
                        Degree = "Доктор",
                        AcademicRank = "Редовен професор",
                        OfficeNumber = "1010",
                        HireDate = DateTime.Parse("2005-4-13")
                    },
                    new Teacher
                    {
                        FirstName = "Име_Професор5",
                        LastName = "Презиме_Професор5",
                        Degree = "Апсолвент",
                        AcademicRank = "Асистент",
                        OfficeNumber = "456Б",
                        HireDate = DateTime.Parse("2018-7-7")
                    },
                    new Teacher
                    {
                        FirstName = "Име_Професор6",
                        LastName = "Презиме_Професор6",
                        Degree = "Магистер",
                        AcademicRank = "Редовен професор",
                        OfficeNumber = "1012",
                        HireDate = DateTime.Parse("2016-5-3")
                    }
                    );
                context.SaveChanges();

                context.Course.AddRange(
                    new Course
                    {
                        Title = "Предмет1",
                        Credits = 6,
                        Semester = 1,
                        Programme = "ТКИИ",
                        EducationLevel = "Додипломски студии",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор1" && d.LastName == "Презиме_Професор1").Id,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор2" && d.LastName == "Презиме_Професор2").Id
                    },
                    new Course
                    {
                        Title = "Предмет2",
                        Credits = 3,
                        Semester = 6,
                        Programme = "КСИАР",
                        EducationLevel = "Додипломски студии",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор4" && d.LastName == "Презиме_Професор4").Id,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор3" && d.LastName == "Презиме_Професор3").Id
                    },
                    new Course
                    {
                        Title = "Предмет3",
                        Credits = 6,
                        Semester = 1,
                        Programme = "ЕАОИЕ",
                        EducationLevel = "Додипломски студии",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор6" && d.LastName == "Презиме_Професор6").Id,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор5" && d.LastName == "Презиме_Професор5").Id
                    },
                    new Course
                    {
                        Title = "Предмет4",
                        Credits = 6,
                        Semester = 1,
                        Programme = "КТИ",
                        EducationLevel = "Додипломски студии",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор1" && d.LastName == "Презиме_Професор1").Id,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор5" && d.LastName == "Презиме_Професор5").Id
                    },
                    new Course
                    {
                        Title = "Предмет5",
                        Credits = 6,
                        Semester = 1,
                        Programme = "ЕЕС",
                        EducationLevel = "Додипломски студии",
                        FirstTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор2" && d.LastName == "Презиме_Професор2").Id,
                        SecondTeacherId = context.Teacher.Single(d => d.FirstName == "Име_Професор3" && d.LastName == "Презиме_Професор3").Id
                    }
                    );
                context.SaveChanges();

                context.Enrollment.AddRange(
                    new Enrollment { StudentId = 1, CourseId = 5 },
                    new Enrollment { StudentId= 2,CourseId=2},
                    new Enrollment { StudentId =3, CourseId =1},
                    new Enrollment { StudentId =4, CourseId =3},
                    new Enrollment { StudentId =5, CourseId =3},
                    new Enrollment { StudentId =6, CourseId =4}
                    );
                context.SaveChanges();
            }
        }
    }
}
