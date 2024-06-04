SELECT NhaCungCap.TenNhaCungCap, NguyenLieu.TenNguyenLieu, NguyenLieu.SoLuong
FROM NhaCungCap
INNER JOIN PhieuNhap ON NhaCungCap.NhaCungCapID = PhieuNhap.NhaCungCapID
INNER JOIN ChiTietPhieuNhap ON PhieuNhap.PhieuNhapID = ChiTietPhieuNhap.PhieuNhapID
INNER JOIN NguyenLieu ON ChiTietPhieuNhap.NguyenLieuID = NguyenLieu.NguyenLieuID;

INSERT INTO MonAn (MonAnID, TenMonAn, Gia, MoTa)
VALUES ('MA022', N'Phở bò', 50000, N'Phở bò thơm ngon');

INSERT INTO MonAn (MonAnID, TenMonAn, Gia, MoTa)
VALUES ('MA021', N'Phở bò', 50000, N'Phở bò thơm ngon');
