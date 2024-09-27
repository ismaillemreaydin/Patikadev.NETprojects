using System;
using System.Collections.Generic;
using System.Linq;

public class Vote
{
    private Dictionary<string, int> categories = new Dictionary<string, int>()
    {
        { "Film Kategorileri", 0 },
        { "Tech Stack Kategorileri", 0 },
        { "Spor Kategorileri", 0 }
    };

    public Dictionary<string, int> GetCategories()
    {
        return categories;
    }

    public void CastVote(string category)
    {
        if (categories.ContainsKey(category))
        {
            categories[category]++;
        }
    }

    public string GetResults()
    {
        int totalVotes = categories.Values.Sum();
        string result = "";

        foreach (var category in categories)
        {
            double percentage = totalVotes > 0 ? (double)category.Value / totalVotes * 100 : 0;
            result += $"{category.Key}: {category.Value} oy (%{percentage:F2})\n";
        }

        return result;
    }
}
