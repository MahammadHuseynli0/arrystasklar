

int[] arry = { -5, 13, 17, -18 };
int i = 0;
int[] newarry = new int[4];

    for ( i = arry.Length -1 ; i >= 0; i--)
    {
    if (arry[i] < 0)
   
    { 
        arry[i] = -arry[i];
    }

    newarry[i] = arry[i];

    Console.WriteLine(newarry[i]);
        
    
       }



