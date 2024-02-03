using lab4;

var clothes = ClothingStorage.Clothes;

var sorter = new ClothingSorter(clothes);

sorter.SortByTypeAscending();
Console.WriteLine("Sorted by type in asc order: ");
clothes.ForEach(Console.WriteLine);
sorter.SortByQuantityDescending();
Console.WriteLine("Sorted by quantity in desc order:");
clothes.ForEach(Console.WriteLine);


