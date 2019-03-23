﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class DataSingleton
    {
        public Dictionary<string, string> data = new Dictionary<string, string>();
        private static DataSingleton instance = null;
        public static DataSingleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DataSingleton();
                }
                return instance;
            }
        }

    }
}
