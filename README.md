-- Stored Procedure untuk Menambah Data Mahasiswa
CREATE PROCEDURE AddMahasiswa
	@NIM CHAR(11),
	@Nama VARCHAR(50),
	@Email VARCHAR(100),
	@Telepon VARCHAR(13),
	@Alamat VARCHAR(255)
AS
BEGIN
	INSERT INTO Mahasiswa (NIM, Nama, Email, Telepon, Alamat)
	VALUES (@NIM, @Nama, @Email, @Telepon, @Alamat);
END;

--Stored Procedure untuk Menghapus Data Mahasiwa berdasarkan NIM
CREATE PROCEDURE DeleteMahasiswa
	@NIM CHAR(11)
AS
BEGIN
	DELETE FROM Mahasiswa WHERE NIM = @NIM;
END;

-- Store Procedure untuk Memperbarui Data Mahasiswa
CREATE PROCEDURE UpdateMahasiswa
    @NIM CHAR(11),
    @Nama VARCHAR(50),
    @Email VARCHAR(100),
    @Telepon VARCHAR(13),
    @Alamat VARCHAR(255)
AS
BEGIN
    UPDATE Mahasiswa
    SET
        Nama = COALESCE(NULLIF(@Nama, ''), Nama),
        Email = COALESCE(NULLIF(@Email, ''), Email),
        Telepon = COALESCE(NULLIF(@Telepon, ''), Telepon),
        Alamat = COALESCE(NULLIF(@Alamat, ''), Alamat)
    WHERE NIM = @NIM;
END;
