namespace Sessions.Model
{
    //Класс хранения времени сканса
    public class Session
    {
        public string Date { get; }
        public string Time { get; }

        public Session(string date, string time)
        {
            Date = date;
            Time = time;
        }
    }
}
