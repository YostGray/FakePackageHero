using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MonoDriver : SingletonMono<MonoDriver>
{
    /// <summary>
    /// 其它线程等待mone update调用的队列 网络用的多
    /// </summary>
    private ConcurrentQueue<Action> otherThreadWaitUpdateCallActions = new ConcurrentQueue<Action>();

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        while (otherThreadWaitUpdateCallActions.Count > 0)
        {
            if (otherThreadWaitUpdateCallActions.TryDequeue(out Action action))
            {
                action.Invoke();
            }
        }
    }

    /// <summary>
    /// 把非主线程要调用UnityAPI的操作 添加到队列 
    /// </summary>
    public void Add2OtherThreadWaitUpdateCall(Action action)
    {
        otherThreadWaitUpdateCallActions.Enqueue(action);
    }
}
