-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 25 fév. 2025 à 16:13
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bibliotheque`
--

-- --------------------------------------------------------

--
-- Structure de la table `jeux`
--

CREATE TABLE `jeux` (
  `id` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `description` text DEFAULT NULL,
  `nombre_joueurs` int(11) NOT NULL,
  `nombre_cartes` int(11) NOT NULL,
  `nombre_joueurs_max` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `jeux`
--

INSERT INTO `jeux` (`id`, `nom`, `description`, `nombre_joueurs`, `nombre_cartes`, `nombre_joueurs_max`) VALUES
(1, 'Catan', 'Un jeu de gestion et de commerce', 3, 95, 4),
(2, 'Monopoly', 'Un jeu de gestion immobilière', 2, 110, 6),
(3, 'Uno', 'Un jeu de cartes rapide et amusant', 2, 108, 10),
(4, 'Risk', 'Un jeu de stratégie et de conquête', 2, 56, 6),
(5, 'Carcassonne', 'Un jeu de placement de tuiles pour construire des paysages médiévaux', 2, 72, 5),
(9, 'Sorry!', 'Un jeu de parcours où les joueurs déplacent leurs pions autour d’un plateau.', 2, 44, 4),
(10, 'Cluedo', 'Un jeu de déduction où les joueurs doivent résoudre un meurtre.', 3, 36, 6),
(11, 'Trivial Pursuit', 'Un jeu de questions de culture générale.', 2, 2400, 6),
(12, 'Sorry!', 'Un jeu de parcours où les joueurs déplacent leurs pions autour d’un plateau.', 2, 44, 4),
(13, 'Operation', 'Un jeu de dextérité où les joueurs retirent des pièces d’un \"patient\".', 1, 12, 0),
(14, 'The Game of Life', 'Un jeu de simulation de vie où les joueurs font des choix de vie.', 2, 104, 4),
(15, 'Connect 4', 'Un jeu de stratégie où les joueurs tentent de connecter quatre jetons de leur couleur.', 2, 0, 2),
(16, 'Guess Who?', 'Un jeu de devinettes où les joueurs essaient de deviner le personnage de l’adversaire.', 2, 24, 2),
(17, 'Battleship', 'Un jeu de stratégie navale où les joueurs tentent de couler les navires de l’adversaire.', 2, 0, 2),
(18, 'One Piece', 'Meilleur manga ', 3, 1500, 10);

-- --------------------------------------------------------

--
-- Structure de la table `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `roles`
--

INSERT INTO `roles` (`id`, `nom`) VALUES
(1, 'administrateur'),
(2, 'utilisateur');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

CREATE TABLE `utilisateurs` (
  `id` int(11) NOT NULL,
  `nom_utilisateur` varchar(50) NOT NULL,
  `mot_de_passe` varchar(255) NOT NULL,
  `role` enum('administrateur','utilisateur') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`id`, `nom_utilisateur`, `mot_de_passe`, `role`) VALUES
(0, 'Lucas', 'coco', 'utilisateur'),
(2, 'admin', 'root', 'administrateur');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `jeux`
--
ALTER TABLE `jeux`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nom` (`nom`);

--
-- Index pour la table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nom_utilisateur` (`nom_utilisateur`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `jeux`
--
ALTER TABLE `jeux`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT pour la table `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `utilisateurs`
--
ALTER TABLE `utilisateurs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
