public class Journal
{
  public List<Write1> _entrylist = new List<Write1>()
  {
  };

  public Journal()
  {

  }
  public void Display()
  {

    _entrylist.Reverse();
    Console.Clear();
    foreach (var Entry in _entrylist)
    {
      Entry.Display();
    }
    _entrylist.Reverse();
    Console.WriteLine();

  }
  public void LoadEntry(List<Write1> entrylist)
  {
    _entrylist = entrylist;

  }

  public List<Write1> GetWrite()
  {
    return _entrylist;
  }

}