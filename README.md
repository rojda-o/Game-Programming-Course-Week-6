# Game-Programming-Course-Week-6
In the sixth week of the Game Programming course, I expanded the game mechanics by adding a "Triple Shot Power-Up" in Unity. This power-up allows the player to shoot three lasers simultaneously for a limited time, enhancing the gameplay experience.

This project demonstrates the following skills:

- Creating Triple Laser Shots: Designed a triple-shot mechanism by generating two additional laser copies, positioning them to spread outwards, and making them children of an empty GameObject.
- Developing a Triple Laser Prefab: Created a prefab for the triple-shot GameObject for easy reuse in the game.
- Power-Up Activation Logic: Programmed the logic to activate the triple-shot bonus when the player collects a specific power-up sprite.
- Power-Up Duration Control: Configured the triple-shot power-up to be active for a limited time, after which it reverts to single laser shots.
- Updating the FireLaser Function: Modified the FireLaser function to switch between single and triple shots based on the power-up status.
- Power-Up Object Setup: Created a new power-up sprite, added a Circle Collider and Rigidbody components, adjusted its scale and sorting layer, and set up movement scripts to make it move within the scene.
- Collision Detection: Added collision logic to trigger the triple-shot bonus upon the player’s collection of the power-up.
- Spawn Manager Enhancement: Updated the SpawnManager script to spawn the triple-shot power-up at random intervals.

In this project, the player collects the power-up, activates triple-shot mode for a limited duration, and returns to the standard single-shot mode afterward. This feature helped me deepen my understanding of prefabs, power-up mechanics, and coding time-limited abilities in Unity.
