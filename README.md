# EnumDayClassifier

A C# console application that classifies days of the week as working or weekend using an enum.

## How to Run
1. Clone the repository: `git clone https://github.com/AwaIIenceCode/EnumMastery.git`
2. Open in Visual Studio or Rider.
3. Build and run the project.
4. Enter a day of the week (e.g., "Monday") to see if it’s a working day or a chill day.

## Features
- Uses an `enum` (`DayOfWeek`) to define days: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday.
- Parses user input with `Enum.TryParse` (case-insensitive, e.g., "monday" or "MONDAY" works).
- Classifies days: Monday–Friday as "Work day, good luck!", Saturday–Sunday as "Chill day, bro!".
- Handles invalid input (e.g., "Blursday") with a friendly error message.
- Displays results in the console.

## Usage Example
Welcome to the calendar tracker. Please, enter the day of week!
Monday
Work day, good luck!

Welcome to the calendar tracker. Please, enter the day of week!
Sunday
Chill day, bro!

Welcome to the calendar tracker. Please, enter the day of week!
Blursday
There is no such day of the week


## About
This project is a learning exercise to master enums in C#. It demonstrates how to use `Enum.TryParse` for user input, conditionals for logic, and enums for structured data, preparing for more advanced C# topics like OOP.

## Notes
- Case-insensitive input makes it user-friendly.
- Consider adding a loop for repeated input attempts to improve UX.
- Could be extended with additional day properties (e.g., holidays).
