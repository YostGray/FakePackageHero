using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class UIBase : MonoBehaviour
{
    [NonSerialized]
    public RectTransform uiTransform;

    public virtual void Awake()
    {
        uiTransform = GetComponent<RectTransform>();
    }

    public virtual void Show()
    {
        this.gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
