using Task01.Models;

int[] position = { 0, 0 };
Shape shape = new Shape("Shape", "Black", position);
shape.getArea();
shape.getPerimeter();
shape.Move();
Console.WriteLine();
Rectangle rectangle = new Rectangle("Rectangle", "White", position, 10, 20);
rectangle.getArea();
rectangle.getPerimeter();
rectangle.Move();
Console.WriteLine();
Circle circle = new Circle("Circle", "Violet", position, 30);
circle.getArea();
circle.getPerimeter();
circle.Move();
