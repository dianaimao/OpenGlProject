#version 330 core
out vec4 FragColor;
in vec3 ourColor;

uniform vec4 ourColor4;
void main()
{
    FragColor = vec4(ourColor4.x+ourColor.x,ourColor4.y+ourColor.y,ourColor4.z+ourColor.z,1.0);
}