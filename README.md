# Đặc tả hệ thống quản lý học sinh
Công ty ABC cần giám sát số lượng sản phẩm trong kho của mình. Hệ thống cần lưu trữ thông tin về các sản phẩm, bao gồm mã sản phẩm, tên sản phẩm, số lượng tồn kho, và vị trí lưu trữ trong kho. Mỗi sản phẩm sẽ có một mã sản phẩm duy nhất và không được trùng lặp.
Cuối kỳ, công ty ABC cần kiểm đếm thông tin về doanh số bán hàng của mỗi nhân viên. Hệ thống cần theo dõi các đơn đặt hàng, bao gồm thông tin về mã đơn hàng, tên khách hàng, ngày đặt hàng, và số lượng sản phẩm trong đơn hàng. Mỗi đơn hàng sẽ được gán một mã đơn hàng duy nhất và không được trùng lặp. Hệ thống cũng cần lưu trữ thông tin về nhân viên, bao gồm mã nhân viên, tên nhân viên, và mức lương.
Ngoài ra, hệ thống cần có khả năng liên kết thông tin giữa các bảng dữ liệu. Ví dụ, mỗi đơn hàng sẽ liên kết với một mã sản phẩm và một mã nhân viên. Hệ thống cũng cần theo dõi lịch sử các đơn đặt hàng và số lượng sản phẩm tồn kho theo thời gian để giúp công ty ABC dự đoán và quản lý tốt hơn việc tồn kho và doanh số bán hàng.
Yêu cầu trên đề xuất một cơ sở dữ liệu bao gồm ít nhất ba bảng: Bảng "Sản Phẩm" (Product), Bảng "Đơn Đặt Hàng" (Order), và Bảng "Nhân Viên" (Employee). Các bảng này sẽ có các trường tương ứng để lưu trữ thông tin theo yêu cầu của công ty ABC và sẽ có khóa chính để đảm bảo tính duy nhất và ràng buộc dữ liệu.

# Thiết kế bảng dữ liệu
Bảng "Sản Phẩm" (Product):
- Mã Sản Phẩm (Product ID): Mã duy nhất định danh cho mỗi sản phẩm.
- Tên Sản Phẩm (Product Name): Tên mô tả sản phẩm.
- Số Lượng Tồn Kho (Stock Quantity): Số lượng sản phẩm còn lại trong kho.
- Vị Trí Lưu Trữ (Storage Location): Vị trí cụ thể trong kho mà sản phẩm được lưu trữ.

Bảng "Đơn Đặt Hàng" (Order):
- Mã Đơn Hàng (Order ID): Mã duy nhất định danh cho mỗi đơn đặt hàng.
- Mã Sản Phẩm (Product ID): Liên kết đến sản phẩm trong đơn hàng.
- Mã Nhân Viên (Employee ID): Liên kết đến nhân viên thực hiện đơn hàng.
- Tên Khách Hàng (Customer Name): Tên của khách hàng đặt hàng.
- Ngày Đặt Hàng (Order Date): Ngày mà đơn hàng được tạo ra.
- Số Lượng Sản Phẩm (Quantity): Số lượng của sản phẩm trong đơn hàng.

Bảng "Nhân Viên" (Employee):
- Mã Nhân Viên (Employee ID): Mã duy nhất định danh cho mỗi nhân viên.
- Tên Nhân Viên (Employee Name): Tên của nhân viên.
- Mức Lương (Salary): Mức lương của nhân viên.

# Mối quan hệ và tính ràng buộc giữa các bảng
Mối quan hệ tính ràng buộc giữa các bảng dữ liệu trong hệ thống quản lý học sinh được mô tả như sau:

Bảng "Sản Phẩm" (Product) và Bảng "Đơn Đặt Hàng" (Order):
Mỗi đơn đặt hàng sẽ liên kết với một hoặc nhiều sản phẩm trong bảng "Đơn Đặt Hàng" thông qua trường "Mã Sản Phẩm" (Product ID).
Mối quan hệ này là một-nhiều (one-to-many), vì mỗi đơn đặt hàng có thể chứa nhiều sản phẩm khác nhau.

Bảng "Nhân Viên" (Employee) và Bảng "Đơn Đặt Hàng" (Order):
Mỗi đơn đặt hàng sẽ được gán cho một nhân viên trong bảng "Đơn Đặt Hàng" thông qua trường "Mã Nhân Viên" (Employee ID).
Mỗi nhân viên có thể có nhiều đơn đặt hàng, vì vậy mối quan hệ này cũng là một-nhiều (one-to-many).

Sự liên kết giữa các bảng:
Mỗi đơn đặt hàng có thông tin về sản phẩm và nhân viên tương ứng thông qua các trường "Mã Sản Phẩm" và "Mã Nhân Viên".
Điều này cho phép hệ thống kết nối dữ liệu giữa các bảng để truy vấn thông tin liên quan, chẳng hạn như thông tin về đơn đặt hàng, sản phẩm, và nhân viên liên quan đến mỗi đơn hàng cụ thể.
Với các mối quan hệ này, hệ thống có thể hiệu quả theo dõi thông tin về sản phẩm, đơn đặt hàng và nhân viên, và cung cấp các báo cáo và phân tích liên quan đến doanh số bán hàng và quản lý tồn kho.


