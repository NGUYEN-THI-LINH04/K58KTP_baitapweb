# K58KTP_baitapweb
K225480106040_Nguyễn Thị Linh
+ DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
+ Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
+ Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
+ Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
## CÁCH LÀM
### 1.DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
### Tạo Project
+ <img width="1101" height="1021" alt="Screenshot 2025-09-26 212649" src="https://github.com/user-attachments/assets/33fe2b93-5584-42c6-b1d6-976af8ac9dd4" />
### Kết quả
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 090234" src="https://github.com/user-attachments/assets/b83f62c9-1ffa-4c22-90d4-27aade1c3f9b" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 090258" src="https://github.com/user-attachments/assets/40ad8288-e4ef-4a44-a590-1804cca49cbd" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 090311" src="https://github.com/user-attachments/assets/682f2735-b689-4351-b6cf-006c6f6146c4" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 090352" src="https://github.com/user-attachments/assets/d2d8898a-f479-442c-80fb-010a21825026" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 090506" src="https://github.com/user-attachments/assets/694e3eb4-18ac-426a-b83b-bfb8b71c7b1e" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 090518" src="https://github.com/user-attachments/assets/df28a42f-9ccf-4970-8e40-86a6e2a26746" />
### 2.Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
### Tạo Project
+ <img width="1104" height="551" alt="Screenshot 2025-09-26 212758" src="https://github.com/user-attachments/assets/8f166c5c-837f-4c5c-9f7f-122d68a7f17d" />
### Kết quả 
+ <img width="1920" height="1080" alt="Screenshot 2025-09-26 173607" src="https://github.com/user-attachments/assets/6817a68d-469e-475e-bc90-8e8ceb3faaaa" />
### 3.+ Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
### Tạo Project
+ <img width="1096" height="553" alt="Screenshot 2025-09-26 212833" src="https://github.com/user-attachments/assets/d0f003bc-463d-4c75-aeff-a5b55f7e19f1" />
### Kết quả
+ <img width="1920" height="1080" alt="Screenshot 2025-09-26 170205" src="https://github.com/user-attachments/assets/4a8c7b0b-5f37-4425-8ca7-e47a698bf317" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-26 170116" src="https://github.com/user-attachments/assets/6dec9063-e24d-45e1-9058-93e59852d831" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-26 170213" src="https://github.com/user-attachments/assets/b6b3adec-5ba3-4062-8923-4b0ea2da2dc8" />
### 4.Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework)
### Tạo Project
+ <img width="1105" height="543" alt="Screenshot 2025-09-26 212913" src="https://github.com/user-attachments/assets/207798d7-c027-4ead-a33a-17101e395ef3" />
### Cấu hình IIS
+ <img width="1920" height="1080" alt="Screenshot 2025-09-26 212943" src="https://github.com/user-attachments/assets/d0fa4ad4-5f90-42c7-bc5f-e4ec7479215b" />
### Kết Quả
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 155330" src="https://github.com/user-attachments/assets/d287bf6f-0807-4668-bb23-c0f8614e0d8e" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 155453" src="https://github.com/user-attachments/assets/712a1ebf-ede4-4af7-8d89-3e89b099064f" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 155504" src="https://github.com/user-attachments/assets/0d1b4b79-7450-4aca-9189-0d9584e6c807" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-25 155536" src="https://github.com/user-attachments/assets/87364ab1-0e98-41af-9005-47676165da50" />
+ <img width="1920" height="1080" alt="Screenshot 2025-09-26 175757" src="https://github.com/user-attachments/assets/fcaf42c2-5ce2-4fd3-9c09-20cfa4232dec" />


















