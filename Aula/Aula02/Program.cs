using System.Diagnostics;
using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1 = new Person("Matheus Stamguerlin,",23);
Console.WriteLine(person1.Name);

Person person2 = new Person();
person2.Name = "Willian Ferreira";
person2.Age = 22;
Console.WriteLine(person2.Name);

Person person3 = new Person ()
{
    Name = "Kalil da Rosa",
    Age = 20
};
Console.WriteLine(person3.Name);




