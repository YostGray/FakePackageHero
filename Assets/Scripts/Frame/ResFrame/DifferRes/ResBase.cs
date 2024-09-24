using System;
using System.Collections;

public abstract class ResBase<T> : IRes where T : UnityEngine.Object
{
    protected eResState _resState;
    eResState IRes.resState { get { return _resState; } set { _resState = value; } }
    protected Action<T> finishAction;
    protected Action loadOverCallback;
    protected IEnumerator loadCoroutine;
    protected Action<Action> loadAction;

    public ResBase()
    {
        _resState = eResState.inited;
    }

    public abstract T ResLoad();

    /// <summary>
    /// 异步加载
    /// </summary>
    public virtual void ResLoadAsync(Action<T> finishAction)
    {
        _resState = eResState.wait2Load;
        this.finishAction = finishAction;
        loadAction = m_ResLoadAsync;
        ResLoadManager.AddWait2LoadCoroutine(loadAction);
    }

    /// <summary>
    /// 开始跑携程
    /// </summary>
    protected virtual void m_ResLoadAsync(Action loadOverCallback)
    {
        _resState = eResState.loading;
        this.loadOverCallback = loadOverCallback;
        this.loadCoroutine = m_ResLoadAsyncCoroutine();
        MonoDriver.Instance.StartCoroutine(loadCoroutine);
    }

    /// <summary>
    /// 异步加载的具体协程
    /// </summary>
    protected abstract IEnumerator m_ResLoadAsyncCoroutine();

    /// <summary>
    /// 从等待加载的队列中移除
    /// </summary>
    public void RemoveFromeWait2LoadCoroutieQueeu()
    {
        if (loadAction != null)
        {
            ResLoadManager.RemoveWait2LoadCoroutine(loadAction);
        }
    }

    /// <summary>
    /// 停止加载的协程
    /// </summary>
    public void StopResLoadAsyncRoutine()
    {
        if (loadCoroutine != null)
        {
            //直接停止可能会因为调用的不原子而产生问题
            //比如AB加载好了，但是引用的AB没加载好
            //MonoDriver.Instance.StopCoroutine(loadCoroutine);

            //替换掉LoadOver
            finishAction = null;
            loadOverCallback = () => {
                ReleaseAsset();
            };
        }
    }

    /// <summary>
    /// 释放此资源
    /// </summary>
    public virtual void ReleaseAsset()
    {
        _resState = eResState.released;
    }
}
