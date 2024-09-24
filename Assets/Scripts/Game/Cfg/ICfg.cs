using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICfg
{
    /// <summary>
    /// 获取数据序列化、反序列化类型
    /// </summary>
    /// <returns></returns>
    public Type GetDataType();
    /// <summary>
    /// 填充数据
    /// </summary>
    /// <param name="o"></param>
    public void FillData(object o);
    /// <summary>
    /// 加载后处理
    /// </summary>
    public void LoadOverDeal();
}