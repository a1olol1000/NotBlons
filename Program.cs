global using Raylib_cs;
using System.Numerics;
using NotBlons;
Vector2 poation = new(100,100);
Raylib.InitWindow(1200,800,"diaijc");
Raylib.SetTargetFPS(60);
BlonsNot blonsNot = new();


while(!Raylib.WindowShouldClose())
{
    blonsNot.HereIAm(poation);
    Raylib.BeginDrawing();
    blonsNot.Draw();
#pragma warning disable IDE0059 // Unnecessary assignment of a value
    foreach (IDrawable item in collection)
    {
        
    }
#pragma warning restore IDE0059 // Unnecessary assignment of a value
    Raylib.ClearBackground(Color.Black);
    Raylib.EndDrawing();
}
