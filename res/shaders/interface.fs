#version 400 core

in vec2 tex_coord;

uniform sampler2D tex;

out vec4 out_color;

void main(void){

    out_color=texture(tex,tex_coord);
}