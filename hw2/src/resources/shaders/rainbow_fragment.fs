#version 330

in vec2 outTexCoord;
in vec3 frontColor;

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
	vec4 baseColour = vec4(material.colour, 1.0);
	
	float indexSum = floor(outTexCoord.x*float(21.0));
	float index = mod(indexSum, 6.0);
	vec4 red = vec4(1.0,0.0,0.0,1.0);
	vec4 orange = vec4(1.0,0.5,0.0,1.0);
	vec4 yellow = vec4(1.0,1.0,0.0,1.0);
	vec4 green = vec4(0.0,1.0,0.0,1.0);
	vec4 blue = vec4(0.0,0.0,1.0,1.0);
	vec4 violet = vec4(1.0,0.5,1.0,1.0);
	
	vec4 color = vec4(0.0,0.0,0.0,0.0);
	if(index==0)
		color = red;
	else if(index==1)
		color = orange;
	else if(index==2)
		color = yellow;
	else if(index==3)
		color = green;
	else if(index==4)
		color = blue;
	else
		color = violet;
	fragColor = color * vec4(frontColor, 1.0);
}