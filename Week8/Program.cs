using Week8;

// Value type demo
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;
// TODO: modify p2 and print both p1 and p2
p2.X = -1;
p1.Print();
p2.Print();
Console.WriteLine();

// Reference type demo
PointRef r1 = new PointRef { X = 1, Y = 2 };
PointRef r2 = r1;
// TODO: modify r2 and print both r1 and r2
r2.X = -1;
r1.Print();
r2.Print();
Console.WriteLine();
//objects are reference-type so r2=r1 will copy pointer on r1 to r2
//struct will be a value type so p1 and p2 are independent 

// Boxing demo
BoxingTester.Test();
//We are boxing value into reference-type (object obja = a), then unboxing it with (int)
