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
            GetMacroEconomiaModulo01(),
            GetMacroEconomiaModulo02(),
            GetMacroEconomiaModulo03(),
            GetMacroEconomiaModulo04(),
            GetMacroEconomiaModulo05()
        };
    }

    private static List<Modulo> GetModuloImpostoDeRenda()
    {
        return new List<Modulo>
        {
            GetImpostoDeRendaModulo01(),
            GetImpostoDeRendaModulo02(),
            GetImpostoDeRendaModulo03(),
            GetImpostoDeRendaModulo04()
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
            Nome = "Módulo 01 - Introdução",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo01)
        };
    }
    private static Modulo GetMacroEconomiaModulo02()
    {
        return new Modulo
        {
            Id = EModulos.Modulo02,
            Nome = "Módulo 02 - Fundamentos",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo02)
        };
    }
    private static Modulo GetMacroEconomiaModulo03()
    {
        return new Modulo
        {
            Id = EModulos.Modulo03,
            Nome = "Módulo 03 - Análise de Cenários",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo03)
        };
    }
    private static Modulo GetMacroEconomiaModulo04()
    {
        return new Modulo
        {
            Id = EModulos.Modulo04,
            Nome = "Módulo 04 - Indicadores Econômicos",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo04)
        };
    }
    private static Modulo GetMacroEconomiaModulo05()
    {
        return new Modulo
        {
            Id = EModulos.Modulo05,
            Nome = "Módulo 05 - Política Monetária",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo05)
        };
    }
    #endregion

    #region ModulosImpostoDeRenda
    private static Modulo GetImpostoDeRendaModulo01()
    {
        return new Modulo
        {
            Id = EModulos.Modulo01,
            Nome = "Módulo 01 - Introdução ao Imposto de Renda",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo01)
        };
    }
    private static Modulo GetImpostoDeRendaModulo02()
    {
        return new Modulo
        {
            Id = EModulos.Modulo02,
            Nome = "Módulo 02 - Declaração de Imposto de Renda",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo02)
        };
    }
    private static Modulo GetImpostoDeRendaModulo03()
    {
        return new Modulo
        {
            Id = EModulos.Modulo03,
            Nome = "Módulo 03 - Deduções e Isenções",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo03)
        };
    }
    private static Modulo GetImpostoDeRendaModulo04()
    {
        return new Modulo
        {
            Id = EModulos.Modulo04,
            Nome = "Módulo 04 - Restituição e Malha Fina",
            Aulas = AulaServer.GetAulasModulo(EModulos.Modulo04)
        };
    }
    #endregion
}

