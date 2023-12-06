namespace AOCApp;
using AOC23.Implementations;
using System.Diagnostics;

public static class Days
{
    public static void Day01()
    {
        Console.WriteLine(BaseCalibrationFixer.ParseLine("1abc2"));
        var calibrationFixer = new BaseCalibrationFixer(@"/home/lift/projects/AdventOfCode2023/AOCApp/Input/Day01.txt");
        Console.WriteLine("Sum: " + calibrationFixer.GetSum());
    }
}