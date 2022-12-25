 //////////////////////////////////////////////////////////////////////////////////////   
/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да 
    РЕШЕНИЕ МЕТОДОМ ЧИСЕЛ*/
    int Numder (int num, int ind) // Фуекция, выводящая из числа num цифру номер ind по
                                  //счету справа
      {
        int res=(num/Convert.ToInt32(Math.Pow(10,ind-1)))%10; 
        return res;
      }
    
      int Len (int num)// Функция подсчета длины числа
      {
        int res =0;
        if (num<0){num*=-1;}
        while(num>=1)
          {
            num/=10;
            res++;
          }
        return res;
      }

    Console.Write("Введите пятизначное число для проверки на палиндром: ");
    if (!int.TryParse(Console.ReadLine(), out int pol))
      {
        Console.Write("Вы ввели не число");
      }
    else 
    {
     
      int n=-1;
      int lenn= Len(pol);

      for (int i=1; i<=lenn/2; i++)
        { 

          if (Numder (pol, i)==Numder (pol, (lenn+1-i)))
            {
              n=1;
            }
          else {n=0; break;}
        }
      if (n==1)
        {
          Console.Write("да"); 
        }
      else 
        {
          Console.Write("нет");
        }
    }   
///////////////////////////////////////////////////////////////////////////////////////////