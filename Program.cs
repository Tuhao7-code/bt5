using System;
using System.Collections.Generic;

// Quy trình đệ quy
/*
 Xác định điều kiện dừng: mảng có 1 phần tử hoặc đã xếp xong
 - Bubble sort: hoán đổi phần tử lớn lên cuối, sau đó gọi đệ quy cho phần còn lại
 - Insertion sort: sắp xếp phần đầu rồi chèn phần tử mới vào đúng vị trí
 - Selection sort: tìm phần tử nhỏ nhất rồi gọi đệ quy cho phần còn lại
 - Exchange sort: đổi chỗ nếu sai vị trí và tiếp tục gọi đệ quy cho phần còn lại
 Gọi lại hàm chính
*/
class RecursiveBubbleSort
{
    public static void BubbleSort(int[] arr, int n)
    {
        if (n == 1) return; 

        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] > arr[i + 1])
                Swap(arr, i, i + 1);
        }

        BubbleSort(arr, n - 1);
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    public static void Main()
    {
        int[] arr = { 10, 3, 8, 15, 6, 12, 2, 18, 7, 4 };
        Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

        BubbleSort(arr, arr.Length);

        Console.WriteLine("Mảng sau BubbleSort: " + string.Join(", ", arr));
    }
}


class RecursiveInsertionSort
{
    public static void InsertionSort(int[] arr, int n)
    {
        if (n <= 1) return; 

        InsertionSort(arr, n - 1); 

        int key = arr[n - 1];
        int j = n - 2;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key; 
    }

    public static void Main()
    {
        int[] arr = { 10, 3, 8, 15, 6, 12, 2, 18, 7, 4 };
        Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

        InsertionSort(arr, arr.Length);

        Console.WriteLine("Mảng sau InsertionSort: " + string.Join(", ", arr));
    }
}

class RecursiveSelectionSort
{
    public static void SelectionSort(int[] arr, int start, int n)
    {
        if (start >= n - 1) return; 

        int minIndex = start;
        for (int i = start + 1; i < n; i++)
        {
            if (arr[i] < arr[minIndex])
                minIndex = i;
        }

        Swap(arr, start, minIndex); 

        SelectionSort(arr, start + 1, n); 
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    public static void Main()
    {
        int[] arr = { 10, 3, 8, 15, 6, 12, 2, 18, 7, 4 };
        Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

        SelectionSort(arr, 0, arr.Length);

        Console.WriteLine("Mảng sau SelectionSort: " + string.Join(", ", arr));
    }
}

class RecursiveExchangeSort
{
    public static void ExchangeSort(int[] arr, int start, int n)
    {
        if (start >= n - 1) return; 

        for (int i = start + 1; i < n; i++)
        {
            if (arr[start] > arr[i])
                Swap(arr, start, i);
        }

        ExchangeSort(arr, start + 1, n); 
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    public static void Main()
    {
        int[] arr = { 10, 3, 8, 15, 6, 12, 2, 18, 7, 4 };
        Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

        ExchangeSort(arr, 0, arr.Length);

        Console.WriteLine("Mảng sau ExchangeSort: " + string.Join(", ", arr));
    }
}


class Program
{
    static void Main()
    {
        // Bài 1: Cài đặt danh sách liên kết đơn
        LinkedListNode<string> node = new LinkedListNode<string>("Mike");
        LinkedList<string> singleList = new LinkedList<string>();
        singleList.AddFirst(node);
        LinkedListNode<string> node1 = new LinkedListNode<string>("David");
        singleList.AddAfter(node, node1);
        LinkedListNode<string> node2 = new LinkedListNode<string>(null);
        singleList.AddLast(node2);
        Console.WriteLine("Danh sach lien ket don:");
        foreach (var name in singleList)
        {
            Console.WriteLine(name ?? "NULL");
        }

        // Bài 2: Cài đặt danh sách liên kết kép
        LinkedList<string> doubleList = new LinkedList<string>();
        doubleList.AddFirst("Alice");
        doubleList.AddLast("Bob");
        doubleList.AddLast("Charlie");
        Console.WriteLine("\nDanh sach lien ket kep:");
        foreach (var name in doubleList)
        {
            Console.WriteLine(name);
        }

        // Bài 3: Danh sách liên kết tích hợp trong .NET
        LinkedList<int> netList = new LinkedList<int>();
        netList.AddLast(10);
        netList.AddLast(20);
        netList.AddLast(30);
        Console.WriteLine("\nDanh sach lien ket trong .NET:");
        foreach (var num in netList)
        {
            Console.WriteLine(num);
        }
    }
}

