
# MacroDeck WebView Tray Applet

 - Small applet that pops up a window with MacroDeck's Web Client, for easy access to macros right from your system tray.

# Installing (Self Compile)

    - Clone the Repository
    - Compile it with Visual Studio
    - Run the Project

# Installing (Pre-compiled)

    - Click on Resources link to the right
    - Download latest .zip file
    - Extract to a location of your choice
    - Run `MacroDeck WebView.exe`

# How to Use

- When Running, an icon will appear in your system tray
- Click icon to open a window with MacroDeck's web client
  - By default, it will auto connect to ws://127.0.0.1:8191. If you are running MacroDeck on a different port or different computer, update the WSURL in `App.config` (or `MacroDeck WebView.exe.config` in the compiled project)
- Clicking off of WebView window will automatically hide the window
- Click tray icon again to show

* Only works in Windows Systems (7, 10) and Windows Servers 2012 and After (because it's based on windows Forms).
