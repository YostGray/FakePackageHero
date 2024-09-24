using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool
{
    //存储用的栈
    protected Stack<GameObject> pool;
    public List<GameObject> livingList;
    protected GameObject prototype;
    protected Transform poolRoot;
    protected Transform recyclePoolRoot;

    public ObjectPool(GameObject prototype,bool isAutoHide = true,Transform customRoot = null)
    {
        pool = new Stack<GameObject>();
        livingList = new List<GameObject>();
        this.prototype = prototype;
        if (isAutoHide)
        {
            prototype.SetActive(false);
        }

        if (customRoot != null)//自定义根节点
        {
            poolRoot = customRoot;
        }
        else
        {
            poolRoot = prototype.transform.parent.transform;
        }

        var root = new GameObject("recyclePoolRoot");
        root.transform.SetParent(poolRoot);
        recyclePoolRoot = root.transform;
    }

    /// <summary>
    /// 从对象池中取出对象
    /// </summary>
    public GameObject GetOne()
    {
        GameObject go = null;
        if (pool.Count > 0)
        {
            go = pool.Pop();
        }

        if (go == null)
        {
            go = GameObject.Instantiate(prototype, poolRoot);
        }
        go.SetActive(true);
        go.transform.SetParent(poolRoot);
        livingList.Add(go);
        return go;
    }

    /// <summary>
    /// 回收对象，放进池中
    /// </summary>
    public void Recycle(GameObject go)
    {
        if (!livingList.Contains(go)) {
            Debug.LogError($"想要回收非池子物体:{go.name}");
        }
        livingList.Remove(go);
        go.SetActive(false);
        go.transform.SetParent(recyclePoolRoot);
        pool.Push(go);
    }

    /// <summary>
    /// 回收所有对象，放进池中
    /// </summary>
    public void RecycleAll()
    {
        foreach (var go in livingList)
        {
            go.SetActive(false);
            go.transform.SetParent(recyclePoolRoot);
            pool.Push(go);
        }
        livingList.Clear();
    }

    /// <summary>
    /// 从对象池移除对象(不再受对象池管控)
    /// </summary>
    public void RemoveOne(GameObject go)
    {
        if (!livingList.Contains(go))
        {
            Debug.LogError($"想要移除非池子物体:{go.name}");
        }
        livingList.Remove(go);
    }

    /// <summary>
    /// 向对象池添加对象(使其受对象池管控，特殊情况才用，需注意)
    /// </summary>
    public void AddOne(GameObject go)
    {
        if (livingList.Contains(go))
        {
            Debug.LogError($"添加对象重复:{go.name}");
        }
        go.SetActive(true);
        go.transform.SetParent(poolRoot);
        livingList.Add(go);
    }
}
