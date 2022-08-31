// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите кол-во строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] OurMatrix = GetMatrix(m,n,0,10);
PrintMatrix(OurMatrix);
int min = SumMatrixStr(OurMatrix,0);
int Posmin = 0;
for (int i=0; i<m; i++) {
    if (min>SumMatrixStr(OurMatrix,i)){min=SumMatrixStr(OurMatrix,i);Posmin = i;}}
Console.WriteLine("строка с наименьшей суммой элементов : "+(Posmin+1)+", ее индекс в массиве - "+(Posmin));

int SumMatrixStr(int[,] matrix, int NStr){
int sum = 0;
for (int i=0; i<(matrix.GetLength(1)); i++){sum= sum+matrix[NStr,i];}
return sum;}

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
