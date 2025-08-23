//HashSet<char> charSet = new HashSet<char>();
//int left = 0, maxLength = 0;

//var s = Console.ReadLine();
//for (int right = 0; right < s.Length; right++)
//{
//    // Если символ уже есть в множестве, сдвигаем левый указатель
//    while (charSet.Contains(s[right]))
//    {
//        charSet.Remove(s[left]);
//        left++;
//    }

//    // Добавляем текущий символ в множество
//    charSet.Add(s[right]);

//    // Обновляем максимальную длину подстроки
//    maxLength = Math.Max(maxLength, right - left + 1);
//}
//Console.WriteLine(maxLength);