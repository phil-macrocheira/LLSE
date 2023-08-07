# LLSE
Professor Layton London Life Save Editor

This is a save editor for _Professor Layton's London Life_, a small life sim side game found within the DS game _Professor Layton and the Last Specter_. This side game was only included in the North American and Japanese versions of the game, not the European version, _Professor Layton and the Spectre's Call_.

In its current form, the program is unfortunately not yet able to actually _edit_ a save file beyond updating the checksum, but it is able to read a variety of data. This program is in early alpha and requires a lot of research and development to make even the simplest features work properly.

If you wish to contact me about this project, you can message me on discord at phil_macrocheira.

RESTRICTIONS:
- You MUST have all ongoing and grapevine quests completed for the day, even if you have cleared them before. In other words, the list of available or ongoing quests must be empty. The save editor WILL NOT work otherwise due to these quests being dynamically allocated and unpredictably sized.
- This goes with the first restriction, but you must have completed the first 5 or so beginning story quests.
* If you have met both of these criteria and the program still does not work for you, please let me know so I can research any potential unknown variations in save files.

Current Features:
- Updates save file with a valid checksum
- Reads the current date
- Reads the player's max happiness, wealth, gender, skin tone, expression, hairstyle, and hair color
- Reads the player's roommate and room items (May not work with houses larger than beginning size)

Planned Features:
- Edit current date
- Read and edit all player data, including name, max happiness, current happiness, wealth, trait, birthday, gender, skin tone, expression, hairstyle, and hair color
- Render an image of the player from player data and clothing data
- Edit player's equipped clothes
- Read player's room size and read data from all house sizes
- Grid that displays position of room items
- Edit roommate and room items, with a grid that allows the user to move items.
- Read list of completed quests and edit which ones are complete.
- Read and edit player's inventory
- Ability to trigger WFC exclusive content

Data:
- Item, Actor, and Quest List Spreadsheet:
https://docs.google.com/spreadsheets/d/18VAszsjBwVjmHgC-I11Us80n1CBJWbdnRHqUrTmsAYk

- Memory Documentation Spreadsheet:
https://docs.google.com/spreadsheets/d/1i6eGxmilNdZDjEHSeXeuchBsOfNLQ0zsw5KtZnshNNE
