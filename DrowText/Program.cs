// Нечто выводящее текст. Якобы.

void DrowText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine(text);
}

DrowText("Fucking World...", 30,30);