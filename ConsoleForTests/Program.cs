using MyArrayList;

/*ArrayList listempty = new ArrayList();

for (int i = 0; i < 10; i++)
{
    listempty.AddInTheEnd(i);
}
listempty.AddInTheEnd(24);
listempty.AddInTheEnd(-7);
listempty.Write();
int X = listempty.DeleteFirstValueAndReturnIndex(25);
int Y = listempty.FindIndexOfMin();    
Console.WriteLine(X);
Console.WriteLine(Y);
//listempty.Reverse();
listempty.Write();




Console.ReadLine();
ArrayList listOne = new ArrayList( 12 );
for (int i = 0; i < 10; i++)
{
    listOne.AddInTheEnd(i);
    listOne.Write();
}

Console.ReadLine();*/

ArrayList listArr = new ArrayList(new int[] {5, 4, 3, 3, 2, 1, 3, 2, 1});

listArr.Write();
listArr.AddListInTheIndex(new int[] {7,6,9 }, 4);
listArr.Write();
