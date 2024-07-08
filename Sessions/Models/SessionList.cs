namespace Sessions.Model
{
    public class SessionList
    {
        Dictionary<string, List<Session>> session_list;
        SessionList() 
        {
            session_list = new Dictionary<string, List<Session>>();
        }
    }
}
