namespace CodilityTasks.RandomTaskInternet;

public class WeekDay
{
    //Given a day of a week, with an int representing the future day, find the day of the week after K days
    public string GetWeekDay(string day, int days)
    {
        var daysInTheWeek = 7;
        var weekDays = new Dictionary<int, string>
        {
            { 1, "Monday" },
            { 2, "Tuesday" },
            { 3, "Wednesday" },
            { 4, "Thursday" },
            { 5, "Friday" },
            { 6, "Saturday" },
            { 7, "Sunday" }
        };

        var currentDayNumeric = weekDays.FirstOrDefault(x => x.Value == day).Key;
        var futureDayValue = (currentDayNumeric + days) % daysInTheWeek;
        var futureDay = weekDays.FirstOrDefault(x => x.Key == futureDayValue).Value;
        
        return futureDay;
    }
}