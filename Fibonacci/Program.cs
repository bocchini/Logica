﻿// See https://aka.ms/new-console-template for more information
/*Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
*/

var first = 1;
var last = 0;

while (first <=150)
{
    var value = 0;
    Console.WriteLine(first);
    value = first + last;
    last = first;
    first = value;
}

Console.ReadLine();