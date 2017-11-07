﻿// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'
//5.3.4+ unity_ObjectToWorld
//5.3.7- _Object2World
Shader "CustomSkin"
{
	Properties
	{
		_Color("Main Color", Color) = (1, 1, 1, 1)
		
		_MainTex("Diffuse", 2D) = "white" {}
		_FalloffSampler("Falloff Control", 2D) = "white" {}
		_RimLightSampler("RimLight Control", 2D) = "white" {}
	}

	SubShader
	{
		Tags
		{
			"RenderType" = "Opaque"
			"Queue"      = "Geometry"
			"LightMode"  = "ForwardBase"
			"IngoreProjector" = "True"
			"ForceNoShadowCasting"="True"
		}
		
		Pass
		{
			ZTest LEqual
			ZWrite On
			Cull Back

			CGPROGRAM
			#pragma multi_compile_fwdbase
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"
			#include "AutoLight.cginc"

			//#define ENABLE_CAST_SHADOWS

			// Material parameters
			float4 _Color;
			float4 _LightColor0;
			float4 _MainTex_ST;

			// Textures
			sampler2D _MainTex;
			sampler2D _FalloffSampler;
			sampler2D _RimLightSampler;

			// Constants
			#define FALLOFF_POWER 1.0
			// Structure from vertex shader to fragment shader
			struct v2f
			{
				float4 pos    : SV_POSITION;
				float3 normal : TEXCOORD0;
				float2 uv     : TEXCOORD1;
				float3 eyeDir : TEXCOORD2;
				float3 lightDir : TEXCOORD3;
			};

			// Float types
			#define float_t  half
			#define float2_t half2
			#define float3_t half3
			#define float4_t half4

			// Vertex shader
			v2f vert(appdata_base v)
			{
				v2f o;
				o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
				o.uv = TRANSFORM_TEX(v.texcoord.xy, _MainTex);
				o.normal = normalize(mul(unity_ObjectToWorld, float4_t(v.normal, 0)).xyz);

				// Eye direction vector
				float4_t worldPos = mul(unity_ObjectToWorld, v.vertex);
				o.eyeDir = normalize(_WorldSpaceCameraPos - worldPos);

				o.lightDir = WorldSpaceLightDir(v.vertex);
				return o;
			}

			// Fragment shader
			float4 frag(v2f i) : COLOR
			{
				float4_t diffSamplerColor = tex2D(_MainTex, i.uv);

				// Falloff. Convert the angle between the normal and the camera direction into a lookup for the gradient
				float_t normalDotEye = dot(i.normal, i.eyeDir);
				float_t falloffU = clamp(1 - abs(normalDotEye), 0.02, 0.98);
				float4_t falloffSamplerColor = FALLOFF_POWER * tex2D(_FalloffSampler, float2(falloffU, 0.25f));
				float3_t combinedColor = falloffSamplerColor.rgb * diffSamplerColor.rgb;// lerp(diffSamplerColor.rgb, falloffSamplerColor.rgb * diffSamplerColor.rgb, falloffSamplerColor.a);

				// Rimlight
				float_t rimlightDot = saturate(0.5 * (dot(i.normal, i.lightDir) + 1.0));
				falloffU = saturate(rimlightDot * falloffU);
				//falloffU = saturate( ( rimlightDot * falloffU - 0.5 ) * 32.0 );
				falloffU = tex2D(_RimLightSampler, float2(falloffU, 0.25f)).a;
				float3_t lightColor = diffSamplerColor.rgb * 0.5; // * 2.0;
				combinedColor += falloffU * lightColor;

				

				return float4_t(combinedColor, diffSamplerColor.a) * _Color * _LightColor0;
			}
			ENDCG
		}
	}

	FallBack "Diffuse"
}
