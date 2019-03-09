using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start..");
            SimpleMapper.RunSimpleMapperUser();
            SimpleMapper.RunSampleFlaterring();
            Console.WriteLine("finished");
            Console.ReadKey();
        }
    }
}
