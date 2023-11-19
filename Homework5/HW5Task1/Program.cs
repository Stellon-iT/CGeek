string ReadDataStr(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

int CountPositivNumber(string str)
{
    int count = 0;
    string strWoSp = str.Replace(" ", "");
    string[] strArr = strWoSp.Split(",");
    int[] intArr = new int[strArr.Length];
    for (int i = 0; i < intArr.Length; i++) intArr[i] = int.Parse(strArr[i]);
    for (int i = 0; i < intArr.Length; i++) if (intArr[i] > 0) count++;
    return count;
}

string sequenceNumbers = ReadDataStr("Введите последовательность чисел: ");
int countPosNum = CountPositivNumber(sequenceNumbers);

Console.WriteLine("Кол-во положительных чисел равно: " + countPosNum);
