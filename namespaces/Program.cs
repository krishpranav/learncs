﻿using System;

namespace first_space {
    class namespace_cl {
        public void func() {
            Console.WriteLine("First Namespace");
        }
    }
}

namespace second_space {
    class namespace_cl {
        public void func() {
            Console.WriteLine("Second Namespace");
        }
    }
}

class TestClass {
    static void Main(string[] args) {
        first_space.namespace_cl fc = new first_space.namespace_cl();
        second_space.namespace_cl sc = new second_space.namespace_cl();

        fc.func();
        sc.func();
    }
}