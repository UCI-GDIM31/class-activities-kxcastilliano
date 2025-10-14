# in-class-activities
## Devlogs
### W1
Hello world

### W2
Why are the r, g, and b variables floats instead of ints, bools, or strings?
The reason why the r,g, and b variables are floats are due to the the fact that the values of the colors are determines by factoral numbers and change based off of small increments. (Adding 0.1 to any variable would still change it), 
it wouldn't make sense for them to be bools or strings since our main purpose of changing the game code is to change the value of the colors. Also, RGB values can only go from 0.0-1.0 so th euse of decimanls is necesarry.

Why is the _bounce variable an int instead of a float, bool, or string?
the bounce variable is an int instead of a float, bool or string due to the fact that we want to change the value of how much/high the ball bounces and to do so we must see the change through adding whole number values (+1)

The error you got after Step X of Part 2 told you something useful about why that line of code was broken- what was it?
After trying to process the code, the console explains that there are errors in the code that need to be fixed and can't be compiled until the errors are resolved?

### W3
Tables 1-6
You’re building a rhythm game, and you’re writing a method named DidPlayerHitBeat that tells you whether or not the player accurately hit a beat based on the time that they pressed a key.

(Table 2) For building this Rhythm game, the method would be a float in which the result is declared based on the time the player hits the beat versus the expected time that the player needs to hit in order to get the perfect accuracy. the return type would be the out come of whether or not the player met or missed the expected accuracy/beat (boolean true or false).

 come up with a metaphor to explain the relationship between classes and Components with a metaphor. Also describe how methods and member variables factor into that metaphor
Looking at this metaphorically, Components are the bottles of potions that make the potion what it is, the classes are the liquid that is stored within the potion that makes it unique and different compared to other potions and the variables are the specific ingredidents needed to create this liquid/class therefore putting it all together brings forth the component or potion. 

Why do you think the balls get extremely bright, especially in the Scene, if they bounce too many times?

Since the cod makes the ball bright with each bounce it's expected that as the ball bounces each time it's hex code gets birghter and brighter with each contact- if they're coded to be faster this mean they'bounce more and their colors will change at a quicker rate and etc.. if they jump slower the colors will change slower.
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 