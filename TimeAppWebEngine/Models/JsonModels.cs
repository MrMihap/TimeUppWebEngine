using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace TimeAppWebEngine.Models
{
  public class SetAlarmDuration
  {
    [JsonProperty(PropertyName = "UserID")]
    public string UserID { get; set; }
    [JsonProperty(PropertyName = "DeviceIMEI")]
    public string DeviceIMEI { get; set; }
    [JsonProperty(PropertyName = "AlarmID")]
    public int AlarmID { get; set; }
    [JsonProperty(PropertyName = "location")]
    public Location location { get; set; }
    [JsonProperty(PropertyName = "Address")]
    public string Address { get; set; }
    [JsonProperty(PropertyName = "TIME")]
    public DateTime TIME { get; set; }
  }
  public class Test
  {
    [JsonProperty(PropertyName = "UserID")]
    public string UserID { get; set; }
  }
  public class RegAlarm
  {
    [JsonProperty(PropertyName = "UserID")]
    public string UserID { get; set; }
    [JsonProperty(PropertyName = "DeviceIMEI")]
    public string DeviceIMEI { get; set; }
    [JsonProperty(PropertyName = "Destination")]
    public Location Location { get; set; }
    [JsonProperty(PropertyName = "Adress")]
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
}