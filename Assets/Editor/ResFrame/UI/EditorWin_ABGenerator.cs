using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

/// <summary>
/// AB包编辑器扩展
/// </summary>
class EditorWin_ABGenerator : EditorWindow
{
    private string[] panelTypeName = { "配置打包器", "打包规则", "开始打包" };
    ePanelType panelType = ePanelType.generatorCfg;
    private enum ePanelType
    {
        generatorCfg = 0,
        ABCfg = 1,
        startGen = 2,
    }
    private ReorderableList ABCfgList;
    private Vector2 ABCfgScrollPos = Vector2.zero;


    /// <summary>
    /// 打开AB生成器的窗口
    /// </summary>
    [MenuItem("Extension/ResFrame/AB打包编辑器", priority = 1)]
    private static void OpenABGeneratorWin()
    {
        EditorWindow.GetWindow<EditorWin_ABGenerator>("AB打包编辑器", true);
    }

    /// <summary>
    /// 试着重读资源目录
    /// </summary>
    [MenuItem("Extension/ResFrame/重读资源目录", priority = 2)]
    private static void TryRereadAllManifest()
    {
        ResLoadManager.TryReadManifest();
    }

    /// <summary>
    /// 在编辑器中切换启用AB
    /// </summary>
    [MenuItem("Extension/ResFrame/在编辑器中启用AB", priority = 3)]
    private static void ChangeUseABInEditor()
    {
        ResLoadManager.useABInEditor = !ResLoadManager.useABInEditor;
    }

    /// <summary>
    /// 在编辑器中切换启用AB
    /// </summary>

    [MenuItem("Extension/ResFrame/在编辑器中启用AB",true)]
    private static bool ChangeUseABInEditorValidate()
    {
        Menu.SetChecked("Extension/ResFrame/在编辑器中启用AB", ResLoadManager.useABInEditor);
        return true;
    }


    private void Awake()
    {
        AssetBundleGenerator.ReadOrCreatCfgDatas();
        ABCfgList = new ReorderableList(AssetBundleGenerator.ABCfgList, typeof(ABPackageCfgData));
        ABCfgList.elementHeight = 150;
        ABCfgList.draggable = true;
        ABCfgList.drawElementCallback = OnDrawElement;
        ABCfgList.drawHeaderCallback = OnDrawHead;
        ABCfgList.onAddCallback = OnAddElement;
    }

    void OnGUI()
    {
        ShowTogs();
        ShowDiffPanel();
    }

#region 窗口样式代码
    private void ShowTogs()
    {
        using (new EditorGUILayout.HorizontalScope())
        {
            panelType = (ePanelType)GUILayout.Toolbar((int)panelType, panelTypeName);
        }
    }

    private void ShowDiffPanel()
    {
        switch (panelType)
        {
            case ePanelType.generatorCfg:
                ShowEditGeneratorCfg();
                break;
            case ePanelType.ABCfg:
                ShowEditABCfg();
                break;
            case ePanelType.startGen:
                ShowStartGenAB();
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 配置打包器
    /// </summary>
    private void ShowEditGeneratorCfg()
    {
        GeneratorCfgData generatoeCfgData = AssetBundleGenerator.generatorCfg;

        EditorGUILayout.LabelField("AB包配置存储目录:", generatoeCfgData.ABPackageCfgsJsonPath);
        EditorGUILayout.LabelField("打包结果存储位置:", generatoeCfgData.ABStorePath);
        EditorGUIUtility.labelWidth = 180;
        EditorGUILayout.Space();
        generatoeCfgData.ABExtension = EditorGUILayout.TextField("AssetBundle后缀", generatoeCfgData.ABExtension);
        EditorGUILayout.Space();
        generatoeCfgData.isWarnAutoDepBundleSize = EditorGUILayout.Toggle("警告依赖收集包大小", generatoeCfgData.isWarnAutoDepBundleSize);
        if (generatoeCfgData.isWarnAutoDepBundleSize)
        {
            generatoeCfgData.warnAutoDepBundleFileSize_KB = EditorGUILayout.FloatField("警告依赖收集包大小(单位KB)", generatoeCfgData.warnAutoDepBundleFileSize_KB);
            EditorGUILayout.Space();
        }
        EditorGUILayout.Space();

        EditorGUILayout.LabelField("使用\"|\"分隔开多个配置:");
        EditorGUIUtility.labelWidth = 250;
        generatoeCfgData.notCollectFileExtensions = ShowCfgString("获取文件时 需要忽略的文件后缀名", generatoeCfgData.notCollectFileExtensions);
        generatoeCfgData.notCollectDirFullName = ShowCfgString("获取文件时 需要忽略的文件夹", generatoeCfgData.notCollectDirFullName);
        generatoeCfgData.notCollectFileExtensions_Dependencies = ShowCfgString("收集依赖时 需要忽略的文件后缀名", generatoeCfgData.notCollectFileExtensions_Dependencies);
        generatoeCfgData.notCollectFileExtensions_Dependencies_Dep = ShowCfgString("收集依赖时 需要忽略的被依赖的文件后缀名", generatoeCfgData.notCollectFileExtensions_Dependencies_Dep);
        EditorGUILayout.Space();

        EditorGUIUtility.labelWidth = 180;
        generatoeCfgData.buildTarget = (BuildTarget)EditorGUILayout.EnumPopup("打包目标平台", generatoeCfgData.buildTarget);
        generatoeCfgData.buildAssetBundleOptions = (BuildAssetBundleOptions)EditorGUILayout.EnumFlagsField("打包枚举", generatoeCfgData.buildAssetBundleOptions);
        generatoeCfgData.isCleanOutputDir = EditorGUILayout.Toggle("是否清空输出目录", generatoeCfgData.isCleanOutputDir);
        generatoeCfgData.copy2SteamingAssets = EditorGUILayout.Toggle("拷贝到SteamingAssets", generatoeCfgData.copy2SteamingAssets);
        EditorGUILayout.Space();


        using (new GUILayout.HorizontalScope())
        {
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("保存", EditorStyles.miniButtonMid, GUILayout.Width(200)))
            {
                AssetBundleGenerator.SaveGeneratorCfg();
            }
            GUILayout.FlexibleSpace();
        }
    }

    private List<string> ShowCfgString(string title,List<string> orginalStrArray)
    {
        string value = "";
        if (orginalStrArray != null && orginalStrArray.Count > 0)
        {
            foreach (var item in orginalStrArray)
            {
                if (string.IsNullOrEmpty(value))
                    value += item;
                else
                    value += "|" + item;
            }
        }
        return EditorGUILayout.TextField(title, value).Split('|').ToList();
    }

    /// <summary>
    /// 打包规则
    /// </summary>
    private void ShowEditABCfg()
    {
        using (var scop = new GUILayout.ScrollViewScope(ABCfgScrollPos)) 
        {
            ABCfgScrollPos = scop.scrollPosition;
            ABCfgList.DoLayoutList();
        }
        EditorGUILayout.Space();
        using (new GUILayout.HorizontalScope())
        {
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("保存", EditorStyles.miniButtonMid, GUILayout.Width(200)))
            {
                AssetBundleGenerator.SaveABCfgs();
            }
            GUILayout.FlexibleSpace();
        }
    }

    private void OnDrawHead(Rect rect)
    {
        GUI.Label(rect, "规则列表");
    }

    private void OnDrawElement(Rect parentRect, int index, bool isActive, bool isFocused)
    {
        ABPackageCfgData cfg = AssetBundleGenerator.ABCfgList[index];
        if (index % 2 == 0)
        {
            EditorGUI.DrawRect(new Rect(parentRect.x - 20, parentRect.y, parentRect.width + 20, parentRect.height), new Color(0.5f, 0.5f, 0.5f, 0.1f));
        }

        Rect rect = new Rect();
        //名字行
        {
            rect.x = parentRect.x;
            rect.y = parentRect.y + 10;
            rect.width = 0;
            rect.height = 20;

            rect.x = rect.x + rect.width;
            rect.width = 80;
            cfg.isUsing = EditorGUI.ToggleLeft(rect, "是否启用", cfg.isUsing);

            if (!cfg.isUsing)
                GUI.enabled = false;

            rect.x = rect.x + rect.width;
            rect.width = 60;
            EditorGUI.LabelField(rect, "规则名字:");

            rect.x = rect.x + rect.width;
            rect.width = parentRect.width - rect.x;
            cfg.name = EditorGUI.TextField(rect, cfg.name);
        }

        //路径行
        {
            rect.x = parentRect.x;
            rect.y = rect.y + rect.height + 5;
            rect.width = 0;
            rect.height = 20;

            rect.x = rect.x + rect.width;
            rect.width = 80;
            EditorGUI.LabelField(rect, "目录根路径:");

            GUI.enabled = false;
            rect.x = rect.x + rect.width;
            rect.width = parentRect.width - rect.x - 80;
            cfg.assetDir = EditorGUI.TextField(rect, cfg.assetDir);
            GUI.enabled = true;
            if (!cfg.isUsing)
                GUI.enabled = false;

            rect.x = rect.x + rect.width + 5;
            rect.width = 75;
            if (GUI.Button(rect, "选择路径"))
            {
               cfg.assetDir = SelectFolder();
            }
        }

        //路径规则行
        {
            rect.x = parentRect.x;
            rect.y = rect.y + rect.height + 5;
            rect.width = 0;
            rect.height = 20;

            rect.x = rect.x + rect.width;
            rect.width = 80;
            EditorGUI.LabelField(rect, "文件通配符:");

            rect.x = rect.x + rect.width;
            rect.width = parentRect.width - rect.x - 285;
            cfg.searchePattern = EditorGUI.TextField(rect, cfg.searchePattern);

            rect.x = rect.x + rect.width + 5;
            rect.width = 90;
            if (cfg.packWay == ePackWay.total)
            {
                GUI.enabled = false;
                GUI.Toggle(rect, false, "递归子文件夹");
                GUI.enabled = true;
                if (!cfg.isUsing)
                    GUI.enabled = false;
            }
            else
            {
                cfg.isRecursionSearch = GUI.Toggle(rect, cfg.isRecursionSearch, "递归子文件夹");
            }

            rect.x = rect.x + rect.width + 5;
            rect.width = 90;
            if (cfg.packWay != ePackWay.eachFolder)
            {
                GUI.enabled = false;
                GUI.Toggle(rect, false, "包含顶层目录");
                GUI.enabled = true;
                if (!cfg.isUsing)
                    GUI.enabled = false;
            }
            else
            {
                cfg.isIncludeTopDir = GUI.Toggle(rect, cfg.isIncludeTopDir, "包含顶层目录");
            }

            rect.x = rect.x + rect.width + 5;
            rect.width = 90;
            cfg.isForceIncludeDepends = GUI.Toggle(rect, cfg.isForceIncludeDepends, "强制包含依赖");
        }

        //类型行
        {
            rect.x = parentRect.x;
            rect.y = rect.y + rect.height + 5;
            rect.width = 0;
            rect.height = 20;

            float w = (parentRect.width - 180) / 2;

            rect.x = rect.x + rect.width;
            rect.width = 80;
            EditorGUI.LabelField(rect, "打包方式:");

            rect.x = rect.x + rect.width;
            rect.width = w;
            cfg.packWay = (ePackWay)EditorGUI.EnumPopup(rect, cfg.packWay);

            rect.x = rect.x + rect.width + 5;
            rect.width = 80;
            EditorGUI.LabelField(rect, "Mainfest方式:");

            rect.x = rect.x + rect.width;
            rect.width = w - 5;
            cfg.manifestWriteType = (eManifestWriteType)EditorGUI.EnumPopup(rect, cfg.manifestWriteType);
        }
        GUI.enabled = true;
    }

    private void OnAddElement(ReorderableList list)
    {
        string folderPath = SelectFolder();
        if (string.IsNullOrEmpty(folderPath))
        {
            return;
        }
        ABPackageCfgData cfg = new ABPackageCfgData();
        cfg.assetDir = folderPath;
        AssetBundleGenerator.ABCfgList.Add(cfg);
    }

    /// <summary>
    /// 开始打包
    /// </summary>
    private void ShowStartGenAB()
    {
        EditorGUILayout.Space();
        using (new EditorGUILayout.HorizontalScope())
        {
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("打包", EditorStyles.miniButtonMid, GUILayout.Width(200)))
            {
                AssetBundleGenerator.StartGenABs();
            }
            GUILayout.FlexibleSpace();
        }
        EditorGUILayout.Space();
        using (new EditorGUILayout.HorizontalScope())
        {
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("检查资源重复", EditorStyles.miniButtonMid, GUILayout.Width(200)))
            {
                Debug.LogWarning("还没做");
            }
            GUILayout.FlexibleSpace();
        }
        EditorGUILayout.Space();
        using (new EditorGUILayout.HorizontalScope())
        {
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("手动拷贝到StreamingAssets", EditorStyles.miniButtonMid, GUILayout.Width(200)))
            {
                AssetBundleGenerator.Copy2SteamingAssets();
            }
            GUILayout.FlexibleSpace();
        }
    }
    #endregion

    private string SelectFolder()
    {
        string assetPath = Application.dataPath.Replace('\\', '/');
        string selectedPath = EditorUtility.OpenFolderPanel("选择目录", assetPath, "").Replace('\\', '/');
        if (string.IsNullOrEmpty(selectedPath))
        {
            return null;
        }
        if (selectedPath.StartsWith(assetPath))
        {
            return "Assets/" + selectedPath.Substring(assetPath.Length + 1);
        }
        else
        {
            ShowNotification(new GUIContent("需要目录在Assets/下！"));
            return null;
        }
    }

    private void OnDestroy()
    {

    }
}
