# Đặc tả hệ thống quản lý học sinh
Mỗi học sinh có một mshs và mã lớp học để phân biệt với nhau. Mỗi sinh viên chỉ có 1 mã lớp duy nhất và 1 mã sinh viên duy nhất, mỗi lớp có nhiều học sinh và học sinh chỉ được học 1 lớp, mỗi lớp chỉ có 1 giáo viên giảng dạy và mỗi giáo viên có thể giảng dạy nhiều lớp học khác nhau

# Thiết kế bảng dữ liệu
Bảng "Học sinh":
- Mã học sinh (student_id)
- Tên học sinh (student_name)
- Mã lớp học (class_id)
- Ngày sinh (birthday)
- SĐT (phone_number)
- Giới tính (gender)

Bảng "Lớp học":
- Mã lớp học (class_id)
- Mã giáo viên (teacher_id)
- Mã chương trình (program_id)
- Năm học (academic_year)

Bảng "Giáo viên":
- Mã giáo viên (teacher_id)
- Tên giáo viên (teacher_name)
- Ngày sinh (birthday)
- SĐT (phone_number)
- Giới tính (gender)
- Chứng chỉ (certification)

Với các quan hệ như sau:
- Mỗi học sinh chỉ thuộc một lớp học và mỗi lớp học có nhiều học sinh.
- Mỗi lớp học chỉ có một giáo viên giảng dạy, và mỗi giáo viên có thể giảng dạy nhiều lớp học khác nhau.