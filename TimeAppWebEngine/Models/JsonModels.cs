using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace TimeAppWebEngine.Models
{
  public class AlarmDuration
  {
    [JsonProperty(PropertyName = "UserID")]
    public string UserID { get; set; }
    [JsonProperty(PropertyName = "DeviceIMEI")]
    public string DeviceIMEI { get; set; }
    [JsonProperty(PropertyName = "AlarmID")]
    public int AlarmID { get; set; }
    [JsonProperty(PropertyName = "location")]
    public Location location { get; set; }
    [JsonProperty(PropertyName = "Addres")]
    public string Address { get; set; }
    [JsonProperty(PropertyName = "RequestDateTime")]
    public DateTime Time { get; set; }
    [JsonProperty(PropertyName = "Duration")]
    public int Duration { get; set; }

  }

  public class RegAlarm
  {
    [JsonProperty(PropertyName = "UserID")]
    public string UserID { get; set; }
    [JsonProperty(PropertyName = "DeviceIMEI")]
    public string DeviceIMEI { get; set; }
    [JsonProperty(PropertyName = "Destination")]
    public Location Location { get; set; }
    [JsonProperty(PropertyName = "Addres")]
    public string Address { get; set; }
    [JsonProperty(PropertyName = "Arrival Time")]
    public DateTime ArrivalTime { get; set; }
    [JsonProperty(PropertyName = "Transtport Type")]
    public string Transtport_Type { get; set; }
  }

  public class Location
  {
    [JsonProperty(PropertyName = "X")]
    public double X { get; set; }
    [JsonProperty(PropertyName = "Y")]
    public double Y { get; set; }

  }

  public class AlarmID
  {
    [JsonProperty(PropertyName = "AlarmID")]
    public int id { get; set; }
  }
  public class AlarmTimeLineResponce
  {
    [JsonProperty(PropertyName = "ResultCode")]
    public int ResultCode;
    [JsonProperty(PropertyName = "ErrorCode")]
    public int ErrorCode;
    [JsonProperty(PropertyName = "K value")]
    public double Kvalue;
    [JsonProperty(PropertyName = "B value")]
    public double Bvalue;
    [JsonProperty(PropertyName = "Sigma Value")]
    public double Sigma;
    public AlarmTimeLineResponce() { }
    public AlarmTimeLineResponce(AlarmTimeLine alarmTimeLine)
    {
      this.Bvalue = alarmTimeLine.Average;
      this.Kvalue = 0.1;
      this.Sigma = alarmTimeLine.Delta * 3;
      this.ErrorCode = 0;
      this.ResultCode = 1;
    }
  }
}