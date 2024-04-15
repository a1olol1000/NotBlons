global using Raylib_cs;
using System.Numerics;
using NotBlons;
Vector2 poation = new(100,100);
Raylib.InitWindow(1200,800,"diaijc");
Raylib.SetTargetFPS(60);
BlonsNot blonsNot = new();
Monk monk = new();
List<BlonsNot> blonsNots = new();
blonsNots.Add(blonsNot);
List<Monk> monks = new();
monks.Add(monk);
List<IDrawable> idrawables = new();
idrawables.AddRange(blonsNots);
idrawables.AddRange(monks);

while(!Raylib.WindowShouldClose())
{
    blonsNot.OnOuch(0.1f);
    blonsNot.HereIAm(poation*Raylib.GetFrameTime());
    Raylib.BeginDrawing();
    // blonsNot.Draw();
    
    idrawables.ForEach(d=>d.Draw());

    Raylib.ClearBackground(Color.Black);
    Raylib.EndDrawing();
}
