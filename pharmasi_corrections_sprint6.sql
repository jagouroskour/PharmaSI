-- ============================================================
-- PharmaSI – Corrections Sprint 6
-- À appliquer sur la base existante
-- ============================================================

-- -----------------------------------------------------------
-- CORRECTION 1 : prix_echantillon FLOAT → DECIMAL(10,2)
-- Un FLOAT introduit des erreurs d'arrondi sur les montants
-- monétaires (ex : 2.1 stocké comme 2.09999...).
-- -----------------------------------------------------------
ALTER TABLE `medicament`
  MODIFY `prix_echantillon` DECIMAL(10,2) DEFAULT NULL;

-- -----------------------------------------------------------
-- CORRECTION 2 : harmonisation du charset en utf8mb4
-- Les tables praticien, posseder et type_praticien utilisaient
-- encore l'ancien utf8 (3 octets) au lieu d'utf8mb4 (4 octets),
-- ce qui peut tronquer certains caractères spéciaux.
-- -----------------------------------------------------------
ALTER TABLE `praticien`
  CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

ALTER TABLE `posseder`
  CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

ALTER TABLE `type_praticien`
  CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

-- -----------------------------------------------------------
-- CORRECTION 3 : bilan TEXT au lieu de VARCHAR(500)
-- Un bilan peut dépasser 500 caractères en situation réelle.
-- TEXT supporte jusqu'à 65 535 caractères sans pénalité notable.
-- -----------------------------------------------------------
ALTER TABLE `rapport_visite`
  MODIFY `bilan` TEXT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL;

-- -----------------------------------------------------------
-- VÉRIFICATION : afficher la structure corrigée
-- -----------------------------------------------------------
DESCRIBE `medicament`;
DESCRIBE `rapport_visite`;
DESCRIBE `praticien`;
