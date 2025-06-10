using System.Text.Json;
using Microsoft.JSInterop;
using ProjectInvest.Entidades;


namespace ProjectInvest.Server;

public static class UserProgressExtensions
{
    public static IJSRuntime JS { get; set; }

    public static async Task<UserProgress?> GetUserProgressAsync(string username)
    {
        var json = await JS.InvokeAsync<string>("localStorage.getItem", username);
        if (string.IsNullOrEmpty(json)) return new UserProgress();
        return JsonSerializer.Deserialize<UserProgress>(json);
    }

    public static async Task SaveUserProgressAsync(string username, UserProgress progress)
    {
        var json = JsonSerializer.Serialize(progress);
        await JS.InvokeVoidAsync("localStorage.setItem", username, json);
    }
    public static async Task MarcarAulaComoAssistida(int aulaId)
    {
        var username = await JS.InvokeAsync<string>("localStorage.getItem", "usuarioAtual");
        var progress = await GetUserProgressAsync(username) ?? new UserProgress();
        if (!progress.AulasAssistidas.Contains(aulaId))
        {
            progress.AulasAssistidas.Add(aulaId);
            await SaveUserProgressAsync(username, progress);
        }
    }

    public static double CalcularProgresso(List<Modulo> modulos, List<int> aulasAssistidas)
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