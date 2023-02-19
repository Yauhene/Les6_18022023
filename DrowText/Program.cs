// Нечто выводящее текст. Якобы.
// И такую шляпу лучше не городить

/*void DrowText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

Console.Clear();
for(int i=0; i<=50; i=i+10)
{
    DrowText("Fucking World...", i, 30);
    //DrowText("*", i, 30);
    Console.WriteLine($"Отступ сверху {i} позиций");
    Console.ReadLine();
}*/
//==================================================================

string caption = "Intensive C# demo text";
int screenWindthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHightPosition = Console.WindowHeight / 2;

void DrowText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

DrawText(caption, screenWindthPosition, screenHightPosition);

// //DrawText(
//     text: caption,
//     left: screenWindthPosition,
//     top: screenHightPosition
//     );

