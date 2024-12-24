/*#### **Ã‰tape 1 : Un sapin blanc simple**

1. **Objectif :** Afficher un sapin composÃ© uniquement de caractÃ¨res `*` pour les feuilles et `|||` pour le tronc.
2. **Instructions :**
   - Demandez Ã  l'utilisateur d'entrer la hauteur du sapin (entre 1 et 30). Utilisez une boucle pour vÃ©rifier que la saisie est valide.
   - Utilisez une fonction `DessinerFeuilles` pour afficher les feuilles du sapin :
     - Les feuilles doivent Ãªtre alignÃ©es en pyramide. La premiÃ¨re ligne contient 1 Ã©toile (`*`), la deuxiÃ¨me 3 Ã©toiles, la troisiÃ¨me 5 Ã©toiles, etc.
     - La pyramide doit Ãªtre centrÃ©e horizontalement dans la console. Vous devrez calculer la position de dÃ©part pour chaque ligne.
     - Pour dessiner plusieurs lignes, vous aurez besoin d'une **boucle**.
   - Ajoutez une fonction `DessinerTronc` pour afficher le tronc :
     - La largeur du tronc est fixe (3 caractÃ¨res : `|||`).
     - La hauteur du tronc est proportionnelle Ã  celle du sapin (par exemple, 1/3 de la hauteur des feuilles).
     - Le tronc doit Ã©galement Ãªtre centrÃ© horizontalement.
   - Organisez votre programme en appelant ces deux fonctions aprÃ¨s avoir validÃ© la hauteur.
3. **Points d'attention :**
   - Utilisez `Console.SetCursorPosition` pour placer le curseur Ã  lâ€™endroit exact oÃ¹ dessiner chaque ligne.
   - Assurez-vous que le sapin est bien centrÃ© dans la console.
4. **RÃ©sultat attendu :** Un sapin statique, centrÃ©, composÃ© uniquement de feuilles blanches et d'un tronc blanc. 
 */


class Program
{
    static void Main() 
    { 

        // déclaraton d'une variable int utilisateur déclarer à zero 
        int utilisateur = 0;
        // utilisation d'un do while pour que l'utilisateur reste dans la boucle si il déclarer un nombre non compris entre 1 et 30.
        do
        {
            // utilisation d'une condition afin de contraindre l'utilisateur à choisir un nombre entre 1 et 30 sinon un message d'erreur apparait 
            if (utilisateur < 1 || utilisateur > 30)
            {

                // message d'erreur 
                Console.WriteLine("veuillez saisir la hauteur du sapin (comprise entre 1 et 30");

            }

            utilisateur = int.Parse(Console.ReadLine());

        } while (utilisateur < 1 || utilisateur > 30);   
        // Appel des fonctions pour dessiner le sapin
        DessinerFeuilles(utilisateur);
        DessinerTronc(utilisateur);
    
        static void DessinerFeuilles(int hauteur)
        {
            for (int i = 0; i < hauteur; i++)
            {
                // Je fais une boucle for pour géré les espaces et je lui indique que tant que j
                // est inférieur à la hauteur - i déclarer précedemment auquel je retire un pour retirer un espaces plus on descend 
                for (int j = 0; j < hauteur - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // je réalise une  troisème boucle for dans laquelle j'incrémente j à 0 et lui indique que tant que j est inférieur à 2 * i
                // soit le nombre d'itération par rapport la hauteur alors j'ajoute + 1 au étoile 
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n"); // Saut de ligne après chaque rangée
            }
        }

        static void DessinerTronc(int hauteur)
        {
            // je défini la hauteur du tronc par rapport à 1/3 du sapin 
            int hauteurTronc = hauteur / 3;
            // je réalise une condition pour éviter que si le sapin est trop petit aucun tronc n'apparaisse 
            if (hauteurTronc < 1)
            {
                hauteurTronc = 1;
            }
            // je défini la largeur du tronc 
            int largeurTronc = 3;
            // ainsi que les espaces afin de centré le tronc je prends donc la hauteur et je soustrait 2
            int espaces = hauteur - 2;

            // j'utilise une boucle for pour indiquer que tant que i et inférieur a la hauteur du tronc je dois continuer la boucle 
            for (int i = 0; i < hauteurTronc; i++)
            {
                // j'utilise une deuxième boucle for pour gérer les espaces 
                for (int j = 0; j < espaces; j++)
                {
                    Console.Write(" ");
                }


                Console.WriteLine("|||");
            }
    }   }
}


