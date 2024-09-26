namespace Aula06___Filas
{
    
        // Esta classe representa a fila
        // chamados em um CallCenter
        public class IncomingCall
        {
            public int Id { get;set; }
            public int ClientID { get;set; }
            public DateTime CallTime { get;set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string? Consultant { get; set; }
        
        }
    
}