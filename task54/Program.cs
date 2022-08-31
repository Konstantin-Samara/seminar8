// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Write("Введите кол-во строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] OurMatrix = GetMatrix(m,n,0,10);

PrintMatrix(OurMatrix);
for (int i=0; i<m; i++) {SortMatrixStr(OurMatrix,i);}
Console.WriteLine();
PrintMatrix(OurMatrix);

void SortMatrixStr(int[,] matrix, int NStr){
for (int j=0; j<(matrix.GetLength(1)-1); j++) {
int buff = 0;
int min = matrix[NStr,j];
int PosMin = j;    
    for (int i=j; i<(matrix.GetLength(1)-1); i++)
    {if (min>matrix[NStr,i+1]) {min = matrix[NStr,i+1]; PosMin = i+1;}}
    buff = matrix[NStr,j];
    matrix[NStr,j] = min;
    matrix[NStr,PosMin] = buff;}}

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