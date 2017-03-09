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
//uniform sampler2D texture_sampler;

void main()
{
	vec4 baseColour = vec4(material.colour, 1);
	fragColor = vec4(frontColor, 1)*baseColour;
}