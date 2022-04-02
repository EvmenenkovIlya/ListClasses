using MyArrayList;


LinkList list = new LinkList(new int[] { 9,5,4,3,2});
for (int i = 0; i < 10; i++)
{ 
    list.AddInTheEnd(i);
}
list.Write();
int x = list.Length;
Console.WriteLine(x);

list.DeleteInTheEnd();
