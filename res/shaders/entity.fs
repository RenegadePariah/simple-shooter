#version 400 core

in vec2 tex;

uniform vec3 color;
uniform vec3 clear;
uniform vec2 orientation;
uniform float blend;
uniform float flash;
uniform float density;
uniform float min_density;

out vec4 out_color;

void main(void){
    out_color=vec4(mix(clear,color*clamp(mod(dot(tex,orientation),density)/density,min_density,1.0)*flash,blend*blend),1.0);
}