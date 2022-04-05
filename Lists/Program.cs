using Lists;
ArrayList list = new ArrayList();






list.Add(156);
list.Add(82);
list.Add(378);
list.Add(442);
list.Add(578);
list.Add(66);
list.Add(567);
list.Add(813);
list.Add(-9);
list.Add(10);
list.Add(11);
list.Add(13);
list.Write();
Console.WriteLine($"MinV{list.FindMin()}");
Console.WriteLine($"MaxV{list.FindMax()}");
Console.WriteLine($"MinI{list.FindMinIndex()}");
Console.WriteLine($"MaxI{list.FindMaxIndex()}");