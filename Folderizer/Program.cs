// See https://aka.ms/new-console-template for more information


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

using Uiorzo;

var gui = new Uiorzo.Uiorzo();

var list = new ListComponent(10, 10);
gui.AddComponent(list);

var input = new InputComponent();
gui.AddComponent(input);

gui.DrawGui();
