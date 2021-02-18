using static System.Console; 
class Program  
{  
        static void Main(string[] args)  
        {  
            	string str = "", reverse = "";  
            	int len = 0;  
            	WriteLine("Enter name");  
            	str = ReadLine();  
            	len = str.Length - 1;  
            	while(len>=0)  
		{  
                	reverse += str[len--];  
            	}  
            
            WriteLine($"Reverse word is {reverse}");  
        }  
}