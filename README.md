## I. General Requirements
You are to design and implement a zoo.

Your zoo should have a set of animals and also zoo keepers. The zoo should also support several operations needed for its proper functioning and to ensure the wellbeing of all animals.

The zoo should be able to “run”. This operation should trigger one cycle of related operations. In that cycle, the zoo keepers should feed the animals and the animals should become tired. Let’s consider that 10 cycles should also make the animals grow older.

## II. Animal Requirements
Each set of animals should be of a different type. There could be sets of mammals and birds, for example, but your zoo should be able to support not less than 4 types of animals. On the other hand, each type of animal should have not less than 3 species, for example goats are mammals. Ensure that are enough animals of each species to provoke visitors interest and not just one crocodile, named “Rick”, other wise the zoo’s evaluation will be decreased by the zoo inspector.

All animals should have name, species, birthdate, age and stamina.

Every animal also should also have a life expectancy, which is how many years we think that animal should live. The life expectancy should be equal to the difference between the average years the animal lives (do internet research) and the animal’s current age. For example, turtles live 100 years, minus the animal’s current age (27), equals a life expectancy of 73 years. When the animal’s life expectancy becomes 0, the animal is dead. There should be a way to “force” the animal to age – reduce its life expectancy and increase its age.

There should also be a way to “tire” animals, by reducing their stamina. If the animal’s stamina drops below 0, we’ll consider the animal “asleep”, or not active. The animal’s stamina diminishes during the zoo’s regular operation cycle but it may drop increasingly if the animal has not been fed. The choice on how much stamina an animal might have and how much stamina the animal should lose each operational cycle is left to you. One option is to decrease, the animal’s stamina by a certain fixed amount. The only restriction is that, if the animal has not been fed, it’s stamina is to be decreased with a higher amount, let’s say twice than the regular. We’ll get back to that later as we discuss zoo keepers and their responsibilities.

There should be an option to “create” newly born animals that have the maximum life expectancy, as well as add animals that are of a certain age, perhaps transferred from some other zoo. Each animal should be easily identifiable, maybe by keeping a tag with a unique ID number.

Each animal should be able to “speak”. When we “call” the method that provokes the animal to speak, we should be able to print a string representation of the sound the animal makes.

## III. Zoo Keeper Requirements
The zoo keepers take care of the animals. 

Each zoo keeper should have attributes to distinguish them from each other. These are typical for all people and that is why the implementation of such properties are left to the developer’s logic and imagination.

However, each zoo keeper should have a set of animals they are required to take care of, but not less than 2. Now these should consist of animals of similar feeding habits, for example crocodiles and lions feed on meat so they have similar feeding habits although they are of different species.

Let’s consider that the only operation the zoo keepers are entrusted with is feeding the animals. At the same time, taking care of animals is a hard work and the zoo keepers may want to slack off a bit.

* Introduce a random factor, which will cause some of the animals a certain zoo keeper has to take care of, to be left unfed. If an animal has not been fed during the zoo’s operation cycle, it’s stamina is to drop. If applicable, this should trigger events that might cause the animal to become inactive as it will need to recuperate some of its strength. If the animal is inactive it should remain inactive for the next operational cycle after which it should receive an increase to its stamina.
