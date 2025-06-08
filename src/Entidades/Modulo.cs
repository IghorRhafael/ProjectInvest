using ProjectInvest.Enums;

namespace ProjectInvest.Entidades;

public class Modulo
{
    public EModulos Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public List<Aula> Aulas { get; set; } = new List<Aula>();
}
