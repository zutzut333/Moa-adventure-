# Moa-adventure-
Préparation:
Dans visual studio, ajouter l'extension monogame

Problèmes restants:
Le niveau 1 fonctionne "correctement"
Le niveau 2 ne fonctionne pas (problème avec les mur qui  devrait bouger lors de l'activation des boutons.
Le niveau 3 fonctionne "correctement"
Le niveau 4 fonctione plus ou moins

vous pouvez changer de niveau en modifiant _actualLevel dans  Game1
Vous pouvez changer la "speed" des créature dans createEntity pour modifier la difficulté

Les collisions ne fonctionne pas toujours correctement

Règles:
	Chaque niveau contient un item qu'il faut rammasser pour ouvrir la porte qui permet de passer au prochain niveau.
	Toucher un monstre ou un piège nous renvoie au début du niveau et nous fait perdre une vie
	On a 3 vie pour réussir les 4 niveau, sinon on recommence au début.