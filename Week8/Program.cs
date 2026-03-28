using Week8;

// Value type demo
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1; // Тут у нас створюється копія саме значень, що містяться в р1. Тому при модифікації р2 р1 ніяк не зміниться, бо вони не залежні.
p2.X = 3;
p1.Print();
p2.Print();
// Reference type demo
PointRef r1 = new PointRef { X = 1, Y = 2 };
PointRef r2 = r1;// Тут у нас створюється посилання на r1, тому r1 i r2 залежні і тому при модифікації r2 r1 також змінюється.
r2.X = 4;
r1.Print();
r2.Print();
// Boxing demo
BoxingTester.Test();