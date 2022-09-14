// See https://aka.ms/new-console-template for more information

using Folderizer.Service;
using Uiorzo;

//var folderPath = @"C:\work";

//var foldersInFolderPath = Directory.GetDirectories(folderPath);
//var tuples = new List<(string name, string path)>();
//foreach(var folder in foldersInFolderPath)
//{
//    tuples.Add(new() { name = folder.Split('\\').Last(), path = folder });
//}
//var searcher = new FuzzySearcher();
//var input = Console.ReadLine();
//while(!input.Equals("q"))
//{
//    var res = searcher.GetMatches(input, tuples.Select(a => a.name).ToList());

//    foreach(var item in res)
//    {
//        Console.WriteLine(item);
//    }
//    input = Console.ReadLine();
//}

var gui = new Uiorzo.Uiorzo();

gui.Draw('#');
Thread.Sleep(2500);
gui.Draw('*');

var res = gui.DrawInput();

Thread.Sleep(5000);


