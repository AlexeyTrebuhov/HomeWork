// Показать четные числа от 1 до N

Console.Write("Введите любое целое число и нажмите клавишу Enter: ");
string string1 = Console.ReadLine();
int arg1 = Convert.ToInt32(string1);
   
        if ( arg1 % 2 == 0 )
        {
        int index = arg1;
        while ( index > 0 )
            {   
            Console.WriteLine (index); 
            index = index - 2; 
            }
        }

        else
        {

            int index = arg1 - 1;
            while ( index > 0 )
            {   
            Console.WriteLine (index); 
            index = index - 2; 
            }
        }
         
    