using UnityEngine;

public class ItemShape
{
    public Vector2Int OutLineSize { private set; get; }//形状的包围框边长(也用作图片的长宽)
    bool[] shapeArray; //形状数组 d1为x d2为y 坐标从左下起
    public Vector2Int root { private set; get; }//形状的根(也是旋转中心)，尽量贴近几何中心
    int blockNum = 0;
    public eRotateToward rotate { private set; get; } = eRotateToward.up;

    public ItemShape(ItemCfgData itemCfg)
    {
        if (string.IsNullOrEmpty(itemCfg.size))
        {
            Debug.LogError($"item size cfg string error, id:{itemCfg.id},name:{itemCfg.name}");
            return;
        }
        string[] lines = itemCfg.size.Split('\n');
        int size_y = lines.Length;
        int size_x = lines[size_y - 1].Length;//最后一列没有换行
        OutLineSize = new Vector2Int(size_x, size_y);
        shapeArray = new bool[size_x * size_y];
        for (int y = 0; y < size_y; y++)
        {
            char[] charArray = lines[size_y - y - 1].ToCharArray();//左下起
            for (int x = 0; x < size_x; x++)
            {
                char c = charArray[x];
                int index = y * size_x + x;
                switch (c)
                {
                    case '1':
                        shapeArray[index] = true;
                        blockNum ++;
                        break;
                    case '0':
                        shapeArray[index] = false;
                        break;
                    default:
                        Debug.LogError($"illegal shap char, id:{itemCfg.id},name:{itemCfg.name}");
                        shapeArray[index] = false;
                        break;
                }
            }
        }
        root = new Vector2Int((size_x - 1) / 2, (size_y - 1) / 2);
        rotate = eRotateToward.up;
    }

    public ItemShape(string customSizeStr)
    {
        if (string.IsNullOrEmpty(customSizeStr))
        {
            Debug.LogError($"custom size string error, string:{customSizeStr}");
            return;
        }
        string[] lines = customSizeStr.Split('\n');
        int size_y = lines.Length;
        int size_x = lines[size_y - 1].Length;//最后一列没有换行
        OutLineSize = new Vector2Int(size_x, size_y);
        shapeArray = new bool[size_x * size_y];
        for (int y = 0; y < size_y; y++)
        {
            char[] charArray = lines[size_y - y - 1].ToCharArray();//左下起
            for (int x = 0; x < size_x; x++)
            {
                char c = charArray[x];
                int index = y * size_x + x;
                switch (c)
                {
                    case '1':
                        shapeArray[index] = true;
                        blockNum++;
                        break;
                    case '0':
                        shapeArray[index] = false;
                        break;
                    default:
                        Debug.LogError($"illegal shap char, string:{customSizeStr}");
                        shapeArray[index] = false;
                        break;
                }
            }
        }
        root = new Vector2Int((size_x - 1) / 2, (size_y - 1) / 2);
        rotate = eRotateToward.up;
    }

    /// <summary>
    /// 获取相对Root的有东西的格子的偏移坐标
    /// </summary>
    public Vector2Int[] Get2RootShiftArray()
    {
        Vector2Int[] array = new Vector2Int[blockNum];

        int size_x = OutLineSize.x;
        int index = 0;
        for (int i = 0; i < shapeArray.Length; i++)
        {
            if (shapeArray[i])
            {
                int y = i / size_x;
                int x = i % size_x;

                array[index] = new Vector2Int(x, y) - root;
                index++;
            }
        }

        return array;
    }

    /// <summary>
    /// 顺时针旋转
    /// </summary>
    public void Rotate()
    {
        int size_x = OutLineSize.x;
        int size_y = OutLineSize.y;
        bool[] newShapeArray = new bool[shapeArray.Length];
        for (int i = 0; i < shapeArray.Length; i++)
        {
            if (shapeArray[i])
            {
                int o_x = i % size_x;
                int o_y = i / size_x; 
                int x = o_y; 
                int y = size_x - o_x - 1;
                int newIndex = y * size_y + x;
                newShapeArray[newIndex] = shapeArray[i];
                if (root.x == o_x && root.y == o_y)
                    root = new Vector2Int(x, y);
            }
        }
        shapeArray = newShapeArray;
        OutLineSize = new Vector2Int(OutLineSize.y, OutLineSize.x);

        //记录当前的旋转角度
        switch (rotate)
        {
            case eRotateToward.up:
                rotate = eRotateToward.right;
                break;
            case eRotateToward.right:
                rotate = eRotateToward.down;
                break;
            case eRotateToward.down:
                rotate = eRotateToward.left;
                break;
            case eRotateToward.left:
                rotate = eRotateToward.up;
                break;
        }
    }

    public void Filp()
    {
        
    }

#region 常量
    private static readonly ItemShape _near4shap = new ItemShape(
            "010\n" +
            "101\n" +
            "010");
    /// <summary>
    /// 临近的四个位置
    /// 010
    /// 101
    /// 010
    /// </summary>
    public static ItemShape Near4shap{
        get{
            return _near4shap;
        }
    }
#endregion
}

public enum eRotateToward
{
    up = 1,//默认都是朝上
    right = 2,
    down = 3,
    left = 4,
}