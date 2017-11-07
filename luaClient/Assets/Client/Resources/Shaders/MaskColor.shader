﻿// Unlit shader. Simplest possible colored shader.
// - no lighting
// - no lightmap support
// - no texture

Shader "Unlit/MaskColor" 
{
	Properties 
	{
		_Color ("Main Color", Color) = (1,1,1,1)
	}

	SubShader 
	{
		Tags { "RenderType"="Transparent" "IngoreProjector"="True" "Queue"="Transparent-1" }
		Blend SrcAlpha OneMinusSrcAlpha
		ZWrite off
		
		Pass 
		{  
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata_t 
			{
				float4 vertex : POSITION;
			};

			struct v2f 
			{
				float4 vertex : SV_POSITION;
			};

			fixed4 _Color;
			
			v2f vert (appdata_t v)
			{
				v2f o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : COLOR
			{
				fixed4 col = _Color;
				return col;
			}
			ENDCG
		}
	}

}