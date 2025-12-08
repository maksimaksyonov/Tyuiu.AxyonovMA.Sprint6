public string CollectTextFromFile(string path)
{
    if (!File.Exists(path))
    {
        throw new FileNotFoundException("Файл не найден", path);
    }

    string text = File.ReadAllText(path);

    // Разделители слов
    char[] separators =
    {
        ' ', '\t', '\r', '\n',
        ',', '.', ';', ':', '!', '?',
        '-', '—', '(', ')', '[', ']', '\"', '\'', '/'
    };

    string[] parts = text.Split(
        separators,
        StringSplitOptions.RemoveEmptyEntries);

    List<string> resultWords = new List<string>();

    foreach (string word in parts)
    {
        // ВАЖНО: учитываем только строчную 'g', заглавную 'G' игнорируем
        if (word.Contains('g'))
        {
            resultWords.Add(word);
        }
    }

    // результирующая строка для вывода в textBoxOut
    return string.Join(" ", resultWords);
}
