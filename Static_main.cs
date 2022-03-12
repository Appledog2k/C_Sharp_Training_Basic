// See https://aka.ms/new-console-template for more information
// khi muốn tạo một cái gì đó có thể dùng chung cho tất cả các đối tượng của lớp đó thậm chí đối tượng của lớp khác cũng có thể sử dụng được
// thì dùng static, thành phần static là thành phần dùng chung không là sở hữu riêng của bất kì đối tượng nào cả
/* example :
   giả sử ngân hàng có n tài khoản cần tạo thành phần có lãi suất (static)
*/
// để thay dổi thành phần static ta sử dụng tên lớp
//trong phương thức static không được sử dụng các thành phần không phải static
/* static constructor chỉ hoạt động với những hàm static
   chỉ có duy nhất 1 static constructor ở trong một lớp
   Không nhận bất kì một tham số nào
   Ko chứa access Modifiers
   Chỉ được gọi một lần 
   và thực hiện  Trước tất cả constructor khác

   */

//! MỤC ĐÍCH TRÊN TẤT CẢ LÀ ĐEM RA SỬ DỤNG


OOP_Static.SavingAcc Acc1 = new OOP_Static.SavingAcc();
OOP_Static.SavingAcc Acc2 = new OOP_Static.SavingAcc();
OOP_Static.SavingAcc Acc3 = new OOP_Static.SavingAcc();
OOP_Static.SavingAcc Acc4 = new OOP_Static.SavingAcc();
OOP_Static.SavingAcc.interestRate = 0.6f;
OOP_Static.SavingAcc.interestRate = 0.3f;
