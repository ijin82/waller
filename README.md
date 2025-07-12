# Waller
Simple utility to change wallpaper on your desktop using Windows task scheduler and timer set up

# How is that working?
- Set up folder with your wallpaper files
- Set up mask for your wallpaper files in folder
- Set up wallpaper rotation time interval
- Create task in scheduler (GUI has button for that purpose)

Windows scheduler will call this app with argument to call function of random wallpaper set up. 
Check out details of sheduled task to understand details.

![2021-10-11_12-44-28](https://user-images.githubusercontent.com/612918/136777600-26c68541-5d37-4a97-838d-8f8d72312186.png)

In case you want to change wallpaper from your favorites folder by click without timer/scheduler  
you can use waller like this (shortcut call, for example):

```text
D:\Applications\Waller\Waller.exe --set-wall --force
```
