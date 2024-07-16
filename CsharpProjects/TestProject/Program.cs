var watch = new System.Diagnostics.Stopwatch();
watch.Start();



// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// char[] openSymbols = {'[','{','('};

// int closingPosition = 6;

// while (true){
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//     if(openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     char matchingSymbol = ' ';

//     switch(currentSymbol){
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }


//======================================//


string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);


//======================================//








// int[] array = { 3, 2, 23, 9, 86, 12, 22, 48, 9 };

// int max = 0;

// for (int i = 0; i < array.Length; i++){

//     if (array[i] > 0)
//     {
//         max += array[i];
//     }
// }
// Console.WriteLine(max);















watch.Stop();
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");