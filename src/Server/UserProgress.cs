using System.Text.Json;
using Microsoft.JSInterop;
using ProjectInvest.Entidades;


namespace ProjectInvest.Server;

public class UserProgressExtensions
{
    public IJSRuntime JS { get; set; } = null!;

    //public async Task<UserProgress?> GetUserProgressAsync(string username)
    //{
    //    var user = await JS.InvokeAsync<string>("localStorage.getItem", "usuarioAtual");

    //    var json = await JS.InvokeAsync<string>("localStorage.getItem", "aulasAssistidas");
    //    if (string.IsNullOrEmpty(json)) return new UserProgress();
    //    return JsonSerializer.Deserialize<UserProgress>(json);
    //}

    public async Task<UserProgress?> GetUserProgressAsync(string username)
    {
        // var user = await JS.InvokeAsync<string>("localStorage.getItem", "usuarioAtual");
        // var json = await JS.InvokeAsync<string>("localStorage.getItem", "aulasAssistidas");

        // if (string.IsNullOrEmpty(json)) return new UserProgress();
        // return JsonSerializer.Deserialize<UserProgress>(json);

        var json = await JS.InvokeAsync<string>("localStorage.getItem", "aulasAssistidas");
        if (string.IsNullOrEmpty(json))
            return new UserProgress();

        try
        {
            // Tenta desserializar como UserProgress
            var progress = JsonSerializer.Deserialize<UserProgress>(json);
            if (progress != null && progress.AulasAssistidas != null)
                return progress;
        }
        catch { }

        try
        {
            // Tenta desserializar como List<int>
            var aulas = JsonSerializer.Deserialize<List<int>>(json);
            if (aulas != null)
                return new UserProgress { AulasAssistidas = aulas };
        }
        catch { }

        return new UserProgress();
    }

    public async Task SaveUserProgressAsync(string username, UserProgress progress)
    {
        var json = JsonSerializer.Serialize(progress);
        await JS.InvokeVoidAsync("localStorage.setItem", "aulasAssistidas", json);
    }
    public async Task MarcarAulaComoAssistida(int aulaId)
    {
        var username = await JS.InvokeAsync<string>("localStorage.getItem", "aulasAssistidas");
        var progress = await GetUserProgressAsync(username) ?? new UserProgress();
        if (!progress.AulasAssistidas.Contains(aulaId))
        {
            progress.AulasAssistidas.Add(aulaId);
            await SaveUserProgressAsync(username, progress);
        }
    }

    public double CalcularProgresso(List<Modulo> modulos, List<int> aulasAssistidas)
    {
        if (modulos == null || modulos.Count == 0) return 0;
        int totalAulas = modulos.Sum(m => m.Aulas?.Count ?? 0);
        if (totalAulas == 0)
            return 0;

        int aulasCompletas = modulos.SelectMany(m => m.Aulas ?? new List<Aula>())
                                    .Count(a => aulasAssistidas.Contains(a.Id));

        return Math.Round((aulasCompletas * 100.0) / totalAulas, 0);
    }
}

public class UserProgress
{
    public List<int> AulasAssistidas { get; set; } = new();
}