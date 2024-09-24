using UnityEngine;

public class UINItemDesNode : UIBase
{
    [SerializeField]
    private ExText conditon;
    [SerializeField]
    private ExText des;

    public void RefreshByItemFuncData(ItemFuncData data)
    {
        conditon.text = data.conditonStr;
        des.text = data.desStr;
    }
}