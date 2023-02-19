// Нечто выводящее текст. Якобы.

void DrowText(string text, int left, int top)
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

}