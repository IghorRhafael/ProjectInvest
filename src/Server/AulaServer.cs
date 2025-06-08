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
            // Adicione outros módulos conforme necessário
            // case EModulos.Modulo02:
            default:
                return new List<Aula>();
        }
    }

    #region Aulas
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
                Link = "https://drive.google.com/file/d/115udNsK4-5CGfrPYJh_wzk1VOdFymMiP/preview",
                Duracao = "00:15:43"
            },
            new Aula
            {
                Id = 8,
                Nome = "Aula 05 - O que é Liberdade Financeira?",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1ZZp38nOfUCRchfCVKV9T1OOnWnxgv81o/preview",
                Duracao = "00:20:07"
            },
            new Aula
            {
                Id = 9,
                Nome = "Aula 06 - Como não cair em golpes",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1g0ILqDKVc395cWoalrEcbOdmEO-F8IJD/preview",
                Duracao = "00:23:28"
            },
             new Aula
            {
                Id = 10,
                Nome = "Aula 07 - Metade salada e metade droga",
                Tipo = ETipoAulas.Video,
                Link = "https://drive.google.com/file/d/1-UTfp1712fhL_BAJewGb6YJmd_nEzBFY/preview",
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
                Link = "https://drive.google.com/file/d/1Kmv8oLQHL_XrGPaPyQZ7IQ--DoZ-zWCl/preview",
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

    #endregion
}
