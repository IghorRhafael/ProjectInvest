using ProjectInvest.Enums;

namespace ProjectInvest.Entidades;

public class Curso
{
    public ECursos Id { get; set; } // Identificador do curso, usado para referenciar o curso específico
    public string Titulo { get; set; } = string.Empty;
    public string ImagemUrl { get; set; } = string.Empty;
    public int Progresso { get; set; } // 0-100
    public string ArquivoRegistro { get; set; } = string.Empty; // Nome do arquivo JSON com progresso
    public List<Modulo> Modulos { get; set; } = new List<Modulo>();
}
