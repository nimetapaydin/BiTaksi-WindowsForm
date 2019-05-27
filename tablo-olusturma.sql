CREATE TABLE admin (
  email varchar(255)  NOT NULL PRIMARY KEY,
  sifre varchar(255) NOT NULL
);

INSERT INTO admin (email, sifre) VALUES
('admin', '21232f297a57a5a743894a0e4a801fc3');

CREATE TABLE arac (
  sofor_id int DEFAULT NULL,
  plaka varchar(15) NOT NULL PRIMARY KEY,
  model varchar(255) NOT NULL
);

INSERT INTO arac (sofor_id, plaka, model) VALUES
(13, '58 NA 333', 'O'),
(2, '58 NA 684', 'Mercedes'),
(3, '58 NZ 211', 'BMW');

CREATE TABLE cagri (
  sofor_id int NOT NULL PRIMARY KEY,
  musteri_adisoyadi varchar(255) NOT NULL,
  musteri_telefon varchar(255) NOT NULL,
  musteri_adres text NOT NULL,
  aktif varchar(1) NOT NULL CHECK(aktif in('0','1'))
);

INSERT INTO cagri (sofor_id, musteri_adisoyadi, musteri_telefon, musteri_adres, aktif) VALUES
(2, 'Test müşterisi', '1234597', 'şura bura', '0'),
(3, 'asd', 'asd', 'asd', '1'),
(13, 'lorem ipsum', 'dolor sit amet', 'o', '1');

CREATE TABLE rapor (
  sofor_id int NOT NULL,
  arac_plaka varchar(15) NOT NULL,
  tarih datetime NOT NULL,
  kazanc float NOT NULL
);

CREATE TABLE sofor (
  id int NOT NULL IDENTITY(1,1),
  tc varchar NOT NULL,
  adisoyadi varchar(255) NOT NULL,
  sifre varchar(255) NOT NULL,
  aktif varchar(1) NOT NULL CHECK(aktif in ('1','0')),
  onayli varchar(1) NOT NULL CHECK(onayli in('1','0'))
);

INSERT INTO sofor (tc, adisoyadi, sifre, aktif, onayli) VALUES
('12345678912', 'Nimet', '81dc9bdb52d04dc20036dbd8313ed055', '0', '1');

ALTER TABLE cagri
  ADD CONSTRAINT cagri_ibfk_1 FOREIGN KEY (sofor_id) REFERENCES sofor (id);
COMMIT;