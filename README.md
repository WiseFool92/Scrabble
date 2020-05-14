# _Scrabble_

#### May 14th, 2020

## Description

_This console application will calculate the value of a scrabble word_

_This application is already linked to a Program.cs, .csproj, & .gitignore, but will need a .NET 3.1 or 2.2 download_

## Setup/Installation Requirements

_Make sure you have [git version control](https://git-scm.com/downloads) installed on your computer._

1. Click the green 'Clone or Download' button and copy the link / download the zip
2. Open terminal and type... or skip to #4 if you downloaded the zip

**Windows**

```sh
cd desktop
```

Mac & linux

```sh
cd ~/Desktop
```

3.  in terminal type '_git clone {link to repository}_ '

```sh
git clone {link to repository}
```
4. If you downloaded the zip then extract all onto your desktop
5. Open the folder with VSC or an equivalent
6. Download .NET Core Sdk 2.2 & Run _dotnet -- version_ in the terminal to confirm installation
7. In the terminal Run _dotnet tool install -g dotnet-script_
8. Open project & Run _dotnet run_
9. Enjoy

## Specs

### Behavior Driven Development Spec List
#### Scrabble
|                          Behavior                          | Input  | Output  |
| :--------------------------------------------------------: | :----: | :-----: |
| The program will only accept string inputs | 'Albatross' | 'True' |
| The program will identify letter values | 'A, E, I, O, U, L, N, R, S, T' | '1' |
| The program will identify letter values | 'D, G' | '2' |
| The program will identify letter values | 'B, C, M, P' | '3' |
| The program will identify letter values | 'F, H, V, W, Y' | '4' |
| The program will identify letter values | 'K' | '5' |
| The program will identify letter values | 'J, X' | '8' |
| The program will identify letter values | 'Q, Z' | '10' |
| The program will accept a word and output the value | 'Cat' | '5' |

---
## Known Bugs

_N/A_ - 5/8/2020

## gh-pages

WiseFool92.github.io/scrabble

## Support

_Email: watkins92@gmail.com_

---
## Built With

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)

## Useful tools

- [free icons @ icons8](https://icons8.com/)
- [free icons @ fontawesome](https://fontawesome.com/)

---

- [Old School Gifs Search](https://gifcities.org/)
- [free images @ unsplash](https://unsplash.com/)

  - **_source.unsplash.com_ will return a random image at a desired size by simply calling the size after the url followed by a '?' and a keyword. Example below**

  - _https://source.unsplash.com/400x400/?cat_
  - http://unsplash.it/500/500 - This will just return a random image the size of 500x500

---

- [Flex-box Cheat Sheet](http://yoksel.github.io/flex-cheatsheet/)
- [CSS Grid Cheat Sheet](http://grid.malven.co/)

---

- [CSS Gradient BG Generator](https://mycolor.space/gradient)
- [CSS Basic Gradient Generator](https://cssgradient.io/)

---

- [CSS Dropshadow Generator](https://cssgenerator.org/box-shadow-css-generator.html)

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Nathan Watkins-Hoagland & Tyler Bates_**
