
# WebView Tray Applet for [Macro Deck](https://macrodeck.org)

 - Small applet that pops up a window with a WebView for Macro Deck's [Web Client](http://web.macrodeck.org). Gives easy access to your macros right from your system tray.

# Running (Self Compile)

    - Clone the Repository
    - Open .sln in Visual Studio
    - Build the Solution
    - Run the Project

# Running (Pre-compiled)

    - Click on Releases link on the right sidebar >>
    - Download latest `MacroDeckWebView.zip` file
    - Extract to a location of your choice
    - Run `Macro Deck WebView.exe`

# How to Use

- When running, an icon will appear in your system tray
- Click icon to open a window with Macro Deck's web client
  - By default, it will auto connect to `ws://127.0.0.1:8191`.
  - If you are running Macro Deck on a different port or different computer, update the WSURL in `App.config` (or `Macro Deck WebView.exe.config` in the compiled project)
- Clicking off of WebView window will automatically hide the window
- Click tray icon again to show
- Resize window to your liking, app will store it's set size & use going forward

*Only works in Windows 7-11 and Windows Servers 2012 and After (because it's based on WPF Windows Forms).*

# Screenshot
![alt text](https://github.com/emerysteele/macrodeckwebview/blob/main/MacroDeckWebView-example.png?raw=true "Screenshot 1")
