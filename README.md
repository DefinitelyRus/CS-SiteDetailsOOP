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
Go to the release page for the specific version you're trying to install. [All version releases can be found here.](https://github.com/DefinitelyRus/InfoApp/releases)

## How to use
![image](https://user-images.githubusercontent.com/72731965/161687717-298a8008-319f-4995-978c-1bb8831d327f.png)

The use of this application is not linear and is an almost fully read-only experience; there is no real need for instructions. Regardless, here are some basics:

There are 3 tabs you can swap between: "About Us", "Rules, and "Rate Us".

![image](https://user-images.githubusercontent.com/72731965/161686835-013acee2-482f-4f0f-bda8-7b4f93b638e6.png)

The first 2 tabs both only display a text box with different contents, both of which are self-explanatory.

The 3rd tab hides the text box and displays 5 buttons for rating and 1 for submit. Clicking any of the 5 buttons will change the colors of the buttons depending on which one is clicked. Clicking the submit button will display popup message, changes the "Rate Us" label to "Thanks for rating!", makes all rating buttons unclickable, and brings the user back to the About tab. It does not store the rating data in any capacity.

![image](https://user-images.githubusercontent.com/72731965/161686941-fa4f1cfc-d47c-4039-8c33-9fb1b7216de6.png)

![image](https://user-images.githubusercontent.com/72731965/161686993-e15f6dd3-4d65-4005-bd64-3015061da7f8.png)

## Difficulties
(All listed here are written in the perspective of a would-be beginner and is not representative of actual difficulties experienced during development.)

Getting used to OOP was confusing at first but I got over it once it became clear to me what its purpose is. Making the rules tab display different content is also hard to work around. There was no clear way to do it other than to use regular windows tabs which doesn't look good for my purposes. I also had trouble making the UI look good, since the designer is apparently not intended for good looks, but rather for simplicity and function.
