
string text = "Материал из Википедии — свободной энциклопедии"
            +"У этого термина существуют и другие значения, см. Текст (значения)."
            +"Пример текста"
            +"Текст (от лат. textus — ткань; сплетение, сочетание) — зафиксированная на каком-либо материальном носителе "
            +"Существуют две основные трактовки понятия «текст»: имманентная (расширенная, философски нагруженная) и" 
            +"В лингвистике термин «текст» используется в широком значении, включая и образцы устной речи. Восприятие "; 
string Replace(string text, char oldValue, char newValue){
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i<length; i++){
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

Console.WriteLine();
string newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
