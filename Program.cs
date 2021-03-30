using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unit unit = new Unit();
            //unit.name = "건설로봇";
            //unit.mineral = 50;
            //unit.supply = 1;
            //unit.hp = 45;
            //unit.attack = 5;

            //Console.WriteLine(unit.name);



            Person person = new Person();
            List<Pet> list = new List<Pet>();
            list.Add(new Pet() { name = "구름", age = 7 });
            list.Add(new Pet() { name = "별", age = 1 });
            person.name = "윤인성";
            person.address = "서울특별시 강서구";
            person.pet = list;


            ////문제 08
            //Random random = new Random();
            ////random.Next(10, 20);
            //int radomnum = random.Next(10, 20);

            //while (true)
            //{

            //    Console.WriteLine("숫자를 입력해주세요 : ");
            //    int j = int.Parse(Console.ReadLine());
            //    if (j > radomnum)
            //    {
            //        Console.WriteLine(j + "보다 작은 숫자 입니다.\n");
            //    }
            //    else if (j < radomnum)
            //    {
            //        Console.WriteLine(j + "보다 큰 숫자입니다.\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("정답입니다.");
            //        break;
            //    }
            //}


        }
    }
}
