using static  System.Console;
class Re
{

	public int Add(int a,int b,int c)
	{
		return c=a+b;
	}	
	
	static void Main()
	{
		Re r  = new Re();
		int x=10,y=20;
		int z = 0;
		int res=r.Add(x,y,z);
		WriteLine($"z: {z}");
		WriteLine($"res: {res}");
	}
}