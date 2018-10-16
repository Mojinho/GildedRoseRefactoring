Gilded Rose Refactoring
======================================

Mode d'emploi :

	Pour lancer l'application, il faut ouvrir la solution dans Visual Studio et l'exécuter. 
	Vous pouvez également faire tourner les unit tests présents dans l'application.

	Sinon, vous pouvez exécuter directement l'exécutable qui se trouve dans bin/Debug/csharp.exe

Choix :

	J'ai d'abord ajouté des tests unitaires plus parlants que la comparaison de résultats présente dans la soltuon d'origine.
	J'ai fait le choix de tout coder dans la classe GildedRose. Le peu de refactoring que j'ai fait a été d'ajouter un "Type" d'item.
	Il est ainsi plus facile de distinguer les items. Ensuite j'ai créé une fonction Update pour chacun des types reprenant les spécificités propres à chaque type. 
	Après cela, la fonction UpdateQuality se résume à une switch case et quelques vérifications qui sont globales à tous les items.

Autre solution :

	Il était demandé dans l'énoncé de ne pas toucher à la classe Item.
	Si j'avais pu toucher à cette classe, je l'aurai rendue abstraite et j'aurai hérité cette classe pour chaque type d'items.
	J'y aurai ajouté une fonction "UpdateQuality" et j'aurai codé les spécificités de chaque type dans leur classe respective.

	Pour aller plus loin, j'aurai pu mettre en place un objet de type "ItemSpec" dans lequel on aurait codé ou écrit en DB les spécifités de chaque item.
	Ainsi, on aurait pu imaginer que l'utilisateur puisse créer des nouveaux types d'items en les paramétrant lui même. Mais ça allait un peu trop loin par rapport à l'exercice demandé.

Fait en +/- 1h40 le 16/10/2018 par Joseph Verstappen