// Определить номер четверти плоскости, в которой находится точка с координатами x и y, причем x!=0 и y!=0


int x=55; 
int y=45;
if(x>0 & y>0)
{
    System.Console.WriteLine("1 координатная четверть");
}
if(x<0 & y>0)
{
    System.Console.WriteLine("2 координатная четверть");
}
if(x<0 & y<0)
{
    System.Console.WriteLine("3 координатная четверть");
}
if(x>0 & y<0)
{
    System.Console.WriteLine("4 координатная четверть");
}