namespace AOCApp;
using AOC23.Implementations;
using System.Diagnostics;

public static class Days
{
    public static void Day01()
    {
        var calibrationFixer = new BaseCalibrationFixer(@"/home/lift/projects/AdventOfCode2023/AOCApp/Input/Day01.txt");
        Console.WriteLine(calibrationFixer.ParseLine("1abc2"));
        Console.WriteLine("Sum: " + calibrationFixer.GetSum().ToString());
    }
}