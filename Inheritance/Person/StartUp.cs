﻿using Person;

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

Child child = new Child(name, age);

Console.WriteLine(child.ToString()); 