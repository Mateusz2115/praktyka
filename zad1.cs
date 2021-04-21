
sortedArray; //posortowana tablic
int arraySize = sortedArray.Length;  //rozmiar tablicy
element; //szukany element

for(int i = 0; i < arraySize; i++)
{
    if(sortedArray[i] == element)
    {
        if(i+1 < arraySize && sortedArray[i] == sortedArray[i+1])
        {
            sortedArray[i] = null;
            continue;
        }
        else
        {
            sortedArray[i] = null;
            break; 
        }
    }
}

///////////////////////////////////////////DRUGI PUNKT
int sizeA = A.size();
int sizeB = B.size();
//zmienna j służy do nawigowania po liście, gdy usuniemy element to zmienią się pozycje elementów w liście więc j jest potrzebna żeby
//nie wyjśc poza zakres oraz odpowiednio sprawdzić wszytkie elementy
for(int i = 0, j = 0; i < sizeA; i++)
{
    Element element = A.get(j);
    int key = element.getKey();
    bool isFound = false;  //informuje czy coś znależliśmy 
    for (int k = 0; k < sizeB; k++) //sprawdzamy czy znajduje się element o tym samym kluczu
    {
        Element element2 = B.get(k);
        int key2 = element2.getKey();
        if(key == key2)
        {
            isFound = true;
            break;
        }
    }
    if(!isFound)
    {
        A.remove(j);
    }
    else
    {
        j++;
        isFound = false;
    }

}

