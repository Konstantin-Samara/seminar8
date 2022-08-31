// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Write("Введите кол-во строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] OurMatrix = GetMatrix(m,n,0,10);
int[,] OurMatrix2 = GetMatrix(m,n,0,10);
int[,] OurMatrix3 = OurMatrix;
Console.WriteLine("Задан массив 1 :");
PrintMatrix(OurMatrix);
Console.WriteLine("и массив 2 :");;
PrintMatrix(OurMatrix2);
Console.WriteLine("их произведение равно массиву 3 :");
for (int i=0; i<m; i++){
    for (int j=0; j<n; j++) {OurMatrix3[i,j] = OurMatrix[i,j]*OurMatrix2[i,j];}}

PrintMatrix(OurMatrix3);

void PrintMatrix(int[,] matrix){
for (int i=0; i<matrix.GetLength(0); i++){
    for (int j=0; j<matrix.GetLength(1); j++){Console.Write(matrix[i,j]+" ");}
    Console.WriteLine();}}

int[,] GetMatrix(int Nstr, int NCol, int LefBorder, int RightBorder){
int[,] matrix = new int[Nstr,NCol];
Random rand = new Random();
for (int i=0; i<Nstr; i++){
    for (int j=0; j<NCol; j++){matrix[i,j] = rand.Next(LefBorder,RightBorder);}}
return matrix;}