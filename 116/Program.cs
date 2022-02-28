// Два друга идут навстречу, а собака бегает между ними

int rasst = 10000;
int V1 = 1;
int V2 = 1;
int Vsob = 5;
int count = 0;
int clock =0;
int rasstost = 0;


while ( rasst > 10 )
{
clock = rasst / (V2 + Vsob);
rasstost = rasst - clock*(V2 + V1); 
rasst = rasstost;
count = count + 1;
}
Console.WriteLine($"Собака пробежит между друзьями {count} раз");
