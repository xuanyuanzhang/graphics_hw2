#version 330

in vec2 outTexCoord;
in vec3 mvVertexNormal;
in vec3 mvVertexPos;

out vec4 fragColor;

struct Material
{
    vec3 colour;
    int useColour;
    float reflectance;
};

uniform Material material;

void main()
{
	//ivec2 size = textureSize(texture_sampler,0);
	vec4 baseColour = vec4(material.colour, 1.0);
    vec4 redTint = vec4(0.5, 0.0, 0.0, 1.0);
	
	float indexSum = floor(outTexCoord.x*float(21.0));
	float index = mod(indexSum, 6.0);
	vec4 red = vec4(1.0,0.0,0.0,1.0);
	vec4 orange = vec4(1.0,0.5,0.0,1.0);
	vec4 yellow = vec4(1.0,1.0,0.0,1.0);
	vec4 green = vec4(0.0,1.0,0.0,1.0);
	vec4 blue = vec4(0.0,0.0,1.0,1.0);
	vec4 violet = vec4(1.0,0.5,1.0,1.0);
	
	if(index==0)
		fragColor = red;
	else if(index==1)
		fragColor = orange;
	else if(index==2)
		fragColor = yellow;
	else if(index==3)
		fragColor = green;
	else if(index==4)
		fragColor = blue;
	else
		fragColor = violet;

    //fragColor = (baseColour + redTint);
}