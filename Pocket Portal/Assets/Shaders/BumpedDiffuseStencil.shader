// Unity built-in shader source. Copyright (c) 2016 Unity Technologies. MIT license (see license.txt)

Shader "Custom/Bumped Diffuse Stencil Filter" {
Properties {
    _Color ("Main Color", Color) = (1,1,1,1)
    _MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
    _BumpMap ("Normalmap", 2D) = "bump" {}

    [Enum(Equal,3,NotEqual,6)] _StencilTest ("Stencil Test",int) = 6
}

SubShader {
    Tags {"Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent"}
    LOD 300

    Stencil{
            Ref 1
            Comp [_StencilTest]
        }

CGPROGRAM
#pragma surface surf Lambert alpha:fade

sampler2D _MainTex;
sampler2D _BumpMap;
fixed4 _Color;

struct Input {
    float2 uv_MainTex;
    float2 uv_BumpMap;
};

void surf (Input IN, inout SurfaceOutput o) {
    fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
    o.Albedo = c.rgb;
    o.Alpha = c.a;
    o.Normal = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap));
}
ENDCG
}

FallBack "Legacy Shaders/Transparent/Diffuse"
}
