// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
Console.Write("Введите кол-во строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] OurMatrix = new int[m,n];

void PrintMatrix(int[,] matrix){
for (int i=0; i<matrix.GetLength(0); i++){
    for (int j=0; j<matrix.GetLength(1); j++){Console.Write(matrix[i,j]+" ");}
    Console.WriteLine();}}

int y=0;
int x=0;
int Number = 1;
OurMatrix[y,x] = Number;
int check = 1;

while (check==1) {
    check = 0;
    while (x<OurMatrix.GetLength(1)-1) {
        if (OurMatrix[y,x+1]==0) {Number++;check = 1;OurMatrix[y,x+1] = Number;x++;} 
        else {break;}}
    while (y<OurMatrix.GetLength(0)-1) {
        if (OurMatrix[y+1,x]==0) {Number++;check = 1;OurMatrix[y+1,x] = Number;y++;} 
        else {break;}}    
    while (x>0) {
        if (OurMatrix[y,x-1]==0) {Number++;check = 1;OurMatrix[y,x-1] = Number;x--;} 
        else {break;}}
    while (y>0) {
        if (OurMatrix[y-1,x]==0) {Number++;check = 1;OurMatrix[y-1,x] = Number;y--;} 
        else {break;}}}

PrintMatrix(OurMatrix);



