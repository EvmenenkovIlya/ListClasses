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

Console.ReadLine();

AList listArr = new AList(new int[] {5, 4, 2, 3, 3, 2, 1, 3, 2, 1});
AList listArr2 = new AList(new int[] { 9,9,8});
listArr.Write();
listArr.AddListInTheEnd(listArr2);
//int x = listArr.DeleteAllValueAndReturnCount(2);
listArr.AddListInTheStart(listArr2);
listArr.AddListInTheIndex(listArr2, 4);
listArr.Write();

//Console.WriteLine(listArr[2]);
//Console.WriteLine(x); */
LinkList list = new LinkList(new int[] { 9,5,4,3,2});
for (int i = 0; i < 10; i++)
{ 
    list.AddInTheEnd(i);
}
list.Write();
int x = list.Length;
Console.WriteLine(x);
