﻿using System;
using System.Collections.Generic;

namespace Structures.Models.HashTable
{
    public class HashTableNode<T>
    {
        public int Key { get; set; }
        private List<T> data { get; set; }

        public List<T> Data
        {
            get => data;
            set
            {
                if(value is List<T>)
                {
                    data = value;
                }
                else { throw new Exception("Invalid argument type!"); }
            }
        }

        public HashTableNode(int key)
        {
            Key = key;
            Data = new List<T>();
        }
    }
}
