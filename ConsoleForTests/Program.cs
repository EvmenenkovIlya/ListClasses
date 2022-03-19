using MyArrayList;

ArrayList listempty = new ArrayList();

for (int i = 0; i < 10; i++)
{
    listempty.AddInTheEnd(i);
    listempty.Write();
}
Console.ReadLine();
ArrayList listOne = new ArrayList( 12 );
for (int i = 0; i < 10; i++)
{
    listOne.AddInTheEnd(i);
    listOne.Write();
}

Console.ReadLine();

ArrayList listArr = new ArrayList(new int[] { 5,4,3, 3,2,1,3,2,1});

for (int i = 0; i < 6; i++)
{
    listArr.DeleteLast();
    listArr.Write();
}