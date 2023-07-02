// Task # Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

//// # Main
// Console.Clear();
// string[] array = new string[] { "Sun", "Monday", "Tu", "Wednesday", "Thu", "F", "Saturday" };
// string[] array_new = new string[array.Length];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i].Length <= 3)
//     {
//         array_new[count] = array[i];
//         count++;
//     }
// }
// Console.WriteLine($"Конечный массив: [{string.Join(" ", array_new)}]");


// // # Alternative
// Console.Clear();
// string[] array = new string[] { "Sun", "Monday", "Tu", "Wednesday", "Thu", "F", "Saturday" };
// int n = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i].Length <= 3)
//     {
//         n++;
//     }
// }

// string[] array_new = new string[n];

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i].Length <= 3)
//     {
//         array_new[count] = array[i];
//         count++;
//     }
// }
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array_new)}]");







