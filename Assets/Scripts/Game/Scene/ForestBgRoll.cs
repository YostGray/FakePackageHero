using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

//森林背景滚动
public class ForestBgRoll : MonoBehaviour
{
    [SerializeField]
    private float backTreeMoveRate = 0.5f;
    [SerializeField]
    private float decoMoveRate = 1;
    [SerializeField]
    private float frontTreeMoveRate = 1;

    [SerializeField]
    private Vector2Int genTreeXRange = new Vector2Int(0,2);
    [SerializeField]
    private Vector2Int genTreeYRange = new Vector2Int(0,2);

    [SerializeField]
    private Transform bkDecoRoot = null;
    [SerializeField]
    private Transform bkGrassRoot = null;
    [SerializeField]
    private Transform bkTreesRoot = null;
    [SerializeField]
    private Transform ftTreesRoot = null;
    [SerializeField]
    private GameObject treePrototype = null;

    private Sprite[] treeSprites;
    private SpriteAtlas forestAtlas = null;
    private Sprite bg_deco = null;
    private Sprite bg_grass = null;
    private GameObject[] decoArray = new GameObject[3];
    private GameObject[] grassArray = new GameObject[3];
    private ObjectPool treePool;
    private Dictionary<int, GameObject> treeDic;
    private Dictionary<int, GameObject> bkTreeDic;
    private float curLogicPos = 0;

    private ResLoader resLoader;
    private Vector3[] posArray = new Vector3[] {
        new Vector3(-128,0,0),
        new Vector3(0, 0, 0),
        new Vector3(128, 0, 0)
    };
    private Color grayColor = new Color(0.427451f, 0.427451f, 0.427451f);

    private int bgLayerValue;

    private void Awake()
    {
        resLoader = ResLoadManager.GetResLoader();

        forestAtlas = resLoader.Load<SpriteAtlas>(PathHelper.GetAtlasePath("Forest"));
        bg_deco = forestAtlas.GetSprite("bg_deco");
        bg_grass = forestAtlas.GetSprite("bg_grass");

         List<string> treeResNames = new List<string>();
        treeResNames.Add("bg_tree01");
        treeResNames.Add("bg_tree02");
        treeSprites = new Sprite[treeResNames.Count];
        for (int i = 0; i < treeResNames.Count; i++)
        {
            treeSprites[i] = forestAtlas.GetSprite(treeResNames[i]);
        }
        treePool = new ObjectPool(treePrototype);
        treeDic = new Dictionary<int, GameObject>();
        bkTreeDic = new Dictionary<int, GameObject>();
        LoopTrees();


        bgLayerValue = SortingLayer.NameToID("Bg");
        for (int i = 0; i < 3; i++)
        {
            decoArray[i] = new GameObject("bg_deco" + i);
            decoArray[i].transform.SetParent(bkDecoRoot);
            decoArray[i].transform.localPosition = posArray[i];
            SpriteRenderer sr = decoArray[i].AddComponent<SpriteRenderer>();
            sr.sprite = Instantiate(bg_deco);
            sr.sortingLayerID = bgLayerValue;
            sr.sortingOrder = 2;

            grassArray[i] = new GameObject("bg_grass" + i);
            grassArray[i].transform.SetParent(bkGrassRoot);
            grassArray[i].transform.localPosition = posArray[i];
            SpriteRenderer sr2 = grassArray[i].AddComponent<SpriteRenderer>();
            sr2.sprite = Instantiate(bg_grass);
            sr2.sortingLayerID = bgLayerValue;
            sr2.sortingOrder = 4;
        }
    }

    //private void Update()
    //{
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        Move(-0.25f);
    //    }
    //    else if (Input.GetKey(KeyCode.D))
    //    {
    //        Move(0.5f);
    //    }
    //}

    /// <summary>
    /// 移动整个背景
    /// </summary>
    /// <param name="distance">移动距离</param>
    public void Move(float distance)
    {
        curLogicPos += distance;
        var moveVector = new Vector3(-distance, 0, 0);
        for (int i = 0; i < 3; i++)
        {
            decoArray[i].transform.position = decoArray[i].transform.position + moveVector * decoMoveRate;
            grassArray[i].transform.position = grassArray[i].transform.position + moveVector * decoMoveRate;
        }
        LoopBlock(decoArray);
        LoopBlock(grassArray);
        LoopTrees(distance);
    }

    private void LoopBlock(GameObject[] goArray)
    {
        if (goArray[1].transform.position.x < -64)
        {
            var temp = goArray[0];
            goArray[0] = goArray[1];
            goArray[1] = goArray[2];
            goArray[2] = temp;
            goArray[2].transform.position = goArray[1].transform.position + posArray[2];
        }
        else if (goArray[1].transform.position.x > 64)
        {
            var temp = goArray[2];
            goArray[2] = goArray[1];
            goArray[1] = goArray[0];
            goArray[0] = temp;
            goArray[0].transform.position = goArray[1].transform.position + posArray[0];
        }
    }

    private readonly int genStep = 48;
    private int? lastGenPos = null;
    private void LoopTrees(float distance = 0)
    {
        //每genStep单位生成一个树
        //树超出±64后销毁
        int startPost = (int)curLogicPos / genStep * genStep;
        List<int> needRemoveIndex = new List<int>();
        var moveVector = new Vector3(-distance, 0, 0);
        foreach (var treePair in treeDic)
        {
            if (treePair.Key > curLogicPos + genStep * 3)
            {
                needRemoveIndex.Add(treePair.Key);
            }
            else if (treePair.Key < curLogicPos - genStep * 3)
            {
                needRemoveIndex.Add(treePair.Key);
            }
            else
            {
                treePair.Value.transform.localPosition = treePair.Value.transform.localPosition + moveVector * frontTreeMoveRate;
            }
        }
        foreach (var index in needRemoveIndex)
        {
            if(treeDic.Remove(index, out var go))
            {
                treePool.Recycle(go);
            }
        }
        needRemoveIndex.Clear();
        foreach (var treePair in bkTreeDic)
        {
            if (treePair.Key > curLogicPos + genStep * 3)
            {
                needRemoveIndex.Add(treePair.Key);
            }
            else if (treePair.Key < curLogicPos - genStep * 3)
            {
                needRemoveIndex.Add(treePair.Key);
            }
            else
            {
                treePair.Value.transform.localPosition = treePair.Value.transform.localPosition + moveVector * backTreeMoveRate;
            }
        }
        foreach (var index in needRemoveIndex)
        {
            if (bkTreeDic.Remove(index, out var go))
            {
                treePool.Recycle(go);
            }
        }

        if (lastGenPos.HasValue && Mathf.Abs(lastGenPos.Value - startPost) < genStep)
        {
            return;
        }
        lastGenPos = startPost;
        for (int i = startPost; i < startPost + genStep * 3; i += genStep) 
        {
            TryGenTree(i);
            TryGenTree(startPost - (i - startPost));

            TryGenTree(i - genStep / 2,true);
            TryGenTree(startPost - (i - startPost - genStep / 2),true);
        }
    }

    private void TryGenTree(int logicPos,bool isBk = false)
    {
        if ((!isBk && treeDic.ContainsKey(logicPos)) || (isBk && bkTreeDic.ContainsKey(logicPos)))
        {
            return;
        }

        //需要根据位置获取唯一的两个随机结果：
        //树的种类 位置的偏移
        //使用柏林噪声
        float scale = 0.05f;
        float treeType = Mathf.Clamp01(Mathf.PerlinNoise(logicPos * scale, 0));
        float treeOffsiteX = Mathf.Clamp01(Mathf.PerlinNoise(logicPos * scale, scale));
        float treeOffsiteY = Mathf.Clamp01(Mathf.PerlinNoise(logicPos * scale, 5 * scale));
        bool marker = Mathf.Clamp01(Mathf.PerlinNoise(logicPos * scale, 10 * scale)) >= 0.5f;
        bool marker2 = Mathf.Clamp01(Mathf.PerlinNoise(logicPos * scale, 20 * scale)) >= 0.5f;
        int flage = marker ? 1 : -1;
        int flage2 = marker2 ? 1 : -1;

        int index = (int)(treeType * (treeSprites.Length + 1));
        if (index >= treeSprites.Length)
        {
            Debug.Log("SKIP GEN");
            return;
        }
        GameObject treeGo = treePool.GetOne();
        SpriteRenderer sr = treeGo.GetComponent<SpriteRenderer>();
        sr.sprite = treeSprites[index];
        sr.flipX = marker;

        int offsiteX = (int)(treeOffsiteX * (genTreeXRange.y - genTreeXRange.x)) * flage;
        int offsiteY = (int)(treeOffsiteY * (genTreeYRange.y - genTreeYRange.x)) * flage2;

        if (isBk)
        {
            treeGo.transform.parent = bkTreesRoot;
            sr.sortingOrder = 1;
            sr.color = grayColor;
            bkTreeDic.Add(logicPos, treeGo);
        }
        else
        {
            treeGo.transform.parent = ftTreesRoot;
            sr.sortingOrder = 3;
            sr.color = Color.white;
            treeDic.Add(logicPos, treeGo);
        }

        treeGo.transform.localPosition = new Vector3(logicPos - curLogicPos + offsiteX, offsiteY - 16,0);
    }
}
