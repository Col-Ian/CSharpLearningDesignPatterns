public class StoreBranch{
  
  public string Location {get; set;} // shorthand for your getters and setters.

  public StoreBranch(){
    
  }

  public StoreBranch(string _Location){
    Location = _Location;
  }

  public StoreBranch Clone(){
    return MemberwiseClone() as StoreBranch; // MemberwiseClone() will return a clone of type StoreBranch
  }
  
}