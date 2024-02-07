// Sample Functions


static void populateList(SortedList list)
{
    list.Add("CS101", "Introduction to Computer Science");
    list.Add("CS102", "Data Structures and Algorithm Analysis");
    list.Add("CS201", "Introduction to Databases");
    list.Add("CS301", "Introduction to Object-Oriented Programming");
}

static void displayList(SortedList list, string key)
{
    int index;
    string course;
    index = list.IndexOfKey(key);
    course = (string)list.GetByIndex(index);
    Console.WriteLine(course);
}

static void removeListItem(SortedList list, string key)
{
    int index;
    string course;
    index = list.IndexOfKey(key);
    course = (string)list.GetByIndex(index);
    list.Remove(key);
    Console.WriteLine(course + " was removed from the list.");
}

