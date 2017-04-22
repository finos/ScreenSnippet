# ScreenSnippet
Screen snipping utility for Windows. Allows user to draw a rectangular region on the screen and save output to given file.

Note: application requires .NET 3.5 framework (or higher).

# Command line:
ScreenSnippet.exe filename
(filename where the saved jpeg output will go)

Application will abort snippet and close if esc is pressed.

# Dev Env Notes:
preinstall script in package.json will build release version of package.  MSBuild.exe must be in path to build.  MSBuild.exe is available when installing Visual Studio.  Has been tested with Visual Studio 2007 Community Edition.
