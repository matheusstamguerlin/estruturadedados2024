// Diferente da TabelaHash, o Dictionay nos permite
// especificar o tipo de dado que será utilizado nos pares
// Key -> Value
// Isso nos fornece uma estrutura fortemente tipada

using System.Data.Common;
using Dicionario;

Dictionary<string, string> dictionary = 
new ()
{
    { "Chave 1", "Valor 1" },
    { "Chave 2", "Valor 2" },
};

// Obter valor do dictionary
string val= dictionary["Chave 1"];

try 
{
    val = dictionary["Chave 3"];
}
catch (Exception  ex)
{
    Console.WriteLine("Erro ao obter valor de chave 3");
    Console.WriteLine(ex.Message);
}

// Verificando se a chave existe antes de acessar
// para evitar erros e prejuízos de execução
if(dictionary.ContainsKey("Chave 2"))
{
    Console.WriteLine($"Chave 2: {dictionary["Chave 2"]}");
}

// Outra forma de obter o valor e evitar erro
dictionary.TryGetValue("Chave 4", out string? valor);
if(valor != null)
   Console.WriteLine($"Chave 4: {valor}");

// Podemos adicionar da mesma forma pela chave inexistente
dictionary["Chave 0"] = "valor 0";

// Percorrer o dicionário
foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}

// Utilizando tipos abstratos de dados com dicionário
Dictionary<int, Person> dicPerson = new Dictionary<int, Person>();
dicPerson.Add(1, new Person(){
    Id = 0,
    BirthDate = new DateTime(2001,5,2),
    Name = "Matheus Stamguerlin"
});
dicPerson.Add(2, new Person(){
    Id = 1,
    BirthDate = new DateTime(2001,5,16),
    Name = "Marco Antônio Dal Vesco" 
    }
);

foreach( KeyValuePair<int, Person> kvp in dicPerson)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}