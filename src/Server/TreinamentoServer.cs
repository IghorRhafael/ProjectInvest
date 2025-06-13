using ProjectInvest.Entidades;
using ProjectInvest.Enums;

namespace ProjectInvest.Server;

public class TreinamentoServer
{
    public static List<Curso> GetCursos()
    {
        var cursos = new List<Curso>
        {
            CursoServer.GetCurso(ECursos.AUVP),
            CursoServer.GetCurso(ECursos.MacroEconomiaGeopolitica),
            CursoServer.GetCurso(ECursos.ImpostoDeRenda),
            CursoServer.GetCurso(ECursos.Lives)
        };

        return cursos;
    }
}
