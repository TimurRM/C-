		
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
	Console.Write(num + " ");
    if (num < 99 & num > -99){
	    Console.WriteLine("-> 3-rd number doesn't exist");
    }
    else{
		if (num > 999 | num < -999)
		{
		    for (; num > 1000 | num < -1000;)
			num /= 10;
	    }
		Console.WriteLine(" -> " + num % 10);
	}

    
