namespace Aula05___ListaGenerica
{
    public enum CountryEnum{
        BR, PY, JP, IT, AR, 
    }
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public CountryEnum Country { get; set; }
    }
}