using Week8;

var container = new DataContainer<DataItem>();
for (int i = 0; i < 10000; i++)
{
    var item = new DataItem
    {
        Id = $"item-{i}",
        Payload = new byte[1024]
    };
// TODO: add item to container
container.AddItem(item);
}
Console.WriteLine($"Total size before GC: {container.GetTotalSize()} bytes");

// TODO: call GC.Collect()
GC.Collect();
Console.WriteLine("GC.Collect() was called.");
Console.WriteLine($"Total size after GC: {container.GetTotalSize()} bytes");
Console.WriteLine($"We still have references to elements in stack, because of container instance");

//We still have references to elements in stack, because of container instance, so GC can't delete it from heap