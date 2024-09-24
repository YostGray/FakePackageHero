using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 战斗场景
/// 每个战斗场景都该有一个
/// </summary>
public class BattleScene : MonoBehaviour
{
    public GameObject heroHolder;
    public GameObject enemyHolder;
    public Camera sceneMainCamera;
}