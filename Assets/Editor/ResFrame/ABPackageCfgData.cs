using System.Collections;
using System.Collections.Generic;

/// <summary>
/// AB������������
/// </summary>
[System.Serializable]
public class ABPackageCfgData
{
    public string name;//�˹��������
    public bool isUsing = true;//�Ƿ����ô˴������
    public ePackWay packWay = ePackWay.none;//�����ʽ
    public eManifestWriteType manifestWriteType = eManifestWriteType.writeAll;

    public string assetDir;//��Դ��������Ŀ¼
    public string searchePattern;//����ͨ���
    public bool isRecursionSearch = true;//�Ƿ�ݹ������(total������)
    public bool isForceIncludeDepends = false;//�Ƿ�ǿ�ư�������(��������)
    public bool isIncludeTopDir = false;//�Ƿ��������Ŀ¼(eachFolder����)
}

/// <summary>
/// �����ʽ
/// </summary>
public enum ePackWay
{
    none = 0,//δ����
    eachFile = 1,//ÿ���ļ�һ��ab
    eachFolder = 2,//ÿ���ļ���һ��ab
    total = 3,//������Ŀ¼һ��ab
}

/// <summary>
/// �嵥д�뷽ʽ
/// TODO:���󶮣���ѧѧ �ƺ���ͼ��֮����ļ����
/// </summary>
public enum eManifestWriteType
{
    writeAll = 0,//д��ȫ��
}