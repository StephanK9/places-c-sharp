using System.Collections.Generic;

namespace Vacation.Objects
{
  public class Place
  {
    private string _cityName;
    private string _picture;
    private string _timeSpent;
    private int _id;

    private static List<Place> _instances = new List<Place>{};

    public Place(string city, string picture, string time)
    {
      _cityName = city;
      _picture = picture;
      _timeSpent = time;
      _instances.Add(this);
      _id = _instances.Count;

    }

    public string GetCityName()
    {
      return _cityName;
    }
    public void SetCityName(string cityName)
    {
      _cityName = cityName;
    }

    public string GetPicture()
    {
      return _picture;
    }
    public void SetPicture(string picture)
    {
      _picture = picture;
    }

    public string GetTimeSpent()
    {
      return _timeSpent;
    }
    public void SetTimeSpent(string timeSpent)
    {
      _timeSpent = timeSpent;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId - 1];
    }

  }
}
