// Задача 19. Определить номер четверти плоскости, в которой находится точка с координатами X и Y, причём X не равен 0, Y не равен 0.
Console.WriteLine("Введите x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y");
int y = int.Parse(Console.ReadLine());
if (x == 0 || y == 0)
{
    Console.WriteLine("Нет четверти");
}
else if  (x > 0 && y > 0)
{
   Console.WriteLine("Первая четверть"); 
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Вторая четверть");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Четвертая четверть");
}