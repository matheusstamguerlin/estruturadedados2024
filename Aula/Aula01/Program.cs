    //comentario de uma linha
    /*
    Comentario de Multiplas Linhas
    /*

    //Declarando Variavel 
*/
using Aula01;

int number;
//atribuindo valor
number = 10;

//declarando constante
const int DAYS_IN_WEEK = 7;

//Imprimindo String Concatenada
//Metodo tem nomes de verbos
Console.WriteLine($"A Semana Tem {DAYS_IN_WEEK}dias");

// new TipoEnumerador () -> Invoca o método construtor do objeto
// Toda classe tem o seu construtor padrão implícito sem argumentos/params
// É possível sobrescrever este método especificando argumentos
// Todavia, se o fizermos, perdemos o original implicito e
// precisaremos defini-lo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish =
      tipoEnum.GetLanguageEnum ("ingles");

Console.WriteLine($"O enum de english é {enumEnglish}");
