public class Person
{

    static Person instance;

    // no arg function
    public static Person Instance
    {
        // Getter
        get
        {
            // If instance has a valid value/not known, return instance
            if (instance != null)
            {
                return instance;
            }
            else
            {
                // If instance is null, set instance as a new person type and return instance.
                instance = new Person();
                return instance;
            }
        }
    }
}