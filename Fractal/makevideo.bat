cd C:\\Users\Erika\Videos\FractalMusic
ffmpeg -i image_%%06d.png -c:v libx264 -pix_fmt yuv420p %1_silent.avi
ffmpeg -i test_fractal.wav -b:a 128k test_fractal.mp3
ffmpeg -i %1_silent.avi -i test_fractal.mp3 -map 0 -map 1 -codec copy -shortest %1_music.avi
pause