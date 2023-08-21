using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers;

[ApiController]
[Route("api/tarefa")]

public class TarefaController : ControllerBase
{

    private List<Tarefa> tarefas = new List<Tarefa>();
    public bool MarcarComoConcluida()
    {
        
        return true;
    }


    [HttpPost]
    [Route("adicionar")]
    public Tarefa AdicionarTarefa(Tarefa tarefa)
    {
        ListaDeTarefas.Tarefas.Add(tarefa);
        return Ok("Tarefa adicionada")
    }
}