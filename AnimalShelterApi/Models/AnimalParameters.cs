public class AnimalParameters
{
  const int maxPageSize = 5;
  public int PageNumber { get; set; } = 1;

  private int _pageSize = 1;
  public int PageSize
  {
    get
    {
      return _pageSize;
    }
    set
    {
      _pageSize = (value > maxPageSize) ? maxPageSize : value;
    }
  }
}