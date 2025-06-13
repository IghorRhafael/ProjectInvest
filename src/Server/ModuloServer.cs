using ProjectInvest.Entidades;
using ProjectInvest.Enums;

namespace ProjectInvest.Server;

public class ModuloServer
{
    public static List<Modulo> GetModulos(ECursos curso)
    {
        return curso switch
        {
            ECursos.AUVP => GetModuloAUVP(),
            ECursos.MacroEconomiaGeopolitica => GetModuloMacroEconomiaGeopolitica(),
            ECursos.ImpostoDeRenda => GetModuloImpostoDeRenda(),
            ECursos.Lives => GetModuloLives(),
            _ => throw new ArgumentOutOfRangeException(nameof(curso), curso, null)
        };
    }

    private static List<Modulo> GetModuloAUVP()
    {
        var moduloAUVP = new List<Modulo>
        {
            GetModulo01(),
            GetModulo02(),
            GetModulo03(),
            GetModulo04(),
            GetModulo05(),
            GetModulo06(),
            GetModulo07(),
            GetModuloBonusIndicadores(),
            GetModuloBonusAUVP()
        };
        return moduloAUVP;
    }

    private static List<Modulo> GetModuloMacroEconomiaGeopolitica()
    {
        return new List<Modulo>
        {
            GetMacroEconomiaModulo01()
        };
    }

    private static List<Modulo> GetModuloImpostoDeRenda()
    {
        return new List<Modulo>
        {
            GetImpostoDeRendaModulo01(),
        };
    }

    private static List<Modulo> GetModuloLives()
    {
        return new List<Modulo>
        {
            GetLives()
        };
    }

    #region ModulosAUVP
    private static Modulo GetModulo01()
    {
        var modulo1 = new Modulo
        {
            Id = EModulos.Modulo01,
            Nome = "Módulo 01",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo01)
        };

        return modulo1;
    }

    private static Modulo GetModulo02()
    {
        return new Modulo
        {
            Id = EModulos.Modulo02,
            Nome = "Módulo 02",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo02)
        };
    }
    private static Modulo GetModulo03()
    {
        return new Modulo
        {
            Id = EModulos.Modulo03,
            Nome = "Módulo 03",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo03)
        };
    }
    private static Modulo GetModulo04()
    {
        return new Modulo
        {
            Id = EModulos.Modulo04,
            Nome = "Módulo 04",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo04)
        };
    }
    private static Modulo GetModulo05()
    {
        return new Modulo
        {
            Id = EModulos.Modulo05,
            Nome = "Módulo 05",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo05)
        };
    }
    private static Modulo GetModulo06()
    {
        return new Modulo
        {
            Id = EModulos.Modulo06,
            Nome = "Módulo 06",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo06)
        };
    }
    private static Modulo GetModulo07()
    {
        return new Modulo
        {
            Id = EModulos.Modulo07,
            Nome = "Módulo 07",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo07)
        };
    }

    private static Modulo GetModuloBonusIndicadores()
    {
        return new Modulo
        {
            Id = EModulos.ModuloBonusIndicadores,
            Nome = "Módulo Bônus - Indicadores",
            Aulas = AulaServer.GetAulasModulo(EModulos.ModuloBonusIndicadores)
        };
    }

    private static Modulo GetModuloBonusAUVP()
    {
        return new Modulo
        {
            Id = EModulos.ModuloBonusMasterclasses,
            Nome = "Módulo Bônus - Masterclasses",
            Aulas = AulaServer.GetAulasModulo(EModulos.ModuloBonusMasterclasses)
        };
    }
    #endregion

    #region ModulosMacroEconomiaGeopolitica
    private static Modulo GetMacroEconomiaModulo01()
    {
        return new Modulo
        {
            Id = EModulos.Modulo01,
            Nome = "Macroeconomia e Geopolítica",
            Aulas = AulaServer.GetAulasMacroEconomiaGeopolitica(EModulos.Modulo01)
        };
    }
    #endregion

    #region ModulosImpostoDeRenda
    private static Modulo GetImpostoDeRendaModulo01()
    {
        return new Modulo
        {
            Id = EModulos.Modulo01,
            Nome = "Imposto de Renda",
            Aulas = AulaServer.GetAulasImpostoDeRenda(EModulos.Modulo01)
        };
    }
    #endregion

    #region ModulosLives
    private static Modulo GetLives()
    {
        return new Modulo
        {
            Id = EModulos.Modulo01,
            Nome = "Lives - Duvidas e Respostas",
            Aulas = AulaServer.GetLives()
        };
    }
    #endregion

}

