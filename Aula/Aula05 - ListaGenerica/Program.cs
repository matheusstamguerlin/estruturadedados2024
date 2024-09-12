using Aula05___ListaGenerica;
List<double> numbers = new List<double>();

do
{
    Console.WriteLine("Informe um número:");
    string? numberStr = Console.ReadLine();
    // Validando a entrada do usuário
    if(!double.TryParse(numberStr, out double number))
    {
        break;
    }
    numbers.Add(number);
    Console.WriteLine($"Á média dos valores é {numbers.Average()}");
}
while(true);

// -- Lista de Pessoas
List<Person> people = new List<Person>();
Person p1 = new Person();
p1.Name = "Matheus";
p1.Age = 23;
p1.Country = CountryEnum.PY;
people.Add(p1);

p1.Name = "Matheus da Silva Stamguerlin";

people.Add( new Person() {
    Name = "Sharon Stone",
    Age = 50,
    Country = CountryEnum.PY,
});

Person p3 = new Person (){
    Name = "Arnold e SuasNega",
    Age = 65,
    Country = CountryEnum.JP
};
people.Add(p3);

// Formas de percorrer a Lista Genérica
foreach(Person p in people)
{
    Console.WriteLine(p.Name);
}

// Modo for tradicional
for(int i = 0; i < people.Count; i++)
{
    Console.WriteLine(people[i].Name);
}