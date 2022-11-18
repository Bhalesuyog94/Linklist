// See https://aka.ms/new-console-template for more information
using LinkList;
using System.Collections.Generic;
Console.WriteLine("===============");
LinkLists link = new LinkLists();
link.Add(56);
link.Add(30);
link.Add(70);
//link.RemoveFirstNode();
//link.RemovaLastNode();
//link.Search(30);
//link.Display();
link.InsertAtParticularPosition(3, 40);
link.Display();