using FluentMappingStudyProject.Data;
using FluentMappingStudyProject.Models;

public class Program
{
    private static void Main(string[] args)
    {
        using var context = new DataContext();
    }
}