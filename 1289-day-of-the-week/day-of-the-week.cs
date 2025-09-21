public class Solution {
    public string DayOfTheWeek(int day, int month, int year) {

DateTime specificDate = new DateTime(year, month, day);
string Result=specificDate.DayOfWeek.ToString();
return Result;
    }
}