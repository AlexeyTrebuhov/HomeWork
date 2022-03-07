// Два друга идут навстречу, а собака бегает между ними

int rasst = 4000;
int V1 = 10;
int V2 = 5;
int Vsob = 15;
double count = 0;
int clock =0;
int rasstost = 0;


while ( rasst > 10 )
{
clock = rasst / (V2 + Vsob);
rasstost = rasst - clock*(V2 + V1); 
rasst = rasstost;
count = count + 1;
clock = rasst / (V1 + Vsob);
rasstost = rasst - clock * (V2 + V1);
rasst = rasstost;
count = count + 1;

}
Console.WriteLine($"Собака пробежит между друзьями {count} раз");
