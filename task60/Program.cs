// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
Console.Write("Введите кол-во столбцов (ширина) массива (х): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во строк (высота) массива (у): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во 'слоев' (глубина) массива (z): ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] OurMatrix = GetMatrix(m,n,z,10,100);
Console.WriteLine("Массив выводится построчно с указанием индекса элемента в формате (y,x,z)");
PrintMatrix(OurMatrix);

void PrintMatrix(int[,,] matrix){
for (int z=0; z<matrix.GetLength(2); z++) {
    Console.WriteLine((z+1)+" 'слой'");
    for (int i=0; i<matrix.GetLength(0); i++){
        for (int j=0; j<matrix.GetLength(1); j++)
        {Console.Write(matrix[i,j,z]+"("+i+","+j+","+z+") ");}
        Console.WriteLine();}}}

int FindNumder(int[,,] matrix, int Number){
int check=0;
 for (int z=0; z<matrix.GetLength(2); z++){
    for (int y=0; y<matrix.GetLength(0); y++){
        for (int x=0; x<matrix.GetLength(1); x++)
        {if (matrix[y,x,z]==Number) {check=1;}} 
        }}   
return check;}

int[,,] GetMatrix(int NStr, int NCol, int Nz,int LefBorder, int RightBorder){
int[,,] matrix = new int[NStr,NCol,Nz];
Random rand = new Random();
for (int z=0; z<Nz; z++){
    for (int j=0; j<NStr; j++){
        for (int i=0; i<NCol; i++){          
            int Number = rand.Next(LefBorder,RightBorder);
            if (FindNumder(matrix,Number)==0) {matrix[j,i,z] = Number;}
            else{i--;}}
            }}
return matrix;}