using System.Globalization;
using System.Text.RegularExpressions;

namespace AOC23.Implementations;
using AOC23.Interfaces;
using System.Collections.Generic;

public class BaseCalibrationFixer(string path) : ICalibrationFixer
{
    private readonly string _path = path;
    private readonly List<int> _results = [];

    /// <summary>
    /// Gets all the digits in a string and returns it as a single number.
    /// </summary>
    /// <param name="line"> String to parse </param>
    /// <returns>Int32 of the joined digits of the parsed string.</returns>
    public static int ParseLine(string line)
    {
        var regex = new Regex(@"\d");
        var result = regex.Matches(line)
            .Select(m => int.Parse(m.Value))
            .ToArray();
        return result.FirstOrDefault()*10 + result.LastOrDefault();
    }
    
    private void ReadFromFile()
    {
        var reader = new StreamReader(_path);
        while (reader.ReadLine() is { } line)
        {
            _results.Add(ParseLine(line));
        }
    }
    
    /// <summary>
    /// Parse the whole file and get the resulting number.
    /// </summary>
    /// <returns>Result of the parse.</returns>
    public IEnumerable<int> GetResult()
    {
        if (_results.Count == 0)
            ReadFromFile();
        return _results.ToArray();
    }

    public void PrintResults()
    {
        foreach (var result in this.GetResult())
        {
            Console.Write(result.ToString() + ", ");
        }
    }

    public int GetSum()
    {
        return GetResult().Sum();
    }
}