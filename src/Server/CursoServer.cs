using ProjectInvest.Entidades;
using ProjectInvest.Enums;

namespace ProjectInvest.Server;

public class CursoServer
{
    public static Curso GetCurso(ECursos eCursos)
    {
        return eCursos switch
        {
            ECursos.AUVP => GetCursoAUVP(),
            ECursos.MacroEconomiaGeopolitica => GetCursoMacroEconomiaGeopolitica(),
            ECursos.ImpostoDeRenda => GetCursoImpostoDeRenda(),
            _ => throw new ArgumentOutOfRangeException(nameof(eCursos), eCursos, null)
        };
    }

    private static Curso GetCursoAUVP()
    {
        var cursoAUVP = new Curso
        {
            Id = ECursos.AUVP,
            Titulo = "AUVP - A ÚNICA VERDADE POSSÍVEL",
            ImagemUrl = "https://lwfiles.mycourse.app/65f0605f45786c13a78a559b-public/custom/400x0_820adb0afb9f4714b2adbcdcf8d68fdf.png",
            Progresso = 0,
            ArquivoRegistro = "curso-auvp.json",
            Modulos = ModuloServer.GetModulos(ECursos.AUVP)
        };

        return cursoAUVP;
    }

    private static Curso GetCursoMacroEconomiaGeopolitica()
    {
        var cursoMacroEconomia = new Curso
        {
            Id = ECursos.MacroEconomiaGeopolitica,
            Titulo = "Macro Economia e Geopolítica",
            ImagemUrl = "https://api.us-e1.learnworlds.com/imagefile/https://lwfiles.mycourse.app/65f0605f45786c13a78a559b-public/c6d953cbf87cade0dde291984e95c22b.jpg?client_id=65f0605f45786c13a78a559b&width=400&height=0",
            Progresso = 0,
            ArquivoRegistro = "curso-macro-economia-geopolitica.json",
            Modulos = ModuloServer.GetModulos(ECursos.MacroEconomiaGeopolitica)
        };

        return cursoMacroEconomia;
    }

    private static Curso GetCursoImpostoDeRenda()
    {
        var cursoImpostoRenda = new Curso
        {
            Id = ECursos.ImpostoDeRenda,
            Titulo = "Imposto de Renda",
            ImagemUrl = "https://api.us-e1.learnworlds.com/imagefile/https://lwfiles.mycourse.app/65f0605f45786c13a78a559b-public/8ae18521b48fab92bf8b592ad9c717c6.jpg?client_id=65f0605f45786c13a78a559b&width=400&height=0",
            Progresso = 0,
            ArquivoRegistro = "curso-imposto-de-renda.json",
            Modulos = ModuloServer.GetModulos(ECursos.ImpostoDeRenda)
        };

        return cursoImpostoRenda;
    }
}
