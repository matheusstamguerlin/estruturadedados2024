// Uma fila é a estrutura de dados que
// pode ser aplicada para representar
// a fila de atendimento da cantina
// As pessoas que chegam entram no final da fila
// e as primeiras que chegaram são as primeiras 
// a serem atendidas.

// A função ENQUEUE é responsável por adicionar
// novos elementos à fila

// A função DEQUEUE remove elementos da fila.

// Desta forma, obedece o prinncípio do FIFO
// First In, First Out -> Primeiro que entra
// é o primeiro que sai

using Aula06___Filas;

Random  random = new Random();

CallCenter center = new CallCenter();
center.Call(1234) ;
center.Call(1369) ;
center.Call(2468) ; 
center.Call(1478) ;

while(center.AreWaitingCalls())
{
    Thread.Sleep(3000) ;
    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(
        @$"{DateTime.Now.ToString ("HH:mm:ss")} 
         Chamado: Call: #{call.Id}
         De: {call.ClientID}
         Atendido por: {call.Consultant}"
    );
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(
        @$"Chamado: {call.Id}
        Encerrado às: {call.EndTime}"
    );
}
wdaqef w|