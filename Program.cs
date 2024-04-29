global using Raylib_cs;
using System.Numerics;
using NotBlons;
float count =0;
float deltaTime = 0;
Vector2 poation = new(100,100);
Raylib.InitWindow(1200,800,"Not Blons");
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
    deltaTime = Raylib.GetFrameTime();
    if (monk.counter>count)
    {
        BlonsNot newf = new();
        blonsNots.Add(newf);
        count ++;
        idrawables.AddRange(blonsNots);
        newf.HereIAm(deltaTime,0,0,true);
    }
    blonsNot.OnOuch(0.1f);
    blonsNot.HereIAm(deltaTime,poation.X,poation.Y,false);
    Raylib.BeginDrawing();
    
    idrawables.ForEach(d=>d.Draw());

    Raylib.ClearBackground(Color.Black);
    Raylib.EndDrawing();
}
