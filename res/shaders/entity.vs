#version 400 core

in vec3 position;

uniform mat4 transform;
uniform mat4 view;
uniform mat4 projection;

out vec2 tex;

void main(void){
    vec4 world_position=transform*vec4(position.xy,0.0,1.0);
    vec4 to_cam_position=view*world_position;
    gl_Position=projection*to_cam_position;
    tex=gl_Position.xy;
}