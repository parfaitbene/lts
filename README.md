# LST (Logistic System of Traceability)

<picture>
	<img alt="LTS preview" src="http://portfolio.parfaitbene.com/wp-content/uploads/2023/06/lts-img.jpg">
</picture>


Un système de gestion permettant la traçabilité de la production en logistique.
Ce projet a été dévloppé dans le cadre d'un projet d'étude.

1. **Gestion des approvisionnements** : matières premières, fournisseurs, stocks ;
2. **Gestion de la production** : gammes de produits, produits, machines, étapes ;
3. **Distribution** : livreurs, clients;
4. **Traçabilité** : traçabilité d'un produit sur la base de son numéro de lot de production. Sur la base du code, identification : des fournisseurs et livraisons, du produit et de sa gamme, des ouvriers, des étapes de production, des livraisons.

# Nécessite

* mysql-5.1
* mysql-connector-c++-1.1.5-win32
* mysql-connector-net-6.6.5
* mysql-connector-odbc-5.3.4-win32
* Microsoft Windows (8, 10)

# Installation de l'application

1. Télécharger puis extraire le contenu de l'archive
2. Installer toutes les dépendances contenues dans le dossier MySql. Elles servent à établir la communication avec la base de données MySql
3. Exécuter le fichier `SMP.application` et suivre les étapes pour installer l'application

# Installation de la base de données

Le projet a été testé avec MySql 5.7.24 uniquement dans un environnement de développement.
Les paramètres ci-dessous sont à usage unique pour des tests et ne sont pas recommandés dans un environnement de production.

**Paramètres BD**
Ces paramètres doivent être respectés afin que l'application puisse s'ouvrir et fonctionner correctement.

* Hôte : `localhost`
* Port : `3306`
* Nom de la base de données : `smb`
* Utilisateur : `root`
* Mot de passe : `(laisser vide, n'utilise pas de mot de passe)`

> Le fichier `smp-db.sql` situé à la racine de l'archive contient quelques données de démonstration, vous pouvez l'importer dans la base de données `smb` précédemment créée.
> L'application et la base de données doivent être installées sur le même poste.

# Lancer l'application

Ouvrir l'application `LTS` se trouvant sur le bureau ou dans le menu démarrer de Windows.

# Demo

Effectuer un test de traçabilité en procédant comme suit :

<picture>
	<img alt="LTS preview" src="http://portfolio.parfaitbene.com/wp-content/uploads/2023/06/lts-img2.jpg">
</picture>

1. Ouvrir la liste des productions : Menu `Production > Nouvelle > Production`
2. Copier ou noter un `numéro de lot` dans la liste
3. Ouvrir le formulaire de traçabilité : Menu `Opération > Traçabilité`
4. Saisir ou coller le `numéro de lot` précédemment mémorisé
5. Cliquer sur le bouton `Tracer` puis observer les résultats