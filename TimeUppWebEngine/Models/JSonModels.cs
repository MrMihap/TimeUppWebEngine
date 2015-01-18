using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace TimeUppWebEngine.Models
{
  public class SetAlarmDuration
  {
    [JsonProperty(PropertyName="UserID")]
    public string UserID { get; set; }
    [JsonProperty(PropertyName = "")]
    public string DeviceIMEI { get; set; }
    [JsonProperty(PropertyName = "")]
    public int AlarmID { get; set; }
    [JsonProperty(PropertyName = "")]
    public Location location { get; set; }
    [JsonProperty(PropertyName = "")]
    public string Address { get; set; }
    [JsonProperty(PropertyName = "")]
    public DateTime TIME { get; set; }
  }
  public class RegAlarm
  {
    [JsonProperty(PropertyName = "")]
    public string UserID { get; set; }
    [JsonProperty(PropertyName = "")]
    public string DeviceIMEI { get; set; }
    [JsonProperty(PropertyName = "")]
    public Location Destination { get; set; }
    [JsonProperty(PropertyName = "")]
    public string Address { get; set; }
    [JsonProperty(PropertyName = "")]
    public DateTime ArrivalTime { get; set; }
    [JsonProperty(PropertyName = "")]
    public int Transtport_Type { get; set; }

  }
  public class Location
  {
    [JsonProperty(PropertyName = "")]
    public double X { get; set; }
    [JsonProperty(PropertyName = "")]
    public double Y { get; set; }

  }
}