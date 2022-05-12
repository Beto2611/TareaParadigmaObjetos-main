using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    class idGenerator
    {
        private static idGenerator instance;
        private int counter = 0;
        private idGenerator() { 
        
        }

        public static idGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new idGenerator();
            }
            return instance;
        }
        public string generarId()
        {
            String id = counter.ToString();
            counter++;
            return id;
        }
        
        public int generarNumeroCamas()
        {
            Random rnd = new Random();
            int rnum = rnd.Next(2, 5);
            return rnum;
        }
        public String generarClaseHabitacion()
        {
            Random rnd = new Random();
            int rnum = rnd.Next(1, 3);
            switch (rnum)
            {
                case 1:
                    return "PC";
                    break;
                case 2:
                    return "SC";
                    break;
                case 3:
                    return "TC";
                    break;
                default:
                    return "X";
                    break;
            }
        }
    }
}
