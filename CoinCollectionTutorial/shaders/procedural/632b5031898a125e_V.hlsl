//*****************************************************************************
// Torque -- HLSL procedural shader
//*****************************************************************************

// Dependencies:
#include "shaders/common/torque.hlsl"

// Features:
// Vert Position
// Diffuse Color
// Reflect Cube
// HDR Output

struct VertData
{
   float3 position        : POSITION;
   float3 normal          : NORMAL;
   float3 T               : TANGENT;
   float2 texCoord        : TEXCOORD0;
};


struct ConnectData
{
   float4 hpos            : POSITION;
   float3 reflectVec      : TEXCOORD0;
};


//-----------------------------------------------------------------------------
// Main
//-----------------------------------------------------------------------------
ConnectData main( VertData IN,
                  uniform float4x4 modelview       : register(C0),
                  uniform float3x3 cubeTrans       : register(C4),
                  uniform float3   cubeEyePos      : register(C7)
)
{
   ConnectData OUT;

   // Vert Position
   OUT.hpos = mul(modelview, float4(IN.position.xyz,1));
   
   // Diffuse Color
   
   // Reflect Cube
   float3 cubeVertPos = mul(cubeTrans, IN.position).xyz;
   float3 cubeNormal = normalize( mul(cubeTrans, normalize(IN.normal)).xyz );
   float3 eyeToVert = cubeVertPos - cubeEyePos;
   OUT.reflectVec = reflect(eyeToVert, cubeNormal);
   
   // HDR Output
   
   return OUT;
}
