using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 用于扩展原来文字的文字
/// </summary>
public class ExTextHelper : Text
{
    [MenuItem("CONTEXT/Text/替换Text为ExText")]
    private static void ReplaceText()
    {
        Debug.Log("在Text上右键");
    }

    [MenuItem("GameObject/UI/ExText")]
    private static void AddExtext()
    {
        GameObject selectOne = Selection.activeGameObject;
        GameObject go = new GameObject();
        go.name = "ExText";
        go.transform.parent = selectOne.transform;
        ExText exText = go.AddComponent<ExText>();
    }
}