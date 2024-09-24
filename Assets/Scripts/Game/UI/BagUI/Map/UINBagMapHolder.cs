using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UINBagMapHolder : UIBase, IDragHandler, IBeginDragHandler
{
    [SerializeField]
    private RectTransform mapRoot;

    private Vector3 startDragPos = Vector3.zero;
    private Vector2 dragRelativePos = Vector2.zero;
    private void Start()
    {
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startDragPos = transform.position;
        dragRelativePos = eventData.position - UIManager.Instance.World2ScreenPos(transform.position, UIManager.Instance.UICamera);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 newPos;
        RectTransformUtility.ScreenPointToWorldPointInRectangle(
            mapRoot, eventData.position - dragRelativePos, UIManager.Instance.UICamera, out newPos);

        Vector2 rootSize = new Vector2(mapRoot.rect.width, mapRoot.rect.height);
        Vector2 rootPos = mapRoot.position;

        Vector2 selfSize = uiTransform.sizeDelta;
        Vector2 selfPos = uiTransform.position;

        //地图小于外框大小不允许拖动
        //否则边缘不能离开外框
        if (rootSize.x > selfSize.x)
        {
            newPos.x = selfPos.x;
        }
        else
        {
            float dis = Math.Abs(uiTransform.anchoredPosition.x);
            float maxDis = selfSize.x - rootSize.x;

            if (dis > maxDis)
            {
                if ((selfPos.x - rootPos.x) * (selfPos.x - newPos.x) < 0)
                {
                    newPos.x = selfPos.x;
                }
            }
        }
        if (rootSize.y > selfSize.y)
        {
            newPos.y = selfPos.y;
        }
        else
        {
            float dis = Math.Abs(uiTransform.anchoredPosition.y);
            float maxDis = selfSize.y - rootSize.y;

            if (dis > maxDis)
            {
                if ((selfPos.y - rootPos.y) * (selfPos.y - newPos.y) < 0)
                {
                    newPos.y = selfPos.y;
                }
            }
        }

        uiTransform.position = newPos;
    }
}