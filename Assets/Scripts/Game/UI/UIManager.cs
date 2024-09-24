using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    ResLoader resLoader;
    Canvas rootCanvas;
    public Camera UICamera { private set; get; }
    public Dictionary<string, GameObject> allWin;

    protected override void Initialize()
    {
        resLoader = ResLoadManager.GetResLoader();
        rootCanvas = GameObject.Find("UIRootCanvas")?.GetComponent<Canvas>();
        UICamera = GameObject.Find("UICamera")?.GetComponent<Camera>();
        allWin = new Dictionary<string, GameObject>();
    }

    public GameObject LoadWindow(string windowName)
    {
        string winPath = PathHelper.GetUIPrefabPath(windowName);
        GameObject go = resLoader.Load<GameObject>(winPath);
        if (go == null)
        {
            Debug.LogError($"can't load ui {windowName}");
            return null;
        }
        GameObject win = GameObject.Instantiate(go, rootCanvas.transform);
        allWin.Add(windowName, win);
        return win;
    }

    public T ShowOrLoadWindow<T>(string windowName) where T: UIBase
    {
        T win = GetWindow<T>(windowName);
        if (win != null)
        {
            win.Show();
            return win;
        }
        win = LoadWindow<T>(windowName);
        return win;
    }

    public T LoadWindow<T>(string windowName) where T : UIBase
    {
        string winPath = PathHelper.GetUIPrefabPath(windowName);
        GameObject go = resLoader.Load<GameObject>(winPath);
        if (go == null)
        {
            Debug.LogError($"can't load ui {windowName}");
            return default;
        }
        GameObject win = GameObject.Instantiate(go, rootCanvas.transform);
        allWin.Add(windowName, win);
        return win.GetComponent<T>();
    }

    public T GetWindow<T>(string windowName) where T : UIBase
    {
        if (allWin.ContainsKey(windowName))
            return allWin[windowName].GetComponent<T>();
        return default;
    }

    public bool IsWorldPositionOutOfScreen(Vector3 worldPos, Camera mainCam = null)
    {
        if (mainCam == null)
            mainCam = Camera.main;
        var screenPos = World2ScreenPos(worldPos, mainCam);
        if (screenPos.x < 0 || screenPos.y < 0 || screenPos.x > Screen.width || screenPos.y > Screen.height)
        {
            return true;
        }
        return false;    
    }

    public Vector2 World2ScreenPos(Vector3 worldPos, Camera mainCam = null)
    {
        if (mainCam == null)
            mainCam = Camera.main;
        return RectTransformUtility.WorldToScreenPoint(mainCam, worldPos);
    }

    public bool World2UIPos(Vector3 worldPos,RectTransform rect, out Vector2 pos, Camera uiCam = null, Camera mainCam = null)
    {
        if (mainCam == null)
            mainCam = Camera.main;
        if (uiCam == null)
            uiCam = UICamera;
        return RectTransformUtility.ScreenPointToLocalPointInRectangle(rect, World2ScreenPos(worldPos, mainCam), uiCam, out pos);
    }
}