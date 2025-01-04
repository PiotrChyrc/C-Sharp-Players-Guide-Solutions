Console.WriteLine("How many eggs?");
string eggs = Console.ReadLine();
int eggNumber = Convert.ToInt32(eggs);

int sisterEggs = eggNumber / 4;
int duckbearEggs = eggNumber % 4;

Console.WriteLine("Each sister gets " + sisterEggs + " Eggs and the duckbear gets " + duckbearEggs);