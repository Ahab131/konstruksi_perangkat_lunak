﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1201230031
{
    class DataGeneric<T>
    {
        public T Data { get; set; }

        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + Data);
        }
    }
}
