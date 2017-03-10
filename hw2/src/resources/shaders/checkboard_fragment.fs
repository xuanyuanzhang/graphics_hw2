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
	//ivec2 size = textureSize(texture_sampler,0);
	vec4 baseColour = vec4(material.colour, 1.0);
    
	float indexSum = floor(outTexCoord.x*float(20.0)) + floor(outTexCoord.y*float(20.0));
	bool isEven = mod(indexSum,2.0) == 1.0;
	vec4 evenGrid = vec4(0.0,0.0,0.0,1.0);
	vec4 oddGrid = vec4(1.0,1.0,1.0,1.0);
	fragColor = ((isEven) ? evenGrid : oddGrid) * vec4(frontColor, 1.0);
	//fragColor = baseColour * vec4(frontColor, 1.0);
}