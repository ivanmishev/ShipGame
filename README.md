	Task:
	Pirate wars: The game is board game with AI for opponent. At the start of the game ocean is drawn in the console with
coordinates for each zone. The player must place 2 smaller one zone ships, 2 larger two zone ships, 2 bigger 3 zones ships,
and one huge 4 zone ship. Each zone should have key bind to it, and the player should hit the keys to select the zone.
Also 3 treasure chests are placed from the computer at random. (but not on unavailable positions).
When player or computer hit a zone it can’t be hit again. Two of the treasures give a pirate captain (or computer) ability to shot again.
One of the treasures gives a special weapon that hits all zones around selected one. Each game should preserve a log in .txt
file with all moves and results from the move. In console this moves are visible by 5 lines, older must be deleted.
The game finishes when the player or computer sink all of the enemy ships.

Crucial tasks:
1. Describe business logic. Create objects.
2. Create matrix for session.
3. Create AI algorithms.
4. Draw ocean.
5. Create cursor mechanism for selecting XY coordinates.

Smaller tasks:
1. Create session log.
2. Create methods to place the ships.
3. Create method to place the chests, and bonuses methods when they are hit.
4. Create logic to secure coordinates (not to hit same filed twice). And ability to hit coordinate.
5. Create game flow in Main class.

Ocean:
	Waves ~
	ships - S
	hits - X
	treasure - T
	coordinates - A->H, I->P