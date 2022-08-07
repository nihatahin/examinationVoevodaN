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

        Console.WriteLine(cnt);

        return array;
    }
////////////////////////////////////////////////////////////////////////////////
}
