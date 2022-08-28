
// Задача 19. Написать прогу кот принимает на вход пятизначное число
//   и проверяет, является ли оно палиндромом.

// void Poli(){
//     int num=new Random().Next(10000, 100000);
//     Console.WriteLine("Number is: " + num);
//     int ed1=0;
//     int ed2=0;
//     int ed3=0;
//     int dec1=0;
//     int dec2=0;
//     int dec3=0;
//     ed1=num % 10;
//     ed2=num % 100;
//     ed3=ed2 / 10;
//     dec1=num / 10000;
//     dec2=num / 1000;
//     dec3=dec2 % 10;

//     if(ed1 == dec1 && ed3 == dec3){
//          Console.WriteLine( "Палиндром");
//     }
//     else{
//         Console.WriteLine( "Не палиндром");
//     }   
    
// }
        
//  Poli();



// Задача23. Написать прогу, кот принимает на вход число N
//  и выдает таблицу кубов чисел от 1 до N

// void Kyb(int n){
   
//     int count=1;
//     while(count <= n){
//          Console.Write( count * count * count + "  ");
//          count++;
//     } 
    
// }

// Console.Write(" Введите число: ");
// int num=Convert.ToInt32(Console.ReadLine());
// if(num<=0) Console.Write("Некорректный ввод");       
// else Kyb(num);




// Задача 21. Написать прогу кот принимает на вход координаты двух точек
// и находит расстояние между ними в 3Д пространстве
// А(3,6,8); B(2,1,-7) - 15,84
// А(7,-5,0); B(1,-1,9) - 11,53
    
// double Avarage(double x1, double y1, double z1, double x2, double y2, double z2){

// double distance=0;
// distance= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
// Console.WriteLine("Расстояние в 3 D:   "  + distance);
// return distance;
// }     


// Console.Write("Введите координаты x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());


// Avarage(x1, y1, z1, x2, y2, z2);

    
        


//Задача на подумать!!! Написать прогу, кот принимает на вход координаты 
//двух точек и находит расстояние между ними в 2Д пространстве
// А(3,6); B(2,1) - 5,09
// А(7,-5); B(1,-1) - 7,21


// double Avarage(double x1, double y1, double x2, double y2){

// double distance=0;
// distance= Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
// Console.WriteLine("Расстояние в 2 D:   "  + distance);
// return distance;
// }     


// Console.Write("Введите координаты x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите координаты y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());


// Avarage(x1, y1, x2, y2);

    
