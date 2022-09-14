namespace Folderizer.Service;
internal class FuzzySearcher
{
    internal List<string> GetMatches(string searchTerm, List<string> items)
    {
        var result = new List<string>();

        var chars = searchTerm.ToCharArray();
        foreach (var item in items)
        {
            if (ItemContainsChars(item, chars))
            {
                result.Add(item);
            }
        }

        return result;
    }

    private bool ItemContainsChars(string item, char[] chars)
    {
        item = item.ToLower();
        foreach (var c in chars)
        {
            if (!item.Contains(c))
            {
                return false;
            } 

            var idx = item.IndexOf(c);
            item = item.Remove(idx, 1);
        }
        return true;
    }
}
