using ProjectInvest.Entidades;
using ProjectInvest.Enums;

namespace ProjectInvest.Server;

public class AulaServer
{
    public static List<Aula> GetAulasModulo(EModulos moduloId)
    {
        switch (moduloId)
        {
            case EModulos.Modulo01:
                return AulasModulo01();
            case EModulos.Modulo02:
                return AulasModulo02();
            case EModulos.Modulo03:
                return AulasModulo03();
            default:
                return new List<Aula>();
        }
    }

    public static List<Aula> GetLives()
    {
        return ModuloLives();
    }

    public static List<Aula> GetAulasMacroEconomiaGeopolitica(EModulos moduloId)
    {
        switch (moduloId)
        {
            case EModulos.Modulo01:
                return GetAulasMacroEconomia01();
            default:
                return new List<Aula>();
        }
    }

    public static List<Aula> GetAulasImpostoDeRenda(EModulos moduloId)
    {
        switch (moduloId)
        {
            case EModulos.Modulo01:
                return GetAulasImpostoDeRenda01();
            default:
                return new List<Aula>();
        }
    }

    #region Aulas Modulo 1
    private static List<Aula> AulasModulo01()
    {
        var aulas = new List<Aula>
        {
            new Aula
            {
                Id = 1,
                Nome = "Live inaugural - Saindo da Caverna",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/7o3bZFnwXtc?si=Aptv8zMBngzOrefX",
                Duracao = "01:39:00"
            },
            new Aula
            {
                Id = 2,
                Nome = "Aula 0 - Boas vindas e aprendendo sobre a plataforma.",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1S8or53V7BNaabrsOaIBGfS6IW-a50AV4/preview",
                Duracao = "00:08:53"
            },
            //new Aula
            //{
            //    Id = 3,
            //    Nome = "Ebook",
            //    Tipo = ETipoAulas.Ebook,
            //    Link = "https://drive.google.com/file/d/1W6E0DxEwGu-vicw3Bq3DLaC5RoVL8-zu/preview",
            //    Duracao = "00:00:00"
            //},
             new Aula
            {
                Id = 4,
                Nome = "Aula 01 - Preparando seu cérebro",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1fhnq5rCMyM0JtLJfliSdZzU619a3C5Cd/preview",
                Duracao = "00:05:00"
            },
            new Aula
            {
                Id = 5,
                Nome = "Aula 02 - Por que os ricos ficam cada vez mais ricos?",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1nmArhqi7T9T1MYxHIH2eWVnGNo1E3KCI/preview",
                Duracao = "00:13:37"
            },
            new Aula
            {
                Id = 6,
                Nome = "Aula 03 - Crenças limitantes",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1Mbvow0t8hodahwD248Eme1Rwx2uLZtXM/preview",
                Duracao = "00:17:09"
            },
             new Aula
            {
                Id = 7,
                Nome = "Aula 04 - Juros Compostos",
                Tipo = ETipoAulas.Video,
                //Link = "https://drive.google.com/file/d/115udNsK4-5CGfrPYJh_wzk1VOdFymMiP/preview",
                Link = "https://www.youtube.com/embed/YL4ebynnXVo",
                Duracao = "00:15:43"
            },
            new Aula
            {
                Id = 8,
                Nome = "Aula 05 - O que é Liberdade Financeira?",
                Tipo = ETipoAulas.Video,
                // Link = "https://drive.google.com/file/d/1ZZp38nOfUCRchfCVKV9T1OOnWnxgv81o/preview",
                Link = "https://www.youtube.com/embed/9yTmKqgmu7E",
                Duracao = "00:20:07"
            },
            new Aula
            {
                Id = 9,
                Nome = "Aula 06 - Como não cair em golpes",
                Tipo = ETipoAulas.Video,
                // Link = "https://drive.google.com/file/d/1g0ILqDKVc395cWoalrEcbOdmEO-F8IJD/preview",
                Link = "https://www.youtube.com/embed/q-6t16mW9OE",
                Duracao = "00:15:21"
            },
             new Aula
            {
                Id = 10,
                Nome = "Aula 07 - Metade salada e metade droga",
                Tipo = ETipoAulas.Video,
                // Link = "https://drive.google.com/file/d/1-UTfp1712fhL_BAJewGb6YJmd_nEzBFY/preview",
                Link = "https://www.youtube.com/embed/XK2fSuZ_6rU",
                Duracao = "00:07:19"
            },
            new Aula
            {
                Id = 11,
                Nome = "Aula 08 - Autoajuda é o caralho",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1pOgJe34GMLv8ovj_UuUk0SyIq2Zbsy9o/preview",
                Duracao = "00:11:09"
            },
            new Aula
            {
                Id = 12,
                Nome = "Aula 09 - Pare de procrastinar",
                Tipo = ETipoAulas.Video,
                // Link = "https://drive.google.com/file/d/1Kmv8oLQHL_XrGPaPyQZ7IQ--DoZ-zWCl/preview",
                Link = "https://www.youtube.com/embed/hg6hvaoBl3Q",
                Duracao = "00:13:33"
            },
            new Aula
            {
                Id = 13,
                Nome = "Aula 10 - Aula da família",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1WKMtJrnNXr7O_2sHZd-yXPsW3tb98COa/preview",
                Duracao = "01:21:33"
            },
            new Aula
            {
                Id = 14,
                Nome = "Aula Bônus - Onde investir sua reserva de emergência",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1Vs-_2HywdFUulBHdr2DrixVMGKob_joX/preview",
                Duracao = "00:11:16"
            },

        };
        return aulas;
    }

    private static List<Aula> AulasModulo02()
    {
        var aulas = new List<Aula>
        {
            new Aula
            {
                Id = 15,
                Nome = "Aula 01 - Finanças Pessoais",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/Ev5rC2ogtz8?si=IUjO1dDItv8hIqZX",
                Duracao = "00:20:31"
            },
            new Aula
            {
                Id = 16,
                Nome = "Aula 02 - Como usar seu Cartão de Crédito",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/Xgiax70lbRg?si=lwDz3ApGfwWYxyes",
                Duracao = "00:19:01"
            },
            new Aula
            {
                Id = 17,
                Nome = "Aula 03 - Como resolver as dividas",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1pjRJRzIj4p0dAuF4HzDB0lsmi5XzGOHq/preview",
                Duracao = "00:05:56"
            },
            new Aula
            {
                Id = 18,
                Nome = "Aula 04 - Financiamento de imóvel, faz sentido?",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/kK7PM2sRnjY?si=VlO6SIIzT-Qn0_QS",
                Duracao = "00:19:40"
            },
            new Aula
            {
                Id = 19,
                Nome = "Aula 05 - Consorcios são tops?",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/15WI0MUHKxF3xpX-oVmY2lFM2D5qk0QIq/preview",
                Duracao = "00:09:31"
            },
            new Aula
            {
                Id = 20,
                Nome = "Aula 06 - Viver de renda Primeiro Milhão",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/JXcney51u-o?si=zEUxm97gvOejncwt",
                Duracao = "00:10:18"
            },
        };
        return aulas;
    }

    private static List<Aula> AulasModulo03()
    {
        var aulas = new List<Aula>
        {
            new Aula
            {
                Id = 21,
                Nome = "Aula 01 - O que é renda fixa?",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/V7qjOpnAviI?si=JFqgTUTwevGlkyh-",
                Duracao = "00:11:40"
            },
            new Aula
            {
                Id = 22,
                Nome = "Aula 02 - Escolhendo uma corretora",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/jV4Mpa7urX8?si=Z-zTqCIro-5ZS8eJ",
                Duracao = "00:13:20"
            },
            new Aula
            {
                Id = 23,
                Nome = "Aula 03 - Introdução ao Tesouro Direto",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/fryzsTUMzFM?si=DK0GjF54KG5S72HJ",
                Duracao = "00:17:55"
            },
            new Aula
            {
                Id = 24,
                Nome = "Aula 04 - Tesouro Selic",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/hHI00U37emo?si=_q2v2Rm4aB9Nw6Jb",
                Duracao = "00:15:49"
            },
            new Aula
            {
                Id = 25,
                Nome = "Aula 05 - TEsouro Pré-fixado",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/U2H5tT6Hefo?si=HFjKRIyyyfGsAxLr",
                Duracao = "00:13:51"
            },
            new Aula
            {
                Id = 26,
                Nome = "Aula 06 - Tesouro IPCA+",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/JSjpgDB6Lrc?si=koRmXo9b8dBlDoek",
                Duracao = "00:07:50"
            },
            new Aula
            {
                Id = 27,
                Nome = "Aula 07 - Marcação a mercado",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/h5VGVAfi574?si=R6mcIsZkjfw9QfUy",
                Duracao = "00:03:32"
            },
            new Aula
            {
                Id = 28,
                Nome = "Aula 07 - Marcação a mercado - Parte 2",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/fvnp3A4N2-0?si=r2Cwm-DkY1Keq05r",
                Duracao = "00:18:00"
            },
            new Aula
            {
                Id = 29,
                Nome = "Aula 08 - Juros Semestrais",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/3hj_CIlou5k?si=BMvpwA6KffDYY3oy",
                Duracao = "00:05:19"
            },
            new Aula
            {
                Id = 30,
                Nome = "Aula 09 - Tesouro Educa+ e Renda+",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/8GPTzWmOOr0?si=JgZFeuF6Hr6nmob2",
                Duracao = "00:06:31"
            },
            new Aula
            {
                Id = 31,
                Nome = "Aula 10 - CDBs, LCs e RDBs",
                Tipo = ETipoAulas.Video,
                Link = "XXXXXXXX",
                Duracao = "00:27:00"
            },
            new Aula
            {
                Id = 32,
                Nome = "Aula 11 - LCI e LCA",
                Tipo = ETipoAulas.Video,
                Link = "XXXXXXXX",
                Duracao = "00:08:15"
            },
            new Aula
            {
                Id = 33,
                Nome = "Aula 12 - CRI's e CRA's",
                Tipo = ETipoAulas.Video,
                Link = "XXXXXXXX",
                Duracao = "00:10:58"
            },
            new Aula
            {
                Id = 34,
                Nome = "Aula 13 - Debêntures",
                Tipo = ETipoAulas.Video,
                Link = "XXXXXXXX",
                Duracao = "00:17:21"
            },
            new Aula
            {
                Id = 35,
                Nome = "Aula 14 - Fundos de Investimentos",
                Tipo = ETipoAulas.Video,
                Link = "XXXXXXXX",
                Duracao = "00:24:38"
            },
            new Aula
            {
                Id = 36,
                Nome = "Aula 15 - PRevidência Privada",
                Tipo = ETipoAulas.Video,
                Link = "XXXXXXXX",
                Duracao = "00:11:19"
            },
            new Aula
            {
                Id = 37,
                Nome = "Aula 16 - Contrafluxo",
                Tipo = ETipoAulas.Video,
                Link = "XXXXXXXX",
                Duracao = "00:26:07"
            },
            new Aula
            {
                Id = 38,
                Nome = "Aula 17 - Montando uma carteira de Renda Fixa",
                Tipo = ETipoAulas.Video,
                Link = "XXXXXXXX",
                Duracao = "00:07:55"
            },

        };
        return aulas;
    }
    #endregion

    #region Aulas Macro Economia e Geopolítica
    private static List<Aula> GetAulasMacroEconomia01()
    {
        var aulas = new List<Aula>
        {
            new Aula
            {
                Id = 201,
                Nome = "Aula 00 - Boas Vindas",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:19:40"
            },
            new Aula
            {
                Id = 202,
                Nome = "Aula 01 - Retorno do Império do Meio",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:32:52"
            },
            new Aula
            {
                Id = 203,
                Nome = "Aula 02 - A Ascensão Econômica da China",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:39:04"
            },
            new Aula
            {
                Id = 204,
                Nome = "Aula 03 - Desafios e Futuro da China",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:55:37"
            },
        };
        return aulas;
    }

    #endregion

    #region Aulas Imposto de Renda
    private static List<Aula> GetAulasImpostoDeRenda01()
    {
        var aulas = new List<Aula>
        {
            new Aula
            {
                Id = 401,
                Nome = "Aula 01 - O que é Imposto de Renda?",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:17:41"
            },
            new Aula
            {
                Id = 402,
                Nome = "Aula 02 - Preparando a delcaração",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:09:05"
            },
            new Aula
            {
                Id = 403,
                Nome = "Aula 03 - O que é e como funciona o IR no Brasil",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:24:38"
            },
            new Aula
            {
                Id = 404,
                Nome = "Aula 04 - Declarando Ações",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:45:20"
            },
            new Aula
            {
                Id = 405,
                Nome = "Aula 05 - Imposto de Renda na Renda Fixa",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:17:00"
            },
            new Aula
            {
                Id = 406,
                Nome = "Aula 06 - Imposto de Renda nos Fundos de Investimento",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:05:32"
            },
            new Aula
            {
                Id = 407,
                Nome = "Aula 07 - Imposto de Renda nos FIIS, Fiagros e FI-Infras",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:14:03"
            },
            new Aula
            {
                Id = 408,
                Nome = "Aula 08 - Declarando dividendos, JCP, redimentos e bonificações",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:21:24"
            },
            new Aula
            {
                Id = 409,
                Nome = "Aula 09 - Investimentos Internacionais",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:19:25"
            },
            new Aula
            {
                Id = 410,
                Nome = "Aula 10 - Criptomoedas",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:24:45"
            },
            new Aula
            {
                Id = 411,
                Nome = "Aula 11 - Como gerar um DARF?",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:06:41"
            },
            new Aula
            {
                Id = 412,
                Nome = "Aula 12 - Declaração de Autôlnomo com Carnê-Leão",
                Tipo = ETipoAulas.Video,
                Link = "",
                Duracao = "00:08:17"
            }

        };

        return aulas;
    }
    #endregion

    #region Lives
    private static List<Aula> ModuloLives()
    {
        var aulas = new List<Aula>
        {
            new Aula
            {
                Id = 901,
                Nome = "Live 01 - ETF GPUS11 Vale a pena?",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/MEcPsdsbMzU?si=ODfMMtunTNTAUjPj",
                Duracao = "01:58:14"
            },
            new Aula
            {
                Id = 902,
                Nome = "Live 02 - Novos Impostos do Andrade",
                Tipo = ETipoAulas.Video,
                Link = "https://www.youtube.com/embed/8sr_WrLFa7c?si=vsstBewpvpIKA3V5",
                Duracao = "01:48:00"
            },
            // Adicione mais aulas conforme necessário
        };
        return aulas;
    }
    #endregion

}
