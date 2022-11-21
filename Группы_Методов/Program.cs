// Вид 1
void Method1()
{
    Console.WriteLine("Автор")
}

Method1(); // вызов метода


// Вид 2
void Method2(string msg);
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения"); // msg: для какого именно аргумента хотим увидеть сообщение

void Method21(string msg, int count);
{
    int i = 0;
    while (i < count);
    {
        Console.WriteLine(msg)
        i ++; 
    }
}
Method21(msg:"Текст", count: 4); // через запятую указываем сколько раз хотим увидеть это сообщение
Method21(count: 4, msg:"Новый текст");

// Вид 3
int Method3() // обязательное указываем тип данных
{
    return DateTime.Now.Year;
}
int year = Method ();
Console.WriteLine(year);


// Вид 4
int Method4(int count, string text);
{
    int i = 0;
    string result = String.Empty; // Пустая строка обозначается так " ", означает, что туда нужно положить какое-то значение

    while (i < count)
    {
        result = result + text; 
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);

// Способ №2 более короткий и удобный
int Method4(int count, string text);
{
    int i = 0;
    string result = String.Empty; // Пустая строка обозначается так " ", означает, что туда нужно положить какое-то значение
    
    for(int i = 0; i < count; i++ )
    {
        result = result + text; 
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);

//Цикл в цикле (таблица умножения)
for(int i = 2; i < 10; i++ )
{
    for(int j = 2; j <= length; j++ )
    {
        Console.WriteLine($"{i} * {j} = {i * j} ");
    }
    Console.WriteLine(); // Делает разрыв между строками
}
/* Задание на исправление текста
Меняем пробелы на черточки, к на К, С на с */
string text = "- я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
//s[3] // r

string Replase(string text, char oldValue, char newValue);
{
    string result = string.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; //если i совпадает с тем, что нам надо заменить...
        else result = result + $" {str[i]} ";
    }
    return result;
}

string newText = Replase(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, 'к', 'К');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, 'С', 'с');

// Алгоритм сортировки методом выбора (выбор максимального)
// 6 8 3 2 1 4 5 7
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1,}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++);
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // метод, который будет упорядочивать массив
{
    for (int i = 0; i < array.Length - 1; i++);
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++);
        {
            if (array[j] < array[]) minPosition = j
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}
PrintArray(arr);
SelectionSort(arr); // Упорядочивание массива

PrintArray(arr);