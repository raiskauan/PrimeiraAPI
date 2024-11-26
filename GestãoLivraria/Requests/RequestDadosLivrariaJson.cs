namespace GestãoLivraria.Requests;

public class RequestDadosLivrariaJson
{
    public int Id { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
    
}