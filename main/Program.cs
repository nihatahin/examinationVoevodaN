using System;

Console.Clear();

//----------Input data----------------------------------------------------------
string[] stringArray = {"hello", "2", "world", ":-)", "asdfasdfa"};
const int maxLength = 3;
//----------Main algorithm and output-------------------------------------------
Console.WriteLine($"[{String.Join(", ", stringArray)}] -> [{String.Join(", ", studyLib.study.getArrOfSmallString(stringArray, maxLength))}]");
////////////////////////////////////////////////////////////////////////////////