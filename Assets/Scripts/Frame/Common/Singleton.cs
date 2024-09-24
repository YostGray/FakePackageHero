using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Singleton<T> where T : Singleton<T>, new()
{
    private static T _instance;
    private static readonly object objectLock = new object();

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (objectLock)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                        _instance.Initialize();
                    }
                }
            }
            return _instance;
        }
    }
    protected virtual void Initialize()
    {
    }
}
