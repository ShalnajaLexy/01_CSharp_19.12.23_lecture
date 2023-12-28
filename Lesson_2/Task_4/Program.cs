
int n = 5;
int[] array = {2, 4, 3, 9, 10};
int i =0;
int max = array[0];

while (i <n)
{
    if (array[i] > max) {
        max = array[i];
    }
    i = i +1;
}
Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++)
{
    if (array[j] > max) {
        max = array[j];
    }
    // j = j +1; не прописываем, т.к. это уде указано в самом цикле, т.е. j++
}
Console.WriteLine(max);

max = array[0];
foreach (int k in array)
{
    if (k > max) {
        max = k;
    }
}
Console.WriteLine(max);