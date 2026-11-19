-- TaskLink database for XAMPP (MySQL / MariaDB)
-- Import with phpMyAdmin (Import tab) or:  mysql -u root < tasklink.sql
CREATE DATABASE IF NOT EXISTS tasklink CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE tasklink;

CREATE TABLE IF NOT EXISTS users (
  id            INT AUTO_INCREMENT PRIMARY KEY,
  name          VARCHAR(100) NOT NULL,
  email         VARCHAR(150) NOT NULL UNIQUE,
  password_hash VARCHAR(100) NOT NULL,
  role          ENUM('USER','ADMIN') NOT NULL DEFAULT 'USER',
  is_active     TINYINT(1) NOT NULL DEFAULT 1,
  avg_rating    DECIMAL(3,2) NOT NULL DEFAULT 0,
  rating_count  INT NOT NULL DEFAULT 0,
  created_at    DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS tasks (
  id           INT AUTO_INCREMENT PRIMARY KEY,
  title        VARCHAR(150) NOT NULL,
  description  TEXT NOT NULL,
  category     VARCHAR(60)  NOT NULL,
  location     VARCHAR(120) NOT NULL,
  deadline     DATETIME NOT NULL,
  status       ENUM('OPEN','CLAIMED','COMPLETED','EXPIRED','CANCELLED','FLAGGED','REMOVED') NOT NULL DEFAULT 'OPEN',
  poster_id    INT NOT NULL,
  helper_id    INT NULL,
  created_at   DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  completed_at DATETIME NULL,
  FOREIGN KEY (poster_id) REFERENCES users(id),
  FOREIGN KEY (helper_id) REFERENCES users(id),
  INDEX idx_status_created (status, created_at)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS claims (
  id         INT AUTO_INCREMENT PRIMARY KEY,
  task_id    INT NOT NULL,
  helper_id  INT NOT NULL,
  claimed_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  withdrawn  TINYINT(1) NOT NULL DEFAULT 0,
  FOREIGN KEY (task_id)   REFERENCES tasks(id),
  FOREIGN KEY (helper_id) REFERENCES users(id)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS ratings (
  id         INT AUTO_INCREMENT PRIMARY KEY,
  task_id    INT NOT NULL,
  rater_id   INT NOT NULL,
  rated_id   INT NOT NULL,
  score      TINYINT NOT NULL CHECK (score BETWEEN 1 AND 5),
  comment    VARCHAR(500) NULL,
  created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  UNIQUE KEY uq_one_rating (task_id, rater_id),
  FOREIGN KEY (task_id)  REFERENCES tasks(id),
  FOREIGN KEY (rater_id) REFERENCES users(id),
  FOREIGN KEY (rated_id) REFERENCES users(id)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS reports (
  id              INT AUTO_INCREMENT PRIMARY KEY,
  task_id         INT NOT NULL,
  reporter_id     INT NOT NULL,
  reason          VARCHAR(500) NOT NULL,
  previous_status VARCHAR(20) NOT NULL,
  status          ENUM('PENDING','DISMISSED','REMOVED') NOT NULL DEFAULT 'PENDING',
  created_at      DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (task_id)     REFERENCES tasks(id),
  FOREIGN KEY (reporter_id) REFERENCES users(id)
) ENGINE=InnoDB;

-- The ADMIN account (admin@tasklink.com / Admin@123) is seeded automatically
-- by the application on first start (BCrypt hash is generated in code).
