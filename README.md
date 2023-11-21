# Prog7312-POE-FINAL
# PROG7312_POE_PART3

# Dewey Decimal Library

Author: Kyle Newmark (ST10081895)

## Table of Contents
1. [Overview](#overview)
2. [Project Structure](#project-structure)
3. [Building and Running](#building-and-running)
4. [Improvements](#improvements)
5. [Game Updates](#game-updates)
6. [Requirements](#requirements)
7. [How to Use](#how-to-use)
8. [License](#license)

## Overview

This is a Dewey Decimal Library application that features various educational games and utilities related to the Dewey Decimal Classification system. The project combines both fun and functionality while focusing on code quality and user experience.

## Project Structure
The project is organized into several logical sections, including code for games, utilities, models, and other components. Efforts have been made to improve code quality and user experience.

### Game Logic

#### Sorting Call Numbers

In the `SortingCallNumbers` game, players arrange call numbers in the correct order while enjoying an engaging experience. We've streamlined the game logic to ensure a smooth and immersive user interaction.

#### Identifying Areas

The `IdentifyingAreas` game challenges players to match call numbers with their respective subject areas in an enjoyable and educational way. Code has been refactored for readability and consistency.

#### Finding Call Numbers

In the `FindingCallNumbers` game, players find call numbers based on subject descriptions, creating an exciting learning experience. We've addressed deep nesting and improved code quality.

#### Replacing the Books

The `ReplacingTheBooks` game tasks players with generating and sorting call numbers, making the learning process more interactive and fun. We've enhanced the naming conventions and commenting for better code understanding.

### Utilities

#### JSON File Utility

The `JsonFileUtility` class provides methods for managing JSON files, enhancing data storage and retrieval in various games. We've ensured code consistency and improved error handling.

#### Game Converter

The `GameConverter` class helps convert data models for game usage, providing a more structured approach to data manipulation.

#### Score System

The `ScoreSystem` class calculates scores for different games based on specific criteria, ensuring a fair and enjoyable gaming experience.

### Models

Various model classes have been thoughtfully designed to represent different game entities, fostering code consistency and clarity.

- `ModelHighScore`: Represents high score entries with usernames and scores.
- `ModelIdentifyingCallNos`: Represents key-value pairs for call numbers and their descriptions.
- `DeweyPair`: Represents Dewey Decimal Classification pairs with numbers and descriptions.
- `DeweyPairGameModel`: Represents Dewey Decimal Classification pairs for games.
- `TreeGameLevel`: Represents game levels with different options for call numbers.

### Other

The `Global` class serves as a central repository for various game-related properties and flags. It's used to store information about game settings, user details, and collections of game data, resulting in a more organized and efficient application.

## Building and Running

To build and run the Dewey Decimal Library project, follow the steps below:

### Initializing from ZIP File

1. Download the ZIP file containing the project.
2. Extract the contents to your preferred location.

### Initializing from GitHub

1. Clone the project repository from GitHub using the following command: https://github.com/Kylenewmark1/Prog7312-POE-FINAL
2. Navigate to the project directory:

3. Open the project in your preferred C# development environment.

4. Build and run the project following your development environment's instructions.

## Improvements

Efforts have been made to improve various aspects of the project:

- Code quality: Code has been refactored to reduce deep nesting and improve readability.
- User experience: The games are designed to be enjoyable and educational.
- Naming conventions: We've enhanced naming consistency for better code understanding.
- Commenting: We've improved comments for code documentation and maintainability.

## Game Updates

In Parts 1 and 2 of the project, the following requirements have been added:

1. Enable the Identifying areas task.
2. When the user chooses the Identifying areas task, they should be presented with a user interface where they will match two columns: call number (top level only) and description.
3. The user shall be allowed to answer as many questions as they want to.
4. The questions should alternate between matching descriptions to call numbers and call numbers to descriptions.
5. Each question should have four randomly selected items in the first column, and seven possible answers (three of which are incorrect) in the second column.
6. Implement a gamification feature to motivate users to keep using the application. You may use the same one as before or choose to implement a different one.

*Note: A question in this context is defined as the whole matching the columns set, including both columns.

### Technical Requirements:

1. Store the call numbers and their descriptions in a dictionary.

## Requirements

The following requirements must be added to the application created in Part 1:

1. Enable the Identifying areas task.
2. When the user chooses the Identifying areas task, they should be presented with a user interface where they will match two columns: call number (top level only) and description.
3. The user shall be allowed to answer as many questions* as they want to.
4. The questions should alternate between matching descriptions to call numbers and call numbers to descriptions.
5. Each question should have four randomly selected items in the first column, and seven possible answers (three of which are incorrect) in the second column.
6. Implement a gamification feature to motivate users to keep using the application. You may use the same one as before or choose to implement a different one.

*Note: A question in this context is defined as the whole matching the columns set, including both columns.

### Technical Requirements:

1. Store the call numbers and their descriptions in a dictionary.

Please ensure to add this content to your project repository in the "Requirements" section of the README.

## How to Use

1. Build and run the project following the instructions provided above.

2. Launch the Dewey Decimal Library application.

3. Navigate through the available games and tasks using the provided user interface.

4. Enjoy the educational games and gamification features included in the application.

## License

This Dewey Decimal Library project is open-source and available under the [MIT License](LICENSE).
