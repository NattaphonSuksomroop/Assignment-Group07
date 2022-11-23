# Assignment : Group07 - ข้าวต้มแมว

## 📖 List Assignment 
- Proposal :[https://docs.google.com/document/d/1sea_cC5RR17qWQT5SRk-vLe_l_ySOuhAPu95nzR5b14/edit]
- Report :[https://docs.google.com/document/d/1iTPC1d-TgI1fAaEQQ8hWUJeABbwI6U_asuoig1QsVpc/edit]
- Diagram files :[https://github.com/NattaphonSuksomroop/Assignment-Group07/tree/main/UML]
- Presentation :[https://github.com/NattaphonSuksomroop/Assignment-Group07/blob/main/FoodDeliveryApp/Group7%20-%20%E0%B8%82%E0%B9%89%E0%B8%B2%E0%B8%A7%E0%B8%95%E0%B9%89%E0%B8%A1%E0%B9%81%E0%B8%A1%E0%B8%A7_Food%20delivery.pdf]
- Source :[https://github.com/NattaphonSuksomroop/Assignment-Group07/tree/main/FoodDeliveryApp]

## Design Pattern
โมดูลที่ 1 เราใช้ Interpreter Design Pattern ในการช่วยค้นหาร้านอาหารที่แตกต่างกัน 
รูปแบบของ Interpreter DEsign Pattern ใช้ในการแยกวิเคราะห์ชุดข้อมูล 
เราใช้รูปแบบการออกแบบนี้ในการค้นหาร้านอาหารต่างๆ เนื่องจากผู้ใช้ค้นหาตามสถานที่ จากคิวอาหารของร้าน ชื่อร้านอาหาร รายการอาหาร

โมดูลที่ 2 เราใข้ Interator Pattern ทำให้ผู้ใช้เห็นเมนูอาหาร
รูปแบบของ Iterator ใช้วิธีการเข้าถึงรายละเอียดของ Object โดยไม่เปิดเผยโครงสร้างพื้นฐานของวัตถุ เราจึงใช้รูปแบบการออกแบบนี้ในการแสดงเมนูอาหารตามร้านอาหาร

โมดูลที่ 3 เราใช้ Builder Design Pattern ในการเพิ่มอาหารและสั่งอาหาร
รูปแบบของ Builder Design pattern จะช่วยแก้ปัญหาเมื่อเรามีคลาสที่มีขั้นตอนการสร้างที่ซับซ้อน และ การสร้าง Object หลายๆอย่างที่มีขั้นตอนในการสร้างคล้ายๆกัน
เราใช้รูปแบบนี้ในการเพิ่มรายการอาหารที่แตกต่างกัน




โมดูลที่ 4 เราใช้ Command Design Pattern ใช้จัดการคำสั่งซื้อและการยกเลิกอาหาร
รูปแบบของ Command Design สามารถติดต่อกับระบบอื่นหรือ Action ที่เข้ามาได้หลายรูปแบบ เช่น คิวหรือบันทึก
เราใช้รูปแบบของการออกแบบนี้เนื่องจากผู้ใช้สามารถสั่งหรือยกเลิกเมนูอาหารเพื่อจัดส่งได้ ผู้ใช้สามารถทำคำขอที่แตกต่างกันสองประเภทสำหรับการสั่งอาหารได้

โมดูลที่ 5 เราใช้ Observer Design Pattern ใช้ติดตามคำสั่งซื้อแบบเรียลไทม์
รูปแบบของ Observer Design เมื่อ Object หนึ่งเปลี่ยนสถานะ จะแจ้งเตือนไปยัง Objectต่างๆ
เราใช้รูปแบบนี้ในการติดตามคำสั่งซื้อแบบเรียลไทม์ เพราะเมื่อใดก็ตามที่บริการส่งอาหารระบุว่า อาหารทำเสร็จแล้ว ไรเดอร์กำลังมา จะถึงในอีกกี่นาที ส่งอาหารแล้ว หรือ อาหารโดนยกเลิก 
ผู้ใช้จะได้รับการแจ้งเตือนโดยอัตโนมัติ
