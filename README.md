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

### W4
(Table 2)

In line 5 of the code we are making a new mmber variable titled "_movespeed_" this variable is created as a float and it's value is set to 1.0

line 22 declares a new variable under Update (), this  member varaible is a float titled "translation" and we are setting it to change the vertical soeed of the player by multiplying "_movespeed_" with Time.Delta. 

Finally in Line 25, we are calling the method in order for it to actually work. (0,0, translation) are the arguments for the method.

In Class Activity part 2
1. What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?
For the Colliders of the Cat, Goal and Soccerball, it was the cat and the ball that require rigidbodies due to the fact that both objects require physics; the cat needs to be able to move and knock into the ball where as the ball needs to be able to bounce, move, and also be able to touch and interact with the cat. The 
goal doesn't require a rigid body since it is a stable still object. However, the Goal requires the Is Trigger checked because it is simply a zone, a collider that isn't physical that the ball enters and collides with, different from the cat that needs physical collision.

2. IF your game did not work perfectly the first time you tested it, talk about what you had to fix.
Some issues I faced doing this activity was that I realized I was putting the colliders in the "kitty" peice inside of the Cat object which didn't show in the game when it ran and didn't actually put colliders on the cat, so I made sure to change that. Other than that, my cat was also just flipping and the screen was rotating in circles so I made sure to freeze the rotation for the X and Z axis of the cat. 
 

 ### W5
 (table 2)

 Collaborative Learning:
 A question that came up was: "What is the difference between class object and Gameobject variable"
The answer of this question was that the  gameobject variable is used to identify anything within a class, it helps identify a tag or name within a class/game object.

Another question that occured was: "What is the difference between the transform() and a Vector3?"
The answer that we came up with was that Transform is the proper class/component that stores Vector3 parts within itself, if we want to use vector3 we use transform().

Programming:
First create the DeerW5 Class, must be a monobehavior since it requires tuning, as well as the variables such as it
s move speed and turn speed since those are variables that play with physics and will get th deer to move. These variables, similar to the one in the Cat script should be SerealizedFields and be private floats. Finally Within the class we must use methods such as Start() to activate the movement and the deers functions, Transform() since it is needed to tune the direction in whichn the deer moves and maybe a Collider Component methods since we are required to make the dear hit a certain target. 

Updated plan notes:
Need to make a variable that will allow us to attach a target to the Deer script. 

### W6 
Team #2
{For our table's document I worked on specifically the Math Section}(https://docs.google.com/document/d/1g257orHX8bQNaC57k1DMqCDIpAd95jDwpQPqJiA4ks8/edit?usp=sharing)

Coding Notes:
Variables Needed/Variable Functions:
Need a member variable for the bats that also need to be an array that has Bat6 Components (Utilize SerealizeField)
(all bats needed in the scene)

Bat class needs a speed variable that can be tuned as well as a stop and go method that identifies when the bats are moving or not?

bats require a for loop function that allows the bats to chase the character or Stop. 

Need a message member variable that is also an array, should have different variety of messages that can be sent to the game and said to the character


Methods needed:
Start()? In order to activate the loops/classes
Update()? To include the statements in the class/component. 
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 