using AdvancedLINQ.Entities;
using AdvancedLINQ.Enums;
using AdvancedLINQ.Helpers;

List<Subject> Subjects = new List<Subject>()
{
            new Subject(1,"C# Basic", Academy.Programing),
            new Subject(2,"Unit Testing", Academy.Testing),
            new Subject(3,"ISO/OSI",Academy.Networks),
            new Subject(4,"JavaScript Advanced", Academy.Programing),
            new Subject(5,"Automation Testing", Academy.Testing),
            new Subject(6,"Networking Interfaces", Academy.Networks),
            new Subject(7,"MVC", Academy.Programing)

};

List<Student> Students = new List<Student>()
{
            new Student(1,"Bob","Bobsky",new List<Subject>(){Subjects[1],Subjects[2]} ),
            new Student(2,"Miki","Miksi",new List<Subject>(){Subjects[1],Subjects[2],Subjects[3]} ),
            new Student(3,"David","Davidski",new List<Subject>(){Subjects[5],Subjects[1],Subjects[5]} ),
            new Student(4,"Nikola","Nikolski",new List<Subject>(){Subjects[5],Subjects[6],Subjects[3]} ),
            new Student(5,"Cvetan","Miksi",new List<Subject>(){Subjects[1],Subjects[3],Subjects[5]} )
};



//List<Student> studentsWithSameLastName = Students.Where(x => x.LastName == "Miksi").ToList();

//studentsWithSameLastName.Print();

//Students.Select(x => $"{x.FirstName} {x.LastName}").ToList().ForEach(x => Console.WriteLine(x));

//List<Student> studentsNetworks = Students.Where(x => x.Subjects.Any(x => x.AcademyType == Academy.Testing)).ToList();

//Student stunentNameMiki = Students.FirstOrDefault(x => x.FirstName == "Miki");

//Subject someSubject = Subjects.LastOrDefault(x => x.Id == 20);

//Student sameLastName = Students.Single(x => x.LastName == "Nikolski");

//Subject singleTypeProgramingSubject = Subjects.SingleOrDefault(x => x.AcademyType == Academy.Programing);

//Students.SelectMany(x => x.Subjects).Distinct().ToList().Print();

//bool hasBob = Students.Any(x => x.FirstName == "Bob");
//Console.WriteLine(hasBob);

//bool allAreBob = Students.All(x => x.FirstName == "Bob");
//Console.WriteLine(allAreBob);

//bool sameIds =Students.All(x => x.Id == 1);
//Console.WriteLine(sameIds);

////Subjects.Except(new List<Subject>() {someSubject}).ToList().Print();

//Students.OrderBy(x => x.FirstName).ThenBy(x=> x.Id).ToList().Print();

//Subjects.OrderByDescending(x => x.Id).ToList().Print();
// (3 1 2) , (9, 2, 1) , (5 , 2 ,3) -> (3 , 1, 2 , 9 , 2 , 1, 5 , 2, 3) -> 
Students.SelectMany(x => x.Subjects.OrderBy(x => x.Name)).ToList().Print();

Console.WriteLine(Students.SelectMany(x => x.Subjects).Distinct().OrderBy(x => x.Name).LastOrDefault().Name); 