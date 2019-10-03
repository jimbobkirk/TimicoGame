# TimicoGame

TimicoGame is a class library to provide the initial framework for a console based RPG.
The framework is a raw version which needs adapting to fulfill the requirements.


## Base Files

Within the framework you'll find a couple of interfaces for the generic structures of the world, including Stores and Items plus an example for both. A placeholder folder for the Player object(s), this will allow for imagination plus own development preferences to show.

The main program file shows a very poor/basic example of the console app, to view all shops in the world and to open a specific one and view it's contents.

## Requirements

To showcase your understanding and skills within C# a few requirements are set out below:

 - The game must include a playable character by default you can 'start' as this character and does not need to be chosen or created.
		 - The player must have a 'bank', to store items - with the ability to add and remove.
		 - The player must have an 'inventory' to store items - with a maximum size of 20, ability to drop and pickup/swap.
		 - The player can hold 'money' (which is an item), but can only store up to 10,000 per inventory, bank and coin pouch. Each of which you are able to add and subtract from to populate another.

- The game must include at least 1 NPC (enemy) - this could be a monster, a person, etc. depending on the level of detail, you could 'instantly' beat this monster in a fight or include a method of 'fighting' via the console.
		- The monster must have a drop table, a random choice of items and amount which can be dropped when the monster has been defeated.

- The game must include at least 1 shop - which contains a stock of items.
		- The player must be able to buy from the stock, if has enough coins to do so.
		- The player must be able to sell to the shop and receive coins.

- The game must include a decent amount of items, these can be completely random or something more genuine for the style of game. 
		- Examples could be: a sword, a bow, arrows, armor (varying levels)
		- These items would populate monster drops and the shop stocks.

- The application must have a friendly way of navigating each area, a basic example has been included where you type text for the action you wish to do though it's not the easiest or user friendly. 
		- Perhaps an autocomplete for the console would be ideal as you could open the shop without having to type the full shop name in?

- The project must have Unit Tests to ensure that the game is working as intended.

## Additional Requirements

Whilst the above is essential for a basic RPG game some ideal requirements are listed below:

- It would be nice if my progress was saved, so when I came back to the game my player was the same, including inventory, bank and progress (if skills/stats are added).
		- A big bonus would be to implement AWS (Amazon Web Services), a free trial can be made and many examples online. They offer a range of databases that would work for this simple project.
- It would be nice if there was skills, leveling up in combat when attacking monsters.
- It would be nice if I could have multiple accounts to enjoy the game in different ways, being able to choose which account to play when starting the program.
