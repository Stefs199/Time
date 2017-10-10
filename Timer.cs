using GTANetworkServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Time : Script
{
    public Time()
    {
        API.onUpdate += OnUpdateHandler;
    }

    public void OnUpdateHandler()
    {
        int hour = DateTime.Now.Hour;
        int minute = DateTime.Now.Minute;
        var date = DateTime.Now.ToString("dd.MM.yyyy");
        var time = DateTime.Now.ToString("HH:mm");
        API.setTime(hour, minute);
        foreach (Client player in API.getAllPlayers())
        {
            API.setEntitySyncedData(player, "dw_date", date);
            API.setEntitySyncedData(player, "dw_hour", time);
        }
    }
}