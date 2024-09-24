Shader "2DFx/AlphaDisslove"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _NoiseTex ("NoiseTex for offset", 2D) = "white" {}
        _PlayAmount ("play amount", Range( 0 , 1)) = 0.0
        _ClampNum ("ClampNum", Range( 0 , 1)) = 0.0
        [Toggle]_Enhance("Enhance", Float) = 1
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

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _MainTex;
            sampler2D _NoiseTex;//for disslove offset
            float _PlayAmount;
            float _ClampNum;
            float _Enhance;

            fixed4 frag (v2f i) : SV_Target
            {
                // fixed2 noiseUV = fixed2(floor(i.uv.x * _BlockInfo.x) / _BlockInfo.x, floor(i.uv.y * _BlockInfo.y) / _BlockInfo.y);
                fixed4 col = tex2D(_MainTex, i.uv);
                float a = 2 / (1 - _ClampNum);
                float b = - (a * (1 + _ClampNum)) / 2;
                float alpha_add = _PlayAmount * a + b;

                fixed4 noiseCol = tex2D(_NoiseTex, i.uv);
                float noise2alpha = (_Enhance)?(pow(1 - noiseCol.g,5)):(1 - noiseCol.g);
                col.a *= clamp((1 - alpha_add - noise2alpha), 0.001 , 1.0);
                return col;
            }
            ENDCG
        }
    }
}
