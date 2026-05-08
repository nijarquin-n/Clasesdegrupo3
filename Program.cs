int[] A = { 15, 18, 20, 25, 30 };
int[] B = { 5, 8, 10, 12, 15 };
int[] R = new int[5];

for (int i = 0; i < 5; i++)
{
    R[i] = A[i] - B[i];
}

Console.WriteLine("Vector resultante:");

for (int i = 0; i < 5; i++)
{
    Console.Write(R[i] + " ");
}
