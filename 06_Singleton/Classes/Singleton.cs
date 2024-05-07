public class Singleton
{
    private static Singleton? instance;
    
    private Singleton()
    {
        // Private constructor to prevent instantiation from outside the class
    }
    
    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
    
    // Add your class members and methods here
}