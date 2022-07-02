﻿using Business.concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using System;

namespace ConsoleUIı
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var carr in carManager.GetAll())
            {
                Console.WriteLine(carr.BrandId);
                Console.WriteLine(carr.Description);
                Console.WriteLine(carr.CarId);
            }

        }
    }
}
