namespace WebApplication1.Models;

public class Tarefa 
{
    public string? Titulo { get; set;}
    public string? Descricao { get; set;}
    public bool Concluida { get; set;}

    public Tarefa(string Titulo, string Descricao, bool Concluida = false)
    {
        this.Titulo = Titulo;
        this.Descricao = Descricao;
        this.Concluida = Concluida;
    }
}