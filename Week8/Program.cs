using Week8;

var file = new FileResource("file.txt");
var network = new NetworkResource("netRes");
var manager = new ResourceManager<Resource>();
// TODO:
// 1. Add resources to manager
manager.Add(file);
manager.Add(network);

// 2. Open all resources
manager.OpenAll();

// 3. Demonstrate using with one disposable resource
using (file)
{
    Console.WriteLine("Working with file");
}

// 4. Close all resources
manager.CloseAll();

Console.WriteLine("Done.");