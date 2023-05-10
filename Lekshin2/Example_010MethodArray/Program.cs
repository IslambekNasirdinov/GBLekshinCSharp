int [] array={112,2,3,455,5,66,787,88,97};

int n = array.Length;
int find =112;

int index=0;

while (index<n)
{
    if(array[index]==find){
        Console.WriteLine(index);
        break;
    }
    index++;
}
