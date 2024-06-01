# Lab 4: https://docs.google.com/document/d/1kvc7Jrt3Y2hlFNf48-6ZaJtzwMrR7g56/edit?usp=sharing&ouid=102737524994634007634&rtpof=true&sd=true

# Đặc Tả Quản Lý Doanh Số Sản Phẩm và Đơn Đặt Hàng Của Công Ty ABC
Công ty ABC cần giám sát số lượng sản phẩm trong kho của mình. Hệ thống cần lưu trữ thông tin về các sản phẩm, bao gồm mã sản phẩm, tên sản phẩm, số lượng tồn kho, và vị trí lưu trữ trong kho. Mỗi sản phẩm sẽ có một mã sản phẩm duy nhất và không được trùng lặp.

Cuối kỳ, công ty ABC cần kiểm đếm thông tin về doanh số bán hàng của mỗi nhân viên. Hệ thống cần theo dõi các đơn đặt hàng, bao gồm thông tin về mã đơn hàng, tên khách hàng, ngày đặt hàng, và số lượng sản phẩm trong đơn hàng. Mỗi đơn hàng sẽ được gán một mã đơn hàng duy nhất và không được trùng lặp. Hệ thống cũng cần lưu trữ thông tin về nhân viên, bao gồm mã nhân viên, tên nhân viên, và mức lương.

Ngoài ra, hệ thống cần có khả năng liên kết thông tin giữa các bảng dữ liệu. Ví dụ, mỗi đơn hàng sẽ liên kết với một mã sản phẩm và một mã nhân viên. Hệ thống cũng cần theo dõi lịch sử các đơn đặt hàng và số lượng sản phẩm tồn kho theo thời gian để giúp công ty ABC dự đoán và quản lý tốt hơn việc tồn kho và doanh số bán hàng.

Yêu cầu trên đề xuất một cơ sở dữ liệu bao gồm ít nhất ba bảng: Bảng "Sản Phẩm" (Product), Bảng "Đơn Đặt Hàng" (Order), và Bảng "Chi tiết đơn hàng" Order details. Các bảng này sẽ có các trường tương ứng để lưu trữ thông tin theo yêu cầu của công ty ABC và sẽ có khóa chính để đảm bảo tính duy nhất và ràng buộc dữ liệu.

1. Giới thiệu
Hệ thống quản lý doanh số sản phẩm và đơn đặt hàng của công ty ABC được thiết kế để theo dõi các sản phẩm, đơn đặt hàng của khách hàng và chi tiết từng đơn hàng. Hệ thống này sẽ giúp công ty quản lý hiệu quả các sản phẩm, theo dõi doanh số bán hàng và đáp ứng các yêu cầu của khách hàng một cách nhanh chóng.

2. Các bảng trong cơ sở dữ liệu
Hệ thống bao gồm ba bảng chính: Products (Sản Phẩm), Orders (Đơn Đặt Hàng), và OrderDetails (Chi Tiết Đơn Hàng).

2.1 Bảng Sản Phẩm (Products)

Mục đích: Lưu trữ thông tin về các sản phẩm của công ty.
ProductID (INT, PRIMARY KEY, AUTO_INCREMENT): Mã định danh duy nhất cho mỗi sản phẩm.
ProductName (VARCHAR(255), NOT NULL): Tên sản phẩm.
UnitPrice (DECIMAL(10, 2), NOT NULL): Giá mỗi đơn vị sản phẩm.
Stock (INT, NOT NULL): Số lượng sản phẩm còn trong kho.

2.2 Bảng Đơn Đặt Hàng (Orders)

Mục đích: Lưu trữ thông tin về các đơn đặt hàng của khách hàng.
OrderID (INT, PRIMARY KEY, AUTO_INCREMENT): Mã định danh duy nhất cho mỗi đơn đặt hàng.
OrderDate (DATE, NOT NULL): Ngày đặt hàng.
CustomerName (VARCHAR(255), NOT NULL): Tên khách hàng.
CustomerAddress (VARCHAR(255), NOT NULL): Địa chỉ khách hàng.

2.3 Bảng Chi Tiết Đơn Hàng (OrderDetails)

Mục đích: Lưu trữ thông tin chi tiết về các sản phẩm trong mỗi đơn đặt hàng.
OrderDetailID (INT, PRIMARY KEY, AUTO_INCREMENT): Mã định danh duy nhất cho mỗi chi tiết đơn hàng.
OrderID (INT, NOT NULL): Mã định danh của đơn đặt hàng, khóa ngoại tham chiếu tới OrderID trong bảng Orders.
ProductID (INT, NOT NULL): Mã định danh của sản phẩm, khóa ngoại tham chiếu tới ProductID trong bảng Products.
Quantity (INT, NOT NULL): Số lượng sản phẩm trong chi tiết đơn hàng.
UnitPrice (DECIMAL(10, 2), NOT NULL): Giá mỗi đơn vị sản phẩm trong chi tiết đơn hàng.

3. Mối quan hệ giữa các bảng
Products và OrderDetails: Mối quan hệ một-nhiều (1-N). Một sản phẩm có thể xuất hiện trong nhiều chi tiết đơn hàng.
Orders và Products: Mối quan hệ nhiều-nhiều (N-N), được thể hiện qua bảng OrderDetails. Một đơn đặt hàng có thể chứa nhiều sản phẩm, và một sản phẩm có thể xuất hiện trong nhiều đơn đặt hàng.
