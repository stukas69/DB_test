// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using StudentsInfSystem;


using (var context = new SchoolContext())
{
    //********* 1 uzduotis  ***********

    /*  var student = new Student() { Name = "Tomas" };
      var lecture = new Lecture() { Name = "Anglu kalba" };
      var departament = new Departament() { Name = "Svietimo", Students = new List<Student> { student }, Lectures = new List<Lecture> { lecture } };

      context.Students.Add(student);
      context.Lectures.Add(lecture);
      context.Departaments.Add(departament);
      context.SaveChanges();*/


    //*********  2 uzduotis  ***********

    /*var lecture = new Lecture() { Name = "Begimas" };
    var student = new Student() { Name = "Tukas" };
    var departament = new Departament() { Name = "Sporto" };

    var exsistDepartament = context.Departaments.FirstOrDefault(d => d.Name == departament.Name);

    if (exsistDepartament != departament)
    {
        exsistDepartament.Lectures.Add(lecture);
        exsistDepartament.Students.Add(student);
        context.SaveChanges();

    }*/


    //*********  3 uzduotis  ***********

    /*var departament = new Departament() { Name = "Sveikatos" };
    var lecture = new Lecture { Name = "Rentgenas" };

    var searchDepartament = context.Departaments.FirstOrDefault(u => u.Name == departament.Name);

    if (searchDepartament != departament)
    {
        searchDepartament.Lectures.Add(lecture);
        context.SaveChanges();
    }*/



    //********* 6 uzduotis  ***********

    /*var StudentsInDepartament = context.Departaments.Where(d => d.Name == "Sporto").Include(d => d.Students);

    foreach (var departament in StudentsInDepartament)
    {
        Console.WriteLine($"Departament Name: {departament.Name}");

        var studentsList = departament.Students;

        foreach (var student in studentsList)
        {
            Console.WriteLine(student.Name);
        }

    }*/


    //*********  7 uzduotis ***********

    /*var LecturesInDepartament = context.Departaments.Where(d => d.Name == "Sporto").Include(d => d.Lectures);

    foreach (var departament in LecturesInDepartament)
    {
        var lecturesList = departament.Lectures;
        foreach (var item in lecturesList)
        {
            Console.WriteLine(item.Name);
        }
    }*/

}