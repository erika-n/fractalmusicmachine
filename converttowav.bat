cd "C:\Users\Erika\Documents\Sound recordings"
ffmpeg -y -i "%~1.m4a" "%~1.wav"
pause