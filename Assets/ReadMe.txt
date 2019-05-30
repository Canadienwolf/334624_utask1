



Double trigger platforms with door:
I added in two cubes that i am using as the jum pads, they start out with the color of gray
If triggered, then they become cyan. They will stay this color for the duration of the timer until they then turn back to gray.
The door will also be instantiated again once the platforms become gray again.

JumpPadsAutomatic:
I made an empty gameobject which i renamed to JumpPadsAutomatic 1.
Then i made two empty gameobjects which i made childs of JumpPadsAutomatic, and called them A and B which are referring to the different platforms
Then i placed two cubes as childs in A and B and called the "Platform", and these are the platforms that you are able to stand on.
On the gameobject i put a script called JumpPadTrigger_01 that is the one that decides how far you will, how fast and where you are supposed to go to. 
More explanation of the codes is inside the script itself.

JumpPadsManual:
When i made the manual jump pad, i used a pressure pad like with the door. When this pad is active, then it will activate the scripts that carries you over to the next platform.
But if you wait for too long, then this platform will deactivate and you will have to go and activate the pressure plate again.
Else the script will not be told to carry you over to the next platform.
