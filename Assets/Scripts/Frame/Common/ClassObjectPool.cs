using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ClassObjectPool<T> where T: class, IPoolClass, new()
{
    //存储用的栈
    protected Stack<T> pool = new Stack<T>();
    //对象池大小 超过的数目则释放
    protected int poolMaxCount = 0;
    //没有回收的对象个数
    protected int noRecycleCount = 0;

    public ClassObjectPool(int max)
    {
        poolMaxCount = max;
        for (int i = 0; i < poolMaxCount; i++)
        {
            pool.Push(new T());
        }
    }

    /// <summary>
    /// 从对象池中取出对象
    /// </summary>
    /// <param name="force">是否强制生成</param>
    /// <returns></returns>
    public T Get(bool force)
    {
        T t = null;
        if (pool.Count > 0)
        {
            t = pool.Pop();
        }

        if (force && t == null)
        {
            t = new T();
            noRecycleCount++;
        }
        t.OnGet();

        return t;
    }
    /// <summary>
    /// 回收对象，放进池中
    /// </summary>
    /// <param name="t">回收对象</param>
    /// <returns></returns>
    public bool Recycle(T t)
    {
        if (t == null)
        {
            return false;
        }

        noRecycleCount--;

        if (pool.Count > poolMaxCount && poolMaxCount > 0)
        {
            t.OnRemove();
            t = null;
            return false;
        }

        t.OnRecycle();
        pool.Push(t);
        return true;

    }
}

public interface IPoolClass
{
    /// <summary>
    /// 当被获取
    /// </summary>
    public void OnGet();
    /// <summary>
    /// 当被回收
    /// </summary>
    public void OnRecycle();

    /// <summary>
    /// 没有被回收 而是销毁了
    /// </summary>
    public void OnRemove();
}
