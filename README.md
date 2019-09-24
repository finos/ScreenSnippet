# ScreenSnippet
Screen snipping utility for Windows. Allows user to draw a rectangular region on the screen and save output to given file.

Note: application requires .NET 3.5 framework (or higher).

# Command line:
ScreenSnippet.exe filename
(filename where the saved jpeg output will go)

Application will abort snippet and close if esc is pressed.

# Dev Env Notes:
preinstall script in package.json will build release version of package.  MSBuild.exe must be in path to build.  MSBuild.exe is available when installing Visual Studio.  Has been tested with Visual Studio 2007 Community Edition.

## Contributing

1. Fork it (<https://github.com/symphonyoss/ScreenSnippet/fork>)
2. Create your feature branch (`git checkout -b feature/fooBar`)
3. Read our [contribution guidelines](.github/CONTRIBUTING.md) and [Community Code of Conduct](https://www.finos.org/code-of-conduct)
4. Commit your changes (`git commit -am 'Add some fooBar'`)
5. Push to the branch (`git push origin feature/fooBar`)
6. Create a new Pull Request

_NOTE:_ Commits and pull requests to FINOS repositories will only be accepted from those contributors with an active, executed Individual Contributor License Agreement (ICLA) with FINOS OR who are covered under an existing and active Corporate Contribution License Agreement (CCLA) executed with FINOS. Commits from individuals not covered under an ICLA or CCLA will be flagged and blocked by the FINOS Clabot tool. Please note that some CCLAs require individuals/employees to be explicitly named on the CCLA.

*Need an ICLA? Unsure if you are covered under an existing CCLA? Email [help@finos.org](mailto:help@finos.org)*

# License

Copyright 2017-2019 Symphony LLC

The code in this repository is distributed under the Apache License, Version 2.0.

SPDX-License-Identifier: Apache-2.0
