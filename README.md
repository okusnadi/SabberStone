<img align="left" src="/Readme/sabberstone.png">
# SabberStone

SabberStone is just another Hearthstone simulator and implementation, written in C#. The project was started in Nov'16 while trying to implement aura, buffs & triggers into Brimstone. Focused to prototype my so called onion system I created SabberStone, which is using a layer approach to handle entity changing enchantments. Since then I haven't stopped implementing day by day new cards, new tests and new stuff. I created for fun a visualisation and a scoring based tree search a.i. which can be used to play games ([SimpleUi](/SimpleUi)). If also implemented a few current decks of the "JANUARY 2017, SEASON 34", like the PirateAggroWarrior and the MidrangeJadeShaman.

By now this is a one man show, but there is still a lot of work to do, so any help is appreciated. The base code of ([Brimstone](https://github.com/HearthSim/Brimstone/tree/master/Brimstone)) was a great inspiration for this project. Big thanks to **@Pattux**, **@Patashu** & **@Katy** for helping on hearthstone super science problems ^^ You're welcome!


### Project Structure ###

* **SabberStone**

  Core simulator engine, all the functions needed for the simulator are in here. Check out the Wiki [Link](https://github.com/HearthSim/SabberStone/wiki) for informations about the core and how to use it.

* **SabberStoneUnitTest**

  UnitTest for the simulator, there is a generated test for each card in the current game.

* **SimpleTest**

  A test project to run simple codeline based games to test outcome.

* **SimpleAi**

  A test project to run A.I. simulations with predefinied decks and strategys.

* **SimpleUi**

  A test project that shows off a visual implementation of the SimpleAi project. This is probably where beginners should start looking at. There is a simple GUI which allows different decks to play against each other with different strategys. Check out the Wiki [Link] (https://github.com/HearthSim/SabberStone/wiki/SimpleUi)
  ![alt tag](/Readme/simpleui.PNG)
  ![alt tag](/Readme/deckcreator.PNG)
  
### Cards Implementation

- [x] Aura, Enchantment & Trigger
- [x] Hero, Hero Power & Weapon
- [x] Battlecry & Deathrattle
- [x] Choose One & Combo
- [x] Spell Power
- [x] Inspire, Joust & Discover
- [x] Jade Golems (Jade Lotus)
- [x] Buffing Hand (Grimy Goons)
- [x] Excess Mana
- [x] Freeze & Stealth
- [ ] Potions (Kabal)

**Basic & Classic**
* 97% Basic (142 Cards)
* 62% Classic (245 Cards)

**Adventures**
* 16% Blackrock Mountain (31 Cards)
* 51% One Night in Karazhan (45 Cards)
* 13% The League of Explorers (45 Cards)

**Expensions**
* 29% The Grand Tournament (132 Cards)
*  8% Whispers of the Old Gods (134 Cards)
* 37% Mean Streets of Gadgetzan (132 Cards)

*(Curse of Naxxrams not on focus, because not in Standard.)*

### ToDo List ###

- [x] Move SabberStone to Github
- [x] Start Wiki for SabberStone
- [ ] Fill Wiki for SabberStone

### Requirements

* Windows
  tbd

### Installation

* Windows
  tbd

### Documentation

* Wiki [Link](https://github.com/HearthSim/SabberStone/wiki)
* SimpleAi [Link](https://github.com/HearthSim/SabberStone/tree/master/SimpleAi)
* SimpleUi [Link](https://github.com/HearthSim/SabberStone/tree/master/SimpleUi)

### License

[![AGPLv3](https://www.gnu.org/graphics/agplv3-88x31.png)](http://choosealicense.com/licenses/agpl-3.0/)

SabberStone is licensed under the terms of the
[Affero GPLv3](https://www.gnu.org/licenses/agpl-3.0.en.html) or any later version.

### Community
SabberStone is beeing developed by darkfriend77 (darkfriend@swissonline.ch)
* SabberStone on [Reddit](https://redd.it/5p0ar8)
* SabberStone is a [HearthSim](http://hearthsim.info) project.
