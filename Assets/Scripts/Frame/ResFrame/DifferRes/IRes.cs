public enum eResState
{
    none = 0,
    inited = 1,//初始化完毕
    wait2Load = 2,//等待加载
    loading = 3,//加载中
    loadDone = 4,//加载完毕
    released = 5,//已释放
}

interface IRes
{
    /// <summary>
    /// 资源的状态
    /// </summary>
    public eResState resState { set; get; }

    /// <summary>
    /// 释放此资源
    /// </summary>
    public void ReleaseAsset();

    /// <summary>
    /// 从等待加载的队列中移除
    /// </summary>
    public void RemoveFromeWait2LoadCoroutieQueeu();

    /// <summary>
    /// 停止加载的协程
    /// </summary>
    public void StopResLoadAsyncRoutine();
}
