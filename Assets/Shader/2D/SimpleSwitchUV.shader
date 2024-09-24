//按照某个方向切换UV
Shader "2DFx/SimpleSwitchUV"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _LineCount ("line count", Integer) = 1
        _RowCount ("row count", Integer) = 1
        _SwitchTime ("switch time", Float) = 0.1
    }
    SubShader
    {
		LOD 0

        Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" "PreviewType"="Plane" "CanUseSpriteAtlas"="True" }

		Cull Off
		Lighting Off
        ZWrite On
        ZTest LEqual
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            int _LineCount;
            int _RowCount;
            float _SwitchTime;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);

                float offset = floor(fmod(_Time.x * _SwitchTime, _LineCount * _RowCount));
                //offset = u + v * _RowCount
                float offset_u = fmod(offset, _RowCount);
                float offset_v = (offset - offset_u) / _RowCount;
                
                float2 uv = float2(v.uv.x / _RowCount, v.uv.y / _LineCount + (_LineCount - 1.0)  / _LineCount );
                uv.x += offset_u * 1 / _RowCount;
                uv.y -= offset_v * 1 / _LineCount;

                o.uv = uv;
                return o;
            }

            sampler2D _MainTex;

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);
                return col;
            }
            ENDCG
        }
    }
}
