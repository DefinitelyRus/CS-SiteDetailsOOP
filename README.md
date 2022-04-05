# InfoApp
This app is made to display the About Us, Rules, and Rating sections of a would-be restaurant. It features a simple and easy-to-use UI with very little setup required (not yet implemented).

## Hardware and Software requirements
**There are no definitive minimum spec requirements to run this project. The listed specs are NOT the required specs.** However, this project was made and tested on Windows 10 Home Single-language v21H2 64-bit running on the specs listed below.
- AMD Ryzen 7 4800H 8-core
- RTX 3050 Mobile 4GB vRAM
- 8GB dRAM

**Any modern machine, even of much lower spec, can run this project**, as long as the OS matches or is newer than Windows 10 v21H2. Even then, it could be assumed that this project will also run just fine on Windows 7 and most versions succeeding it, including Windows 11. Linux and MacOS emulation compatibility is not guaranteed.

**TL;DR**: If your device is running Windows 8 or newer, you can run this program... probably.

## Setup process
As of version 1.0.1-beta, the app only runs in-IDE using Visual Studio 2022 with .NET Core 6.0 package installed. **If you don't already have these installed**, see [the official installation tutorial for Visual Studio 2022](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2022) and [the official installation tutorial for .NET Core 6.0](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60#install-with-visual-studio) for more info about that.

1. **Go to [the releases page](https://github.com/DefinitelyRus/CS-SiteDetailsOOP/releases)** and look for the latest version.

![image](https://user-images.githubusercontent.com/72731965/161648645-add7dfdb-c648-4e3a-8e08-34ac96f42cb6.png)

2. Within the Assets menu, **click on `Source code (zip)`**. This will download the source code for this project.

![image](https://user-images.githubusercontent.com/72731965/161649128-0f03b6f4-b20a-418f-8686-959f48ffb65b.png)

3. Go to your downloads folder, then **extract `InfoApp-1.0.0-beta.zip`**.

4. Go to the extracted folder (same name, without the `.zip`), then **open `Site Details.sln`**. This will open the solution and project in Visual Studio.

![image](https://user-images.githubusercontent.com/72731965/161649412-eba9e993-8ce2-40b6-8bad-33db9e4ea876.png)

5. **Click on the "Site Details" button next to a green triangular arrow.** This will build the project and will generate necessary files to run the program. This will then run the program, assuming everything works as expected. If the program fails to run during this process, contact me directly and provide a screenshot of the issue.

![image](https://user-images.githubusercontent.com/72731965/161649852-887ac96a-0132-45cd-8a28-813043e8a351.png)

6. **Close Visual Studio and reopen `Site Details.sln`.** You can now run the program by pressing the same button (see step 5).

## How to use
![image](https://user-images.githubusercontent.com/72731965/161677495-26378af7-758f-483d-9339-874ac0f77190.png)

The use of this application is not linear and is an almost fully read-only experience; there is no real need for instructions. Regardless, here are some basics:

There are 3 tabs you can swap between: "About Us", "Rules, and "Rate Us".

![image](https://user-images.githubusercontent.com/72731965/161677612-28941d23-e3dd-4fdd-b8ed-d925a01e4d9d.png)

The first 2 tabs both only display a text box with different contents, both of which are self-explanatory.

The 3rd tab hides the text box and displays 5 buttons for rating and 1 for submit. Clicking any of the 5 buttons do nothing. Clicking the submit button will display popup message and does nothing else.

![image](https://user-images.githubusercontent.com/72731965/161677715-ecba65dd-c28b-4e65-bb7a-c58294eebe80.png)
![image](https://user-images.githubusercontent.com/72731965/161677763-3b3c10c1-c000-4f7c-b807-ddb2302ecfc3.png)

## Difficulties
(All listed here are written in the perspective of a would-be beginner and is not representative of actual difficulties experienced during development.)

Getting used to OOP was confusing at first but I got over it once it became clear to me what its purpose is. Making the rules tab display different content is also hard to work around. There was no clear way to do it other than to use regular windows tabs which doesn't look good for my purposes. I also had trouble making the UI look good, since the designer is apparently not intended for good looks, but rather for simplicity and function.
