#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtualFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Action`1<System.Reflection.Assembly>
struct Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42;
// System.Action`1<System.IO.FileInfo>
struct Action_1_t8FDFDD761A78E63D829702D183AAE14618CE0DAA;
// System.Action`1<System.Object>
struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87;
// System.Collections.Generic.HashSet`1<System.Object>
struct HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885;
// System.Collections.Generic.HashSet`1<System.String>
struct HashSet_1_tEFC6605F7DE53F71946C33FD371E53C3100F2178;
// System.Collections.Generic.IEqualityComparer`1<System.String>
struct IEqualityComparer_1_tAE94C8F24AD5B94D4EE85CA9FC59E3409D41CAF7;
// System.Collections.Generic.IReadOnlyList`1<System.String>
struct IReadOnlyList_1_t7BB300FE9C8B0D3BCB34B752D2516BD12EB5E8CF;
// System.Collections.Generic.List`1<DLLLoadCfg>
struct List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C;
// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D;
// System.Collections.Generic.List`1<System.String>
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD;
// System.Collections.Generic.HashSet`1/Slot<System.String>[]
struct SlotU5BU5D_t8B8EE191EEC1575F1F0CAC91A208DBFDF2821D01;
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// DLLLoadCfg[]
struct DLLLoadCfgU5BU5D_t2E0EF5ACD716768EF5A3BF225CE5CD18B6947A49;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.IO.DirectoryInfo[]
struct DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953;
// System.IO.FileInfo[]
struct FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6;
// System.IO.FileSystemInfo[]
struct FileSystemInfoU5BU5D_tF7D37070CBD32AA8FF200811C4906E3543061AE7;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
// System.Type[]
struct TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB;
// AOTGenericReferences
struct AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07;
// System.Reflection.Assembly
struct Assembly_t;
// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
// BasicPathHelper
struct BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E;
// System.Reflection.Binder
struct Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235;
// DLLLoadCfg
struct DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4;
// DLLLoader
struct DLLLoader_t95408ED76C29A4565E62021A397981E36B84516C;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// System.IO.DirectoryInfo
struct DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2;
// System.IO.FileInfo
struct FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C;
// System.IO.FileSystemInfo
struct FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9;
// System.IAsyncResult
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// System.Reflection.MemberFilter
struct MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553;
// System.Reflection.MethodBase
struct MethodBase_t;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t3C47F63E24BEB9FCE2DC6309E027F238DC5C5E37;
// System.String
struct String_t;
// System.Type
struct Type_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// HybridCLRCfg/<>c
struct U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D;

IL2CPP_EXTERN_C RuntimeClass* AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerable_1_t349E66EC5F09B881A8E52EE40A1AB9EC60E08E44_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_1_t73FD060C436E3C4264A734C8F8DCC01DFF6046B8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* LoadImageErrorCode_tC778A2553ADB45B8C61EFE26C20837C23894FEB3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral079998E3393B6BDC1FAFFA63A54F724488AE5306;
IL2CPP_EXTERN_C String_t* _stringLiteral0B34DFC38793BF0AF6DEA9A94F7CCB4150E999A6;
IL2CPP_EXTERN_C String_t* _stringLiteral158F3A8EBA35F33F74D6EE2F0DE6901C6C4BB25B;
IL2CPP_EXTERN_C String_t* _stringLiteral16616D61D1F596C11D66025981D6CED3F79A8444;
IL2CPP_EXTERN_C String_t* _stringLiteral2102995F349F17F639C4D239BE8B75DCEB6CDB4F;
IL2CPP_EXTERN_C String_t* _stringLiteral357434484751BA5EBE0EFE7F1BFD26D693185794;
IL2CPP_EXTERN_C String_t* _stringLiteral3FDB11A0609F905FF0F487D647904BEC589DD4B7;
IL2CPP_EXTERN_C String_t* _stringLiteral433D44993C565E2FF97977521ADC0298C066AC34;
IL2CPP_EXTERN_C String_t* _stringLiteral4C43361A0A500CC6B80443746394A4C1D19915BD;
IL2CPP_EXTERN_C String_t* _stringLiteral50AD21DAB9A9167E61A4D419343EE9409B103EDF;
IL2CPP_EXTERN_C String_t* _stringLiteral5CCAE404D857518E96A426119632D5498AFE1A6F;
IL2CPP_EXTERN_C String_t* _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1;
IL2CPP_EXTERN_C String_t* _stringLiteralAD55C6B8DCDB3688806E444D804CF76748D47714;
IL2CPP_EXTERN_C String_t* _stringLiteralB33C27CA0C0FED17B3C2F420F374320CADB9F1FE;
IL2CPP_EXTERN_C String_t* _stringLiteralC7E9DAF844B25471D821CB8F094AE5423C2EECC4;
IL2CPP_EXTERN_C String_t* _stringLiteralE55DA8BFEECF6A3A4DBF25AE911B7F07FF3F8FC6;
IL2CPP_EXTERN_C String_t* _stringLiteralEC4C5477D8BA260A27C36AFD7E8C1C289169E9CF;
IL2CPP_EXTERN_C String_t* _stringLiteralF8C9D1D7502E6E972626BDAC058F8E8D20E20E8F;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m8F948E5CA79E9FB97AA88568D104F6D2BDBCB841_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_mCB63518F6AAC7C5645F8266E4707CEAD9E36AEB5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m89A7F0C504AFC98682031BB015F324DCA4E99F67_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_Contains_mAE49939A0DE08C4864E8560F3F7FCDAC2E193853_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m076677A129A54D202CBF65448113ABBA0963E29A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_GetEnumerator_m360A8DDD167BBB6AE06E83DCE28DC33887075E0D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m7B7C2F87380B13815D89B0A327509AD6BF4160AF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec_U3C_cctorU3Eb__1_0_m20C803CBCBEBE252D4B0BE2F6CD9FEA245DF1E69_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
struct DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953;
struct FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6;
struct FileSystemInfoU5BU5D_tF7D37070CBD32AA8FF200811C4906E3543061AE7;
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t023A682EF3B222CCDF440DCCBD8F43269DA6D932 
{
};

// System.Collections.Generic.HashSet`1<System.String>
struct HashSet_1_tEFC6605F7DE53F71946C33FD371E53C3100F2178  : public RuntimeObject
{
	// System.Int32[] System.Collections.Generic.HashSet`1::_buckets
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____buckets_7;
	// System.Collections.Generic.HashSet`1/Slot<T>[] System.Collections.Generic.HashSet`1::_slots
	SlotU5BU5D_t8B8EE191EEC1575F1F0CAC91A208DBFDF2821D01* ____slots_8;
	// System.Int32 System.Collections.Generic.HashSet`1::_count
	int32_t ____count_9;
	// System.Int32 System.Collections.Generic.HashSet`1::_lastIndex
	int32_t ____lastIndex_10;
	// System.Int32 System.Collections.Generic.HashSet`1::_freeList
	int32_t ____freeList_11;
	// System.Collections.Generic.IEqualityComparer`1<T> System.Collections.Generic.HashSet`1::_comparer
	RuntimeObject* ____comparer_12;
	// System.Int32 System.Collections.Generic.HashSet`1::_version
	int32_t ____version_13;
	// System.Runtime.Serialization.SerializationInfo System.Collections.Generic.HashSet`1::_siInfo
	SerializationInfo_t3C47F63E24BEB9FCE2DC6309E027F238DC5C5E37* ____siInfo_14;
};

// System.Collections.Generic.List`1<DLLLoadCfg>
struct List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	DLLLoadCfgU5BU5D_t2E0EF5ACD716768EF5A3BF225CE5CD18B6947A49* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Collections.Generic.List`1<System.String>
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

// System.Reflection.Assembly
struct Assembly_t  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.Reflection.Assembly
struct Assembly_t_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Reflection.Assembly
struct Assembly_t_marshaled_com
{
};

// BasicPathHelper
struct BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E  : public RuntimeObject
{
	// System.String BasicPathHelper::<StreamingAssetsPath>k__BackingField
	String_t* ___U3CStreamingAssetsPathU3Ek__BackingField_1;
	// System.String BasicPathHelper::<StreamingAssetsPathForWWW>k__BackingField
	String_t* ___U3CStreamingAssetsPathForWWWU3Ek__BackingField_2;
	// System.String BasicPathHelper::<PersistentDataPath>k__BackingField
	String_t* ___U3CPersistentDataPathU3Ek__BackingField_3;
	// System.String BasicPathHelper::<PersistentDataPathForWWW>k__BackingField
	String_t* ___U3CPersistentDataPathForWWWU3Ek__BackingField_4;
};

// DLLLoadCfg
struct DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4  : public RuntimeObject
{
	// System.String DLLLoadCfg::<dllName>k__BackingField
	String_t* ___U3CdllNameU3Ek__BackingField_0;
	// System.Action`1<System.Reflection.Assembly> DLLLoadCfg::<afterLoadeAction>k__BackingField
	Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* ___U3CafterLoadeActionU3Ek__BackingField_1;
};

// HybridCLRCfg
struct HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C  : public RuntimeObject
{
};

// System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE  : public RuntimeObject
{
	// System.Object System.MarshalByRefObject::_identity
	RuntimeObject* ____identity_0;
};
// Native definition for P/Invoke marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_pinvoke
{
	Il2CppIUnknown* ____identity_0;
};
// Native definition for COM marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_com
{
	Il2CppIUnknown* ____identity_0;
};

// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// HybridCLRCfg/<>c
struct U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D  : public RuntimeObject
{
};

// System.Collections.Generic.List`1/Enumerator<DLLLoadCfg>
struct Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618 
{
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::_list
	List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* ____list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.List`1/Enumerator::_current
	DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* ____current_3;
};

// System.Collections.Generic.List`1/Enumerator<System.Object>
struct Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A 
{
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::_list
	List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* ____list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.List`1/Enumerator::_current
	RuntimeObject* ____current_3;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// System.Byte
struct Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3 
{
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// System.Reflection.MethodBase
struct MethodBase_t  : public MemberInfo_t
{
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// Interop/Kernel32/FILE_TIME
struct FILE_TIME_tBD950B410C18B85474477EEA8F3651A2BD367965 
{
	// System.UInt32 Interop/Kernel32/FILE_TIME::dwLowDateTime
	uint32_t ___dwLowDateTime_0;
	// System.UInt32 Interop/Kernel32/FILE_TIME::dwHighDateTime
	uint32_t ___dwHighDateTime_1;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// System.Reflection.MethodInfo
struct MethodInfo_t  : public MethodBase_t
{
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// System.RuntimeTypeHandle
struct RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B 
{
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;
};

// Interop/Kernel32/WIN32_FILE_ATTRIBUTE_DATA
struct WIN32_FILE_ATTRIBUTE_DATA_tD093F8658579DA72CCD2E158A681DDE37834F73B 
{
	// System.Int32 Interop/Kernel32/WIN32_FILE_ATTRIBUTE_DATA::dwFileAttributes
	int32_t ___dwFileAttributes_0;
	// Interop/Kernel32/FILE_TIME Interop/Kernel32/WIN32_FILE_ATTRIBUTE_DATA::ftCreationTime
	FILE_TIME_tBD950B410C18B85474477EEA8F3651A2BD367965 ___ftCreationTime_1;
	// Interop/Kernel32/FILE_TIME Interop/Kernel32/WIN32_FILE_ATTRIBUTE_DATA::ftLastAccessTime
	FILE_TIME_tBD950B410C18B85474477EEA8F3651A2BD367965 ___ftLastAccessTime_2;
	// Interop/Kernel32/FILE_TIME Interop/Kernel32/WIN32_FILE_ATTRIBUTE_DATA::ftLastWriteTime
	FILE_TIME_tBD950B410C18B85474477EEA8F3651A2BD367965 ___ftLastWriteTime_3;
	// System.UInt32 Interop/Kernel32/WIN32_FILE_ATTRIBUTE_DATA::nFileSizeHigh
	uint32_t ___nFileSizeHigh_4;
	// System.UInt32 Interop/Kernel32/WIN32_FILE_ATTRIBUTE_DATA::nFileSizeLow
	uint32_t ___nFileSizeLow_5;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.IO.FileSystemInfo
struct FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// Interop/Kernel32/WIN32_FILE_ATTRIBUTE_DATA System.IO.FileSystemInfo::_data
	WIN32_FILE_ATTRIBUTE_DATA_tD093F8658579DA72CCD2E158A681DDE37834F73B ____data_1;
	// System.Int32 System.IO.FileSystemInfo::_dataInitialized
	int32_t ____dataInitialized_2;
	// System.String System.IO.FileSystemInfo::FullPath
	String_t* ___FullPath_3;
	// System.String System.IO.FileSystemInfo::OriginalPath
	String_t* ___OriginalPath_4;
	// System.String System.IO.FileSystemInfo::_name
	String_t* ____name_5;
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// System.Type
struct Type_t  : public MemberInfo_t
{
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_t332A452B8B6179E4469B69525D0FE82A88030F7B ____impl_8;
};

// System.Action`1<System.Reflection.Assembly>
struct Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42  : public MulticastDelegate_t
{
};

// System.Action`1<System.IO.FileInfo>
struct Action_1_t8FDFDD761A78E63D829702D183AAE14618CE0DAA  : public MulticastDelegate_t
{
};

// System.Action`1<System.Object>
struct Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87  : public MulticastDelegate_t
{
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// System.IO.DirectoryInfo
struct DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2  : public FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9
{
};

// System.IO.FileInfo
struct FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C  : public FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9
{
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// AOTGenericReferences
struct AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// DLLLoader
struct DLLLoader_t95408ED76C29A4565E62021A397981E36B84516C  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// <Module>

// <Module>

// System.Collections.Generic.HashSet`1<System.String>

// System.Collections.Generic.HashSet`1<System.String>

// System.Collections.Generic.List`1<DLLLoadCfg>
struct List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	DLLLoadCfgU5BU5D_t2E0EF5ACD716768EF5A3BF225CE5CD18B6947A49* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<DLLLoadCfg>

// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Object>

// System.Collections.Generic.List`1<System.String>
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.String>

// System.Reflection.Assembly

// System.Reflection.Assembly

// BasicPathHelper
struct BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_StaticFields
{
	// BasicPathHelper BasicPathHelper::m_instance
	BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* ___m_instance_0;
};

// BasicPathHelper

// DLLLoadCfg

// DLLLoadCfg

// HybridCLRCfg
struct HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_StaticFields
{
	// System.Collections.Generic.List`1<DLLLoadCfg> HybridCLRCfg::hotUpdateDLLNames
	List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* ___hotUpdateDLLNames_0;
};

// HybridCLRCfg

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// HybridCLRCfg/<>c
struct U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_StaticFields
{
	// HybridCLRCfg/<>c HybridCLRCfg/<>c::<>9
	U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D* ___U3CU3E9_0;
};

// HybridCLRCfg/<>c

// System.Collections.Generic.List`1/Enumerator<DLLLoadCfg>

// System.Collections.Generic.List`1/Enumerator<DLLLoadCfg>

// System.Collections.Generic.List`1/Enumerator<System.Object>

// System.Collections.Generic.List`1/Enumerator<System.Object>

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// System.Byte

// System.Byte

// System.Int32

// System.Int32

// System.IntPtr
struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.IntPtr

// System.Reflection.MethodBase

// System.Reflection.MethodBase

// System.Void

// System.Void

// System.Exception
struct Exception_t_StaticFields
{
	// System.Object System.Exception::s_EDILock
	RuntimeObject* ___s_EDILock_0;
};

// System.Exception

// System.Reflection.MethodInfo

// System.Reflection.MethodInfo

// System.IO.FileSystemInfo

// System.IO.FileSystemInfo

// System.Type
struct Type_t_StaticFields
{
	// System.Reflection.Binder modreq(System.Runtime.CompilerServices.IsVolatile) System.Type::s_defaultBinder
	Binder_t91BFCE95A7057FADF4D8A1A342AFE52872246235* ___s_defaultBinder_0;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_1;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t97234E1129B564EB38B8D85CAC2AD8B5B9522FFB* ___EmptyTypes_2;
	// System.Object System.Type::Missing
	RuntimeObject* ___Missing_3;
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterAttribute_4;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterName_5;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_tF644F1AE82F611B677CE1964D5A3277DDA21D553* ___FilterNameIgnoreCase_6;
};

// System.Type

// System.Action`1<System.Reflection.Assembly>

// System.Action`1<System.Reflection.Assembly>

// System.Action`1<System.IO.FileInfo>

// System.Action`1<System.IO.FileInfo>

// System.Action`1<System.Object>

// System.Action`1<System.Object>

// System.IO.DirectoryInfo

// System.IO.DirectoryInfo

// System.IO.FileInfo

// System.IO.FileInfo

// UnityEngine.MonoBehaviour

// UnityEngine.MonoBehaviour

// AOTGenericReferences
struct AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_StaticFields
{
	// System.Collections.Generic.IReadOnlyList`1<System.String> AOTGenericReferences::PatchedAOTAssemblyList
	RuntimeObject* ___PatchedAOTAssemblyList_4;
};

// AOTGenericReferences

// DLLLoader

// DLLLoader
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.IO.FileSystemInfo[]
struct FileSystemInfoU5BU5D_tF7D37070CBD32AA8FF200811C4906E3543061AE7  : public RuntimeArray
{
	ALIGN_FIELD (8) FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* m_Items[1];

	inline FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.IO.DirectoryInfo[]
struct DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953  : public RuntimeArray
{
	ALIGN_FIELD (8) DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* m_Items[1];

	inline DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.IO.FileInfo[]
struct FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6  : public RuntimeArray
{
	ALIGN_FIELD (8) FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* m_Items[1];

	inline FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031  : public RuntimeArray
{
	ALIGN_FIELD (8) uint8_t m_Items[1];

	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// System.Boolean System.Collections.Generic.HashSet`1<System.Object>::Contains(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool HashSet_1_Contains_m9BACE52BFA0BD83C601529D3629118453E459BBB_gshared (HashSet_1_t2F33BEB06EEA4A872E2FAF464382422AA39AE885* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
// System.Void System.Action`1<System.Object>::Invoke(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_mF2422B2DD29F74CE66F791C3F68E288EC7C3DB9E_gshared_inline (Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* __this, RuntimeObject* ___0_obj, const RuntimeMethod* method) ;
// System.Collections.Generic.List`1/Enumerator<T> System.Collections.Generic.List`1<System.Object>::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A List_1_GetEnumerator_mD8294A7FA2BEB1929487127D476F8EC1CDC23BFC_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1/Enumerator<System.Object>::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mD9DC3E3C3697830A4823047AB29A77DBBB5ED419_gshared (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1/Enumerator<System.Object>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mE921CC8F29FBBDE7CC3209A0ED0D921D58D00BCB_gshared (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) ;
// System.Void System.Action`1<System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1__ctor_m2E1DFA67718FC1A0B6E5DFEB78831FFE9C059EB4_gshared (Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;

// System.Void BasicPathHelper::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper__ctor_mEA961036DBAA2C4C0A39BC4A3602BE0F520D81E5 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) ;
// System.Void BasicPathHelper::Initialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper_Initialize_m1C654F522191AFF79F201BD26E75EAE2FA834B3D (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) ;
// System.String UnityEngine.Application::get_dataPath()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Application_get_dataPath_m4C8412CBEE4EAAAB6711CC9BEFFA73CEE5BDBEF7 (const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8 (String_t* ___0_format, RuntimeObject* ___1_arg0, const RuntimeMethod* method) ;
// System.Void BasicPathHelper::set_StreamingAssetsPathForWWW(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void BasicPathHelper_set_StreamingAssetsPathForWWW_m1F8666EFCE6E652B75EDD04E2AF96B4C780D4176_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// System.Void BasicPathHelper::set_StreamingAssetsPath(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void BasicPathHelper_set_StreamingAssetsPath_mCC68EBF42A8BD1F4F2CE6936C1759E42873D402B_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// System.Void BasicPathHelper::set_PersistentDataPathForWWW(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void BasicPathHelper_set_PersistentDataPathForWWW_m515D13F9038D1B4FDF4D1CC202FE13A495525409_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// System.Void BasicPathHelper::set_PersistentDataPath(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void BasicPathHelper_set_PersistentDataPath_mFF1623055A00737DF12F202805448BD53AC7AAA8_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// System.String BasicPathHelper::get_PersistentDataPath()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* BasicPathHelper_get_PersistentDataPath_m635AAA65829247BC830D094C259535A738A76D38_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m9E3155FB84015C823606188F53B47CB44C444991 (String_t* ___0_str0, String_t* ___1_str1, const RuntimeMethod* method) ;
// System.String BasicPathHelper::get_StreamingAssetsPathForWWW()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* BasicPathHelper_get_StreamingAssetsPathForWWW_m4C98CA0009E40636A5C78F43E2141D7922E5D764_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) ;
// System.Void System.IO.DirectoryInfo::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DirectoryInfo__ctor_m36BC476C58B55083046C0A738157D84E2323E0E9 (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* __this, String_t* ___0_path, const RuntimeMethod* method) ;
// System.IO.FileSystemInfo[] System.IO.DirectoryInfo::GetFileSystemInfos()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR FileSystemInfoU5BU5D_tF7D37070CBD32AA8FF200811C4906E3543061AE7* DirectoryInfo_GetFileSystemInfos_m35F27B3A479619281F13C053A9164ACC6C135BED (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* __this, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.HashSet`1<System.String>::Contains(T)
inline bool HashSet_1_Contains_mAE49939A0DE08C4864E8560F3F7FCDAC2E193853 (HashSet_1_tEFC6605F7DE53F71946C33FD371E53C3100F2178* __this, String_t* ___0_item, const RuntimeMethod* method)
{
	return ((  bool (*) (HashSet_1_tEFC6605F7DE53F71946C33FD371E53C3100F2178*, String_t*, const RuntimeMethod*))HashSet_1_Contains_m9BACE52BFA0BD83C601529D3629118453E459BBB_gshared)(__this, ___0_item, method);
}
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1 (String_t* ___0_a, String_t* ___1_b, const RuntimeMethod* method) ;
// System.Void System.IO.DirectoryInfo::Delete(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DirectoryInfo_Delete_mF79B7BBC51DC847268E2EB216FBBF5412C9E870C (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* __this, bool ___0_recursive, const RuntimeMethod* method) ;
// System.Void System.IO.File::Delete(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void File_Delete_mE29829DA504F3E1B8BCB78F21E2862C9ED7EC386 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2 (RuntimeObject* ___0_message, const RuntimeMethod* method) ;
// System.IO.DirectoryInfo[] System.IO.DirectoryInfo::GetDirectories()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* DirectoryInfo_GetDirectories_m2EC8498544C3A85EF92273330858E03B284C6901 (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* __this, const RuntimeMethod* method) ;
// System.Boolean System.IO.Directory::Exists(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Directory_Exists_m3D125E9E88C291CF11113444F961A64DD83AE1C7 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.IO.DirectoryInfo System.IO.Directory::CreateDirectory(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* Directory_CreateDirectory_m16EC5CE8561A997C6635E06DC24C77590F29D94F (String_t* ___0_path, const RuntimeMethod* method) ;
// System.IO.FileInfo[] System.IO.DirectoryInfo::GetFiles()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6* DirectoryInfo_GetFiles_m998040748717954CDDCE273F61EEC0625069543F (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* __this, const RuntimeMethod* method) ;
// System.String System.IO.Path::Combine(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_Combine_m1ADAC05CDA2D1D61B172DF65A81E86592696BEAE (String_t* ___0_path1, String_t* ___1_path2, const RuntimeMethod* method) ;
// System.IO.FileInfo System.IO.FileInfo::CopyTo(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* FileInfo_CopyTo_m4AC9EAD035D0106081B5DA5FBE4E02BDA911DD49 (FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* __this, String_t* ___0_destFileName, bool ___1_overwrite, const RuntimeMethod* method) ;
// System.Void System.Action`1<System.IO.FileInfo>::Invoke(T)
inline void Action_1_Invoke_mE9AF50D78F1965638B4FD05542F3613DC0F8C670_inline (Action_1_t8FDFDD761A78E63D829702D183AAE14618CE0DAA* __this, FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* ___0_obj, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t8FDFDD761A78E63D829702D183AAE14618CE0DAA*, FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C*, const RuntimeMethod*))Action_1_Invoke_mF2422B2DD29F74CE66F791C3F68E288EC7C3DB9E_gshared_inline)(__this, ___0_obj, method);
}
// System.Boolean BasicPathHelper::DirectoryCopy(System.String,System.String,System.Boolean,System.Action`1<System.IO.FileInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool BasicPathHelper_DirectoryCopy_mF560AD07CF1521ABCAA853D0AA9A3D01F72B19A4 (String_t* ___0_sourceDirName, String_t* ___1_destDirName, bool ___2_copySubDirs, Action_1_t8FDFDD761A78E63D829702D183AAE14618CE0DAA* ___3_afterCopyFileAction, const RuntimeMethod* method) ;
// System.String System.IO.Path::GetDirectoryName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_GetDirectoryName_m428BADBE493A3927B51A13DEF658929B430516F6 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.Boolean System.IO.File::Exists(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool File_Exists_m95E329ABBE3EAD6750FE1989BBA6884457136D4A (String_t* ___0_path, const RuntimeMethod* method) ;
// System.Void System.IO.File::Copy(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void File_Copy_mC698F2F0FF8BBF3339527CD00E57A6D5B26DE4AA (String_t* ___0_sourceFileName, String_t* ___1_destFileName, const RuntimeMethod* method) ;
// System.Boolean BasicPathHelper::MoveFile(System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool BasicPathHelper_MoveFile_m7AF9134D8F3711DBA515F5A817A70C41E921DA70 (String_t* ___0_srcPath, String_t* ___1_tarPath, bool ___2_includeMeta, const RuntimeMethod* method) ;
// System.Boolean BasicPathHelper::MoveDir(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool BasicPathHelper_MoveDir_m741D3B7C7FA4BE5A8480D8EF1AF7D0F2424A87CA (String_t* ___0_srcPath, String_t* ___1_tarPath, const RuntimeMethod* method) ;
// System.Void BasicPathHelper::TryMoveMeta(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper_TryMoveMeta_mA9292EF0D203ECFF408E66A0171AE6694495C7A4 (String_t* ___0_srcPath, String_t* ___1_tarPath, const RuntimeMethod* method) ;
// System.Void System.IO.Directory::Delete(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Directory_Delete_mB5C70379DEFE9B8AA95F67BAE04233E60CEF09F4 (String_t* ___0_path, bool ___1_recursive, const RuntimeMethod* method) ;
// System.Void System.IO.File::Move(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void File_Move_mBC9450111E0144A55D893A720F19E612D658AC37 (String_t* ___0_sourceFileName, String_t* ___1_destFileName, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void DLLLoader::LoadMetadataForAOTAssemblies()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DLLLoader_LoadMetadataForAOTAssemblies_m0CF84F954792E33EC829038D54F91043F7D0786D (DLLLoader_t95408ED76C29A4565E62021A397981E36B84516C* __this, const RuntimeMethod* method) ;
// System.Collections.Generic.List`1/Enumerator<T> System.Collections.Generic.List`1<DLLLoadCfg>::GetEnumerator()
inline Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618 List_1_GetEnumerator_m360A8DDD167BBB6AE06E83DCE28DC33887075E0D (List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618 (*) (List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C*, const RuntimeMethod*))List_1_GetEnumerator_mD8294A7FA2BEB1929487127D476F8EC1CDC23BFC_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1/Enumerator<DLLLoadCfg>::Dispose()
inline void Enumerator_Dispose_m8F948E5CA79E9FB97AA88568D104F6D2BDBCB841 (Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618* __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618*, const RuntimeMethod*))Enumerator_Dispose_mD9DC3E3C3697830A4823047AB29A77DBBB5ED419_gshared)(__this, method);
}
// T System.Collections.Generic.List`1/Enumerator<DLLLoadCfg>::get_Current()
inline DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* Enumerator_get_Current_m89A7F0C504AFC98682031BB015F324DCA4E99F67_inline (Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618* __this, const RuntimeMethod* method)
{
	return ((  DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* (*) (Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618*, const RuntimeMethod*))Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline)(__this, method);
}
// BasicPathHelper BasicPathHelper::get_Instance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* BasicPathHelper_get_Instance_m97B42DAE9B68013832DF2B6B51BCC68601D7D87D (const RuntimeMethod* method) ;
// System.String DLLLoadCfg::get_dllName()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DLLLoadCfg_get_dllName_mD6527A4807214DFA6C2D8B3433D6F5E8970C29AF_inline (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m093934F71A9B351911EE46311674ED463B180006 (String_t* ___0_str0, String_t* ___1_str1, String_t* ___2_str2, String_t* ___3_str3, const RuntimeMethod* method) ;
// System.Byte[] System.IO.File::ReadAllBytes(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* File_ReadAllBytes_m704CBBA3F130C94F5A3E0BE2A93D9E9D79DC3E24 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.Reflection.Assembly System.Reflection.Assembly::Load(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Assembly_t* Assembly_Load_mD9E9CED2EFF8BBE97ACDE83FB8ED492D1E42E975 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___0_rawAssembly, const RuntimeMethod* method) ;
// System.Action`1<System.Reflection.Assembly> DLLLoadCfg::get_afterLoadeAction()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* DLLLoadCfg_get_afterLoadeAction_mB4A28D8DB7D6B13E7D38FCB58EF6FDD158618694_inline (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, const RuntimeMethod* method) ;
// System.Void System.Action`1<System.Reflection.Assembly>::Invoke(T)
inline void Action_1_Invoke_m03986762CAC07D19A51669597128749F7F427C70_inline (Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* __this, Assembly_t* ___0_obj, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42*, Assembly_t*, const RuntimeMethod*))Action_1_Invoke_mF2422B2DD29F74CE66F791C3F68E288EC7C3DB9E_gshared_inline)(__this, ___0_obj, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<DLLLoadCfg>::MoveNext()
inline bool Enumerator_MoveNext_mCB63518F6AAC7C5645F8266E4707CEAD9E36AEB5 (Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618*, const RuntimeMethod*))Enumerator_MoveNext_mE921CC8F29FBBDE7CC3209A0ED0D921D58D00BCB_gshared)(__this, method);
}
// HybridCLR.LoadImageErrorCode HybridCLR.RuntimeApi::LoadMetadataForAOTAssembly(System.Byte[],HybridCLR.HomologousImageMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RuntimeApi_LoadMetadataForAOTAssembly_mE1E398132DBF86D7DE042300E1EE6AC37B7649D8 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___0_dllBytes, int32_t ___1_mode, const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987 (String_t* ___0_format, RuntimeObject* ___1_arg0, RuntimeObject* ___2_arg1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB (RuntimeObject* ___0_message, const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<DLLLoadCfg>::.ctor()
inline void List_1__ctor_m7B7C2F87380B13815D89B0A327509AD6BF4160AF (List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
// System.Void DLLLoadCfg::.ctor(System.String,System.Action`1<System.Reflection.Assembly>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DLLLoadCfg__ctor_mCA33D02A1FC6F36347FB9397AB4C237F02248DE5 (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, String_t* ___0_name, Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* ___1_cb, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<DLLLoadCfg>::Add(T)
inline void List_1_Add_m076677A129A54D202CBF65448113ABBA0963E29A_inline (List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* __this, DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C*, DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
// System.Void System.Action`1<System.Reflection.Assembly>::.ctor(System.Object,System.IntPtr)
inline void Action_1__ctor_mA5CC188AF946F9AB740FB0C5F0FF3B6EB3627541 (Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42*, RuntimeObject*, intptr_t, const RuntimeMethod*))Action_1__ctor_m2E1DFA67718FC1A0B6E5DFEB78831FFE9C059EB4_gshared)(__this, ___0_object, ___1_method, method);
}
// System.Void HybridCLRCfg/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m786E08B98DE18711131140DC71A4CD2C37B38C02 (U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D* __this, const RuntimeMethod* method) ;
// System.Boolean System.Reflection.Assembly::op_Equality(System.Reflection.Assembly,System.Reflection.Assembly)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Assembly_op_Equality_m1E2666F9D0537F02AB32F14B4458C98C4851CEAB (Assembly_t* ___0_left, Assembly_t* ___1_right, const RuntimeMethod* method) ;
// System.Reflection.MethodInfo System.Type::GetMethod(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MethodInfo_t* Type_GetMethod_m66AD062187F19497DBCA900823B0C268322DC231 (Type_t* __this, String_t* ___0_name, const RuntimeMethod* method) ;
// System.Object System.Reflection.MethodBase::Invoke(System.Object,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MethodBase_Invoke_mEEF3218648F111A8C338001A7804091A0747C826 (MethodBase_t* __this, RuntimeObject* ___0_obj, ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___1_parameters, const RuntimeMethod* method) ;
// System.Void DLLLoadCfg::set_dllName(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DLLLoadCfg_set_dllName_m148E67557E56757C2C0EB820F8A2A9051DB91C27_inline (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// System.Void DLLLoadCfg::set_afterLoadeAction(System.Action`1<System.Reflection.Assembly>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DLLLoadCfg_set_afterLoadeAction_m5CB3AAA18A5E21B0B6EBBE781CD34E220989E55D_inline (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* ___0_value, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.String>::.ctor()
inline void List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.String>::Add(T)
inline void List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, String_t* ___0_item, const RuntimeMethod* method)
{
	((  void (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, String_t*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___0_item, method);
}
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// BasicPathHelper BasicPathHelper::get_Instance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* BasicPathHelper_get_Instance_m97B42DAE9B68013832DF2B6B51BCC68601D7D87D (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (m_instance == null)
		BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* L_0 = ((BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_StaticFields*)il2cpp_codegen_static_fields_for(BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_il2cpp_TypeInfo_var))->___m_instance_0;
		if (L_0)
		{
			goto IL_001b;
		}
	}
	{
		// m_instance = new BasicPathHelper();
		BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* L_1 = (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E*)il2cpp_codegen_object_new(BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		BasicPathHelper__ctor_mEA961036DBAA2C4C0A39BC4A3602BE0F520D81E5(L_1, NULL);
		((BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_StaticFields*)il2cpp_codegen_static_fields_for(BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_il2cpp_TypeInfo_var))->___m_instance_0 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&((BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_StaticFields*)il2cpp_codegen_static_fields_for(BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_il2cpp_TypeInfo_var))->___m_instance_0), (void*)L_1);
		// m_instance.Initialize();
		BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* L_2 = ((BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_StaticFields*)il2cpp_codegen_static_fields_for(BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_il2cpp_TypeInfo_var))->___m_instance_0;
		NullCheck(L_2);
		BasicPathHelper_Initialize_m1C654F522191AFF79F201BD26E75EAE2FA834B3D(L_2, NULL);
	}

IL_001b:
	{
		// return m_instance;
		BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* L_3 = ((BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_StaticFields*)il2cpp_codegen_static_fields_for(BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E_il2cpp_TypeInfo_var))->___m_instance_0;
		return L_3;
	}
}
// System.Void BasicPathHelper::set_StreamingAssetsPath(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper_set_StreamingAssetsPath_mCC68EBF42A8BD1F4F2CE6936C1759E42873D402B (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string StreamingAssetsPath { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CStreamingAssetsPathU3Ek__BackingField_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CStreamingAssetsPathU3Ek__BackingField_1), (void*)L_0);
		return;
	}
}
// System.String BasicPathHelper::get_StreamingAssetsPath()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BasicPathHelper_get_StreamingAssetsPath_mE8C85B42EF5D5053FE645FB2D4E10FD49E3CB487 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) 
{
	{
		// public string StreamingAssetsPath { private set; get; }
		String_t* L_0 = __this->___U3CStreamingAssetsPathU3Ek__BackingField_1;
		return L_0;
	}
}
// System.Void BasicPathHelper::set_StreamingAssetsPathForWWW(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper_set_StreamingAssetsPathForWWW_m1F8666EFCE6E652B75EDD04E2AF96B4C780D4176 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string StreamingAssetsPathForWWW { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CStreamingAssetsPathForWWWU3Ek__BackingField_2 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CStreamingAssetsPathForWWWU3Ek__BackingField_2), (void*)L_0);
		return;
	}
}
// System.String BasicPathHelper::get_StreamingAssetsPathForWWW()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BasicPathHelper_get_StreamingAssetsPathForWWW_m4C98CA0009E40636A5C78F43E2141D7922E5D764 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) 
{
	{
		// public string StreamingAssetsPathForWWW { private set; get; }
		String_t* L_0 = __this->___U3CStreamingAssetsPathForWWWU3Ek__BackingField_2;
		return L_0;
	}
}
// System.Void BasicPathHelper::set_PersistentDataPath(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper_set_PersistentDataPath_mFF1623055A00737DF12F202805448BD53AC7AAA8 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string PersistentDataPath { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CPersistentDataPathU3Ek__BackingField_3 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CPersistentDataPathU3Ek__BackingField_3), (void*)L_0);
		return;
	}
}
// System.String BasicPathHelper::get_PersistentDataPath()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BasicPathHelper_get_PersistentDataPath_m635AAA65829247BC830D094C259535A738A76D38 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) 
{
	{
		// public string PersistentDataPath { private set; get; }
		String_t* L_0 = __this->___U3CPersistentDataPathU3Ek__BackingField_3;
		return L_0;
	}
}
// System.Void BasicPathHelper::set_PersistentDataPathForWWW(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper_set_PersistentDataPathForWWW_m515D13F9038D1B4FDF4D1CC202FE13A495525409 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string PersistentDataPathForWWW { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CPersistentDataPathForWWWU3Ek__BackingField_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CPersistentDataPathForWWWU3Ek__BackingField_4), (void*)L_0);
		return;
	}
}
// System.String BasicPathHelper::get_PersistentDataPathForWWW()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BasicPathHelper_get_PersistentDataPathForWWW_m6524BDE05B9D833340436FB6247322209A3157F4 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) 
{
	{
		// public string PersistentDataPathForWWW { private set; get; }
		String_t* L_0 = __this->___U3CPersistentDataPathForWWWU3Ek__BackingField_4;
		return L_0;
	}
}
// System.Void BasicPathHelper::Initialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper_Initialize_m1C654F522191AFF79F201BD26E75EAE2FA834B3D (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3FDB11A0609F905FF0F487D647904BEC589DD4B7);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralAD55C6B8DCDB3688806E444D804CF76748D47714);
		s_Il2CppMethodInitialized = true;
	}
	{
		// StreamingAssetsPathForWWW = string.Format("file:///{0}/StreamingAssets/", Application.dataPath);
		String_t* L_0;
		L_0 = Application_get_dataPath_m4C8412CBEE4EAAAB6711CC9BEFFA73CEE5BDBEF7(NULL);
		String_t* L_1;
		L_1 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteral3FDB11A0609F905FF0F487D647904BEC589DD4B7, L_0, NULL);
		BasicPathHelper_set_StreamingAssetsPathForWWW_m1F8666EFCE6E652B75EDD04E2AF96B4C780D4176_inline(__this, L_1, NULL);
		// StreamingAssetsPath = string.Format("{0}/StreamingAssets/", Application.dataPath);
		String_t* L_2;
		L_2 = Application_get_dataPath_m4C8412CBEE4EAAAB6711CC9BEFFA73CEE5BDBEF7(NULL);
		String_t* L_3;
		L_3 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteralAD55C6B8DCDB3688806E444D804CF76748D47714, L_2, NULL);
		BasicPathHelper_set_StreamingAssetsPath_mCC68EBF42A8BD1F4F2CE6936C1759E42873D402B_inline(__this, L_3, NULL);
		// PersistentDataPathForWWW = string.Format("file:///{0}/StreamingAssets/", Application.dataPath);
		String_t* L_4;
		L_4 = Application_get_dataPath_m4C8412CBEE4EAAAB6711CC9BEFFA73CEE5BDBEF7(NULL);
		String_t* L_5;
		L_5 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteral3FDB11A0609F905FF0F487D647904BEC589DD4B7, L_4, NULL);
		BasicPathHelper_set_PersistentDataPathForWWW_m515D13F9038D1B4FDF4D1CC202FE13A495525409_inline(__this, L_5, NULL);
		// PersistentDataPath = string.Format("{0}/StreamingAssets/", Application.dataPath);
		String_t* L_6;
		L_6 = Application_get_dataPath_m4C8412CBEE4EAAAB6711CC9BEFFA73CEE5BDBEF7(NULL);
		String_t* L_7;
		L_7 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteralAD55C6B8DCDB3688806E444D804CF76748D47714, L_6, NULL);
		BasicPathHelper_set_PersistentDataPath_mFF1623055A00737DF12F202805448BD53AC7AAA8_inline(__this, L_7, NULL);
		// }
		return;
	}
}
// System.String BasicPathHelper::GetPersistentDataPath(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BasicPathHelper_GetPersistentDataPath_mF4C7F528E1A2B6A96803281260B8BB40EACA4304 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_path, const RuntimeMethod* method) 
{
	{
		// return string.Concat(PersistentDataPath, path);
		String_t* L_0;
		L_0 = BasicPathHelper_get_PersistentDataPath_m635AAA65829247BC830D094C259535A738A76D38_inline(__this, NULL);
		String_t* L_1 = ___0_path;
		String_t* L_2;
		L_2 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_0, L_1, NULL);
		return L_2;
	}
}
// System.String BasicPathHelper::GetStreamingPathForWWW(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BasicPathHelper_GetStreamingPathForWWW_m7DF7C0A253DAF202F252D0F136133DAE69BC3C31 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_path, const RuntimeMethod* method) 
{
	{
		// return string.Concat(StreamingAssetsPathForWWW, path);
		String_t* L_0;
		L_0 = BasicPathHelper_get_StreamingAssetsPathForWWW_m4C98CA0009E40636A5C78F43E2141D7922E5D764_inline(__this, NULL);
		String_t* L_1 = ___0_path;
		String_t* L_2;
		L_2 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_0, L_1, NULL);
		return L_2;
	}
}
// System.Boolean BasicPathHelper::DeleteDir(System.String,System.Boolean,System.Collections.Generic.HashSet`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool BasicPathHelper_DeleteDir_m9F122632A9224F2A84A8AF421566EB1C71058AB8 (String_t* ___0_srcPath, bool ___1_includeSrcPath, HashSet_1_tEFC6605F7DE53F71946C33FD371E53C3100F2178* ___2_excludePath, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_Contains_mAE49939A0DE08C4864E8560F3F7FCDAC2E193853_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* V_0 = NULL;
	bool V_1 = false;
	FileSystemInfoU5BU5D_tF7D37070CBD32AA8FF200811C4906E3543061AE7* V_2 = NULL;
	int32_t V_3 = 0;
	FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* V_4 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		{
			// DirectoryInfo dir = new DirectoryInfo(srcPath);
			String_t* L_0 = ___0_srcPath;
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_1 = (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2*)il2cpp_codegen_object_new(DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var);
			NullCheck(L_1);
			DirectoryInfo__ctor_m36BC476C58B55083046C0A738157D84E2323E0E9(L_1, L_0, NULL);
			V_0 = L_1;
			// if (!dir.Exists)
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_2 = V_0;
			NullCheck(L_2);
			bool L_3;
			L_3 = VirtualFuncInvoker0< bool >::Invoke(10 /* System.Boolean System.IO.FileSystemInfo::get_Exists() */, L_2);
			if (L_3)
			{
				goto IL_0013_1;
			}
		}
		{
			// return true;
			V_1 = (bool)1;
			goto IL_0087;
		}

IL_0013_1:
		{
			// FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //?????????????????????
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_4 = V_0;
			NullCheck(L_4);
			FileSystemInfoU5BU5D_tF7D37070CBD32AA8FF200811C4906E3543061AE7* L_5;
			L_5 = DirectoryInfo_GetFileSystemInfos_m35F27B3A479619281F13C053A9164ACC6C135BED(L_4, NULL);
			// foreach (FileSystemInfo i in fileinfo)
			V_2 = L_5;
			V_3 = 0;
			goto IL_0074_1;
		}

IL_001e_1:
		{
			// foreach (FileSystemInfo i in fileinfo)
			FileSystemInfoU5BU5D_tF7D37070CBD32AA8FF200811C4906E3543061AE7* L_6 = V_2;
			int32_t L_7 = V_3;
			NullCheck(L_6);
			int32_t L_8 = L_7;
			FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
			V_4 = L_9;
			// if (excludePath != null && excludePath.Contains(i.Name))
			HashSet_1_tEFC6605F7DE53F71946C33FD371E53C3100F2178* L_10 = ___2_excludePath;
			if (!L_10)
			{
				goto IL_0035_1;
			}
		}
		{
			HashSet_1_tEFC6605F7DE53F71946C33FD371E53C3100F2178* L_11 = ___2_excludePath;
			FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_12 = V_4;
			NullCheck(L_12);
			String_t* L_13;
			L_13 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.IO.FileSystemInfo::get_Name() */, L_12);
			NullCheck(L_11);
			bool L_14;
			L_14 = HashSet_1_Contains_mAE49939A0DE08C4864E8560F3F7FCDAC2E193853(L_11, L_13, HashSet_1_Contains_mAE49939A0DE08C4864E8560F3F7FCDAC2E193853_RuntimeMethod_var);
			if (L_14)
			{
				goto IL_0070_1;
			}
		}

IL_0035_1:
		{
			// if (i is DirectoryInfo)            //???????????
			FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_15 = V_4;
			if (!((DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2*)IsInstSealed((RuntimeObject*)L_15, DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var)))
			{
				goto IL_0064_1;
			}
		}
		{
			// if (!includeSrcPath && i.FullName == srcPath)
			bool L_16 = ___1_includeSrcPath;
			if (L_16)
			{
				goto IL_0050_1;
			}
		}
		{
			FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_17 = V_4;
			NullCheck(L_17);
			String_t* L_18;
			L_18 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_17);
			String_t* L_19 = ___0_srcPath;
			bool L_20;
			L_20 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_18, L_19, NULL);
			if (L_20)
			{
				goto IL_0070_1;
			}
		}

IL_0050_1:
		{
			// var subdir = new DirectoryInfo(i.FullName);
			FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_21 = V_4;
			NullCheck(L_21);
			String_t* L_22;
			L_22 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_21);
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_23 = (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2*)il2cpp_codegen_object_new(DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var);
			NullCheck(L_23);
			DirectoryInfo__ctor_m36BC476C58B55083046C0A738157D84E2323E0E9(L_23, L_22, NULL);
			// subdir.Delete(true);          //????????????
			NullCheck(L_23);
			DirectoryInfo_Delete_mF79B7BBC51DC847268E2EB216FBBF5412C9E870C(L_23, (bool)1, NULL);
			goto IL_0070_1;
		}

IL_0064_1:
		{
			// File.Delete(i.FullName);      //?????????
			FileSystemInfo_tE3063B9229F46B05A5F6D018C8C4CA510104E8E9* L_24 = V_4;
			NullCheck(L_24);
			String_t* L_25;
			L_25 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_24);
			File_Delete_mE29829DA504F3E1B8BCB78F21E2862C9ED7EC386(L_25, NULL);
		}

IL_0070_1:
		{
			int32_t L_26 = V_3;
			V_3 = ((int32_t)il2cpp_codegen_add(L_26, 1));
		}

IL_0074_1:
		{
			// foreach (FileSystemInfo i in fileinfo)
			int32_t L_27 = V_3;
			FileSystemInfoU5BU5D_tF7D37070CBD32AA8FF200811C4906E3543061AE7* L_28 = V_2;
			NullCheck(L_28);
			if ((((int32_t)L_27) < ((int32_t)((int32_t)(((RuntimeArray*)L_28)->max_length)))))
			{
				goto IL_001e_1;
			}
		}
		{
			// }
			goto IL_0085;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_007c;
		}
		throw e;
	}

CATCH_007c:
	{// begin catch(System.Exception)
		// Debug.LogError(e);
		il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var)));
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*)), NULL);
		// return false;
		V_1 = (bool)0;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0087;
	}// end catch (depth: 1)

IL_0085:
	{
		// return true;
		return (bool)1;
	}

IL_0087:
	{
		// }
		bool L_29 = V_1;
		return L_29;
	}
}
// System.Boolean BasicPathHelper::DirectoryCopy(System.String,System.String,System.Boolean,System.Action`1<System.IO.FileInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool BasicPathHelper_DirectoryCopy_mF560AD07CF1521ABCAA853D0AA9A3D01F72B19A4 (String_t* ___0_sourceDirName, String_t* ___1_destDirName, bool ___2_copySubDirs, Action_1_t8FDFDD761A78E63D829702D183AAE14618CE0DAA* ___3_afterCopyFileAction, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2102995F349F17F639C4D239BE8B75DCEB6CDB4F);
		s_Il2CppMethodInitialized = true;
	}
	DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* V_0 = NULL;
	DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* V_1 = NULL;
	FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6* V_2 = NULL;
	int32_t V_3 = 0;
	FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* V_4 = NULL;
	String_t* V_5 = NULL;
	FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* V_6 = NULL;
	DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* V_7 = NULL;
	DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* V_8 = NULL;
	String_t* V_9 = NULL;
	{
		// var dir = new DirectoryInfo(sourceDirName);
		String_t* L_0 = ___0_sourceDirName;
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_1 = (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2*)il2cpp_codegen_object_new(DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		DirectoryInfo__ctor_m36BC476C58B55083046C0A738157D84E2323E0E9(L_1, L_0, NULL);
		V_0 = L_1;
		// if (!dir.Exists)
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_2 = V_0;
		NullCheck(L_2);
		bool L_3;
		L_3 = VirtualFuncInvoker0< bool >::Invoke(10 /* System.Boolean System.IO.FileSystemInfo::get_Exists() */, L_2);
		if (L_3)
		{
			goto IL_001b;
		}
	}
	{
		// Debug.LogError("Source directory doesn't exist");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(_stringLiteral2102995F349F17F639C4D239BE8B75DCEB6CDB4F, NULL);
		// return false;
		return (bool)0;
	}

IL_001b:
	{
		// var dirs = dir.GetDirectories();
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_4 = V_0;
		NullCheck(L_4);
		DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* L_5;
		L_5 = DirectoryInfo_GetDirectories_m2EC8498544C3A85EF92273330858E03B284C6901(L_4, NULL);
		V_1 = L_5;
		// if (!Directory.Exists(destDirName))
		String_t* L_6 = ___1_destDirName;
		bool L_7;
		L_7 = Directory_Exists_m3D125E9E88C291CF11113444F961A64DD83AE1C7(L_6, NULL);
		if (L_7)
		{
			goto IL_0031;
		}
	}
	{
		// Directory.CreateDirectory(destDirName);
		String_t* L_8 = ___1_destDirName;
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_9;
		L_9 = Directory_CreateDirectory_m16EC5CE8561A997C6635E06DC24C77590F29D94F(L_8, NULL);
	}

IL_0031:
	{
		// var files = dir.GetFiles();
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_10 = V_0;
		NullCheck(L_10);
		FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6* L_11;
		L_11 = DirectoryInfo_GetFiles_m998040748717954CDDCE273F61EEC0625069543F(L_10, NULL);
		// foreach (var file in files)
		V_2 = L_11;
		V_3 = 0;
		goto IL_006b;
	}

IL_003c:
	{
		// foreach (var file in files)
		FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6* L_12 = V_2;
		int32_t L_13 = V_3;
		NullCheck(L_12);
		int32_t L_14 = L_13;
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_15 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		V_4 = L_15;
		// var tempPath = Path.Combine(destDirName, file.Name);
		String_t* L_16 = ___1_destDirName;
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_17 = V_4;
		NullCheck(L_17);
		String_t* L_18;
		L_18 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.IO.FileSystemInfo::get_Name() */, L_17);
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_19;
		L_19 = Path_Combine_m1ADAC05CDA2D1D61B172DF65A81E86592696BEAE(L_16, L_18, NULL);
		V_5 = L_19;
		// var newFile = file.CopyTo(tempPath, true);
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_20 = V_4;
		String_t* L_21 = V_5;
		NullCheck(L_20);
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_22;
		L_22 = FileInfo_CopyTo_m4AC9EAD035D0106081B5DA5FBE4E02BDA911DD49(L_20, L_21, (bool)1, NULL);
		V_6 = L_22;
		// afterCopyFileAction?.Invoke(newFile);
		Action_1_t8FDFDD761A78E63D829702D183AAE14618CE0DAA* L_23 = ___3_afterCopyFileAction;
		if (!L_23)
		{
			goto IL_0067;
		}
	}
	{
		Action_1_t8FDFDD761A78E63D829702D183AAE14618CE0DAA* L_24 = ___3_afterCopyFileAction;
		FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_25 = V_6;
		NullCheck(L_24);
		Action_1_Invoke_mE9AF50D78F1965638B4FD05542F3613DC0F8C670_inline(L_24, L_25, NULL);
	}

IL_0067:
	{
		int32_t L_26 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_26, 1));
	}

IL_006b:
	{
		// foreach (var file in files)
		int32_t L_27 = V_3;
		FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6* L_28 = V_2;
		NullCheck(L_28);
		if ((((int32_t)L_27) < ((int32_t)((int32_t)(((RuntimeArray*)L_28)->max_length)))))
		{
			goto IL_003c;
		}
	}
	{
		// if (copySubDirs)
		bool L_29 = ___2_copySubDirs;
		if (!L_29)
		{
			goto IL_00ac;
		}
	}
	{
		// foreach (var subDir in dirs)
		DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* L_30 = V_1;
		V_7 = L_30;
		V_3 = 0;
		goto IL_00a5;
	}

IL_007b:
	{
		// foreach (var subDir in dirs)
		DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* L_31 = V_7;
		int32_t L_32 = V_3;
		NullCheck(L_31);
		int32_t L_33 = L_32;
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_34 = (L_31)->GetAt(static_cast<il2cpp_array_size_t>(L_33));
		V_8 = L_34;
		// var tempPath = Path.Combine(destDirName, subDir.Name);
		String_t* L_35 = ___1_destDirName;
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_36 = V_8;
		NullCheck(L_36);
		String_t* L_37;
		L_37 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.IO.FileSystemInfo::get_Name() */, L_36);
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_38;
		L_38 = Path_Combine_m1ADAC05CDA2D1D61B172DF65A81E86592696BEAE(L_35, L_37, NULL);
		V_9 = L_38;
		// DirectoryCopy(subDir.FullName, tempPath, true, afterCopyFileAction);
		DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_39 = V_8;
		NullCheck(L_39);
		String_t* L_40;
		L_40 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_39);
		String_t* L_41 = V_9;
		Action_1_t8FDFDD761A78E63D829702D183AAE14618CE0DAA* L_42 = ___3_afterCopyFileAction;
		bool L_43;
		L_43 = BasicPathHelper_DirectoryCopy_mF560AD07CF1521ABCAA853D0AA9A3D01F72B19A4(L_40, L_41, (bool)1, L_42, NULL);
		int32_t L_44 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_44, 1));
	}

IL_00a5:
	{
		// foreach (var subDir in dirs)
		int32_t L_45 = V_3;
		DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* L_46 = V_7;
		NullCheck(L_46);
		if ((((int32_t)L_45) < ((int32_t)((int32_t)(((RuntimeArray*)L_46)->max_length)))))
		{
			goto IL_007b;
		}
	}

IL_00ac:
	{
		// return true;
		return (bool)1;
	}
}
// System.Boolean BasicPathHelper::CopyFile(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool BasicPathHelper_CopyFile_m611A89F8C1C5F8D6149C6100BC8DE94583A8BE0B (String_t* ___0_srcPath, String_t* ___1_tarPath, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	bool V_1 = false;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		{
			// var dirPath = Path.GetDirectoryName(tarPath);
			String_t* L_0 = ___1_tarPath;
			il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
			String_t* L_1;
			L_1 = Path_GetDirectoryName_m428BADBE493A3927B51A13DEF658929B430516F6(L_0, NULL);
			V_0 = L_1;
			// if (!Directory.Exists(dirPath))
			String_t* L_2 = V_0;
			bool L_3;
			L_3 = Directory_Exists_m3D125E9E88C291CF11113444F961A64DD83AE1C7(L_2, NULL);
			if (L_3)
			{
				goto IL_0018_1;
			}
		}
		{
			// Directory.CreateDirectory(dirPath);
			String_t* L_4 = V_0;
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_5;
			L_5 = Directory_CreateDirectory_m16EC5CE8561A997C6635E06DC24C77590F29D94F(L_4, NULL);
			goto IL_0026_1;
		}

IL_0018_1:
		{
			// else if (File.Exists(tarPath))
			String_t* L_6 = ___1_tarPath;
			bool L_7;
			L_7 = File_Exists_m95E329ABBE3EAD6750FE1989BBA6884457136D4A(L_6, NULL);
			if (!L_7)
			{
				goto IL_0026_1;
			}
		}
		{
			// File.Delete(tarPath); //????
			String_t* L_8 = ___1_tarPath;
			File_Delete_mE29829DA504F3E1B8BCB78F21E2862C9ED7EC386(L_8, NULL);
		}

IL_0026_1:
		{
			// File.Copy(srcPath, tarPath);
			String_t* L_9 = ___0_srcPath;
			String_t* L_10 = ___1_tarPath;
			File_Copy_mC698F2F0FF8BBF3339527CD00E57A6D5B26DE4AA(L_9, L_10, NULL);
			// }
			goto IL_0038;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_002f;
		}
		throw e;
	}

CATCH_002f:
	{// begin catch(System.Exception)
		// Debug.LogError(e);
		il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var)));
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*)), NULL);
		// return false;
		V_1 = (bool)0;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_003a;
	}// end catch (depth: 1)

IL_0038:
	{
		// return true;
		return (bool)1;
	}

IL_003a:
	{
		// }
		bool L_11 = V_1;
		return L_11;
	}
}
// System.Boolean BasicPathHelper::MoveDir(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool BasicPathHelper_MoveDir_m741D3B7C7FA4BE5A8480D8EF1AF7D0F2424A87CA (String_t* ___0_srcPath, String_t* ___1_tarPath, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2102995F349F17F639C4D239BE8B75DCEB6CDB4F);
		s_Il2CppMethodInitialized = true;
	}
	DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* V_0 = NULL;
	bool V_1 = false;
	FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6* V_2 = NULL;
	int32_t V_3 = 0;
	FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* V_4 = NULL;
	String_t* V_5 = NULL;
	DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* V_6 = NULL;
	DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* V_7 = NULL;
	String_t* V_8 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		{
			// var dir = new DirectoryInfo(srcPath);
			String_t* L_0 = ___0_srcPath;
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_1 = (DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2*)il2cpp_codegen_object_new(DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2_il2cpp_TypeInfo_var);
			NullCheck(L_1);
			DirectoryInfo__ctor_m36BC476C58B55083046C0A738157D84E2323E0E9(L_1, L_0, NULL);
			V_0 = L_1;
			// if (!dir.Exists)
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_2 = V_0;
			NullCheck(L_2);
			bool L_3;
			L_3 = VirtualFuncInvoker0< bool >::Invoke(10 /* System.Boolean System.IO.FileSystemInfo::get_Exists() */, L_2);
			if (L_3)
			{
				goto IL_0020_1;
			}
		}
		{
			// Debug.LogError("Source directory doesn't exist");
			il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
			Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(_stringLiteral2102995F349F17F639C4D239BE8B75DCEB6CDB4F, NULL);
			// return false;
			V_1 = (bool)0;
			goto IL_00be;
		}

IL_0020_1:
		{
			// if (!Directory.Exists(tarPath))
			String_t* L_4 = ___1_tarPath;
			bool L_5;
			L_5 = Directory_Exists_m3D125E9E88C291CF11113444F961A64DD83AE1C7(L_4, NULL);
			if (L_5)
			{
				goto IL_002f_1;
			}
		}
		{
			// Directory.CreateDirectory(tarPath);
			String_t* L_6 = ___1_tarPath;
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_7;
			L_7 = Directory_CreateDirectory_m16EC5CE8561A997C6635E06DC24C77590F29D94F(L_6, NULL);
		}

IL_002f_1:
		{
			// var files = dir.GetFiles();
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_8 = V_0;
			NullCheck(L_8);
			FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6* L_9;
			L_9 = DirectoryInfo_GetFiles_m998040748717954CDDCE273F61EEC0625069543F(L_8, NULL);
			// foreach (var file in files)
			V_2 = L_9;
			V_3 = 0;
			goto IL_0062_1;
		}

IL_003a_1:
		{
			// foreach (var file in files)
			FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6* L_10 = V_2;
			int32_t L_11 = V_3;
			NullCheck(L_10);
			int32_t L_12 = L_11;
			FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_13 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
			V_4 = L_13;
			// var tarFilePath = Path.Combine(tarPath, file.Name);
			String_t* L_14 = ___1_tarPath;
			FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_15 = V_4;
			NullCheck(L_15);
			String_t* L_16;
			L_16 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.IO.FileSystemInfo::get_Name() */, L_15);
			il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
			String_t* L_17;
			L_17 = Path_Combine_m1ADAC05CDA2D1D61B172DF65A81E86592696BEAE(L_14, L_16, NULL);
			V_5 = L_17;
			// MoveFile(file.FullName, tarFilePath, false);
			FileInfo_t62782BBAFA832A78724E4CF2EE96548B8466AB1C* L_18 = V_4;
			NullCheck(L_18);
			String_t* L_19;
			L_19 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_18);
			String_t* L_20 = V_5;
			bool L_21;
			L_21 = BasicPathHelper_MoveFile_m7AF9134D8F3711DBA515F5A817A70C41E921DA70(L_19, L_20, (bool)0, NULL);
			int32_t L_22 = V_3;
			V_3 = ((int32_t)il2cpp_codegen_add(L_22, 1));
		}

IL_0062_1:
		{
			// foreach (var file in files)
			int32_t L_23 = V_3;
			FileInfoU5BU5D_tCB74DD125A9220ABCF5F48549F2C71B74BBCD7E6* L_24 = V_2;
			NullCheck(L_24);
			if ((((int32_t)L_23) < ((int32_t)((int32_t)(((RuntimeArray*)L_24)->max_length)))))
			{
				goto IL_003a_1;
			}
		}
		{
			// var dirs = dir.GetDirectories();
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_25 = V_0;
			NullCheck(L_25);
			DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* L_26;
			L_26 = DirectoryInfo_GetDirectories_m2EC8498544C3A85EF92273330858E03B284C6901(L_25, NULL);
			// foreach (var temDir in dirs)
			V_6 = L_26;
			V_3 = 0;
			goto IL_009c_1;
		}

IL_0074_1:
		{
			// foreach (var temDir in dirs)
			DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* L_27 = V_6;
			int32_t L_28 = V_3;
			NullCheck(L_27);
			int32_t L_29 = L_28;
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_30 = (L_27)->GetAt(static_cast<il2cpp_array_size_t>(L_29));
			V_7 = L_30;
			// var temTargetPath = Path.Combine(tarPath, temDir.Name);
			String_t* L_31 = ___1_tarPath;
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_32 = V_7;
			NullCheck(L_32);
			String_t* L_33;
			L_33 = VirtualFuncInvoker0< String_t* >::Invoke(9 /* System.String System.IO.FileSystemInfo::get_Name() */, L_32);
			il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
			String_t* L_34;
			L_34 = Path_Combine_m1ADAC05CDA2D1D61B172DF65A81E86592696BEAE(L_31, L_33, NULL);
			V_8 = L_34;
			// MoveDir(temDir.FullName, temTargetPath);
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_35 = V_7;
			NullCheck(L_35);
			String_t* L_36;
			L_36 = VirtualFuncInvoker0< String_t* >::Invoke(8 /* System.String System.IO.FileSystemInfo::get_FullName() */, L_35);
			String_t* L_37 = V_8;
			bool L_38;
			L_38 = BasicPathHelper_MoveDir_m741D3B7C7FA4BE5A8480D8EF1AF7D0F2424A87CA(L_36, L_37, NULL);
			int32_t L_39 = V_3;
			V_3 = ((int32_t)il2cpp_codegen_add(L_39, 1));
		}

IL_009c_1:
		{
			// foreach (var temDir in dirs)
			int32_t L_40 = V_3;
			DirectoryInfoU5BU5D_t5D09D46C6EBC15480AF7C63C54276B57A4287953* L_41 = V_6;
			NullCheck(L_41);
			if ((((int32_t)L_40) < ((int32_t)((int32_t)(((RuntimeArray*)L_41)->max_length)))))
			{
				goto IL_0074_1;
			}
		}
		{
			// TryMoveMeta(srcPath, tarPath);
			String_t* L_42 = ___0_srcPath;
			String_t* L_43 = ___1_tarPath;
			BasicPathHelper_TryMoveMeta_mA9292EF0D203ECFF408E66A0171AE6694495C7A4(L_42, L_43, NULL);
			// Directory.Delete(srcPath, true);
			String_t* L_44 = ___0_srcPath;
			Directory_Delete_mB5C70379DEFE9B8AA95F67BAE04233E60CEF09F4(L_44, (bool)1, NULL);
			// }
			goto IL_00bc;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_00b3;
		}
		throw e;
	}

CATCH_00b3:
	{// begin catch(System.Exception)
		// Debug.LogError(e);
		il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var)));
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*)), NULL);
		// return false;
		V_1 = (bool)0;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00be;
	}// end catch (depth: 1)

IL_00bc:
	{
		// return true;
		return (bool)1;
	}

IL_00be:
	{
		// }
		bool L_45 = V_1;
		return L_45;
	}
}
// System.Boolean BasicPathHelper::MoveFile(System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool BasicPathHelper_MoveFile_m7AF9134D8F3711DBA515F5A817A70C41E921DA70 (String_t* ___0_srcPath, String_t* ___1_tarPath, bool ___2_includeMeta, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	bool V_1 = false;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	try
	{// begin try (depth: 1)
		{
			// var dirPath = Path.GetDirectoryName(tarPath);
			String_t* L_0 = ___1_tarPath;
			il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
			String_t* L_1;
			L_1 = Path_GetDirectoryName_m428BADBE493A3927B51A13DEF658929B430516F6(L_0, NULL);
			V_0 = L_1;
			// if (!Directory.Exists(dirPath))
			String_t* L_2 = V_0;
			bool L_3;
			L_3 = Directory_Exists_m3D125E9E88C291CF11113444F961A64DD83AE1C7(L_2, NULL);
			if (L_3)
			{
				goto IL_0018_1;
			}
		}
		{
			// Directory.CreateDirectory(dirPath);
			String_t* L_4 = V_0;
			DirectoryInfo_tEAEEC018EB49B4A71907FFEAFE935FAA8F9C1FE2* L_5;
			L_5 = Directory_CreateDirectory_m16EC5CE8561A997C6635E06DC24C77590F29D94F(L_4, NULL);
			goto IL_0026_1;
		}

IL_0018_1:
		{
			// else if (File.Exists(tarPath))
			String_t* L_6 = ___1_tarPath;
			bool L_7;
			L_7 = File_Exists_m95E329ABBE3EAD6750FE1989BBA6884457136D4A(L_6, NULL);
			if (!L_7)
			{
				goto IL_0026_1;
			}
		}
		{
			// File.Delete(tarPath); //????
			String_t* L_8 = ___1_tarPath;
			File_Delete_mE29829DA504F3E1B8BCB78F21E2862C9ED7EC386(L_8, NULL);
		}

IL_0026_1:
		{
			// File.Move(srcPath, tarPath);
			String_t* L_9 = ___0_srcPath;
			String_t* L_10 = ___1_tarPath;
			File_Move_mBC9450111E0144A55D893A720F19E612D658AC37(L_9, L_10, NULL);
			// if (includeMeta)
			bool L_11 = ___2_includeMeta;
			if (!L_11)
			{
				goto IL_0037_1;
			}
		}
		{
			// TryMoveMeta(srcPath, tarPath);
			String_t* L_12 = ___0_srcPath;
			String_t* L_13 = ___1_tarPath;
			BasicPathHelper_TryMoveMeta_mA9292EF0D203ECFF408E66A0171AE6694495C7A4(L_12, L_13, NULL);
		}

IL_0037_1:
		{
			// }
			goto IL_0042;
		}
	}// end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0039;
		}
		throw e;
	}

CATCH_0039:
	{// begin catch(System.Exception)
		// Debug.LogError(e);
		il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var)));
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(((Exception_t*)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t*)), NULL);
		// return false;
		V_1 = (bool)0;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0044;
	}// end catch (depth: 1)

IL_0042:
	{
		// return true;
		return (bool)1;
	}

IL_0044:
	{
		// }
		bool L_14 = V_1;
		return L_14;
	}
}
// System.Void BasicPathHelper::TryMoveMeta(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper_TryMoveMeta_mA9292EF0D203ECFF408E66A0171AE6694495C7A4 (String_t* ___0_srcPath, String_t* ___1_tarPath, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral158F3A8EBA35F33F74D6EE2F0DE6901C6C4BB25B);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	String_t* V_1 = NULL;
	{
		// var metaPath = $"{srcPath}.meta";
		String_t* L_0 = ___0_srcPath;
		String_t* L_1;
		L_1 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_0, _stringLiteral158F3A8EBA35F33F74D6EE2F0DE6901C6C4BB25B, NULL);
		V_0 = L_1;
		// if (File.Exists(metaPath))
		String_t* L_2 = V_0;
		bool L_3;
		L_3 = File_Exists_m95E329ABBE3EAD6750FE1989BBA6884457136D4A(L_2, NULL);
		if (!L_3)
		{
			goto IL_0029;
		}
	}
	{
		// var targetMetaPath = $"{tarPath}.meta";
		String_t* L_4 = ___1_tarPath;
		String_t* L_5;
		L_5 = String_Concat_m9E3155FB84015C823606188F53B47CB44C444991(L_4, _stringLiteral158F3A8EBA35F33F74D6EE2F0DE6901C6C4BB25B, NULL);
		V_1 = L_5;
		// MoveFile(metaPath, targetMetaPath, false);
		String_t* L_6 = V_0;
		String_t* L_7 = V_1;
		bool L_8;
		L_8 = BasicPathHelper_MoveFile_m7AF9134D8F3711DBA515F5A817A70C41E921DA70(L_6, L_7, (bool)0, NULL);
	}

IL_0029:
	{
		// }
		return;
	}
}
// System.String BasicPathHelper::GetResPlatformName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BasicPathHelper_GetResPlatformName_m3445712793D9125C52B0AAC0B6E7642F25BF5C4E (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral357434484751BA5EBE0EFE7F1BFD26D693185794);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return "Windows";
		return _stringLiteral357434484751BA5EBE0EFE7F1BFD26D693185794;
	}
}
// System.Void BasicPathHelper::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BasicPathHelper__ctor_mEA961036DBAA2C4C0A39BC4A3602BE0F520D81E5 (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DLLLoader::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DLLLoader_Start_m34E2A3012D07922CAD694EB22CB840181920D46A (DLLLoader_t95408ED76C29A4565E62021A397981E36B84516C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m8F948E5CA79E9FB97AA88568D104F6D2BDBCB841_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_mCB63518F6AAC7C5645F8266E4707CEAD9E36AEB5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m89A7F0C504AFC98682031BB015F324DCA4E99F67_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_GetEnumerator_m360A8DDD167BBB6AE06E83DCE28DC33887075E0D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF8C9D1D7502E6E972626BDAC058F8E8D20E20E8F);
		s_Il2CppMethodInitialized = true;
	}
	Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618 V_0;
	memset((&V_0), 0, sizeof(V_0));
	DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* V_1 = NULL;
	Assembly_t* V_2 = NULL;
	{
		// LoadMetadataForAOTAssemblies();
		DLLLoader_LoadMetadataForAOTAssemblies_m0CF84F954792E33EC829038D54F91043F7D0786D(__this, NULL);
		// foreach (DLLLoadCfg cfg in HybridCLRCfg.hotUpdateDLLNames)
		il2cpp_codegen_runtime_class_init_inline(HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_il2cpp_TypeInfo_var);
		List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* L_0 = ((HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_StaticFields*)il2cpp_codegen_static_fields_for(HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_il2cpp_TypeInfo_var))->___hotUpdateDLLNames_0;
		NullCheck(L_0);
		Enumerator_t52BF1CF092E1D3B1505AFDA463BACB7637B3B618 L_1;
		L_1 = List_1_GetEnumerator_m360A8DDD167BBB6AE06E83DCE28DC33887075E0D(L_0, List_1_GetEnumerator_m360A8DDD167BBB6AE06E83DCE28DC33887075E0D_RuntimeMethod_var);
		V_0 = L_1;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0064:
			{// begin finally (depth: 1)
				Enumerator_Dispose_m8F948E5CA79E9FB97AA88568D104F6D2BDBCB841((&V_0), Enumerator_Dispose_m8F948E5CA79E9FB97AA88568D104F6D2BDBCB841_RuntimeMethod_var);
				return;
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_0059_1;
			}

IL_0013_1:
			{
				// foreach (DLLLoadCfg cfg in HybridCLRCfg.hotUpdateDLLNames)
				DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* L_2;
				L_2 = Enumerator_get_Current_m89A7F0C504AFC98682031BB015F324DCA4E99F67_inline((&V_0), Enumerator_get_Current_m89A7F0C504AFC98682031BB015F324DCA4E99F67_RuntimeMethod_var);
				V_1 = L_2;
				// Assembly hotUpdateAss = Assembly.Load(File.ReadAllBytes($"{BasicPathHelper.Instance.PersistentDataPath}/{cfg.dllName}.dll.bytes"));
				BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* L_3;
				L_3 = BasicPathHelper_get_Instance_m97B42DAE9B68013832DF2B6B51BCC68601D7D87D(NULL);
				NullCheck(L_3);
				String_t* L_4;
				L_4 = BasicPathHelper_get_PersistentDataPath_m635AAA65829247BC830D094C259535A738A76D38_inline(L_3, NULL);
				DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* L_5 = V_1;
				NullCheck(L_5);
				String_t* L_6;
				L_6 = DLLLoadCfg_get_dllName_mD6527A4807214DFA6C2D8B3433D6F5E8970C29AF_inline(L_5, NULL);
				String_t* L_7;
				L_7 = String_Concat_m093934F71A9B351911EE46311674ED463B180006(L_4, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, L_6, _stringLiteralF8C9D1D7502E6E972626BDAC058F8E8D20E20E8F, NULL);
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_8;
				L_8 = File_ReadAllBytes_m704CBBA3F130C94F5A3E0BE2A93D9E9D79DC3E24(L_7, NULL);
				Assembly_t* L_9;
				L_9 = Assembly_Load_mD9E9CED2EFF8BBE97ACDE83FB8ED492D1E42E975(L_8, NULL);
				V_2 = L_9;
				// if (cfg.afterLoadeAction != null)
				DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* L_10 = V_1;
				NullCheck(L_10);
				Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* L_11;
				L_11 = DLLLoadCfg_get_afterLoadeAction_mB4A28D8DB7D6B13E7D38FCB58EF6FDD158618694_inline(L_10, NULL);
				if (!L_11)
				{
					goto IL_0059_1;
				}
			}
			{
				// cfg.afterLoadeAction.Invoke(hotUpdateAss);
				DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* L_12 = V_1;
				NullCheck(L_12);
				Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* L_13;
				L_13 = DLLLoadCfg_get_afterLoadeAction_mB4A28D8DB7D6B13E7D38FCB58EF6FDD158618694_inline(L_12, NULL);
				Assembly_t* L_14 = V_2;
				NullCheck(L_13);
				Action_1_Invoke_m03986762CAC07D19A51669597128749F7F427C70_inline(L_13, L_14, NULL);
			}

IL_0059_1:
			{
				// foreach (DLLLoadCfg cfg in HybridCLRCfg.hotUpdateDLLNames)
				bool L_15;
				L_15 = Enumerator_MoveNext_mCB63518F6AAC7C5645F8266E4707CEAD9E36AEB5((&V_0), Enumerator_MoveNext_mCB63518F6AAC7C5645F8266E4707CEAD9E36AEB5_RuntimeMethod_var);
				if (L_15)
				{
					goto IL_0013_1;
				}
			}
			{
				goto IL_0072;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0072:
	{
		// }
		return;
	}
}
// System.Void DLLLoader::LoadMetadataForAOTAssemblies()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DLLLoader_LoadMetadataForAOTAssemblies_m0CF84F954792E33EC829038D54F91043F7D0786D (DLLLoader_t95408ED76C29A4565E62021A397981E36B84516C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_1_t349E66EC5F09B881A8E52EE40A1AB9EC60E08E44_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_1_t73FD060C436E3C4264A734C8F8DCC01DFF6046B8_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&LoadImageErrorCode_tC778A2553ADB45B8C61EFE26C20837C23894FEB3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral433D44993C565E2FF97977521ADC0298C066AC34);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEC4C5477D8BA260A27C36AFD7E8C1C289169E9CF);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	String_t* V_1 = NULL;
	int32_t V_2 = 0;
	{
		// foreach (var aotDllName in AOTGenericReferences.PatchedAOTAssemblyList)
		il2cpp_codegen_runtime_class_init_inline(AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_il2cpp_TypeInfo_var);
		RuntimeObject* L_0 = ((AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_StaticFields*)il2cpp_codegen_static_fields_for(AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_il2cpp_TypeInfo_var))->___PatchedAOTAssemblyList_4;
		NullCheck(L_0);
		RuntimeObject* L_1;
		L_1 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.IEnumerable`1<System.String>::GetEnumerator() */, IEnumerable_1_t349E66EC5F09B881A8E52EE40A1AB9EC60E08E44_il2cpp_TypeInfo_var, L_0);
		V_0 = L_1;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_005a:
			{// begin finally (depth: 1)
				{
					RuntimeObject* L_2 = V_0;
					if (!L_2)
					{
						goto IL_0063;
					}
				}
				{
					RuntimeObject* L_3 = V_0;
					NullCheck(L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_3);
				}

IL_0063:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				goto IL_0050_1;
			}

IL_000d_1:
			{
				// foreach (var aotDllName in AOTGenericReferences.PatchedAOTAssemblyList)
				RuntimeObject* L_4 = V_0;
				NullCheck(L_4);
				String_t* L_5;
				L_5 = InterfaceFuncInvoker0< String_t* >::Invoke(0 /* T System.Collections.Generic.IEnumerator`1<System.String>::get_Current() */, IEnumerator_1_t73FD060C436E3C4264A734C8F8DCC01DFF6046B8_il2cpp_TypeInfo_var, L_4);
				V_1 = L_5;
				// byte[] dllBytes = File.ReadAllBytes($"{BasicPathHelper.Instance.PersistentDataPath}/{aotDllName}.bytes");
				BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* L_6;
				L_6 = BasicPathHelper_get_Instance_m97B42DAE9B68013832DF2B6B51BCC68601D7D87D(NULL);
				NullCheck(L_6);
				String_t* L_7;
				L_7 = BasicPathHelper_get_PersistentDataPath_m635AAA65829247BC830D094C259535A738A76D38_inline(L_6, NULL);
				String_t* L_8 = V_1;
				String_t* L_9;
				L_9 = String_Concat_m093934F71A9B351911EE46311674ED463B180006(L_7, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, L_8, _stringLiteralEC4C5477D8BA260A27C36AFD7E8C1C289169E9CF, NULL);
				ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_10;
				L_10 = File_ReadAllBytes_m704CBBA3F130C94F5A3E0BE2A93D9E9D79DC3E24(L_9, NULL);
				// LoadImageErrorCode err = RuntimeApi.LoadMetadataForAOTAssembly(dllBytes, HomologousImageMode.SuperSet);
				int32_t L_11;
				L_11 = RuntimeApi_LoadMetadataForAOTAssembly_mE1E398132DBF86D7DE042300E1EE6AC37B7649D8(L_10, 1, NULL);
				V_2 = L_11;
				// Debug.Log($"LoadMetadataForAOTAssembly:{aotDllName}. ret:{err}");
				String_t* L_12 = V_1;
				int32_t L_13 = V_2;
				int32_t L_14 = L_13;
				RuntimeObject* L_15 = Box(LoadImageErrorCode_tC778A2553ADB45B8C61EFE26C20837C23894FEB3_il2cpp_TypeInfo_var, &L_14);
				String_t* L_16;
				L_16 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(_stringLiteral433D44993C565E2FF97977521ADC0298C066AC34, L_12, L_15, NULL);
				il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
				Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(L_16, NULL);
			}

IL_0050_1:
			{
				// foreach (var aotDllName in AOTGenericReferences.PatchedAOTAssemblyList)
				RuntimeObject* L_17 = V_0;
				NullCheck(L_17);
				bool L_18;
				L_18 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA_il2cpp_TypeInfo_var, L_17);
				if (L_18)
				{
					goto IL_000d_1;
				}
			}
			{
				goto IL_0064;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0064:
	{
		// }
		return;
	}
}
// System.Void DLLLoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DLLLoader__ctor_mFB5200D69A4A760B2386265A671BB97FB766E3FF (DLLLoader_t95408ED76C29A4565E62021A397981E36B84516C* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void HybridCLRCfg::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HybridCLRCfg__cctor_m5BAEC5A61643BD3C11768D0E763CC3889B13D03C (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m076677A129A54D202CBF65448113ABBA0963E29A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m7B7C2F87380B13815D89B0A327509AD6BF4160AF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_U3C_cctorU3Eb__1_0_m20C803CBCBEBE252D4B0BE2F6CD9FEA245DF1E69_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral079998E3393B6BDC1FAFFA63A54F724488AE5306);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral16616D61D1F596C11D66025981D6CED3F79A8444);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB33C27CA0C0FED17B3C2F420F374320CADB9F1FE);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public readonly static List<DLLLoadCfg> hotUpdateDLLNames = new List<DLLLoadCfg>
		// {
		//     new DLLLoadCfg("Frame"),
		//     new DLLLoadCfg("Cfg"),
		//     new DLLLoadCfg("Game",(assembly)=>{
		//         if (assembly == null)
		//             return;
		//         Type launcherType = assembly.GetType("Launcher");
		//         launcherType.GetMethod("InitGame").Invoke(null, null);
		//     })
		// };
		List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* L_0 = (List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C*)il2cpp_codegen_object_new(List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		List_1__ctor_m7B7C2F87380B13815D89B0A327509AD6BF4160AF(L_0, List_1__ctor_m7B7C2F87380B13815D89B0A327509AD6BF4160AF_RuntimeMethod_var);
		List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* L_1 = L_0;
		DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* L_2 = (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4*)il2cpp_codegen_object_new(DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		DLLLoadCfg__ctor_mCA33D02A1FC6F36347FB9397AB4C237F02248DE5(L_2, _stringLiteral16616D61D1F596C11D66025981D6CED3F79A8444, (Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42*)NULL, NULL);
		NullCheck(L_1);
		List_1_Add_m076677A129A54D202CBF65448113ABBA0963E29A_inline(L_1, L_2, List_1_Add_m076677A129A54D202CBF65448113ABBA0963E29A_RuntimeMethod_var);
		List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* L_3 = L_1;
		DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* L_4 = (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4*)il2cpp_codegen_object_new(DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4_il2cpp_TypeInfo_var);
		NullCheck(L_4);
		DLLLoadCfg__ctor_mCA33D02A1FC6F36347FB9397AB4C237F02248DE5(L_4, _stringLiteralB33C27CA0C0FED17B3C2F420F374320CADB9F1FE, (Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42*)NULL, NULL);
		NullCheck(L_3);
		List_1_Add_m076677A129A54D202CBF65448113ABBA0963E29A_inline(L_3, L_4, List_1_Add_m076677A129A54D202CBF65448113ABBA0963E29A_RuntimeMethod_var);
		List_1_t4C549F58EC1049D4CDBA0D70ED963B36A6ED6E3C* L_5 = L_3;
		il2cpp_codegen_runtime_class_init_inline(U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_il2cpp_TypeInfo_var);
		U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D* L_6 = ((U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_il2cpp_TypeInfo_var))->___U3CU3E9_0;
		Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* L_7 = (Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42*)il2cpp_codegen_object_new(Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42_il2cpp_TypeInfo_var);
		NullCheck(L_7);
		Action_1__ctor_mA5CC188AF946F9AB740FB0C5F0FF3B6EB3627541(L_7, L_6, (intptr_t)((void*)U3CU3Ec_U3C_cctorU3Eb__1_0_m20C803CBCBEBE252D4B0BE2F6CD9FEA245DF1E69_RuntimeMethod_var), NULL);
		DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* L_8 = (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4*)il2cpp_codegen_object_new(DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		DLLLoadCfg__ctor_mCA33D02A1FC6F36347FB9397AB4C237F02248DE5(L_8, _stringLiteral079998E3393B6BDC1FAFFA63A54F724488AE5306, L_7, NULL);
		NullCheck(L_5);
		List_1_Add_m076677A129A54D202CBF65448113ABBA0963E29A_inline(L_5, L_8, List_1_Add_m076677A129A54D202CBF65448113ABBA0963E29A_RuntimeMethod_var);
		((HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_StaticFields*)il2cpp_codegen_static_fields_for(HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_il2cpp_TypeInfo_var))->___hotUpdateDLLNames_0 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&((HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_StaticFields*)il2cpp_codegen_static_fields_for(HybridCLRCfg_tEFB705CD1DCE9DA6724599E698981A948E265B2C_il2cpp_TypeInfo_var))->___hotUpdateDLLNames_0), (void*)L_5);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void HybridCLRCfg/<>c::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_m4E635EB8CFC01A75F6A3217A481B3EA7C5CE6C99 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D* L_0 = (U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D*)il2cpp_codegen_object_new(U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__ctor_m786E08B98DE18711131140DC71A4CD2C37B38C02(L_0, NULL);
		((U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_il2cpp_TypeInfo_var))->___U3CU3E9_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&((U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D_il2cpp_TypeInfo_var))->___U3CU3E9_0), (void*)L_0);
		return;
	}
}
// System.Void HybridCLRCfg/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m786E08B98DE18711131140DC71A4CD2C37B38C02 (U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Void HybridCLRCfg/<>c::<.cctor>b__1_0(System.Reflection.Assembly)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec_U3C_cctorU3Eb__1_0_m20C803CBCBEBE252D4B0BE2F6CD9FEA245DF1E69 (U3CU3Ec_tDB86FA86A65AEC533200A1717991A3CA01ABE49D* __this, Assembly_t* ___0_assembly, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral50AD21DAB9A9167E61A4D419343EE9409B103EDF);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5CCAE404D857518E96A426119632D5498AFE1A6F);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (assembly == null)
		Assembly_t* L_0 = ___0_assembly;
		bool L_1;
		L_1 = Assembly_op_Equality_m1E2666F9D0537F02AB32F14B4458C98C4851CEAB(L_0, (Assembly_t*)NULL, NULL);
		if (!L_1)
		{
			goto IL_000a;
		}
	}
	{
		// return;
		return;
	}

IL_000a:
	{
		// Type launcherType = assembly.GetType("Launcher");
		Assembly_t* L_2 = ___0_assembly;
		NullCheck(L_2);
		Type_t* L_3;
		L_3 = VirtualFuncInvoker1< Type_t*, String_t* >::Invoke(18 /* System.Type System.Reflection.Assembly::GetType(System.String) */, L_2, _stringLiteral50AD21DAB9A9167E61A4D419343EE9409B103EDF);
		// launcherType.GetMethod("InitGame").Invoke(null, null);
		NullCheck(L_3);
		MethodInfo_t* L_4;
		L_4 = Type_GetMethod_m66AD062187F19497DBCA900823B0C268322DC231(L_3, _stringLiteral5CCAE404D857518E96A426119632D5498AFE1A6F, NULL);
		NullCheck(L_4);
		RuntimeObject* L_5;
		L_5 = MethodBase_Invoke_mEEF3218648F111A8C338001A7804091A0747C826(L_4, NULL, (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)NULL, NULL);
		// })
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DLLLoadCfg::set_dllName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DLLLoadCfg_set_dllName_m148E67557E56757C2C0EB820F8A2A9051DB91C27 (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string dllName { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CdllNameU3Ek__BackingField_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CdllNameU3Ek__BackingField_0), (void*)L_0);
		return;
	}
}
// System.String DLLLoadCfg::get_dllName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DLLLoadCfg_get_dllName_mD6527A4807214DFA6C2D8B3433D6F5E8970C29AF (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, const RuntimeMethod* method) 
{
	{
		// public string dllName { private set; get; }
		String_t* L_0 = __this->___U3CdllNameU3Ek__BackingField_0;
		return L_0;
	}
}
// System.Void DLLLoadCfg::set_afterLoadeAction(System.Action`1<System.Reflection.Assembly>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DLLLoadCfg_set_afterLoadeAction_m5CB3AAA18A5E21B0B6EBBE781CD34E220989E55D (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* ___0_value, const RuntimeMethod* method) 
{
	{
		// public Action<Assembly> afterLoadeAction { private set; get; }
		Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* L_0 = ___0_value;
		__this->___U3CafterLoadeActionU3Ek__BackingField_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CafterLoadeActionU3Ek__BackingField_1), (void*)L_0);
		return;
	}
}
// System.Action`1<System.Reflection.Assembly> DLLLoadCfg::get_afterLoadeAction()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* DLLLoadCfg_get_afterLoadeAction_mB4A28D8DB7D6B13E7D38FCB58EF6FDD158618694 (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Assembly> afterLoadeAction { private set; get; }
		Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* L_0 = __this->___U3CafterLoadeActionU3Ek__BackingField_1;
		return L_0;
	}
}
// System.Void DLLLoadCfg::.ctor(System.String,System.Action`1<System.Reflection.Assembly>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DLLLoadCfg__ctor_mCA33D02A1FC6F36347FB9397AB4C237F02248DE5 (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, String_t* ___0_name, Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* ___1_cb, const RuntimeMethod* method) 
{
	{
		// public DLLLoadCfg(string name, Action<Assembly> cb = null)
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		// dllName = name;
		String_t* L_0 = ___0_name;
		DLLLoadCfg_set_dllName_m148E67557E56757C2C0EB820F8A2A9051DB91C27_inline(__this, L_0, NULL);
		// afterLoadeAction = cb;
		Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* L_1 = ___1_cb;
		DLLLoadCfg_set_afterLoadeAction_m5CB3AAA18A5E21B0B6EBBE781CD34E220989E55D_inline(__this, L_1, NULL);
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AOTGenericReferences::RefMethods()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AOTGenericReferences_RefMethods_mB171E62645FD26D4941B482E0BE0AC950775DA9B (AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07* __this, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void AOTGenericReferences::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AOTGenericReferences__ctor_mD5103A2C4494134F4C1EA26BA272D6CF42FFF29C (AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
// System.Void AOTGenericReferences::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AOTGenericReferences__cctor_mFFC2EDD272C2DB0617334BCD54345404E2BC71D7 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0B34DFC38793BF0AF6DEA9A94F7CCB4150E999A6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4C43361A0A500CC6B80443746394A4C1D19915BD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC7E9DAF844B25471D821CB8F094AE5423C2EECC4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE55DA8BFEECF6A3A4DBF25AE911B7F07FF3F8FC6);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
		// {
		//     "Newtonsoft.Json.dll",
		//     "UnityEngine.AssetBundleModule.dll",
		//     "UnityEngine.CoreModule.dll",
		//     "mscorlib.dll",
		// };
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_0 = (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*)il2cpp_codegen_object_new(List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E(L_0, List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E_RuntimeMethod_var);
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_1 = L_0;
		NullCheck(L_1);
		List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline(L_1, _stringLiteral4C43361A0A500CC6B80443746394A4C1D19915BD, List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_2 = L_1;
		NullCheck(L_2);
		List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline(L_2, _stringLiteralE55DA8BFEECF6A3A4DBF25AE911B7F07FF3F8FC6, List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_3 = L_2;
		NullCheck(L_3);
		List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline(L_3, _stringLiteralC7E9DAF844B25471D821CB8F094AE5423C2EECC4, List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_4 = L_3;
		NullCheck(L_4);
		List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline(L_4, _stringLiteral0B34DFC38793BF0AF6DEA9A94F7CCB4150E999A6, List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		((AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_StaticFields*)il2cpp_codegen_static_fields_for(AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_il2cpp_TypeInfo_var))->___PatchedAOTAssemblyList_4 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&((AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_StaticFields*)il2cpp_codegen_static_fields_for(AOTGenericReferences_t3CAEC7642DCDEC219668C72029DD25EAE01E9F07_il2cpp_TypeInfo_var))->___PatchedAOTAssemblyList_4), (void*)L_4);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void BasicPathHelper_set_StreamingAssetsPathForWWW_m1F8666EFCE6E652B75EDD04E2AF96B4C780D4176_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string StreamingAssetsPathForWWW { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CStreamingAssetsPathForWWWU3Ek__BackingField_2 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CStreamingAssetsPathForWWWU3Ek__BackingField_2), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void BasicPathHelper_set_StreamingAssetsPath_mCC68EBF42A8BD1F4F2CE6936C1759E42873D402B_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string StreamingAssetsPath { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CStreamingAssetsPathU3Ek__BackingField_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CStreamingAssetsPathU3Ek__BackingField_1), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void BasicPathHelper_set_PersistentDataPathForWWW_m515D13F9038D1B4FDF4D1CC202FE13A495525409_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string PersistentDataPathForWWW { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CPersistentDataPathForWWWU3Ek__BackingField_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CPersistentDataPathForWWWU3Ek__BackingField_4), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void BasicPathHelper_set_PersistentDataPath_mFF1623055A00737DF12F202805448BD53AC7AAA8_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string PersistentDataPath { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CPersistentDataPathU3Ek__BackingField_3 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CPersistentDataPathU3Ek__BackingField_3), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* BasicPathHelper_get_PersistentDataPath_m635AAA65829247BC830D094C259535A738A76D38_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) 
{
	{
		// public string PersistentDataPath { private set; get; }
		String_t* L_0 = __this->___U3CPersistentDataPathU3Ek__BackingField_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* BasicPathHelper_get_StreamingAssetsPathForWWW_m4C98CA0009E40636A5C78F43E2141D7922E5D764_inline (BasicPathHelper_t00D74A224F1FC5C2117D34974EA633913358908E* __this, const RuntimeMethod* method) 
{
	{
		// public string StreamingAssetsPathForWWW { private set; get; }
		String_t* L_0 = __this->___U3CStreamingAssetsPathForWWWU3Ek__BackingField_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DLLLoadCfg_get_dllName_mD6527A4807214DFA6C2D8B3433D6F5E8970C29AF_inline (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, const RuntimeMethod* method) 
{
	{
		// public string dllName { private set; get; }
		String_t* L_0 = __this->___U3CdllNameU3Ek__BackingField_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* DLLLoadCfg_get_afterLoadeAction_mB4A28D8DB7D6B13E7D38FCB58EF6FDD158618694_inline (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, const RuntimeMethod* method) 
{
	{
		// public Action<Assembly> afterLoadeAction { private set; get; }
		Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* L_0 = __this->___U3CafterLoadeActionU3Ek__BackingField_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DLLLoadCfg_set_dllName_m148E67557E56757C2C0EB820F8A2A9051DB91C27_inline (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, String_t* ___0_value, const RuntimeMethod* method) 
{
	{
		// public string dllName { private set; get; }
		String_t* L_0 = ___0_value;
		__this->___U3CdllNameU3Ek__BackingField_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CdllNameU3Ek__BackingField_0), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DLLLoadCfg_set_afterLoadeAction_m5CB3AAA18A5E21B0B6EBBE781CD34E220989E55D_inline (DLLLoadCfg_t2EF422011F1163C64D80D9FC7F065A3A3788A6C4* __this, Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* ___0_value, const RuntimeMethod* method) 
{
	{
		// public Action<Assembly> afterLoadeAction { private set; get; }
		Action_1_tD76BD77292550C8F1AD2DFC58127EE5587545B42* L_0 = ___0_value;
		__this->___U3CafterLoadeActionU3Ek__BackingField_1 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___U3CafterLoadeActionU3Ek__BackingField_1), (void*)L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_mF2422B2DD29F74CE66F791C3F68E288EC7C3DB9E_gshared_inline (Action_1_t6F9EB113EB3F16226AEF811A2744F4111C116C87* __this, RuntimeObject* ___0_obj, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___0_obj, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Enumerator_get_Current_m6330F15D18EE4F547C05DF9BF83C5EB710376027_gshared_inline (Enumerator_t9473BAB568A27E2339D48C1F91319E0F6D244D7A* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0 = (RuntimeObject*)__this->____current_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___0_item, const RuntimeMethod* method) 
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_1 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_6 = V_0;
		int32_t L_7 = V_1;
		RuntimeObject* L_8 = ___0_item;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (RuntimeObject*)L_8);
		return;
	}

IL_0034:
	{
		RuntimeObject* L_9 = ___0_item;
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
