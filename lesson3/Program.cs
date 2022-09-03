// Метод вид1 (ничего не возвращает, аргументы не принимает)
/*void Method1 (); // - нет аргументов
{
    Console.WriteLine("@ Evgeniya"); // Метод не принимает аргументы, а выводит что-либо на консоль, например, авторство
}
Method1(); // - т.о метод вызывается
*/

// Метод вид2 (ничего не возвращает, аргументы принимает)
/*void Method2 (string msg, int count) // текст, кол-во раз msg
{
    int i = 0; // счетчик
    while (i < count)
    {
      Console.WriteLine(msg);
      i ++;
    }
    
}
//Method2 ("Hello, world", 4); // вывод на экран
Method2 (count: 6 , msg: "Super, it's good");//а можн так выводить на экран, указывая явно какому аргументы, что соответствует
*/

// Метод вид3. (что-то возвращает, но не принимает аргументы)
/*int Method3 () //для возвращаемых метод обязательно указываем тип данных
{
   return (DateTime.Now.Year); //оператор ретерн тут обязателен
}
int DateYear = Method3 (); //обязательна новая переменная в которую мы "положим " этот метод
Console.WriteLine(DateYear); //для вывода в консоль используем уже эту переменную, в которой "лежит" то что вернул нам метод
*/

// Метод вид4 (что-то принимают и что-то возвращают)
/*string Method4 (int count, string Hello) // возвращаемый тип данных строки, название метода, аргументы: строка с, коунт раз ее выводим
{
  int i = 0; //счетчик
  string result = string.Empty; //перменная резалт, которая изначальная пустая строка
  
  while  (i < count)
  result = result + Hello!;
   i++;
return result;
}

string res = Method4(10, "dfg");
Console.WriteLine(res);
*/

// Задача по выводу таблицы умножения на экран, использую цикл for
/*for (int i = 2; i <= 10; i++) //таблица умножения начинается с 2, заканчивается 10 поэтому i=2 и < 10, увеличивает счетчик 
{  
    
     for (int j = 2; j <= 10; j++)
     {
      Console.WriteLine($"{i} x {j} = {i * j}");

     }
     Console.WriteLine();
}
*/
// Задача - Работа с текстом.
//Дан текст,в нем нужно все пробелы заменить черточками. Маленькие к заменить большими К
//Большие С заменить маленькими с.
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
               + "ежели бы вас послали вместо нашего милого Винценгероде, "
               +  "вы бы взяли приступом согласие прусского короляю. "
               +  "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "some text" - дан некий текст
//             012345     - индексы, чтобы обратится к конкретному символу этого текста
// s [3] - e  = ставим идентификатор и в скобках номер индекса, к которому хотим обратится.
/*string Replace(string text, char oldValue, char newValue) //метод название (строка текса, символ старый, символ на который будем менять)
{
  string result = string.Empty;

  int length = text.Length; //выдает длину символов текста
  for (int i = 0; i < text.Length; i++)
  {
    if (text [i] == oldValue) result += $"{newValue}";         // Если текущий текст на позиции i совпал со значение oldValue то в результат кладем новое значение new.Value
    else result += $"{text[i]}";
  }
  return result;
}    
string newtext = Replace(text,' ', '|');
Console.WriteLine(newtext); 
Console.WriteLine(); // делаем разрыв одного от другого чтобы не шло скопом

newtext = Replace(newtext, 'к' , 'К');
Console.WriteLine(newtext);
Console.WriteLine();

newtext = Replace(newtext, 'С', 'с');
Console.WriteLine(newtext);
*/

// Сортировка массива по возрастанию.
int [] arr = {1,6,8,9,4,2,4,3,5,7,1,5}; // создаем массив, со значениями.
void PrintArray(int[] array) // метод печати массива, в качестве аргументов приходит массив.
{
  int count = array.Length; //получение количесва элементов

   for (int i = 0; i < count; i++)
   {
     Console.Write($"{array[i]}  ");
   }
     Console.WriteLine();

}
   
void Sort(int[] array)
{  
   for (int i = 0 ; i < array.Length - 1; i++)
   {
    int minPosition = i;
    
    for (int j = i + 1; j < array.Length; j++)
    {
         if (array[j] < array[minPosition]) minPosition = j;
    }


    int help = array[i];
    array[i] = array[minPosition];
    array[minPosition] = help;
   }
 
}   
   
PrintArray(arr);
Sort(arr);
PrintArray(arr);








