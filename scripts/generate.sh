#!/bin/sh
ffmpeg -t 0.02 -f lavfi -i color=c=black:s=1920x1080 -c:v vp8 -pix_fmt yuv420p TWLogo_and_Partners.ivf
ffmpeg -f lavfi -i anullsrc -t 0.02 -c:a libvorbis TWLogo_and_Partners.ogg

ffmpeg -t 0.02 -f lavfi -i color=c=black:s=1920x1080 -c:v libx264 -pix_fmt yuv420p TWLogo_and_Partners.mp4