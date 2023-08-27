# Cubethon Game

Cubethon is a simple and fun game made with Unity and C#. Guide your cube forward and dodge obstacles to reach the finish line.

![image](https://github.com/bozkuya/Cube_Game/assets/129911627/23e07051-2b93-44fa-b79f-33cbd2d9f88a)
![image](https://github.com/bozkuya/Cube_Game/assets/129911627/93695b30-3422-461f-a578-8fb99d85f455)
![image](https://github.com/bozkuya/Cube_Game/assets/129911627/7b05fab1-a0b9-4184-a98b-b66cf3b39ef5)



## Table of Contents

- [How to Play](#how-to-play)
- [Features](#features)
- [Getting Started](#getting-started)
- [Scripts Overview](#scripts-overview)
- [Contribute](#contribute)
- [License](#license)

## How to Play

1. Press the **'D'** key to move the cube to the right.
2. Press the **'A'** key to move the cube to the left.
3. Avoid falling! If the cube goes below platform, the game ends.
4. Reach the end trigger to complete the level.

## Features

- Smooth player movement with Rigidbody physics.
- Responsive controls with real-time force application.
- Level completion UI.
- Restart level capability upon game over.
  
## Getting Started

1. Clone the repository to your local machine.
git clone ttps://github.com/bozkuya/Cube_Game.git
2. Open the project with Unity.
3. Play and enjoy!

## Scripts Overview

1. **PlayerMovement.cs**:
    - Controls the cube's movement.
    - Applies forward and sideways forces based on user input.
    - Checks for game over condition if the cube falls off.

2. **GameManager.cs**:
    - Manages game states like level completion and game over.
    - Provides functionality to restart the game.
    - Controls the level completion UI.

3. **EndTrigger.cs**:
    - Currently a placeholder for triggering level completion (unimplemented).

## Contribute

If you'd like to contribute, please fork the repository and use a feature branch. Pull requests are warmly welcome.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
