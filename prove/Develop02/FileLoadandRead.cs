using System;
using System.Collections.Generic;
using System.IO;

public class FileLoadRead
{
  private List<Write1> entrylist = new List<Write1>();

  public void WriteFile(List<Write1> entrylist)
  {
    string filename = PromptFile("What is the filename? ");
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (var entry in entrylist)
      {
        outputFile.WriteLine(entry.Something());
      }
    }
  }

  public string PromptFile(string promptquestion)
  {
    Console.Write(promptquestion);
    // muestra un mensaje al usuario
    string filename = Console.ReadLine();
    // lee una línea desde la consola
    return filename;
  }

  public List<Write1> ReadFile()
  {
    string filename = PromptFile("What is the filename? ");
    string[] lines = File.ReadAllLines(filename);
    foreach (string line in lines)
    {
      string[] parts = line.Split(",");
      Write1 write = new Write1();
      write.CreateList(parts);
      entrylist.Add(write);
    }
    return entrylist;
  }
}