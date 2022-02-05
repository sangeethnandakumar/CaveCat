# CaveCat
Official CaveCat repository. A super simplified automation bridge

## What is CaveCat
Cave cat is a super simplified Browser automation bridge. CaveCat is designed for people with no programming experiance get there automation job done by writing a structured english text in a notepad. As simple as it is.

## Why CaveCat?
Browser automation can be done in many ways. It can be used for Testing, Data Scrapping etc..
But mostly these tasks are done by programmers in languages like C#, Java, Python etc..
What if you need to do the same but you're not a programmer?
CaveCat can help.
CaveCat exposes a english like script which didn't feel like a programming language to any beginner.
It's designed in a way that to become extreamly simple for any eye.

## How tough is to learn CaveCat script?
If you know english. You can read/write most of it.
Handling complex scenerios on script can be simplified as much as possible.
See an example below

## The CaveCat script
The CaveCat script is an english like structured script that is extreamily easy to read and understand. Highly verbose and powerfull.
An example of CaveCat script to do a quick Google Search.

```cavecat
goto 'https://www.youtube.com'
type 'Sundar Pichai' in SearchBox
click SearchBtn

[DOM]
SearchBox = (//div[@class='FPdoLc lJ9FBc']//input[@name='btnK'])
SearchBtn = (//div[@class='FPdoLc lJ9FBc']//input[@name='btnK'])
```
As simple it is. We can define elements in DOM that points to HTML elements using XPath

## Is it a CommandLine tool?
CaveCat run as an interepreter to execute CaveScript.
We can create a CaveScript with any text editors such as notepad.
For a rich CaveScript editing experiance with UI support. CaveCat IDE is released.

## Releases
v1 - Supported Commands
goto <URL> = Allows
