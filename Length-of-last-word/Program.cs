public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int length = 0;
        int i = s.Length - 1;

        // Пропускаємо пробіли з кінця рядка
        while (i >= 0 && s[i] == ' ')
        {
            i--;
        }

        // Підраховуємо довжину останнього слова
        while (i >= 0 && s[i] != ' ')
        {
            length++;
            i--;
        }

        return length;
    }
}
