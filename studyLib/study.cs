namespace studyLib;
public class study
{
    public static string[] getArrOfSmallString(string[] array, int strMaxSize)
    {
        int cnt = 0;
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i].Length <= strMaxSize)
            {
                array[cnt] = array[i];
                ++cnt;
            }
        }

        //Console.WriteLine(cnt);

        return arrayContaining(array, cnt);
    }
////////////////////////////////////////////////////////////////////////////////
    public static string[] arrayContaining(string[] arr, int n)
    {
        string[] finArr = new string[n];
        for (int i = 0; i < n; ++i)
        {
            finArr[i] = arr[i];
        }

        return finArr;
    }
////////////////////////////////////////////////////////////////////////////////
    public static void answerOutput(string[] inputArray, string[] outputArray, int boardSize)
    {
        if (outputArray.Length == 0)
        {
            Console.WriteLine($"There are no strings {boardSize} symbols in length.");
        }
        Console.WriteLine($"[{String.Join(", ", inputArray)}] -> [{String.Join(", ", outputArray)}]");
    }
}
