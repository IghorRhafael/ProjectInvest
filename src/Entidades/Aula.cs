using ProjectInvest.Enums;

namespace ProjectInvest.Entidades;

public class Aula
{
    public int Id { get; set; } // Adicionando ID para identificar a aula
    public string Nome { get; set; } = string.Empty;
    public ETipoAulas Tipo { get; set; } // "video", "ebook", "material"
    public string Link { get; set; } = string.Empty;
    public string Duracao { get; set; } = string.Empty;
}
