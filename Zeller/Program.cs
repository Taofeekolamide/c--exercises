Console.Write("Enter day of the month in number : ");
int q = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter month in number : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter year : ");
int year =  Convert.ToInt32(Console.ReadLine());

if(m == 1) {
    m = 13;
    year--;
} 
 if(m == 2){
    m = 14;
    year--;
}

int j =  year/100;
int k =  year % 100;


int result = (q + ((26*(m + 1)) / 10) + k + (k / 4) + (j / 4) + (5*j) ) % 7;

string day;
switch (result)
{
    case 0:
    day = "Saturday";
    break;

    case 1:
    day = "Sunday";
    break;

    case 2:
    day = "Monday";
    break;

    case 3:
    day = "Teusday";
    break;

    case 4:
    day = "Wednesday";
    break;

    case 5:
    day = "Thursday";
    break;

    case 6:
    day = "Friday";
    break;

    default:
    day = "Invalid day";
    break;
}
Console.WriteLine(day);