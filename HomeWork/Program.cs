
Console.WriteLine("Task 1");

int i = 132;
int k = 63;
int j;



j = i / k;
Console.WriteLine();
Console.WriteLine(j); //გაყოფა (უნაშთო)//

j = i % k;
Console.WriteLine();
Console.WriteLine(j); //გაყოფა (ნაშთი)//

j = i + k;
Console.WriteLine();
Console.WriteLine(j); //მიმატება//

j = i * k;
Console.WriteLine();
Console.WriteLine(j); //გამრავლება//

j = i - k;
Console.WriteLine();
Console.WriteLine(j); //გამოკლება//


Console.WriteLine("----------");
Console.WriteLine(" ");
Console.WriteLine("Task 2");

double  du = 1.0;
float   fl = 7.0f;
decimal de = 7.0m;

Console.WriteLine(du * 7);
Console.WriteLine();
Console.WriteLine(fl * 7);
Console.WriteLine();
Console.WriteLine(de * 7);


Console.WriteLine("----------");
Console.WriteLine(" ");
Console.WriteLine("Task 3");



Convert.ToInt32(du);
Console.WriteLine(du);
Console.WriteLine();
Convert.ToDouble(fl);
Console.WriteLine(fl);
Console.WriteLine();
Convert.ToDecimal(i);
Console.WriteLine(i);
Console.WriteLine();

Console.WriteLine("----------");
Console.WriteLine(" ");
Console.WriteLine("Task 4");

int num1 = 5;
int num2 = 10;
int num3;

Console.Write("num1 = ");
Console.Write(num1);
Console.Write("   ");
Console.Write("num2= ");
Console.Write(num2);


num3 = num1;
 
num1 = num2;

num2 = num3;

Console.WriteLine();
Console.Write("num1 = ");
Console.Write(num1);
Console.Write("   ");
Console.Write("num2= ");
Console.WriteLine(num2);


Console.WriteLine("----------");
Console.WriteLine(" ");
Console.WriteLine("Task 5");

int height;
int weight;
decimal bmi;

Console.WriteLine("enter your weight");
weight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(weight);
Console.WriteLine("enter your height");
height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(height);


Convert.ToDecimal(height / 100);
Console.WriteLine(height);

decimal hgt = (Convert.ToDecimal(height)/100);
Console.WriteLine(hgt);

bmi = weight / (hgt * hgt);
Console.WriteLine(bmi);





