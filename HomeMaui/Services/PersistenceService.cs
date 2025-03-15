using System.Text.Json;

namespace HomeMaui.Services;

public class PersistenceService {
    private List<Tuple<string, string>> links { get; set; } 

    public PersistenceService() {
        // generated with ChatGPT
        string jsonString = Preferences.Get("links", string.Empty);
        links = jsonString == string.Empty
            ? new List<Tuple<string, string>>()
            : JsonSerializer.Deserialize<List<Tuple<string, string>>>(jsonString);
    }

    public void AddLink(string name, string url) {
        links.Add(new Tuple<string, string>(name, url));
        SetPrefs();
    }

    public void RemoveLink(Tuple<string, string> link) {
        links.Remove(link);
        SetPrefs();
    }

    public List<Tuple<string, string>> GetLinks() {
        return links;
    }   

    private void SetPrefs() {
        string val = JsonSerializer.Serialize(links);
        Preferences.Set("links", val);
    }

    //public void Dispose() {
    //    Preferences.Set("links", links.ToList().ToString());
    //}
}
